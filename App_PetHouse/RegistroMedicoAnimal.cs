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
using static App_PetHouse.Animais;
using static App_PetHouse.RegistroMedicoAnimal;

namespace App_PetHouse
{
    public partial class RegistroMedicoAnimal : Form
    {
        public RegistroMedicoAnimal()
        {
            InitializeComponent();
        }

        private void TXTnomeDoAnimal_Click(object sender, EventArgs e)
        {

        }

        private void TXTdono_Click(object sender, EventArgs e)
        {

        }

        private void RegistroMedicoAnimal_Load(object sender, EventArgs e)
        {
            AtualizarDados();
        }
        private async Task AtualizarDados()
        {
            // Fazendo a solicitação HTTP para a API em PHP
            var dados = await DadosAPI("http://localhost/api_CRUD/api/Tabela_VinculoCliente");
            // Definindo os dados no DataGridView
            DGVregistro.DataSource = dados;
        }
        //Metodo dos dados do DataGrid
        private async Task<List<VinculoData>> DadosAPI(string URL)
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

                }
            }

            return dados;
        }
        public class VinculoResponse
        {
            public string Status { get; set; }
            public VinculoData Data { get; set; }
        }
        public class VinculoData

        {
            public int id_do_cliente { get; set; }
            public string nome_do_cliente { get; set; }
            public string sobrenome { get; set; }
            public string cpf { get; set; }
            public int id_do_animal { get; set; }
            public string nome_do_animal { get; set; }
            public string especie { get; set; }
            public string raca { get; set; }
            public int Id_registro_medico_do_animal { get; set; }


        }
        public class RegistroResponse
        {
            public string Status { get; set; }
            public RegistroData Data { get; set; }
        }

        public class RegistroData
        {
            public int Id_registro_medico_do_animal { get; set; }
            public string historico_de_vacinacao { get; set; }
            public string medicamentos_prescritos { get; set; }
            public string tratamentos_realizados { get; set; }
            public string consultas_veterinarias { get; set; }
            public string alergias { get; set; }
            public string condicoes_de_saude { get; set; }
            public string exames { get; set; }
            public string resultados { get; set; }
            public string observacoes { get; set; }
        }

        private void DGVregistro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selecao = DGVregistro.Rows[index];

            TXTnomeDoAnimal.Text = selecao.Cells["nome_do_animal"].Value.ToString();
            TXTdono.Text = selecao.Cells["nome_do_cliente"].Value.ToString();
            TBid.Text = selecao.Cells["Id_registro_medico_do_animal"].Value.ToString();

        }


        //metodo Buscar
        private void BTbuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TBid.Text);


            BuscarRegistro(id);
        }
        private async Task BuscarRegistro(int id)
        {
            if (id != 0)
            {
                string URL = $"http://localhost/api_CRUD/api/Cadastro_RegistroMedico/{id}";

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

                            RegistroResponse registroResponse = JsonConvert.DeserializeObject<RegistroResponse>(responsedata);

                            // Verificar se a desserialização foi bem-sucedida e o status é "success"
                            if (registroResponse != null && registroResponse.Status == "success")
                            {
                                RegistroData registrodata = registroResponse.Data;
                                MostrarResposta(registrodata);

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
        public void MostrarResposta(RegistroData registroData)
        {

            RTBhistoricoVacinacao.Text = registroData.historico_de_vacinacao;
            RTBmeicamentosPrescritos.Text = registroData.medicamentos_prescritos;
            RTBconsultas.Text = registroData.consultas_veterinarias;
            RTBalergias.Text = registroData.alergias;
            RTBcondicoes.Text = registroData.condicoes_de_saude;
            RTBexames.Text = registroData.exames;
            RTBobservacoes.Text = registroData.observacoes;
            RTBresultados.Text = registroData.resultados;
            RTBtratamentosRealizados.Text = registroData.tratamentos_realizados;
        }


        //metodo Cadastrar
        private void BTcadastrar_Click(object sender, EventArgs e)
        {
            string id = TBid.Text;
            string medicamento = RTBmeicamentosPrescritos.Text;
            string historico = RTBhistoricoVacinacao.Text;
            string consultas = RTBconsultas.Text;
            string alergias = RTBalergias.Text;
            string condicoes = RTBcondicoes.Text;
            string exames = RTBexames.Text;
            string observacoes = RTBobservacoes.Text;
            string resultados = RTBresultados.Text;
            string tratamentos = RTBtratamentosRealizados.Text;

            CadastrarRegistro(id, medicamento, historico, consultas, alergias, condicoes, exames, observacoes, resultados, tratamentos);
        }
        private async Task CadastrarRegistro(string id, string medicamento, string historico, string consultas, string alergias, string condicoes, string exames, string observacoes, string resultados, string tratamentos)
        {
            if (id == "")
            {
                string URl = $"http://localhost/api_CRUD/api/Cadastro_RegistroMedico";

                using (HttpClient client = new HttpClient())
                {
                    try
                    {

                        var informacoes = new
                        {

                            historico_de_vacinacao = historico,
                            medicamentos_prescritos = medicamento,
                            tratamentos_realizados = tratamentos,
                            consultas_veterinarias = consultas,
                            alergias = alergias,
                            condicoes_de_saude = condicoes,
                            exames = exames,
                            resultados = resultados,
                            observacoes = observacoes





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
            RTBhistoricoVacinacao.Text = "";
            RTBmeicamentosPrescritos.Text = "";
            RTBconsultas.Text = "";
            RTBalergias.Text = "";
            RTBcondicoes.Text = "";
            RTBexames.Text = "";
            RTBobservacoes.Text = "";
            RTBresultados.Text = "";
            RTBtratamentosRealizados.Text = "";
        }

        // metodo Atualizar
        private void BTatualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TBid.Text);
            string medicamento = RTBmeicamentosPrescritos.Text;
            string historico = RTBhistoricoVacinacao.Text;
            string consultas = RTBconsultas.Text;
            string alergias = RTBalergias.Text;
            string condicoes = RTBcondicoes.Text;
            string exames = RTBexames.Text;
            string observacoes = RTBobservacoes.Text;
            string resultados = RTBresultados.Text;
            string tratamentos = RTBtratamentosRealizados.Text;

            AtualizarRegistro(id, medicamento, historico, consultas, alergias, condicoes, exames, observacoes, resultados, tratamentos);
        }

        private async Task AtualizarRegistro(int id, string medicamento, string historico, string consultas, string alergias, string condicoes, string exames, string observacoes, string resultados, string tratamentos)
        {
            if (id != 0)
            {
                string URl = $"http://localhost/api_CRUD/api/Cadastro_RegistroMedico/{id}";

                using (HttpClient client = new HttpClient())
                {
                    try
                    {

                        var informacoes = new
                        {
                            Id_registro_medico_do_animal = id,
                            historico_de_vacinacao = historico,
                            medicamentos_prescritos = medicamento,
                            tratamentos_realizados = tratamentos,
                            consultas_veterinarias = consultas,
                            alergias = alergias,
                            condicoes_de_saude = condicoes,
                            exames = exames,
                            resultados = resultados,
                            observacoes = observacoes





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
                        MessageBox.Show("Não foi possivel realizar a atualização \n" + ex);

                    }

                }

            }
            else
            {
                MessageBox.Show("Para Atualizar as informações é necessario ID");
            }
        }

        // Metodo Excluir
        private void BTexcluir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TBid.Text);
            if (MessageBox.Show("Tem certeza que deseja desfazer esse vinculo ?", "Confirmação de Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ExcluirRegistro(id);
            }
              
        }
        private async Task ExcluirRegistro(int id)
        {
            if (id != 0)
            {
                string URL = $"http://localhost/api_CRUD/api/Cadastro_RegistroMedico/{id}";

                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        HttpResponseMessage response = await client.DeleteAsync(URL);
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Dados excluidos com sucesso");
                            AtualizarDados();
                            LimparCampos();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possivel excluir os dados\n Verifique se esse registro esta Desvinculado\n " + response.StatusCode);
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possivel excluir dados  " + ex.Message);
                    }

                }
            }
            else
            {
                MessageBox.Show("Coloque o Id do animal que deseja excluir");
            }
        }
    }


}
