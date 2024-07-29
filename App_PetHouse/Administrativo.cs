using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static App_PetHouse.Clientes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace App_PetHouse
{
    public partial class Administrativo : Form
    {
        public Administrativo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void Administrativo_Load(object sender, EventArgs e)
        {
            await AtualizarDados();
        }
        private async Task AtualizarDados()
        {
            // Fazendo a solicitação HTTP para a API em PHP
            var dados = await DadosAPI("http://localhost/api_CRUD/api/Cadastro_Funcionarios");
            // Definindo os dados no DataGridView
            DGVfuncionarios.DataSource = dados;
        }
        //Metodo dos dados do DataGrid
        private async Task<List<FuncionarioData>> DadosAPI(string URL)
        {
            List<FuncionarioData> dados = null;
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
                            dados = JsonConvert.DeserializeObject<List<FuncionarioData>>(dataJson);
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
        public class FuncionarioResponse
        {
            public string Status { get; set; }
            public FuncionarioData Data { get; set; }
        }
        public class FuncionarioData

        {
            public int ID_funcionarios { get; set; }
            public string Nome { get; set; }
            public string Sobrenome { get; set; }
            public string Usuario { get; set; }
            public string Senha { get; set; }
            public int Grau { get; set; }
            public string email { get; set; }
            public string Telefone { get; set; }

        }

        private void DGVfuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selecao = DGVfuncionarios.Rows[index];




            TBid.Text = selecao.Cells["ID_Funcionarios"].Value.ToString();
            TBnome.Text = selecao.Cells["Nome"].Value.ToString();
            TBsobrenome.Text = selecao.Cells["Sobrenome"].Value.ToString();
            TBemail.Text = selecao.Cells["email"].Value.ToString();
            MTBtelefone.Text = selecao.Cells["Telefone"].Value.ToString();
            TBsenha.Text = selecao.Cells["Senha"].Value.ToString();
            TBusuario.Text = selecao.Cells["Usuario"].Value.ToString();
            CBgrau.Text = selecao.Cells["Grau"].Value.ToString();


        }


        //Metodo buscar
        private void BTbuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TBid.Text);
            BuscarFuncionario(id);
        }

        private async Task BuscarFuncionario(int id)
        {
            if (id != 0)
            {
                string URL = $"http://localhost/api_CRUD/api/Cadastro_Funcionarios/{id}";

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
                            FuncionarioResponse clienteResponse = JsonConvert.DeserializeObject<FuncionarioResponse>(responsedata);

                            // Verificar se a desserialização foi bem-sucedida e o status é "success"
                            if (clienteResponse != null && clienteResponse.Status == "success")
                            {
                                FuncionarioData funcionariodata = clienteResponse.Data;
                                MostrarResposta(funcionariodata);

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
        public void MostrarResposta(FuncionarioData funcionarioData)
        {
            TBnome.Text = funcionarioData.Nome;
            TBsobrenome.Text = funcionarioData.Sobrenome;
            TBemail.Text = funcionarioData.email;
            MTBtelefone.Text = funcionarioData.Telefone;
            TBusuario.Text = funcionarioData.Usuario;
            TBsenha.Text = funcionarioData.Senha;
            CBgrau.Text = Convert.ToString(funcionarioData.Grau);
        }
        // Metodo Cadastrar
        private void BTcadastrar_Click(object sender, EventArgs e)
        {
            string id = TBid.Text;
            string nome = TBnome.Text;
            string sobrenome = TBsobrenome.Text;
            string email = TBemail.Text;
            string telefone = MTBtelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "");
            string usuario = TBusuario.Text;
            string senha = TBsenha.Text;
            int grau = Convert.ToInt32(CBgrau.Text);

            CadastrarFuncionario(id, nome, sobrenome, email, telefone, usuario, senha, grau);
        }
        private async Task CadastrarFuncionario(string id, string nome, string sobrenome, string email, string telefone, string usuario, string senha, int grau)
        {
            if (id == "")
            {
                string URl = $"http://localhost/api_CRUD/api/Cadastro_Funcionarios";

                using (HttpClient client = new HttpClient())
                {
                    try
                    {

                        var informacoes = new
                        {

                            Nome = nome,
                            Sobrenome = sobrenome,
                            email = email,
                            Telefone = telefone,
                            Usuario = usuario,
                            Senha = senha,
                            Grau = grau


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
            TBemail.Text = "";
            TBid.Text = "";
            TBnome.Text = "";
            TBsenha.Text = "";
            TBsobrenome.Text = "";
            TBusuario.Text = "";
            MTBtelefone.Text = "";
            CBgrau.Text = "";
        }


        // Metodo atualizar
        private void BTatualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TBid.Text);
            string nome = TBnome.Text;
            string sobrenome = TBsobrenome.Text;
            string email = TBemail.Text;
            string telefone = MTBtelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "");
            string usuario = TBusuario.Text;
            string senha = TBsenha.Text;
            int grau = Convert.ToInt32(CBgrau.Text);

            AtualizarFuncionario(id, nome, sobrenome, email, telefone, usuario, senha, grau);
        }
        private async Task AtualizarFuncionario(int id, string nome, string sobrenome, string email, string telefone, string usuario, string senha, int grau)
        {
            if (id != 0)
            {
                string URl = $"http://localhost/api_CRUD/api/Cadastro_Funcionarios/{id}";

                using (HttpClient client = new HttpClient())
                {
                    try
                    {

                        var informacoes = new
                        {
                            ID_funcionario = id,
                            Nome = nome,
                            Sobrenome = sobrenome,
                            email = email,
                            Telefone = telefone,
                            Usuario = usuario,
                            Senha = senha,
                            Grau = grau


                        };


                        var conteudo = new StringContent(System.Text.Json.JsonSerializer.Serialize(informacoes));

                        // Definindo o tipo de mídia diretamente como uma string
                        conteudo.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");


                        HttpResponseMessage response = await client.PutAsync(URl, conteudo);

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Dados atualizados com sucesso");
                            LimparCampos();
                            AtualizarDados();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possivel atualizar " + response.StatusCode);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possivel realizar a atualizar  \n" + ex);

                    }

                }

            }
            else
            {
                MessageBox.Show("Para Atualizar as informações é necessario ID");
            }
        }


        // Metodo Deletar 
        private void BTexcluir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TBid.Text);

            if (MessageBox.Show("Tem certeza que deseja excluir esse funcionario ?", "Confirmação de Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ExcluirFuncionarios(id);
            }
            
        }
        private async Task ExcluirFuncionarios(int id)
        {
            if (id != 0)
            {
                string URL = $"http://localhost/api_CRUD/api/Cadastro_funcionarios/{id}";

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
                            MessageBox.Show("Não foi possivel excluir os dados" + response.StatusCode);
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possivel excluir dados " + ex.Message);
                    }

                }
            }
            else
            {
                MessageBox.Show("Coloque o Id do funcionario que deseja excluir");
            }
        }
    }
}
