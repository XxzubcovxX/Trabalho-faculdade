using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static App_PetHouse.Clientes;

namespace App_PetHouse
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private async void Clientes_Load(object sender, EventArgs e)
        {
            await AtualizarDados();
        }

        private async Task AtualizarDados()
        {
            // Fazendo a solicitação HTTP para a API em PHP
            var dados = await DadosAPI("http://localhost/api_CRUD/api/Cadastro_Cliente");
            // Definindo os dados no DataGridView
            DGVclientes.DataSource = dados;
        }
        //Metodo dos dados do DataGrid
        private async Task<List<ClienteData>> DadosAPI(string URL)
        {
            List<ClienteData> dados = null;
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(URL);

                    if (response.IsSuccessStatusCode)
                    {
                        string responsedata = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Dados buscados com sucesso: ");

                        // Desserializar o JSON para um objeto que contém uma propriedade "status" e uma propriedade "data"
                        dynamic responseObject = JsonConvert.DeserializeObject(responsedata);
                        string status = responseObject.status;

                        // Verificar se o status é "success"
                        if (status == "success")
                        {
                            // Desserializar os dados contidos na propriedade "data" como uma lista de objetos EstoqueData
                            string dataJson = JsonConvert.SerializeObject(responseObject.data);
                            dados = JsonConvert.DeserializeObject<List<ClienteData>>(dataJson);
                        }
                        else
                        {
                            MessageBox.Show("Erro no status: " + status);
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

            return dados;
        }

        public class ClienteResponse
        {
            public string Status { get; set; }
            public ClienteData Data { get; set; }
        }
        public class ClienteData

        {
            public int id_do_cliente { get; set; }
            public string nome_do_cliente { get; set; }
            public string sobrenome { get; set; }
            public string cpf { get; set; }
            public string telefone_fixo { get; set; }
            public string telefone_celular { get; set; }
            public string email { get; set; }
            public string genero { get; set; }
            public string data_de_nascimento { get; set; }
            public string cep { get; set; }
            public string endereco { get; set; }
            public string numero { get; set; }
            public string bairro { get; set; }
            public string cidade { get; set; }
            public string uf { get; set; }
        }


        // Buscando dados para os campos através do DGV
        private void DGVclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            DataGridViewRow selecao = DGVclientes.Rows[index];




            TBid.Text = selecao.Cells["id_do_cliente"].Value.ToString();
            TBnome.Text = selecao.Cells["nome_do_cliente"].Value.ToString();
            TBsobrenome.Text = selecao.Cells["sobrenome"].Value.ToString();
            TBcpf.Text = selecao.Cells["cpf"].Value.ToString();
            MTBtelefoneFixo.Text = selecao.Cells["telefone_fixo"].Value.ToString();
           MTBtelefoneCelular.Text = selecao.Cells["telefone_celular"].Value.ToString();
            TBemail.Text = selecao.Cells["email"].Value.ToString();
            TBgenero.Text = selecao.Cells["genero"].Value.ToString();
            MTBdataNascimento.Text = selecao.Cells["data_de_nascimento"].Value.ToString();
            TBcep.Text = selecao.Cells["cep"].Value.ToString();
            TBendereco.Text = selecao.Cells["endereco"].Value.ToString();
            TBnumero.Text = selecao.Cells["numero"].Value.ToString();
            TBbairro.Text = selecao.Cells["bairro"].Value.ToString();
            TBcidade.Text = selecao.Cells["cidade"].Value.ToString();
            TBuf.Text = selecao.Cells["uf"].Value.ToString();



        }


        // metodo buscar
        private void BTbuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TBid.Text);
            BuscarCliente(id);
        }
        private async Task BuscarCliente(int id)
        {
            if (id != 0)
            {
                string URL = $"http://localhost/api_CRUD/api/Cadastro_Cliente/{id}";

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
                            ClienteResponse clienteResponse = JsonConvert.DeserializeObject<ClienteResponse>(responsedata);

                            // Verificar se a desserialização foi bem-sucedida e o status é "success"
                            if (clienteResponse != null && clienteResponse.Status == "success")
                            {
                                ClienteData clientedata = clienteResponse.Data;
                                MostrarResposta(clientedata);

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
            else
            {
                MessageBox.Show("Insira um ID para buscar");
            }
        }
        public void MostrarResposta(ClienteData clienteData)
        {
            TBnome.Text = clienteData.nome_do_cliente;
            TBsobrenome.Text = clienteData.sobrenome;
            TBcpf.Text = clienteData.cpf;
           MTBtelefoneFixo.Text = clienteData.telefone_fixo;
            MTBtelefoneCelular.Text = clienteData.telefone_celular;
            TBemail.Text = clienteData.email;
            TBgenero.Text = clienteData.genero;
            MTBdataNascimento.Text = clienteData.data_de_nascimento;
            TBcep.Text = clienteData.cep;
            TBendereco.Text = clienteData.endereco;
            TBnumero.Text = clienteData.numero;
            TBbairro.Text = clienteData.bairro;
            TBcidade.Text = clienteData.cidade;
            TBuf.Text = clienteData.uf;
        }

        //Função cadastrar

        private void BTcadastrar_Click(object sender, EventArgs e)
        {
            string id = TBid.Text;
            string nome = TBnome.Text;
            string sobrenome = TBsobrenome.Text;
            string CPF = TBcpf.Text;
            string teleFixo = MTBtelefoneFixo.Text.Replace("(", "").Replace(")", "").Replace("-", "");
            string teleCell = MTBtelefoneCelular.Text.Replace("(", "").Replace(")", "").Replace("-", "");
            string email = TBemail.Text;
            string genero = TBgenero.Text;
            string data = MTBdataNascimento.Text;
            string cep = TBcep.Text;
            string endereco = TBendereco.Text;
            string numero = TBnumero.Text;
            string bairro = TBbairro.Text;
            string cidade = TBcidade.Text;
            string uf = TBuf.Text;

            CadastrandoCliente(id, nome, sobrenome, CPF, teleFixo, teleCell, email, genero, data, cep, endereco, numero, bairro, cidade, uf);
        }
        private async Task CadastrandoCliente(string id, string nome_do_cliente, string sobrenome, string cpf, string telefone_fixo, string telefone_celular, string email, string genero, string data_de_nascimento, string cep, string endereco, string numero, string bairro, string cidade, string uf)
        {
            if (id == "")
            {
                string URl = $"http://localhost/api_CRUD/api/Cadastro_Cliente";

                using (HttpClient client = new HttpClient())
                {
                    try
                    {

                        var informacoes = new
                        {

                            nome_do_cliente = nome_do_cliente,
                            sobrenome = sobrenome,
                            cpf = cpf,
                            telefone_fixo = telefone_fixo,
                            telefone_celular = telefone_celular,
                            email = email,
                            genero = genero,
                            data_de_nascimento = data_de_nascimento,
                            cep = cep,
                            endereco = endereco,
                            numero = numero,
                            bairro = bairro,
                            cidade = cidade,
                            uf = uf

                        };


                        var conteudo = new StringContent(System.Text.Json.JsonSerializer.Serialize(informacoes));

                        // Definindo o tipo de mídia diretamente como uma string
                        conteudo.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");


                        HttpResponseMessage response = await client.PostAsync(URl, conteudo);

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Dados cadastrados com sucesso");
                            LimparCampos();
                            AtualizarDados();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possivel Cadastrar " + response.StatusCode);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possivel realizar o cadastro \n" + ex);

                    }

                }

            }
            else
            {
                MessageBox.Show("Para inserir um dado é necessario o campo Id esteja vazio!");
            }


        }
        private void LimparCampos()
        {
            TBid.Text = "";
            TBnome.Text = "";
            TBsobrenome.Text = "";
            TBcpf.Text = "";
           MTBtelefoneCelular.Text = "";
            MTBtelefoneFixo.Text = "";
            TBemail.Text = "";
            TBgenero.Text = "";
            MTBdataNascimento.Text = "";
            TBcep.Text = "";
            TBendereco.Text = "";
            TBnumero.Text = "";
            TBbairro.Text = "";
            TBcidade.Text = "";
            TBuf.Text = "";
        }

        // Função atualizar

        private void BTatualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TBid.Text);
            string nome = TBnome.Text;
            string sobrenome = TBsobrenome.Text;
            string CPF = TBcpf.Text;
            string teleFixo = MTBtelefoneFixo.Text.Replace("(", "").Replace(")", "").Replace("-", "");
            string teleCell = MTBtelefoneCelular.Text.Replace("(", "").Replace(")", "").Replace("-", "");
            string email = TBemail.Text;
            string genero = TBgenero.Text;
            string data = MTBdataNascimento.Text;
            string cep = TBcep.Text;
            string endereco = TBendereco.Text;
            string numero = TBnumero.Text;
            string bairro = TBbairro.Text;
            string cidade = TBcidade.Text;
            string uf = TBuf.Text;

            AtualizarCadastro(id, nome, sobrenome, CPF, teleFixo, teleCell, email, genero, data, cep, endereco, numero, bairro, cidade, uf);
        }
        private async Task AtualizarCadastro(int id_do_cliente, string nome_do_cliente, string sobrenome, string cpf, string telefone_fixo, string telefone_celular, string email, string genero, string data_de_nascimento, string cep, string endereco, string numero, string bairro, string cidade, string uf)
        {
            if (id_do_cliente != 0)
            {
                string URl = $"http://localhost/api_CRUD/api/Cadastro_Cliente/{id_do_cliente}";

                using (HttpClient client = new HttpClient())
                {
                    try
                    {

                        var informacoes = new
                        {
                            id_do_cliente = id_do_cliente,
                            nome_do_cliente = nome_do_cliente,
                            sobrenome = sobrenome,
                            cpf = cpf,
                            telefone_fixo = telefone_fixo,
                            telefone_celular = telefone_celular,
                            email = email,
                            genero = genero,
                            data_de_nascimento = data_de_nascimento,
                            cep = cep,
                            endereco = endereco,
                            numero = numero,
                            bairro = bairro,
                            cidade = cidade,
                            uf = uf
                        };


                        var conteudo = new StringContent(System.Text.Json.JsonSerializer.Serialize(informacoes));

                        // Definindo o tipo de mídia diretamente como uma string
                        conteudo.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");


                        HttpResponseMessage response = await client.PutAsync(URl, conteudo);

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Dados atualizados com sucesso");
                            AtualizarDados();
                            LimparCampos();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possivel atualizar os dados" + response.StatusCode);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possivel Atualizar os dados \n" + ex);

                    }

                }

            }
            else
            {
                MessageBox.Show("Para Atualizar as informações é necessario ID");
            }
        }

        // Função deletar
        private void BTexcluir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TBid.Text);
            if (MessageBox.Show("Tem certeza que deseja excluir esse cliente?", "Confirmação de Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Deletar(id);
            }
           
        }
        private async Task Deletar(int id)
        {
            if (id != 0)
            {
                string URL = $"http://localhost/api_CRUD/api/Cadastro_Cliente/{id}";

                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        HttpResponseMessage response = await client.DeleteAsync(URL);
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Dados excluidos com sucesso");
                            await AtualizarDados();
                            LimparCampos();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possivel excluir os dados\n Verifique se esse registro esta Desvinculado\n" + response.StatusCode);
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possivel excluir dados " + ex.Message);
                    }
                    
                }
            }
        }


    }
}
