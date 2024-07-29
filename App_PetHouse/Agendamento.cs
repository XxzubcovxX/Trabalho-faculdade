using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Globalization;
using System.Linq;
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

namespace App_PetHouse
{
    public partial class Agendamento : Form
    {
        public Agendamento()
        {
            InitializeComponent();
        }

        private void Agendamento_Load(object sender, EventArgs e)
        {
            AtualizarDados();
        }

        private async Task AtualizarDados()
        {
            // Fazendo a solicitação HTTP para a API em PHP
            var dados = await DadosAPI("http://localhost/api_CRUD/api/Agendamento");
            // Definindo os dados no DataGridView
            DVGagentamentos.DataSource = dados;
        }

        private async Task<List<AgendamentoData>> DadosAPI(string URL)
        {
            List<AgendamentoData> dados = null;
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(URL);

                    if (response.IsSuccessStatusCode)
                    {
                        string responsedata = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Dados buscados com sucesso");

                        // Desserializar o JSON para um objeto dinâmico
                        dynamic responseObject = JsonConvert.DeserializeObject(responsedata);

                        // Verificar se a desserialização foi bem-sucedida e o status é "success"
                        if (responseObject != null && responseObject.status == "success")
                        {
                            // Desserializar os dados contidos na propriedade "data"
                            string dataJson = JsonConvert.SerializeObject(responseObject.data);
                            dados = JsonConvert.DeserializeObject<List<AgendamentoData>>(dataJson);

                            // Inverter o formato da data para cada objeto AgendamentoData
                            foreach (var agendamento in dados)
                            {
                                if (DateTime.TryParseExact(agendamento.dataAgendamento, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime dataAgendamento))
                                {
                                    agendamento.dataAgendamento = dataAgendamento.ToString("dd/MM/yyyy");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Erro na desserialização ou no status 'success'");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Erro ao buscar dados. Código de status: " + response.StatusCode);
                    }
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show("Erro de requisição HTTP: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar dados: " + ex.Message);
                    TBcpfCliente.Text = "Erro ao buscar dados: " + ex.Message;
                }
            }

            // Se não houve dados válidos retornados, retornamos uma lista vazia ao invés de nula
            return dados ?? new List<AgendamentoData>();
        }

        public class AgendamentoResponse
        {
            public string Status { get; set; }
            public AgendamentoData Data { get; set; }
        }

        public class AgendamentoData

        {
            public int id { get; set; }
            public string? nomeCompleto { get; set; }
            public string? CPF { get; set; }
            public string? telefone { get; set; }
            public string? email { get; set; }
            public string? nomeAnimal { get; set; }
            public string? racaAnimal { get; set; }
            public int? idadeAnimal { get; set; }
            public decimal? pesoAnimal { get; set; }
            public string? tipoServico { get; set; }
            public string? dataAgendamento { get; set; }
            public string? horaAgendamento { get; set; }

        }

        private void DVGagentamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique foi em uma célula válida
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtém os dados da linha clicada
                var row = DVGagentamentos.Rows[e.RowIndex];

