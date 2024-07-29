using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static App_PetHouse.Estoque;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace App_PetHouse
{
    public partial class Estoque : Form

    {
        string FotoProdu = string.Empty;
        public Estoque()
        {
            InitializeComponent();
        }


        private async void Estoque_Load(object sender, EventArgs e)
        {
            // Carregar todos os produtos no DataGridView ao iniciar a aplicação
            await AtualizarDados();
        }
        //puxando as informações do DataGrid
        private async Task AtualizarDados()
        {
            // Fazendo a solicitação HTTP para a API em PHP
            var dados = await DadosAPI("http://localhost/api_CRUD/api/Cadastro_Produto");
            // Definindo os dados no DataGridView
            dataGridView1.DataSource = dados;
        }
        //Metodo dos dados do DataGrid
        private async Task<List<EstoqueData>> DadosAPI(string URL)
        {
            List<EstoqueData> dados = null;
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(URL);

                    if (response.IsSuccessStatusCode)
                    {
                        string responsedata = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Dados buscados com sucesso: " + responsedata);

                        // Desserializar o JSON para um objeto que contém uma propriedade "status" e uma propriedade "data"
                        dynamic responseObject = JsonConvert.DeserializeObject(responsedata);
                        string status = responseObject.status;

                        // Verificar se o status é "success"
                        if (status == "success")
                        {
                            // Desserializar os dados contidos na propriedade "data" como uma lista de objetos EstoqueData
                            string dataJson = JsonConvert.SerializeObject(responseObject.data);
                            dados = JsonConvert.DeserializeObject<List<EstoqueData>>(dataJson);
                        }
                        else
                        {
                            MessageBox.Show("Erro no status: " + status);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro ao buscar dados. Código de status: " + response.StatusCode);
                        RTBdescricaoProduto.Text = "Erro ao buscar dados. Código de status: " + response.StatusCode;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar dados: " + ex.Message);
                    RTBdescricaoProduto.Text = "Erro ao buscar dados: " + ex.Message;
                }
            }

            return dados;
        }
        public class EstoqueResponse 
        {
            public string Status { get; set; }
            public EstoqueData Data { get; set; }
        }
        public class EstoqueData
        {
            public int id_do_produto { get; set; }
            public string nome_do_produto { get; set; }
            public float preco { get; set; }
            public string descricao { get; set; }
            public int quantidade_estoque { get; set; }
            public string imagem_base64 { get; set; }
            public int nota { get; set; }
            public string data_cadastro { get; set; }
        }
        //Função de BUSCAR 

        private void BTbuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TBidEstoque.Text);
            BuscarProduto(id);
        }

        private async Task BuscarProduto(int id)
        {
            if (id != 0)
            {
                string URL = $"http://localhost/api_CRUD/api/Cadastro_Produto/{id}";

                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        HttpResponseMessage response = await client.GetAsync(URL);

                        if (response.IsSuccessStatusCode)
                        {
                            string responsedata = await response.Content.ReadAsStringAsync();
                            MessageBox.Show("Dados buscado com sucesso" + responsedata);


                            // Desserializar o JSON para um objeto
                            EstoqueResponse estoqueResponse = JsonConvert.DeserializeObject<EstoqueResponse>(responsedata);

                            // Verificar se a desserialização foi bem-sucedida e o status é "success"
                            if (estoqueResponse != null && estoqueResponse.Status == "success")
                            {
                                EstoqueData estoquedata = estoqueResponse.Data;
                                MostrarResposta(estoquedata);

                            }
                            else
                            {
                                MessageBox.Show("Erro na desserialização ou no status 'success' ");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Erro ao buscar dados. Código de status: " + response.StatusCode);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao buscar dados: " + ex.Message);
                    }
                }
            }
        }

        public void MostrarResposta(EstoqueData estoqueData)
        {
            TBnomeProdu.Text = estoqueData.nome_do_produto;
            TBpreco.Text = Convert.ToString(estoqueData.preco);
            TBqtdEstoque.Text = Convert.ToString(estoqueData.quantidade_estoque);
            RTBdescricaoProduto.Text = estoqueData.descricao;
            TBnota.Text = Convert.ToString(estoqueData.nota);
            TBdata.Text = estoqueData.data_cadastro;


            //Puxando a imagem do API para o PictureBox

            if (!string.IsNullOrEmpty(estoqueData.imagem_base64))
            {

                byte[] imagemBytes = Convert.FromBase64String(estoqueData.imagem_base64);
                pictureBox1.Image = ConverterBytesParaImagem(imagemBytes);
               
            }
            else
            {
                MessageBox.Show("Nenhuma imagem encontrada para este produto.");
            }
             

        }

        //Convertendo Bytes para imagem
        private Image ConverterBytesParaImagem(byte[] dados)
        {

            try
            {
                using (MemoryStream ms = new MemoryStream(dados))
                {
                   
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao converter imagem: " + ex.Message);
                return null;
            }


        }

        //Buscar os dados através do click no Datagrid ( concertar erro a puxar algumas imagens)
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selecao = dataGridView1.Rows[index];




            TBidEstoque.Text = selecao.Cells["id_do_produto"].Value.ToString();
            TBnomeProdu.Text = selecao.Cells["nome_do_produto"].Value.ToString();
            TBpreco.Text = selecao.Cells["preco"].Value.ToString();
            RTBdescricaoProduto.Text = selecao.Cells["descricao"].Value.ToString();
            TBqtdEstoque.Text = selecao.Cells["quantidade_estoque"].Value.ToString();
            TBnota.Text = selecao.Cells["nota"].Value.ToString();
            TBdata.Text = selecao.Cells["data_cadastro"].Value.ToString();

            string imagemBase64 = selecao.Cells["imagem_base64"].Value.ToString();
            if(imagemBase64 != null)
            {
                // Converte a imagem de Base64 para um objeto Image
                Image imagem;
                using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(imagemBase64)))
                {
                    imagem = Image.FromStream(ms);
                }

                // Atribui a imagem ao controle PictureBox
                pictureBox1.Image = imagem;
            }
            else
            {
                pictureBox1.Image = null;
                MessageBox.Show("não há imagem deste produto");
            }
           
        }

        //Função de cadastrar
        private void BTcadastrar_Click(object sender, EventArgs e)
        {
            string id = TBidEstoque.Text;
            string nome_produto = TBnomeProdu.Text;
            decimal preco = Convert.ToDecimal(TBpreco.Text);
            string descricao = RTBdescricaoProduto.Text;
            int qtdEstoque = Convert.ToInt32(TBqtdEstoque.Text);
            int nota = Convert.ToInt32(TBnota.Text);
            string data = TBdata.Text;
            string foto = pictureBox1.ImageLocation;

              Cadastrando(id, nome_produto, preco, descricao, qtdEstoque, nota, data, foto);

        }
        private async Task Cadastrando( string id ,string nome_produto,decimal preco,string descricao, int qtdEstoque, int nota, string data, string foto)
        {
            if(id == "")
            {
                string URl = $"http://localhost/api_CRUD/api/Cadastro_Produto";

                using (HttpClient client = new HttpClient())
                {
                    try 
                    {
                        byte[] imagemByte = Converterimagembyte(foto);
                        var informacoes = new
                        {
                           
                            nome_do_produto =nome_produto,
                            preco=preco,
                            descricao=descricao,
                            quantidade_estoque=qtdEstoque,
                            nota=nota,
                            data_cadastro=data,
                            imagem_base64= Convert.ToBase64String(imagemByte)
                        };


                        var conteudo = new StringContent(System.Text.Json.JsonSerializer.Serialize(informacoes));

                        // Definindo o tipo de mídia diretamente como uma string
                        conteudo.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");


                        HttpResponseMessage response = await client.PostAsync(URl,conteudo);

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Dados cadastrados com sucesso");
                        }
                        else
                        {
                            MessageBox.Show("Não foi possivel Cadastrar" + response.StatusCode);
                        }

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Não foi possivel realizar o cadastro \n" + ex);
                        RTBdescricaoProduto.Text = ex.Message; 
                    }
                   
                }
            }
            else
            {
                MessageBox.Show("Para inserir um dado é necessario o campo Id esteja vazio!");

            }
            LimparCampos();
            await AtualizarDados();

        }

        private void BTinserirfoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog janela = new OpenFileDialog();

            // Configurando o filtro dinâmico para tipos de imagem comuns
            string filtro = "Imagens|";
            string[] tiposDeImagem = { "*.jpg", "*.png", "*.gif" }; // Adicione outros tipos de imagem, se necessário
            filtro += string.Join("; ", tiposDeImagem);

            janela.Filter = filtro;

            if (janela.ShowDialog() == DialogResult.OK)
            {
                string fotoProdu = janela.FileName;
                pictureBox1.ImageLocation = fotoProdu;
            }
        }
        private byte[] Converterimagembyte(string caminhoFoto) // Adicionado o parâmetro para o caminho da foto
        {
            byte[] imagembyte = null;
            using (FileStream fs = new FileStream(caminhoFoto, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader BR = new BinaryReader(fs))
                {
                    imagembyte = BR.ReadBytes((int)fs.Length);
                }
            }
            return imagembyte;
        }

        private void LimparCampos()
        {
            TBidEstoque.Text = "";
            TBnomeProdu.Text = "";
            TBnota.Text = "";
            TBdata.Text = "";
            TBpreco.Text = "";
            RTBdescricaoProduto.Text = "";
            TBqtdEstoque.Text = "";
            pictureBox1.Image = null;
        }



        //Função atualizar

        private void BTatualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TBidEstoque.Text);
            string nome_produto = TBnomeProdu.Text;
            decimal preco = Convert.ToDecimal(TBpreco.Text);
            string descricao = RTBdescricaoProduto.Text;
            int qtdEstoque = Convert.ToInt32(TBqtdEstoque.Text);
            int nota = Convert.ToInt32(TBnota.Text);
            string data = TBdata.Text;
            string foto = pictureBox1.ImageLocation;
            

            Atualizar(id, nome_produto, preco, descricao, qtdEstoque, nota, data, foto);
        }
        private async Task Atualizar(int id, string nome_produto, decimal preco, string descricao, int qtdEstoque,int nota, string data, string foto)
        {
            if (id != 0)
            {
                string URl = $"http://localhost/api_CRUD/api/Cadastro_Produto/{id}";

                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        byte[] imagemByte = Converterimagembyte(foto);
                        var informacoes = new
                        {
                            id_do_produto = id,
                            nome_do_produto = nome_produto,
                            preco = preco,
                            descricao = descricao,
                            quantidade_estoque = qtdEstoque,
                            nota = nota,
                            data_cadastro = data,
                            imagem_base64 = Convert.ToBase64String(imagemByte)
                        };


                        var conteudo = new StringContent(System.Text.Json.JsonSerializer.Serialize(informacoes));

                        // Definindo o tipo de mídia diretamente como uma string
                        conteudo.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");


                        HttpResponseMessage response = await client.PutAsync(URl, conteudo);

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Dados atualizados com sucesso");
                        }
                        else
                        {
                            MessageBox.Show("Não foi possivel atualizar os dados" + response.StatusCode);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possivel Atualizar os dados \n" + ex);
                        RTBdescricaoProduto.Text = ex.Message;
                    }

                }
            }
            else
            {
                MessageBox.Show("Para Atualizar as informações é necessario ID");

            }
            LimparCampos();
            await AtualizarDados();
        }



        //Função Deletar
        private void BTexcluir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TBidEstoque.Text);
            if (MessageBox.Show("Tem certeza que deseja excluir esse produto ?", "Confirmação de Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Deletar(id);
            }
           
        }
        private async Task Deletar(int id)
        {
            if (id != 0)
            {
                string URL = $"http://localhost/api_CRUD/api/Cadastro_Produto/{id}";

                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        HttpResponseMessage response = await client.DeleteAsync(URL);
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Dados excluidos com sucesso");
                        }
                        else
                        {
                            MessageBox.Show("Não foi possivel excluir os dados" + response.StatusCode);
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possivel excluir dados " + ex.Message);
                    }
                    await AtualizarDados();
                }
            }
        }

    }


}