namespace App_PetHouse
{
    partial class Animais
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
            DGVgeral = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            BTbuscar = new Button();
            TBraca = new TextBox();
            MTBdataNascimento = new MaskedTextBox();
            TBaltura = new TextBox();
            TBpeso = new TextBox();
            TBcomprimento = new TextBox();
            BTcadastrar = new Button();
            BTexcluir = new Button();
            BTregistroMedico = new Button();
            label9 = new Label();
            TBid = new TextBox();
            label10 = new Label();
            CBespecie = new ComboBox();
            TBnomeAnimal = new TextBox();
            label1 = new Label();
            label11 = new Label();
            TXTnome = new Label();
            TXTsobrenome = new Label();
            BTatualizar = new Button();
            DGvinculo = new DataGridView();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            TBidVinculo = new TextBox();
            TBidCliente = new TextBox();
            TBidAnimal = new TextBox();
            TBidRegistro = new TextBox();
            BTbuscarV = new Button();
            BTcadastrarV = new Button();
            BTexcluirV = new Button();
            BTatualizarV = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVgeral).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGvinculo).BeginInit();
            SuspendLayout();
            // 
            // DGVgeral
            // 
            DGVgeral.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVgeral.Location = new Point(18, 273);
            DGVgeral.Name = "DGVgeral";
            DGVgeral.RowTemplate.Height = 25;
            DGVgeral.Size = new Size(776, 196);
            DGVgeral.TabIndex = 0;
            DGVgeral.CellClick += DGVgeral_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 53);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome do animal:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 52);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 1;
            label3.Text = "Especie:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(254, 57);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 1;
            label4.Text = "Raça:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(360, 52);
            label5.Name = "label5";
            label5.Size = new Size(115, 15);
            label5.TabIndex = 1;
            label5.Text = "Data de nascimento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 115);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 1;
            label6.Text = "Altura(cm):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(139, 115);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 1;
            label7.Text = "Peso(kg):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(273, 115);
            label8.Name = "label8";
            label8.Size = new Size(110, 15);
            label8.TabIndex = 1;
            label8.Text = "Comprimento(cm):";
            // 
            // BTbuscar
            // 
            BTbuscar.Location = new Point(94, 30);
            BTbuscar.Name = "BTbuscar";
            BTbuscar.Size = new Size(60, 23);
            BTbuscar.TabIndex = 3;
            BTbuscar.Text = "Buscar";
            BTbuscar.UseVisualStyleBackColor = true;
            BTbuscar.Click += BTbuscar_Click;
            // 
            // TBraca
            // 
            TBraca.Location = new Point(245, 71);
            TBraca.Name = "TBraca";
            TBraca.Size = new Size(93, 23);
            TBraca.TabIndex = 2;
            // 
            // MTBdataNascimento
            // 
            MTBdataNascimento.Location = new Point(360, 71);
            MTBdataNascimento.Mask = "0000/00/00";
            MTBdataNascimento.Name = "MTBdataNascimento";
            MTBdataNascimento.Size = new Size(100, 23);
            MTBdataNascimento.TabIndex = 4;
            MTBdataNascimento.ValidatingType = typeof(DateTime);
            // 
            // TBaltura
            // 
            TBaltura.Location = new Point(12, 133);
            TBaltura.Name = "TBaltura";
            TBaltura.Size = new Size(99, 23);
            TBaltura.TabIndex = 2;
            TBaltura.TextChanged += TBaltura_TextChanged;
            // 
            // TBpeso
            // 
            TBpeso.Location = new Point(139, 133);
            TBpeso.Name = "TBpeso";
            TBpeso.Size = new Size(99, 23);
            TBpeso.TabIndex = 2;
            TBpeso.TextChanged += TBaltura_TextChanged;
            // 
            // TBcomprimento
            // 
            TBcomprimento.Location = new Point(273, 133);
            TBcomprimento.Name = "TBcomprimento";
            TBcomprimento.Size = new Size(99, 23);
            TBcomprimento.TabIndex = 2;
            TBcomprimento.TextChanged += TBaltura_TextChanged;
            // 
            // BTcadastrar
            // 
            BTcadastrar.Location = new Point(12, 184);
            BTcadastrar.Name = "BTcadastrar";
            BTcadastrar.Size = new Size(74, 33);
            BTcadastrar.TabIndex = 3;
            BTcadastrar.Text = "Cadastrar";
            BTcadastrar.UseVisualStyleBackColor = true;
            BTcadastrar.Click += BTcadastrar_Click;
            // 
            // BTexcluir
            // 
            BTexcluir.Location = new Point(172, 184);
            BTexcluir.Name = "BTexcluir";
            BTexcluir.Size = new Size(74, 33);
            BTexcluir.TabIndex = 3;
            BTexcluir.Text = "Excluir";
            BTexcluir.UseVisualStyleBackColor = true;
            BTexcluir.Click += BTexcluir_Click;
            // 
            // BTregistroMedico
            // 
            BTregistroMedico.Location = new Point(273, 173);
            BTregistroMedico.Name = "BTregistroMedico";
            BTregistroMedico.Size = new Size(183, 44);
            BTregistroMedico.TabIndex = 3;
            BTregistroMedico.Text = "Registro médico do animal";
            BTregistroMedico.UseVisualStyleBackColor = true;
            BTregistroMedico.Click += BTregistroMedico_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 53);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 5;
            // 
            // TBid
            // 
            TBid.Location = new Point(12, 27);
            TBid.Name = "TBid";
            TBid.Size = new Size(76, 23);
            TBid.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 9);
            label10.Name = "label10";
            label10.Size = new Size(76, 15);
            label10.TabIndex = 1;
            label10.Text = "Id do animal:";
            // 
            // CBespecie
            // 
            CBespecie.FormattingEnabled = true;
            CBespecie.Items.AddRange(new object[] { "Cachorro", "Gato", "Passáro", "Peixe", "Roedor", "Reptil", "Anfibio" });
            CBespecie.Location = new Point(140, 71);
            CBespecie.Name = "CBespecie";
            CBespecie.Size = new Size(98, 23);
            CBespecie.TabIndex = 6;
            // 
            // TBnomeAnimal
            // 
            TBnomeAnimal.Location = new Point(18, 71);
            TBnomeAnimal.Name = "TBnomeAnimal";
            TBnomeAnimal.Size = new Size(116, 23);
            TBnomeAnimal.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 9);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 7;
            label1.Text = "Nome do dono:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(342, 9);
            label11.Name = "label11";
            label11.Size = new Size(119, 15);
            label11.TabIndex = 7;
            label11.Text = "Sobrenome do dono:";
            // 
            // TXTnome
            // 
            TXTnome.AutoSize = true;
            TXTnome.Location = new Point(254, 34);
            TXTnome.Name = "TXTnome";
            TXTnome.Size = new Size(0, 15);
            TXTnome.TabIndex = 7;
            // 
            // TXTsobrenome
            // 
            TXTsobrenome.AutoSize = true;
            TXTsobrenome.Location = new Point(360, 30);
            TXTsobrenome.Name = "TXTsobrenome";
            TXTsobrenome.Size = new Size(0, 15);
            TXTsobrenome.TabIndex = 7;
            // 
            // BTatualizar
            // 
            BTatualizar.Location = new Point(92, 184);
            BTatualizar.Name = "BTatualizar";
            BTatualizar.Size = new Size(74, 33);
            BTatualizar.TabIndex = 3;
            BTatualizar.Text = "Atualizar";
            BTatualizar.UseVisualStyleBackColor = true;
            BTatualizar.Click += BTatualizar_Click;
            // 
            // DGvinculo
            // 
            DGvinculo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGvinculo.Location = new Point(810, 273);
            DGvinculo.Name = "DGvinculo";
            DGvinculo.RowTemplate.Height = 25;
            DGvinculo.Size = new Size(315, 196);
            DGvinculo.TabIndex = 8;
            DGvinculo.CellClick += DGvinculo_CellClick_1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(284, 240);
            label12.Name = "label12";
            label12.Size = new Size(191, 30);
            label12.TabIndex = 9;
            label12.Text = "Informações Gerais";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(933, 240);
            label13.Name = "label13";
            label13.Size = new Size(82, 30);
            label13.TabIndex = 9;
            label13.Text = "Vinculo";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(810, 9);
            label14.Name = "label14";
            label14.RightToLeft = RightToLeft.No;
            label14.Size = new Size(76, 15);
            label14.TabIndex = 1;
            label14.Text = "Id do vinculo";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(810, 53);
            label15.Name = "label15";
            label15.RightToLeft = RightToLeft.No;
            label15.Size = new Size(75, 15);
            label15.TabIndex = 1;
            label15.Text = "Id do cliente:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(810, 97);
            label16.Name = "label16";
            label16.RightToLeft = RightToLeft.No;
            label16.Size = new Size(78, 15);
            label16.TabIndex = 1;
            label16.Text = "Id do Animal:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(810, 142);
            label17.Name = "label17";
            label17.RightToLeft = RightToLeft.No;
            label17.Size = new Size(123, 15);
            label17.TabIndex = 1;
            label17.Text = "Id do registro médico:";
            // 
            // TBidVinculo
            // 
            TBidVinculo.Location = new Point(812, 27);
            TBidVinculo.Name = "TBidVinculo";
            TBidVinculo.Size = new Size(156, 23);
            TBidVinculo.TabIndex = 2;
            // 
            // TBidCliente
            // 
            TBidCliente.Location = new Point(809, 71);
            TBidCliente.Name = "TBidCliente";
            TBidCliente.Size = new Size(159, 23);
            TBidCliente.TabIndex = 2;
            // 
            // TBidAnimal
            // 
            TBidAnimal.Location = new Point(810, 115);
            TBidAnimal.Name = "TBidAnimal";
            TBidAnimal.Size = new Size(158, 23);
            TBidAnimal.TabIndex = 2;
            // 
            // TBidRegistro
            // 
            TBidRegistro.Location = new Point(812, 160);
            TBidRegistro.Name = "TBidRegistro";
            TBidRegistro.Size = new Size(156, 23);
            TBidRegistro.TabIndex = 2;
            // 
            // BTbuscarV
            // 
            BTbuscarV.Location = new Point(1031, 27);
            BTbuscarV.Name = "BTbuscarV";
            BTbuscarV.Size = new Size(75, 23);
            BTbuscarV.TabIndex = 10;
            BTbuscarV.Text = "Buscar";
            BTbuscarV.UseVisualStyleBackColor = true;
            BTbuscarV.Click += BTbuscarV_Click;
            // 
            // BTcadastrarV
            // 
            BTcadastrarV.Location = new Point(1031, 70);
            BTcadastrarV.Name = "BTcadastrarV";
            BTcadastrarV.Size = new Size(75, 23);
            BTcadastrarV.TabIndex = 10;
            BTcadastrarV.Text = "Cadastrar";
            BTcadastrarV.UseVisualStyleBackColor = true;
            BTcadastrarV.Click += BTcadastrarV_Click;
            // 
            // BTexcluirV
            // 
            BTexcluirV.Location = new Point(1031, 159);
            BTexcluirV.Name = "BTexcluirV";
            BTexcluirV.Size = new Size(75, 23);
            BTexcluirV.TabIndex = 10;
            BTexcluirV.Text = "Excluir";
            BTexcluirV.UseVisualStyleBackColor = true;
            BTexcluirV.Click += BTexcluirV_Click;
            // 
            // BTatualizarV
            // 
            BTatualizarV.Location = new Point(1031, 115);
            BTatualizarV.Name = "BTatualizarV";
            BTatualizarV.Size = new Size(75, 23);
            BTatualizarV.TabIndex = 10;
            BTatualizarV.Text = "Atualizar";
            BTatualizarV.UseVisualStyleBackColor = true;
            BTatualizarV.Click += BTatualizarV_Click;
            // 
            // Animais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 631);
            Controls.Add(BTatualizarV);
            Controls.Add(BTexcluirV);
            Controls.Add(BTcadastrarV);
            Controls.Add(BTbuscarV);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(DGvinculo);
            Controls.Add(TXTsobrenome);
            Controls.Add(label11);
            Controls.Add(TXTnome);
            Controls.Add(label1);
            Controls.Add(CBespecie);
            Controls.Add(label9);
            Controls.Add(MTBdataNascimento);
            Controls.Add(BTregistroMedico);
            Controls.Add(BTexcluir);
            Controls.Add(BTatualizar);
            Controls.Add(BTcadastrar);
            Controls.Add(BTbuscar);
            Controls.Add(TBraca);
            Controls.Add(TBcomprimento);
            Controls.Add(TBpeso);
            Controls.Add(TBaltura);
            Controls.Add(TBidRegistro);
            Controls.Add(TBidAnimal);
            Controls.Add(TBidCliente);
            Controls.Add(TBidVinculo);
            Controls.Add(TBid);
            Controls.Add(TBnomeAnimal);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label10);
            Controls.Add(label2);
            Controls.Add(DGVgeral);
            Name = "Animais";
            Text = "Animais";
            Load += Animais_Load;
            ((System.ComponentModel.ISupportInitialize)DGVgeral).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGvinculo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGVgeral;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button BTbuscar;
        private TextBox TBraca;
        private MaskedTextBox MTBdataNascimento;
        private TextBox TBaltura;
        private TextBox TBpeso;
        private TextBox TBcomprimento;
        private Button BTcadastrar;
        private Button BTexcluir;
        private Button BTregistroMedico;
        private Label label9;
        private TextBox TBid;
        private Label label10;
        private ComboBox CBespecie;
        private TextBox TBnomeAnimal;
        private Label label1;
        private Label label11;
        private Label TXTnome;
        private Label TXTsobrenome;
        private Button BTatualizar;
        private DataGridView DGvinculo;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox TBidVinculo;
        private TextBox TBidCliente;
        private TextBox TBidAnimal;
        private TextBox TBidRegistro;
        private Button BTbuscarV;
        private Button BTcadastrarV;
        private Button BTexcluirV;
        private Button BTatualizarV;
    }
}