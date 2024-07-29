namespace App_PetHouse
{
    partial class Estoque
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
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            TBidEstoque = new TextBox();
            TBnomeProdu = new TextBox();
            TBpreco = new TextBox();
            TBqtdEstoque = new TextBox();
            TBnota = new TextBox();
            RTBdescricaoProduto = new RichTextBox();
            BTcadastrar = new Button();
            BTatualizar = new Button();
            BTexcluir = new Button();
            BTbuscar = new Button();
            TBdata = new TextBox();
            BTinserirfoto = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(872, 171);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonShadow;
            pictureBox1.Location = new Point(580, 204);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 220);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 257);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome do produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 257);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Preço:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(388, 257);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Em estoque:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(638, 186);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 2;
            label4.Text = "Imagem produto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 326);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 2;
            label5.Text = "Nota:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(157, 326);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 2;
            label6.Text = "Data de cadastro:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 204);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 2;
            label7.Text = "ID do produto:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 376);
            label8.Name = "label8";
            label8.Size = new Size(124, 15);
            label8.TabIndex = 2;
            label8.Text = "Descrição do produto:";
            // 
            // TBidEstoque
            // 
            TBidEstoque.Location = new Point(12, 222);
            TBidEstoque.Name = "TBidEstoque";
            TBidEstoque.Size = new Size(57, 23);
            TBidEstoque.TabIndex = 3;
            // 
            // TBnomeProdu
            // 
            TBnomeProdu.Location = new Point(12, 275);
            TBnomeProdu.Name = "TBnomeProdu";
            TBnomeProdu.Size = new Size(141, 23);
            TBnomeProdu.TabIndex = 3;
            // 
            // TBpreco
            // 
            TBpreco.Location = new Point(202, 275);
            TBpreco.Name = "TBpreco";
            TBpreco.Size = new Size(103, 23);
            TBpreco.TabIndex = 3;
            // 
            // TBqtdEstoque
            // 
            TBqtdEstoque.Location = new Point(388, 275);
            TBqtdEstoque.Name = "TBqtdEstoque";
            TBqtdEstoque.Size = new Size(103, 23);
            TBqtdEstoque.TabIndex = 3;
            // 
            // TBnota
            // 
            TBnota.Location = new Point(12, 344);
            TBnota.Name = "TBnota";
            TBnota.Size = new Size(103, 23);
            TBnota.TabIndex = 3;
            // 
            // RTBdescricaoProduto
            // 
            RTBdescricaoProduto.Location = new Point(12, 394);
            RTBdescricaoProduto.Name = "RTBdescricaoProduto";
            RTBdescricaoProduto.Size = new Size(470, 96);
            RTBdescricaoProduto.TabIndex = 6;
            RTBdescricaoProduto.Text = "";
            // 
            // BTcadastrar
            // 
            BTcadastrar.Location = new Point(12, 496);
            BTcadastrar.Name = "BTcadastrar";
            BTcadastrar.Size = new Size(94, 36);
            BTcadastrar.TabIndex = 4;
            BTcadastrar.Text = "Cadastrar";
            BTcadastrar.UseVisualStyleBackColor = true;
            BTcadastrar.Click += BTcadastrar_Click;
            // 
            // BTatualizar
            // 
            BTatualizar.Location = new Point(112, 496);
            BTatualizar.Name = "BTatualizar";
            BTatualizar.Size = new Size(94, 36);
            BTatualizar.TabIndex = 4;
            BTatualizar.Text = "Atualizar";
            BTatualizar.UseVisualStyleBackColor = true;
            BTatualizar.Click += BTatualizar_Click;
            // 
            // BTexcluir
            // 
            BTexcluir.Location = new Point(212, 496);
            BTexcluir.Name = "BTexcluir";
            BTexcluir.Size = new Size(94, 36);
            BTexcluir.TabIndex = 4;
            BTexcluir.Text = "Excluir";
            BTexcluir.UseVisualStyleBackColor = true;
            BTexcluir.Click += BTexcluir_Click;
            // 
            // BTbuscar
            // 
            BTbuscar.Location = new Point(75, 221);
            BTbuscar.Name = "BTbuscar";
            BTbuscar.Size = new Size(75, 23);
            BTbuscar.TabIndex = 7;
            BTbuscar.Text = "Buscar";
            BTbuscar.UseVisualStyleBackColor = true;
            BTbuscar.Click += BTbuscar_Click;
            // 
            // TBdata
            // 
            TBdata.Location = new Point(157, 344);
            TBdata.Name = "TBdata";
            TBdata.Size = new Size(103, 23);
            TBdata.TabIndex = 3;
            // 
            // BTinserirfoto
            // 
            BTinserirfoto.Location = new Point(638, 430);
            BTinserirfoto.Name = "BTinserirfoto";
            BTinserirfoto.Size = new Size(86, 35);
            BTinserirfoto.TabIndex = 8;
            BTinserirfoto.Text = "Inserir";
            BTinserirfoto.UseVisualStyleBackColor = true;
            BTinserirfoto.Click += BTinserirfoto_Click;
            // 
            // Estoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 547);
            Controls.Add(BTinserirfoto);
            Controls.Add(BTbuscar);
            Controls.Add(RTBdescricaoProduto);
            Controls.Add(BTexcluir);
            Controls.Add(BTatualizar);
            Controls.Add(BTcadastrar);
            Controls.Add(TBqtdEstoque);
            Controls.Add(TBnota);
            Controls.Add(TBdata);
            Controls.Add(TBpreco);
            Controls.Add(TBnomeProdu);
            Controls.Add(TBidEstoque);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Name = "Estoque";
            Text = "Estoque";
            Load += Estoque_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox TBidEstoque;
        private TextBox TBnomeProdu;
        private TextBox TBpreco;
        private TextBox TBqtdEstoque;
        private TextBox TBnota;
        private RichTextBox RTBdescricaoProduto;
        private Button BTcadastrar;
        private Button BTatualizar;
        private Button BTexcluir;
        private Button BTbuscar;
        private TextBox TBdata;
        private Button BTinserirfoto;
    }
}