                // Preenche os campos de entrada com os dados da linha clicada
                TBcpfCliente.Text = row.Cells["CPF"].Value != null ? row.Cells["CPF"].Value.ToString() : "Nulo";
                TBnomeCliente.Text = row.Cells["nomeCompleto"].Value != null ? row.Cells["nomeCompleto"].Value.ToString() : "Nulo";
                TBtelefone.Text = row.Cells["telefone"].Value != null ? row.Cells["telefone"].Value.ToString() : "Nulo";
                TBemail.Text = row.Cells["email"].Value != null ? row.Cells["email"].Value.ToString() : "Nulo";
                TBnomeAnimal.Text = row.Cells["nomeAnimal"].Value != null ? row.Cells["nomeAnimal"].Value.ToString() : "Nulo";
                TBracaAnimal.Text = row.Cells["racaAnimal"].Value != null ? row.Cells["racaAnimal"].Value.ToString() : "Nulo";
                TBidadeAnimal.Text = row.Cells["idadeAnimal"].Value != null ? row.Cells["idadeAnimal"].Value.ToString() : "Nulo";
                TBpesoAnimal.Text = row.Cells["pesoAnimal"].Value != null ? row.Cells["pesoAnimal"].Value.ToString() : "Nulo";
                CBservico.Text = row.Cells["tipoServico"].Value != null ? row.Cells["tipoServico"].Value.ToString() : "Nulo";
                MTBdiaAgendamento.Text = row.Cells["dataAgendamento"].Value != null ? row.Cells["dataAgendamento"].Value.ToString() : "Nulo";
                CBhoraAgendamento.Text = row.Cells["horaAgendamento"].Value != null ? row.Cells["horaAgendamento"].Value.ToString() : "Nulo";
            }
        }

        private async void BTbuscar_Click(object sender, EventArgs e)
        {
            string CPF = TBcpfCliente.Text;

            if (!string.IsNullOrEmpty(CPF) && CPF.All(char.IsDigit) && CPF.Length == 11)
            {
                await BuscarAgendamento(CPF);
            }
            else
            {
                MessageBox.Show("Insira um CPF válido para buscar.");
            }
        }


        private async Task BuscarAgendamento(string CPF)
        {
            if (!string.IsNullOrEmpty(CPF))
            {
                string URL = $"http://localhost/api_CRUD/api/Agendamento/{CPF}";

                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        HttpResponseMessage response = await client.GetAsync(URL);

                        if (response.IsSuccessStatusCode)
                        {
                            string responsedata = await response.Content.ReadAsStringAsync();
                            MessageBox.Show("Dados buscados com sucesso: " + responsedata);

                            // Desserializar o JSON para um objeto
                            AgendamentoResponse agendamentoResponse = null;
                            try
                            {
                                agendamentoResponse = JsonConvert.DeserializeObject<AgendamentoResponse>(responsedata);
                            }
                            catch (JsonException ex)
                            {
                                MessageBox.Show("Erro na desserialização do JSON: " + ex.Message);
                                return;
                            }

                            // Verificar se a desserialização foi bem-sucedida e o status é "success"
                            if (agendamentoResponse != null && agendamentoResponse.Status == "success")
                            {
                                var agendamento = agendamentoResponse.Data;
                                if (agendamento != null && agendamento.CPF == CPF)
                                {
                                    // Inverter o formato da data
                                    if (DateTime.TryParseExact(agendamento.dataAgendamento, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime dataAgendamento))
                                    {
                                        agendamento.dataAgendamento = dataAgendamento.ToString("dd/MM/yyyy");
                                    }

                                    // Mostra a resposta (ajuste para o seu método de exibição)
                                    MostrarResposta(agendamento);
                                }
                                else
                                {
                                    MessageBox.Show("Nenhum dado encontrado para o CPF fornecido.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Erro na desserialização ou no status 'success'");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Erro ao buscar dados. Código de status: " + response.StatusCode);
                        }
                    }
                    catch (HttpRequestException ex)
                    {
                        MessageBox.Show("Erro ao conectar com o servidor: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao buscar dados: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Insira um CPF para buscar");
            }
        }


        public void MostrarResposta(AgendamentoData AgendamentoData)
        {
            TBcpfCliente.Text = AgendamentoData?.CPF ?? "";
            TBnomeCliente.Text = AgendamentoData?.nomeCompleto ?? "";
            TBtelefone.Text = AgendamentoData?.telefone ?? "";
            TBemail.Text = AgendamentoData?.email ?? "";
            TBnomeAnimal.Text = AgendamentoData?.nomeAnimal ?? "";
            TBracaAnimal.Text = AgendamentoData?.racaAnimal ?? "";
            TBidadeAnimal.Text = AgendamentoData?.idadeAnimal?.ToString() ?? "";
            TBpesoAnimal.Text = AgendamentoData?.pesoAnimal?.ToString() ?? "";
            CBservico.Text = AgendamentoData?.tipoServico ?? "";
            MTBdiaAgendamento.Text = AgendamentoData?.dataAgendamento ?? "";
            CBhoraAgendamento.Text = AgendamentoData?.horaAgendamento ?? "";
        }
       
        private async void BTcadastrar_Click(object sender, EventArgs e)
        {
            await CadastrarAgendamento();
            AtualizarDados();
        }

        private async Task CadastrarAgendamento()
        {
            // Verificar se todos os campos obrigatórios estão preenchidos
            if (string.IsNullOrWhiteSpace(TBnomeCliente.Text) ||
                string.IsNullOrWhiteSpace(TBcpfCliente.Text) ||
                string.IsNullOrWhiteSpace(TBtelefone.Text) ||
                string.IsNullOrWhiteSpace(TBemail.Text) ||
                string.IsNullOrWhiteSpace(TBnomeAnimal.Text) ||
                string.IsNullOrWhiteSpace(TBracaAnimal.Text) ||
                string.IsNullOrWhiteSpace(TBidadeAnimal.Text) ||
                string.IsNullOrWhiteSpace(TBpesoAnimal.Text) ||
                string.IsNullOrWhiteSpace(CBservico.Text) ||
                string.IsNullOrWhiteSpace(MTBdiaAgendamento.Text) ||
                string.IsNullOrWhiteSpace(CBhoraAgendamento.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.");
                return; // Retorna sem prosseguir com o cadastro
            }

            // Convertendo os campos para os tipos corretos
            string nomeCompleto = TBnomeCliente.Text;
            string CPF = TBcpfCliente.Text;
            string telefone = TBtelefone.Text;
            string email = TBemail.Text;
            string nomeAnimal = TBnomeAnimal.Text;
            string racaAnimal = TBracaAnimal.Text;
            int idadeAnimal = Convert.ToInt32(TBidadeAnimal.Text);
            decimal pesoAnimal = Convert.ToDecimal(TBpesoAnimal.Text);
            string tipoServico = CBservico.Text;
            string dataAgendamentoInput = MTBdiaAgendamento.Text; // Data no formato dd/MM/yyyy
            string horaAgendamento = CBhoraAgendamento.Text;

            // Converter a data para o formato yyyy-MM-dd
            string dataAgendamento = DateTime.ParseExact(dataAgendamentoInput, "dd/MM/yyyy", CultureInfo.InvariantCulture)
                                            .ToString("yyyy-MM-dd");

            // Montar o objeto com os dados
            var dados = new
            {
                nomeCompleto = nomeCompleto,
                CPF = CPF,
                telefone = telefone,
                email = email,
                nomeAnimal = nomeAnimal,
                racaAnimal = racaAnimal,
                idadeAnimal = idadeAnimal,
                pesoAnimal = pesoAnimal,
                tipoServico = tipoServico,
                dataAgendamento = dataAgendamento, // Data no formato yyyy-MM-dd
                horaAgendamento = horaAgendamento,
            };

            string jsonDados = JsonConvert.SerializeObject(dados);
            var content = new StringContent(jsonDados, Encoding.UTF8, "application/json");

            string URL = "http://localhost/api_CRUD/api/Agendamento";

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


        private async void BTatualizar_Click(object sender, EventArgs e)
        {
            string CPF = TBcpfCliente.Text;

            if (!string.IsNullOrEmpty(CPF) && CPF.All(char.IsDigit) && CPF.Length == 11)
            {
                await AtualizarAgendamento(CPF);
            }
            else
            {
                MessageBox.Show("Insira um CPF válido para atualizar.");
            }
            AtualizarDados();
        }

        private async Task AtualizarAgendamento(string CPF)
        {
            // Verificar se o CPF é válido
            if (!string.IsNullOrEmpty(CPF) && CPF.All(char.IsDigit) && CPF.Length == 11)
            {
                string URL = $"http://localhost/api_CRUD/api/Agendamento/{CPF}";

                // Ler os dados dos campos de entrada
                string nomeCompleto = TBnomeCliente.Text;
                string telefone = TBtelefone.Text;
                string email = TBemail.Text;
                string nomeAnimal = TBnomeAnimal.Text;
                string racaAnimal = TBracaAnimal.Text;
                int idadeAnimal = 0;
                decimal pesoAnimal = 0;

                if (!string.IsNullOrEmpty(TBidadeAnimal.Text) && int.TryParse(TBidadeAnimal.Text, out int idade))
                {
                    idadeAnimal = idade;
                }

                if (!string.IsNullOrEmpty(TBpesoAnimal.Text) && decimal.TryParse(TBpesoAnimal.Text, out decimal peso))
                {
                    pesoAnimal = peso;
                }

                string tipoServico = CBservico.Text;
                string dataAgendamentoInput = MTBdiaAgendamento.Text;
                string horaAgendamento = CBhoraAgendamento.Text;

                // Converter a data para o formato yyyy-MM-dd
                string dataAgendamento = DateTime.ParseExact(dataAgendamentoInput, "dd/MM/yyyy", CultureInfo.InvariantCulture)
                                                    .ToString("yyyy-MM-dd");

                // Montar o objeto com os dados
                var dados = new
                {
                    nomeCompleto = nomeCompleto,
                    telefone = telefone,
                    email = email,
                    nomeAnimal = nomeAnimal,
                    racaAnimal = racaAnimal,
                    idadeAnimal = idadeAnimal,
                    pesoAnimal = pesoAnimal,
                    tipoServico = tipoServico,
                    dataAgendamento = dataAgendamento,
                    horaAgendamento = horaAgendamento
                };

                string jsonDados = JsonConvert.SerializeObject(dados);
                var content = new StringContent(jsonDados, Encoding.UTF8, "application/json");

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
                    catch (HttpRequestException ex)
                    {
                        MessageBox.Show("Erro ao conectar com o servidor: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao atualizar: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Insira um CPF válido para buscar e atualizar.");
            }
        }


        private async void BTexcluir_Click(object sender, EventArgs e)
        {
            string CPF = TBcpfCliente.Text;

            if (!string.IsNullOrEmpty(CPF) && CPF.All(char.IsDigit) && CPF.Length == 11)
            {
                if (MessageBox.Show("Tem certeza que deseja excluir o agendamento?", "Confirmação de Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    await ExcluirAgendamento(CPF);
                }
            }
            else
            {
                MessageBox.Show("Insira um CPF válido para excluir.");
            }
            AtualizarDados();
        }

        private async Task ExcluirAgendamento(string CPF)
        {
            if (!string.IsNullOrEmpty(CPF))
            {
                string URL = $"http://localhost/api_CRUD/api/Agendamento/{CPF}";

                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        HttpResponseMessage response = await client.DeleteAsync(URL);

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Agendamento excluído com sucesso.");
                            LimparCampos(); // Limpar campos após a exclusão
                        }
                        else
                        {
                            MessageBox.Show("Erro ao excluir. Código de status: " + response.StatusCode);
                        }
                    }
                    catch (HttpRequestException ex)
                    {
                        MessageBox.Show("Erro ao conectar com o servidor: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir agendamento: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Insira um CPF para excluir.");
            }
        }


        private void LimparCampos()
        {
            TBcpfCliente.Text = "";
            TBnomeCliente.Text = "";
            TBtelefone.Text = "";
            TBemail.Text = "";
            TBnomeAnimal.Text = "";
            TBracaAnimal.Text = "";
            TBidadeAnimal.Text = "";
            TBpesoAnimal.Text = "";
            CBservico.Text = "";
            MTBdiaAgendamento.Text = "";
            CBhoraAgendamento.Text = "";
        }
    }
}
