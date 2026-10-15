using System.Security.Policy;
using System.Text.Json;
using Herois.DTOs;

namespace Herois
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient cliente = new HttpClient();
        public Form1()
        {
            InitializeComponent();
            ConfigurarGrid();
        }
        private void ConfigurarGrid()
        {
            organizar();
            listPersonagens.Columns.Clear();
            listPersonagens.Columns.Add("colId", "id");
            listPersonagens.Columns.Add("cols", "nome personagem");
            listPersonagens.Columns.Add("cols", "pulicado");
            listPersonagens.Columns.Add("cols", "nome completo");
            listPersonagens.Columns["cols"]?.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void organizar()
        {
            panel1.Anchor = AnchorStyles.None;
        }

        private async void Pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                Pesquisar.Enabled = false;
                var inputPesquisa = areaPesquisa.Text;
                await requisicao(inputPesquisa);
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro: {erro.Message}");
            }
            finally
            {
                selecionado.Text = areaPesquisa.Text;
                areaPesquisa.Text = "";
                Pesquisar.Enabled = true;
            }
        }

        private async Task requisicao(string inputPesquisa)
        {
            string url = $"https://www.superheroapi.com/api.php/e67c2cb4edad8d635496d3e156a9cf83/search/{inputPesquisa}";

            string resposta = await cliente.GetStringAsync(url);
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            var dadosApi = JsonSerializer.Deserialize<SuperHeroApiResponse>(resposta, options);
            var personagens = dadosApi?.results;

            listPersonagens.Rows.Clear();
            foreach (var personagem in personagens)
            {
                var id = personagem.id;
                var nome = personagem.name;
                var publicado = personagem.biography.publisher;
                var nomeCompleto = personagem.biography.FullName;
                if (publicado == null || publicado == "" || publicado == "null")
                {
                    publicado = "Não encontrado";
                }
                if (nomeCompleto == null || nomeCompleto == "" || nomeCompleto == "null")
                {
                    nomeCompleto = "Não encontrado";
                }

                listPersonagens.Rows.Add(id, nome, publicado, nomeCompleto);
            }

        }

        private async void listPersonagens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string? idPersonagem = listPersonagens.Rows[e.RowIndex].Cells["colId"].Value?.ToString();
            string url = $"https://www.superheroapi.com/api.php/e67c2cb4edad8d635496d3e156a9cf83/{idPersonagem}";

            var resposta = await cliente.GetStreamAsync(url);
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            var personagem = JsonSerializer.Deserialize<DTOpersonagem>(resposta, options);
            
            if (personagem != null && !string.IsNullOrEmpty(personagem.image?.url))
            {
                personagemSelecionado.Text = personagem.name;
                nomePersonagem.Text = personagem.biography.FullName;
                imagem.Load(personagem.image.url);
                imagem.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                MessageBox.Show("Não foi possível carregar a imagem do personagem.");
            }
        }

        private void listPersonagens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linhaAtual = listPersonagens.Rows[e.RowIndex];
                string idSelecionado = linhaAtual.Cells["colId"].Value.ToString();

                if (!string.IsNullOrEmpty(idSelecionado))
                {
                    Form2 telaDetalhes = new Form2(idSelecionado);
                    telaDetalhes.Show();
                }
            }
        }
    }
}
