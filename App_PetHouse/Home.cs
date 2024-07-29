using Newtonsoft.Json;
using System.Diagnostics.Eventing.Reader;
using System.Text;
using static App_PetHouse.Clientes;

namespace App_PetHouse
{
    public partial class Home : Form
    {
        int login = 0;
        int Grau = 0;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            VerificarLogin();

        }

        private void VerificarLogin()
        {
            if (login == 0 && Grau == 0)
            {
                BTMestoque.Enabled = false;
                BTMcliente.Enabled = false;
                BTMadministrativo.Enabled = false;
                BTMagendamento.Enabled = false;
                BTManimais.Enabled = false;


            }
            else if (login == 1 && Grau == 1)
            {
                BTMestoque.Enabled = true;
                BTMcliente.Enabled = true;
                BTMadministrativo.Enabled = true;
                BTMagendamento.Enabled = true;
                BTManimais.Enabled = true;
            }
            else if (login == 1 && Grau == 2)
            {
                BTMestoque.Enabled = true;
                BTMcliente.Enabled = true;

            }
            else if (login == 1 && Grau == 3)
            {
                BTMagendamento.Enabled = true;
                BTMcliente.Enabled = true;
                BTManimais.Enabled = true;
            }
        }
        //Botões do menu 
        private void BTMestoque_Click(object sender, EventArgs e)
        {

            Form tela = new Estoque();
            tela.Show();
        }

        private void BTMcliente_Click(object sender, EventArgs e)
        {
            Form tela = new Clientes();
            tela.Show();
        }

        private void BTManimais_Click(object sender, EventArgs e)
        {
            Form tela = new Animais();
            tela.Show();
        }

        private void BTMagendamento_Click(object sender, EventArgs e)
        {
            Form tela = new Agendamento();
            tela.Show();
        }

        private void BTMadministrativo_Click(object sender, EventArgs e)
        {
            Form tela = new Administrativo();
            tela.Show();
        }

        private void BTentrar_Click(object sender, EventArgs e)
        {
            string usuario = TBusuario.Text;
            string senha = TBsenha.Text;

            LoginFuncionario(usuario, senha);
        }

        public class FuncionarioResponse
        {
            public string Status { get; set; }
            public FuncionarioData Data { get; set; }
        }
        public class FuncionarioData

        {
            public int Grau { get; set; }


        }
        private async Task LoginFuncionario(string usuario, string senha)
        {
            string apiUrl = "http://localhost/api_CRUD/api/Login";

            var dados = new
            {
                Usuario = usuario,
                Senha = senha
            };

            var json = JsonConvert.SerializeObject(dados);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string responsedata = await response.Content.ReadAsStringAsync();
                        Console.WriteLine("Resposta da API: " + responsedata);

                        var funcionarioResponse = JsonConvert.DeserializeObject<FuncionarioResponse>(responsedata);

                        if (funcionarioResponse.Status == "error")
                        {
                            MessageBox.Show("Erro ao fazer login. Por favor, tente novamente.");
                        }
                        else
                        {
                            // Login bem-sucedido
                            MessageBox.Show("Login bem-sucedido!");

                            var grau = funcionarioResponse.Data.Grau;

                            // Atualiza o estado de login e Grau
                            login = 1;
                            Grau = grau;
                            TBusuario.Text = "";
                            TBsenha.Text = "";

                            // Atualiza a interface com base no novo estado de login e Grau
                            VerificarLogin();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Erro ao chamar a API: " + response.StatusCode);
                        MessageBox.Show("Erro ao fazer login. Por favor, tente novamente.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao fazer login: " + ex.Message);
                    MessageBox.Show("Erro ao fazer login. Por favor, tente novamente.");
                }
            }
        }

        private void BTsair_Click(object sender, EventArgs e)
        {
            login = 0;
            Grau = 0;
            VerificarLogin();
            TBusuario.Text = "";
            TBsenha.Text = "";

            
        }
    }
}