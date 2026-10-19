namespace Herois
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            exibirImagem = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            exibirNomeCompleto = new Label();
            NomeCompleto = new Label();
            exibirNome = new Label();
            nome = new Label();
            publicado = new Label();
            peso = new Label();
            sexo = new Label();
            combate = new Label();
            poder = new Label();
            durabilidade = new Label();
            velocidade = new Label();
            força = new Label();
            inteligencia = new Label();
            exibirPublicado = new Label();
            exibirPeso = new Label();
            exibirSexo = new Label();
            exibirCombate = new Label();
            exibirPoder = new Label();
            exibirDurabilidade = new Label();
            exibirVelocidade = new Label();
            exibirForca = new Label();
            exibirInteligencia = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)exibirImagem).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // exibirImagem
            // 
            exibirImagem.BackgroundImage = (Image)resources.GetObject("exibirImagem.BackgroundImage");
            exibirImagem.BackgroundImageLayout = ImageLayout.Zoom;
            exibirImagem.BorderStyle = BorderStyle.FixedSingle;
            exibirImagem.Location = new Point(3, 3);
            exibirImagem.Name = "exibirImagem";
            exibirImagem.Size = new Size(340, 426);
            exibirImagem.TabIndex = 4;
            exibirImagem.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel1.Location = new Point(349, 41);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(281, 349);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(exibirNomeCompleto, 1, 1);
            tableLayoutPanel1.Controls.Add(NomeCompleto, 0, 1);
            tableLayoutPanel1.Controls.Add(exibirNome, 1, 0);
            tableLayoutPanel1.Controls.Add(nome, 0, 0);
            tableLayoutPanel1.Controls.Add(publicado, 0, 10);
            tableLayoutPanel1.Controls.Add(peso, 0, 9);
            tableLayoutPanel1.Controls.Add(sexo, 0, 8);
            tableLayoutPanel1.Controls.Add(combate, 0, 7);
            tableLayoutPanel1.Controls.Add(poder, 0, 6);
            tableLayoutPanel1.Controls.Add(durabilidade, 0, 5);
            tableLayoutPanel1.Controls.Add(velocidade, 0, 4);
            tableLayoutPanel1.Controls.Add(força, 0, 3);
            tableLayoutPanel1.Controls.Add(inteligencia, 0, 2);
            tableLayoutPanel1.Controls.Add(exibirPublicado, 1, 10);
            tableLayoutPanel1.Controls.Add(exibirPeso, 1, 9);
            tableLayoutPanel1.Controls.Add(exibirSexo, 1, 8);
            tableLayoutPanel1.Controls.Add(exibirCombate, 1, 7);
            tableLayoutPanel1.Controls.Add(exibirPoder, 1, 6);
            tableLayoutPanel1.Controls.Add(exibirDurabilidade, 1, 5);
            tableLayoutPanel1.Controls.Add(exibirVelocidade, 1, 4);
            tableLayoutPanel1.Controls.Add(exibirForca, 1, 3);
            tableLayoutPanel1.Controls.Add(exibirInteligencia, 1, 2);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(278, 346);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // exibirNomeCompleto
            // 
            exibirNomeCompleto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            exibirNomeCompleto.AutoSize = true;
            exibirNomeCompleto.Location = new Point(142, 41);
            exibirNomeCompleto.Name = "exibirNomeCompleto";
            exibirNomeCompleto.Size = new Size(132, 15);
            exibirNomeCompleto.TabIndex = 23;
            exibirNomeCompleto.Text = "vazio";
            // 
            // NomeCompleto
            // 
            NomeCompleto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NomeCompleto.AutoSize = true;
            NomeCompleto.Location = new Point(4, 41);
            NomeCompleto.Name = "NomeCompleto";
            NomeCompleto.Size = new Size(131, 15);
            NomeCompleto.TabIndex = 22;
            NomeCompleto.Text = "Nome Completo:";
            // 
            // exibirNome
            // 
            exibirNome.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            exibirNome.AutoSize = true;
            exibirNome.Location = new Point(142, 9);
            exibirNome.Name = "exibirNome";
            exibirNome.Size = new Size(132, 15);
            exibirNome.TabIndex = 11;
            exibirNome.Text = "vazio";
            // 
            // nome
            // 
            nome.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nome.AutoSize = true;
            nome.Location = new Point(4, 9);
            nome.Name = "nome";
            nome.Size = new Size(131, 15);
            nome.TabIndex = 0;
            nome.Text = "Nome:";
            nome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // publicado
            // 
            publicado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            publicado.AutoSize = true;
            publicado.Location = new Point(4, 325);
            publicado.Name = "publicado";
            publicado.Size = new Size(131, 15);
            publicado.TabIndex = 9;
            publicado.Text = "publicado:";
            // 
            // peso
            // 
            peso.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            peso.AutoSize = true;
            peso.Location = new Point(4, 297);
            peso.Name = "peso";
            peso.Size = new Size(131, 15);
            peso.TabIndex = 8;
            peso.Text = "peso:";
            // 
            // sexo
            // 
            sexo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            sexo.AutoSize = true;
            sexo.Location = new Point(4, 265);
            sexo.Name = "sexo";
            sexo.Size = new Size(131, 15);
            sexo.TabIndex = 7;
            sexo.Text = "sexo:";
            // 
            // combate
            // 
            combate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            combate.AutoSize = true;
            combate.Location = new Point(4, 233);
            combate.Name = "combate";
            combate.Size = new Size(131, 15);
            combate.TabIndex = 6;
            combate.Text = "combate:";
            // 
            // poder
            // 
            poder.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            poder.AutoSize = true;
            poder.Location = new Point(4, 201);
            poder.Name = "poder";
            poder.Size = new Size(131, 15);
            poder.TabIndex = 5;
            poder.Text = "poder:";
            // 
            // durabilidade
            // 
            durabilidade.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            durabilidade.AutoSize = true;
            durabilidade.Location = new Point(4, 169);
            durabilidade.Name = "durabilidade";
            durabilidade.Size = new Size(131, 15);
            durabilidade.TabIndex = 4;
            durabilidade.Text = "durabilidade:";
            // 
            // velocidade
            // 
            velocidade.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            velocidade.AutoSize = true;
            velocidade.Location = new Point(4, 137);
            velocidade.Name = "velocidade";
            velocidade.Size = new Size(131, 15);
            velocidade.TabIndex = 3;
            velocidade.Text = "velocidade:";
            // 
            // força
            // 
            força.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            força.AutoSize = true;
            força.Location = new Point(4, 105);
            força.Name = "força";
            força.Size = new Size(131, 15);
            força.TabIndex = 2;
            força.Text = "força:";
            // 
            // inteligencia
            // 
            inteligencia.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inteligencia.AutoSize = true;
            inteligencia.Location = new Point(4, 73);
            inteligencia.Name = "inteligencia";
            inteligencia.Size = new Size(131, 15);
            inteligencia.TabIndex = 1;
            inteligencia.Text = "inteligencia:";
            // 
            // exibirPublicado
            // 
            exibirPublicado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            exibirPublicado.AutoSize = true;
            exibirPublicado.Location = new Point(142, 325);
            exibirPublicado.Name = "exibirPublicado";
            exibirPublicado.Size = new Size(132, 15);
            exibirPublicado.TabIndex = 21;
            exibirPublicado.Text = "vazio";
            // 
            // exibirPeso
            // 
            exibirPeso.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            exibirPeso.AutoSize = true;
            exibirPeso.Location = new Point(142, 297);
            exibirPeso.Name = "exibirPeso";
            exibirPeso.Size = new Size(132, 15);
            exibirPeso.TabIndex = 19;
            exibirPeso.Text = "vazio";
            // 
            // exibirSexo
            // 
            exibirSexo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            exibirSexo.AutoSize = true;
            exibirSexo.Location = new Point(142, 265);
            exibirSexo.Name = "exibirSexo";
            exibirSexo.Size = new Size(132, 15);
            exibirSexo.TabIndex = 18;
            exibirSexo.Text = "vazio";
            // 
            // exibirCombate
            // 
            exibirCombate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            exibirCombate.AutoSize = true;
            exibirCombate.Location = new Point(142, 233);
            exibirCombate.Name = "exibirCombate";
            exibirCombate.Size = new Size(132, 15);
            exibirCombate.TabIndex = 17;
            exibirCombate.Text = "vazio";
            // 
            // exibirPoder
            // 
            exibirPoder.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            exibirPoder.AutoSize = true;
            exibirPoder.Location = new Point(142, 201);
            exibirPoder.Name = "exibirPoder";
            exibirPoder.Size = new Size(132, 15);
            exibirPoder.TabIndex = 16;
            exibirPoder.Text = "vazio";
            // 
            // exibirDurabilidade
            // 
            exibirDurabilidade.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            exibirDurabilidade.AutoSize = true;
            exibirDurabilidade.Location = new Point(142, 169);
            exibirDurabilidade.Name = "exibirDurabilidade";
            exibirDurabilidade.Size = new Size(132, 15);
            exibirDurabilidade.TabIndex = 15;
            exibirDurabilidade.Text = "vazio";
            // 
            // exibirVelocidade
            // 
            exibirVelocidade.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            exibirVelocidade.AutoSize = true;
            exibirVelocidade.Location = new Point(142, 137);
            exibirVelocidade.Name = "exibirVelocidade";
            exibirVelocidade.Size = new Size(132, 15);
            exibirVelocidade.TabIndex = 14;
            exibirVelocidade.Text = "vazio";
            // 
            // exibirForca
            // 
            exibirForca.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            exibirForca.AutoSize = true;
            exibirForca.Location = new Point(142, 105);
            exibirForca.Name = "exibirForca";
            exibirForca.Size = new Size(132, 15);
            exibirForca.TabIndex = 13;
            exibirForca.Text = "vazio";
            // 
            // exibirInteligencia
            // 
            exibirInteligencia.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            exibirInteligencia.AutoSize = true;
            exibirInteligencia.Location = new Point(142, 73);
            exibirInteligencia.Name = "exibirInteligencia";
            exibirInteligencia.Size = new Size(132, 15);
            exibirInteligencia.TabIndex = 12;
            exibirInteligencia.Text = "vazio";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.White;
            flowLayoutPanel2.Controls.Add(exibirImagem);
            flowLayoutPanel2.Controls.Add(flowLayoutPanel1);
            flowLayoutPanel2.Location = new Point(12, 12);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(634, 433);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(666, 459);
            Controls.Add(flowLayoutPanel2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)exibirImagem).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox exibirImagem;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label publicado;
        private Label peso;
        private Label sexo;
        private Label combate;
        private Label poder;
        private Label durabilidade;
        private Label nome;
        private Label inteligencia;
        private Label força;
        private Label velocidade;
        private Label exibirPeso;
        private Label exibirSexo;
        private Label exibirCombate;
        private Label exibirPoder;
        private Label exibirDurabilidade;
        private Label exibirVelocidade;
        private Label exibirForca;
        private Label exibirInteligencia;
        private Label exibirNome;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label exibirPublicado;
        private Label exibirNomeCompleto;
        private Label NomeCompleto;
    }
}