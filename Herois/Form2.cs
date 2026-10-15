using Herois.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.Json;

namespace Herois
{
    public partial class Form2 : Form
    {
        private static readonly HttpClient cliente = new HttpClient();
        private string idHeroi;
        public Form2(string Id)
        {
            InitializeComponent();
            organizar();

            idHeroi = Id;
            this.Load += Form2_Load;
        }

        private void organizar()
        {
            flowLayoutPanel2.Anchor = AnchorStyles.None;
        }

        public async Task requisicao(string id)
        {
            string url = $"https://www.superheroapi.com/api.php/e67c2cb4edad8d635496d3e156a9cf83/{id}";
            string resposta = await cliente.GetStringAsync(url);
            var heroi = JsonSerializer.Deserialize<dadosPersonagem>(resposta);

            exibirNome.Text = heroi?.name;
            exibirSexo.Text = heroi?.appearance.gender;
            exibirPoder.Text = heroi?.powerstats.power;
            exibirDurabilidade.Text = heroi?.powerstats.durability;
            exibirForca.Text = heroi?.powerstats.strength;
            exibirCombate.Text = heroi?.powerstats.combat;
            exibirVelocidade.Text = heroi?.powerstats.speed;
            exibirInteligencia.Text = heroi?.powerstats.intelligence;
            exibirNomeCompleto.Text = heroi?.biography.FullName;
            exibirPublicado.Text = heroi?.biography.publisher;
            exibirPeso.Text = heroi?.appearance.weight[1];
            exibirImagem.Load(heroi.image.url);
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            await requisicao(idHeroi);
        }
    }
}
