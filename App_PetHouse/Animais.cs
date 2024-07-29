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
using static App_PetHouse.Administrativo;
using static App_PetHouse.Animais;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace App_PetHouse
{
    public partial class Animais : Form
    {
        public Animais()
        {
            InitializeComponent();
        }

        private void TBaltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void Animais_Load(object sender, EventArgs e)
        {
            AtualizarDadosGerais();
            AtualizarDadosVinculo();
        }
        private async Task AtualizarDadosGerais()
        {
            // Fazendo a solicitação HTTP para a API em PHP
            var dados = await DadosAPI("http://localhost/api_CRUD/api/Tabela_VinculoCliente");
            // Definindo os dados no DataGridView
            DGVgeral.DataSource = dados;
        }
        //Metodo dos dados do DataGrid
        private async Task<List<GeralData>> DadosAPI(string URL)
        {
            List<GeralData> dados = null;
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
                            dados = JsonConvert.DeserializeObject<List<GeralData>>(dataJson);
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
        private async Task AtualizarDadosVinculo()
        {
            // Fazendo a solicitação HTTP para a API em PHP
            var dados = await DadosAPIAnima("http://localhost/api_CRUD/api/Cadastro_VinculoCliente");
            // Definindo os dados no DataGridView
            DGvinculo.DataSource = dados;
        }
        private async Task<List<VinculoData>> DadosAPIAnima(string URL)
        {
            List<VinculoData> dados = null;
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
                            dados = JsonConvert.DeserializeObject<List<VinculoData>>(dataJson);
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
                    TBid.Text = ex.Message;

                }
            }

            return dados;
        }

        public class AnimalResponse
        {
            public string Status { get; set; }
            public AnimalData Data { get; set; }
        }
        public class AnimalData

        {
            public int id_do_animal { get; set; }
            public string nome_do_animal { get; set; }
            public string especie { get; set; }
            public string raca { get; set; }
            public string data_de_nascimento { get; set; }
            public decimal altura_cm { get; set; }
            public decimal peso_kg { get; set; }
            public decimal comprimento_cm { get; set; }

        }
        public class GeralResponse
        {
            public string Status { get; set; }
            public GeralData Data { get; set; }
        }
        public class GeralData

        {
            public int id_vinculo_tabelasCliente { get; set; }
            public int id_do_cliente { get; set; }
            public string nome_do_cliente { get; set; }
            public string sobrenome { get; set; }
            public string cpf { get; set; }
            public int id_do_animal { get; set; }
            public string nome_do_animal { get; set; }
            public string especie { get; set; }
            public string raca { get; set; }
            public string data_de_nascimento { get; set; }
            public decimal altura_cm { get; set; }
            public decimal peso_kg { get; set; }
            public decimal comprimento_cm { get; set; }
            public int Id_registro_medico_do_animal { get; set; }


        }
        public class VinculoResponse
        {
            public string Status { get; set; }
            public VinculoData Data { get; set; }
        }
        public class VinculoData

        {
            public int? id_vinculo_tabelasCliente { get; set; }
            public int? id_do_cliente { get; set; }
            public int? id_do_animal { get; set; }
            public int? Id_registro_medico_do_animal { get; set; }


        }
        // Preecher os campos pelo CellClick Do DGVgeral e dos vinculos
        private void DGVgeral_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selecao = DGVgeral.Rows[index];

            TXTnome.Text = selecao.Cells["nome_do_cliente"].Value.ToString();
            TXTsobrenome.Text = selecao.Cells["sobrenome"].Value.ToString();
            TBid.Text = selecao.Cells["id_do_animal"].Value.ToString();
            MTBdataNascimento.Text = selecao.Cells["data_de_nascimento"].Value.ToString();
            TBnomeAnimal.Text = selecao.Cells["nome_do_animal"].Value.ToString();
            CBespecie.Text = selecao.Cells["especie"].Value.ToString();
            TBraca.Text = selecao.Cells["raca"].Value.ToString();
            TBaltura.Text = selecao.Cells["altura_cm"].Value.ToString();
            TBpeso.Text = selecao.Cells["peso_kg"].Value.ToString();
            TBcomprimento.Text = selecao.Cells["Comprimento_cm"].Value.ToString();
        }
        private void DGvinculo_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique foi em uma célula válida 
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtém os dados da linha clicada 
                var row = DGvinculo.Rows[e.RowIndex];

                // Preenche os inputs de entrada com os dados da linha clicada do data grid 
                TBidVinculo.Text = row.Cells["id_vinculo_tabelasCliente"].Value != null ? row.Cells["id_vinculo_tabelasCliente"].Value.ToString() : "Nulo";
                TBidCliente.Text = row.Cells["id_do_cliente"].Value != null ? row.Cells["id_do_cliente"].Value.ToString() : "Nulo";
                TBidAnimal.Text = row.Cells["id_do_animal"].Value != null ? row.Cells["id_do_animal"].Value.ToString() : "Nulo";
                TBidRegistro.Text = row.Cells["Id_registro_medico_do_animal"].Value != null ? row.Cells["id_do_animal"].Value.ToString() : "Nulo";

            }

        }
        // Metodo Buscar
        private async void BTbuscar_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(TBid.Text);


            BuscarAnimal(id);
        }

        private async Task BuscarAnimal(int id)
        {
            if (id != 0)
            {
                string URL = $"http://localhost/api_CRUD/api/Cadastro_Animal/{id}";

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

                            AnimalResponse animalResponse = JsonConvert.DeserializeObject<AnimalResponse>(responsedata);

                            // Verificar se a desserialização foi bem-sucedida e o status é "success"
                            if (animalResponse != null && animalResponse.Status == "success")
                            {
                                AnimalData animalodata = animalResponse.Data;
                                MostrarResposta(animalodata);

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
                        TBid.Text = ex.Message;
                    }
                }
            }
            else
            {
                MessageBox.Show("Insira o ID para buscar");
            }
        }
        public void MostrarResposta(AnimalData animalData)
        {

            TBnomeAnimal.Text = animalData.nome_do_animal;
            CBespecie.Text = animalData.especie;
            TBaltura.Text = Convert.ToString(animalData.altura_cm);
            TBcomprimento.Text = Convert.ToString(animalData.comprimento_cm);
            TBpeso.Text = Convert.ToString(animalData.peso_kg);
            TBraca.Text = animalData.raca;
            MTBdataNascimento.Text = animalData.data_de_nascimento;
        }

        // Metodo Cadastrar
        private void BTcadastrar_Click(object sender, EventArgs e)
        {
            string id = TBid.Text;
            string nome = TBnomeAnimal.Text;
            string especie = CBespecie.Text;
            string raca = TBraca.Text;
            decimal altura = Convert.ToDecimal(TBaltura.Text);
            decimal comprimento = Convert.ToDecimal(TBcomprimento.Text);
            decimal peso = Convert.ToDecimal(TBpeso.Text);
            string data_nascimento = MTBdataNascimento.Text;

            CadastrarAnimal(id, nome, especie, raca, altura, comprimento, peso, data_nascimento);
        }
        private async Task CadastrarAnimal(string id, string nome, string especie, string raca, decimal altura, decimal comprimento, decimal peso, string data_nascimento)
        {
            if (id == "")
            {
                string URl = $"http://localhost/api_CRUD/api/Cadastro_Animal";

                using (HttpClient client = new HttpClient())
                {
                    try
                    {

                        var informacoes = new
                        {

                            nome_do_animal = nome,
                            data_de_nascimento = data_nascimento,
                            altura_cm = altura,
                            peso_kg = peso,
                            comprimento_cm = comprimento,
                            especie = especie,
                            raca = raca





                        };


                        var conteudo = new StringContent(System.Text.Json.JsonSerializer.Serialize(informacoes));

                        // Definindo o tipo de mídia diretamente como uma string
                        conteudo.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");


                        HttpResponseMessage response = await client.PostAsync(URl, conteudo);

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Dados cadastrados com sucesso");
                            LimparCampos();

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
            TBnomeAnimal.Text = "";
            CBespecie.Text = "";
            MTBdataNascimento.Text = "";
            TBraca.Text = "";
            TBpeso.Text = "";
            TBcomprimento.Text = "";
            TBaltura.Text = "";
            TBidAnimal.Text = "";
            TBidCliente.Text = "";
            TBidRegistro.Text = "";
            TBidVinculo.Text = "";
        }


        //metodo Atualizar
        private void BTatualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TBid.Text);
            string nome = TBnomeAnimal.Text;
            string especie = CBespecie.Text;
            string raca = TBraca.Text;
            decimal altura = Convert.ToDecimal(TBaltura.Text);
            decimal comprimento = Convert.ToDecimal(TBcomprimento.Text);
            decimal peso = Convert.ToDecimal(TBpeso.Text);
            string data_nascimento = MTBdataNascimento.Text;

            AtualizarDadosAnimais(id, nome, especie, raca, altura, comprimento, peso, data_nascimento);
        }
        private async Task AtualizarDadosAnimais(int id, string nome, string especie, string raca, decimal altura, decimal comprimento, decimal peso, string data_nascimento)
        {
            if (id != 0)
            {
                string URl = $"http://localhost/api_CRUD/api/Cadastro_Animal/{id}";

                using (HttpClient client = new HttpClient())
                {
                    try
                    {

                        var informacoes = new
                        {
                            id_do_animal = id,
                            nome_do_animal = nome,
                            data_de_nascimento = data_nascimento,
                            altura_cm = altura,
                            peso_kg = peso,
                            comprimento_cm = comprimento,
                            especie = especie,
                            raca = raca


                        };


                        var conteudo = new StringContent(System.Text.Json.JsonSerializer.Serialize(informacoes));

                        // Definindo o tipo de mídia diretamente como uma string
                        conteudo.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");


                        HttpResponseMessage response = await client.PutAsync(URl, conteudo);

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Dados atualizados com sucesso");
                            LimparCampos();
                            AtualizarDadosGerais();
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

        //metodo excluir
        private void BTexcluir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TBid.Text);
            if (MessageBox.Show("Tem certeza que deseja excluir esse animal ?", "Confirmação de Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ExcluirAnimal(id);
            }
        }
           

        private async Task ExcluirAnimal(int id)
        {
            if (id != 0)
            {
                string URL = $"http://localhost/api_CRUD/api/Cadastro_Animal/{id}";

                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        HttpResponseMessage response = await client.DeleteAsync(URL);
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Dados excluidos com sucesso");
                            AtualizarDadosGerais();
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
            else
            {
                MessageBox.Show("Coloque o Id do animal que deseja excluir");
            }
        }
        // Chamando o formulario RegistroMedicoAnimal.cs
        private void BTregistroMedico_Click(object sender, EventArgs e)
        {

            Form tela = new RegistroMedicoAnimal();
            tela.Show();
        }

        //Metodo de buscar para o Vinculo

        private async void BTbuscarV_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(TBidVinculo.Text, out id))
            {
                await BuscarVinculo(id);
            }
            else
            {
                MessageBox.Show("Insira um ID válido para buscar.");
            }
        }
        private async Task BuscarVinculo(int id)
        {
            if (id != 0)
            {
                string URL = $"http://localhost/api_CRUD/api/Cadastro_VinculoCliente/{id}";

                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        HttpResponseMessage response = await client.GetAsync(URL);

                        if (response.IsSuccessStatusCode)
                        {
                            string responsedata = await response.Content.ReadAsStringAsync();
                            MessageBox.Show("Dados buscados com sucesso");

                            // Desserializar o JSON para um objeto 
                            VinculoResponse VinculoClienteResponse = JsonConvert.DeserializeObject<VinculoResponse>(responsedata);

                            // Verificar se a desserialização foi bem-sucedida e o status é "success" 
                            if (VinculoClienteResponse != null && VinculoClienteResponse.Status == "success")
                            {
                                VinculoData VinculoClienteData = VinculoClienteResponse.Data;
                                if (VinculoClienteData != null)
                                {
                                    MostrarRespostaVinculo(VinculoClienteData);
                                }
                                else
                                {
                                    MessageBox.Show("Nenhum dado encontrado para o ID fornecido.");
                                    LimparCampos();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Erro na desserialização ou no status 'success'");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Dados não encontrado!!! verifique o ID digitado. Código de status: " + response.StatusCode);
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
                MessageBox.Show("Insira o ID para buscar.");
            }
        }
        private void MostrarRespostaVinculo(VinculoData VinculoData)
        {
            TBidCliente.Text = VinculoData.id_do_cliente.HasValue ? Convert.ToString(VinculoData.id_do_cliente) : "Nulo";
            TBidAnimal.Text = VinculoData.id_do_animal.HasValue ? Convert.ToString(VinculoData.id_do_animal) : "Nulo";
            TBidRegistro.Text = VinculoData.Id_registro_medico_do_animal.HasValue ? Convert.ToString(VinculoData.Id_registro_medico_do_animal) : "Nulo";


        }



        //Metodo cadastrar na tabela vinculo

        private async void BTcadastrarV_Click(object sender, EventArgs e)
        {
            await CadastrarVinculoCliente();
            AtualizarDadosVinculo();
            AtualizarDadosGerais();
        }
        private async Task CadastrarVinculoCliente()
        {
            // Ler os dados dos campos de entrada 
            int? idCliente = string.IsNullOrEmpty(TBidCliente.Text) ? (int?)null : Convert.ToInt32(TBidCliente.Text);
            int? idAnimal = string.IsNullOrEmpty(TBidAnimal.Text) ? (int?)null : Convert.ToInt32(TBidAnimal.Text);
            int? idRegistroMedicoAnimal = string.IsNullOrEmpty(TBidRegistro.Text) ? (int?)null : Convert.ToInt32(TBidRegistro.Text);

            // Montar o objeto com os dados 
            var dados = new
            {
                id_do_cliente = idCliente,
                id_do_animal = idAnimal,
                id_registro_medico_do_animal = idRegistroMedicoAnimal
            };

            string jsonDados = JsonConvert.SerializeObject(dados);
            var content = new StringContent(jsonDados, Encoding.UTF8, "application/json");

            string URL = "http://localhost/api_CRUD/api/Cadastro_VinculoCliente";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.PostAsync(URL, content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Cadastro realizado com sucesso.");
                        LimparCampos(); // Limpar campos após o cadastro 
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar. Código de status: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar: " + ex.Message);
                }
            }
        }



        //Metodo Atualizar na tabela vinculo
        private async void BTatualizarV_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TBidVinculo.Text);
            await AtualizarVinculo(id);
            AtualizarDadosVinculo();
            AtualizarDadosGerais();
        }
        private async Task AtualizarVinculo(int id)
        {
            // Ler os dados dos campos de entrada 
            int? idCliente = string.IsNullOrEmpty(TBidCliente.Text) ? (int?)null : Convert.ToInt32(TBidCliente.Text);
            int? idAnimal = string.IsNullOrEmpty(TBidAnimal.Text) ? (int?)null : Convert.ToInt32(TBidAnimal.Text);
            int? idRegistroMedicoAnimal = string.IsNullOrEmpty(TBidRegistro.Text) ? (int?)null : Convert.ToInt32(TBidRegistro.Text);

            // Montar o objeto com os dados 
            var dados = new
            {
                id_vinculo_tabelasCliente = id,
                id_do_cliente = idCliente,
                id_do_animal = idAnimal,
                id_registro_medico_do_animal = idRegistroMedicoAnimal
            };

            string jsonDados = JsonConvert.SerializeObject(dados);
            var content = new StringContent(jsonDados, Encoding.UTF8, "application/json");

            string URL = $"http://localhost/api_CRUD/api/Cadastro_VinculoCliente/{id}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.PutAsync(URL, content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Atualização realizada com sucesso.");
                        LimparCampos(); // Limpar campos após a atualização 
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atualizar. Código de status: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar: " + ex.Message);
                }
            }
        }



        //Metodo Excluir na  tabela vinculo
        private async void BTexcluirV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja desfazer esse vinculo ?", "Confirmação de Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                await ExcluirTabelaVinculoCliente();
                AtualizarDadosGerais();
                AtualizarDadosVinculo();
            }
        }
        private async Task ExcluirTabelaVinculoCliente()
        {
            if (!string.IsNullOrEmpty(TBidVinculo.Text))
            {
                int id = Convert.ToInt32(TBidVinculo.Text);
                string URL = $"http://localhost/api_CRUD/api/Cadastro_VinculoCliente/{id}";

                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        HttpResponseMessage response = await client.DeleteAsync(URL);

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Dados excluídos com sucesso.");
                            LimparCampos();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao excluir dados. Código de status: " +response.StatusCode);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir dados: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Insira o ID para excluir.");
            }
        }
    }

}




