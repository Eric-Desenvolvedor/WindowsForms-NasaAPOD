namespace Herois
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listPersonagens = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            areaPesquisa = new TextBox();
            Pesquisar = new Button();
            label = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            selecionado = new Label();
            imagem = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            nomePersonagem = new Label();
            label2 = new Label();
            label1 = new Label();
            personagemSelecionado = new Label();
            ((System.ComponentModel.ISupportInitialize)listPersonagens).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagem).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // listPersonagens
            // 
            listPersonagens.AllowUserToAddRows = false;
            listPersonagens.AllowUserToResizeColumns = false;
            listPersonagens.AllowUserToResizeRows = false;
            listPersonagens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listPersonagens.Location = new Point(234, 15);
            listPersonagens.MultiSelect = false;
            listPersonagens.Name = "listPersonagens";
            listPersonagens.ReadOnly = true;
            listPersonagens.Size = new Size(429, 426);
            listPersonagens.TabIndex = 0;
            listPersonagens.CellClick += listPersonagens_CellClick;
            listPersonagens.CellDoubleClick += listPersonagens_CellDoubleClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.9767456F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.0232544F));
            tableLayoutPanel1.Controls.Add(areaPesquisa, 0, 0);
            tableLayoutPanel1.Controls.Add(Pesquisar, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(215, 33);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // areaPesquisa
            // 
            areaPesquisa.Location = new Point(3, 3);
            areaPesquisa.Name = "areaPesquisa";
            areaPesquisa.Size = new Size(138, 23);
            areaPesquisa.TabIndex = 0;
            // 
            // Pesquisar
            // 
            Pesquisar.BackgroundImageLayout = ImageLayout.Zoom;
            Pesquisar.Location = new Point(147, 3);
            Pesquisar.Name = "Pesquisar";
            Pesquisar.Size = new Size(65, 27);
            Pesquisar.TabIndex = 1;
            Pesquisar.Text = "Pesquisar";
            Pesquisar.UseVisualStyleBackColor = false;
            Pesquisar.Click += Pesquisar_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(3, 0);
            label.Name = "label";
            label.Size = new Size(59, 15);
            label.TabIndex = 2;
            label.Text = "Pesquisa: ";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.16279F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.83721F));
            tableLayoutPanel2.Controls.Add(label, 0, 0);
            tableLayoutPanel2.Controls.Add(selecionado, 1, 0);
            tableLayoutPanel2.Location = new Point(12, 48);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(215, 27);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // selecionado
            // 
            selecionado.AutoSize = true;
            selecionado.Location = new Point(70, 0);
            selecionado.Name = "selecionado";
            selecionado.Size = new Size(109, 15);
            selecionado.TabIndex = 3;
            selecionado.Text = "Nenhuma Pesquisa";
            // 
            // imagem
            // 
            imagem.BackgroundImage = Properties.Resources.iconePesquisa;
            imagem.BackgroundImageLayout = ImageLayout.Zoom;
            imagem.BorderStyle = BorderStyle.FixedSingle;
            imagem.Location = new Point(12, 90);
            imagem.Name = "imagem";
            imagem.Size = new Size(212, 269);
            imagem.TabIndex = 3;
            imagem.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.679245F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.320755F));
            tableLayoutPanel3.Controls.Add(nomePersonagem, 1, 1);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(personagemSelecionado, 1, 0);
            tableLayoutPanel3.Location = new Point(12, 374);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(212, 45);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // nomePersonagem
            // 
            nomePersonagem.AutoSize = true;
            nomePersonagem.Location = new Point(85, 22);
            nomePersonagem.Name = "nomePersonagem";
            nomePersonagem.Size = new Size(64, 15);
            nomePersonagem.TabIndex = 5;
            nomePersonagem.Text = "Sem nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 22);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 4;
            label2.Text = "Nome: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 2;
            label1.Text = "Personagem: ";
            // 
            // personagemSelecionado
            // 
            personagemSelecionado.AutoSize = true;
            personagemSelecionado.Location = new Point(85, 0);
            personagemSelecionado.Name = "personagemSelecionado";
            personagemSelecionado.Size = new Size(123, 15);
            personagemSelecionado.TabIndex = 3;
            personagemSelecionado.Text = "Nenhum personagem";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 449);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(imagem);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(listPersonagens);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)listPersonagens).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagem).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView listPersonagens;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label;
        private TableLayoutPanel tableLayoutPanel2;
        private Label selecionado;
        private TextBox areaPesquisa;
        private Button Pesquisar;
        private PictureBox imagem;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private Label personagemSelecionado;
        private Label nomePersonagem;
        private Label label2;
    }
}
