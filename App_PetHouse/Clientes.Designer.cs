namespace App_PetHouse
{
    partial class Clientes
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
            DGVclientes = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label8 = new Label();
            label13 = new Label();
            label14 = new Label();
            TBid = new TextBox();
            BTbuscar = new Button();
            TBnome = new TextBox();
            TBsobrenome = new TextBox();
            TBcpf = new TextBox();
            MTBdataNascimento = new MaskedTextBox();
            TBgenero = new TextBox();
            TBemail = new TextBox();
            TBendereco = new TextBox();
            TBnumero = new TextBox();
            TBbairro = new TextBox();
            TBcidade = new TextBox();
            TBuf = new TextBox();
            BTcadastrar = new Button();
            BTatualizar = new Button();
            BTexcluir = new Button();
            TBcep = new TextBox();
            label15 = new Label();
            MTBtelefoneCelular = new MaskedTextBox();
            MTBtelefoneFixo = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)DGVclientes).BeginInit();
            SuspendLayout();
            // 
            // DGVclientes
            // 
            DGVclientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVclientes.Location = new Point(12, 288);
            DGVclientes.Name = "DGVclientes";
            DGVclientes.RowTemplate.Height = 25;
            DGVclientes.Size = new Size(861, 244);
            DGVclientes.TabIndex = 0;
            DGVclientes.CellClick += DGVclientes_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 1;
            label1.Text = "ID do cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 73);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 1;
            label3.Text = "Sobrenome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(264, 73);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 1;
            label4.Text = "CPF:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(417, 73);
            label5.Name = "label5";
            label5.Size = new Size(115, 15);
            label5.TabIndex = 1;
            label5.Text = "Data de nascimento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(555, 73);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 1;
            label6.Text = "Gênero:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 132);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 1;
            label7.Text = "Email:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(156, 132);
            label9.Name = "label9";
            label9.Size = new Size(95, 15);
            label9.TabIndex = 1;
            label9.Text = "Telefone celular::";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(279, 132);
            label10.Name = "label10";
            label10.Size = new Size(79, 15);
            label10.TabIndex = 1;
            label10.Text = "Telefone Fixo:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(156, 196);
            label11.Name = "label11";
            label11.Size = new Size(59, 15);
            label11.TabIndex = 1;
            label11.Text = "Endereço:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(291, 196);
            label12.Name = "label12";
            label12.Size = new Size(54, 15);
            label12.TabIndex = 1;
            label12.Text = "Numero:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(371, 196);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 1;
            label8.Text = "Bairro:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(509, 196);
            label13.Name = "label13";
            label13.Size = new Size(47, 15);
            label13.TabIndex = 1;
            label13.Text = "Cidade:";
            label13.Click += label13_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(620, 196);
            label14.Name = "label14";
            label14.Size = new Size(24, 15);
            label14.TabIndex = 1;
            label14.Text = "UF:";
            label14.Click += label13_Click;
            // 
            // TBid
            // 
            TBid.Location = new Point(12, 27);
            TBid.Name = "TBid";
            TBid.Size = new Size(43, 23);
            TBid.TabIndex = 2;
            // 
            // BTbuscar
            // 
            BTbuscar.Location = new Point(65, 27);
            BTbuscar.Name = "BTbuscar";
            BTbuscar.Size = new Size(61, 23);
            BTbuscar.TabIndex = 3;
            BTbuscar.Text = "Buscar";
            BTbuscar.UseVisualStyleBackColor = true;
            BTbuscar.Click += BTbuscar_Click;
            // 
            // TBnome
            // 
            TBnome.Location = new Point(12, 91);
            TBnome.Name = "TBnome";
            TBnome.Size = new Size(93, 23);
            TBnome.TabIndex = 2;
            // 
            // TBsobrenome
            // 
            TBsobrenome.Location = new Point(121, 91);
            TBsobrenome.Name = "TBsobrenome";
            TBsobrenome.Size = new Size(107, 23);
            TBsobrenome.TabIndex = 2;
            // 
            // TBcpf
            // 
            TBcpf.Location = new Point(264, 91);
            TBcpf.Name = "TBcpf";
            TBcpf.Size = new Size(131, 23);
            TBcpf.TabIndex = 2;
            // 
            // MTBdataNascimento
            // 
            MTBdataNascimento.Location = new Point(417, 91);
            MTBdataNascimento.Mask = "0000/00/00";
            MTBdataNascimento.Name = "MTBdataNascimento";
            MTBdataNascimento.Size = new Size(92, 23);
            MTBdataNascimento.TabIndex = 4;
            MTBdataNascimento.ValidatingType = typeof(DateTime);
            // 
            // TBgenero
            // 
            TBgenero.Location = new Point(555, 91);
            TBgenero.Name = "TBgenero";
            TBgenero.Size = new Size(98, 23);
            TBgenero.TabIndex = 2;
            // 
            // TBemail
            // 
            TBemail.Location = new Point(12, 150);
            TBemail.Name = "TBemail";
            TBemail.Size = new Size(114, 23);
            TBemail.TabIndex = 2;
            // 
            // TBendereco
            // 
            TBendereco.Location = new Point(156, 214);
            TBendereco.Name = "TBendereco";
            TBendereco.Size = new Size(123, 23);
            TBendereco.TabIndex = 2;
            // 
            // TBnumero
            // 
            TBnumero.Location = new Point(291, 214);
            TBnumero.Name = "TBnumero";
            TBnumero.Size = new Size(54, 23);
            TBnumero.TabIndex = 2;
            // 
            // TBbairro
            // 
            TBbairro.Location = new Point(371, 214);
            TBbairro.Name = "TBbairro";
            TBbairro.Size = new Size(117, 23);
            TBbairro.TabIndex = 2;
            // 
            // TBcidade
            // 
            TBcidade.Location = new Point(509, 214);
            TBcidade.Name = "TBcidade";
            TBcidade.Size = new Size(83, 23);
            TBcidade.TabIndex = 2;
            // 
            // TBuf
            // 
            TBuf.Location = new Point(620, 214);
            TBuf.Name = "TBuf";
            TBuf.Size = new Size(33, 23);
            TBuf.TabIndex = 2;
            // 
            // BTcadastrar
            // 
            BTcadastrar.Location = new Point(27, 252);
            BTcadastrar.Name = "BTcadastrar";
            BTcadastrar.Size = new Size(78, 30);
            BTcadastrar.TabIndex = 3;
            BTcadastrar.Text = "Cadastrar";
            BTcadastrar.UseVisualStyleBackColor = true;
            BTcadastrar.Click += BTcadastrar_Click;
            // 
            // BTatualizar
            // 
            BTatualizar.Location = new Point(114, 252);
            BTatualizar.Name = "BTatualizar";
            BTatualizar.Size = new Size(78, 30);
            BTatualizar.TabIndex = 3;
            BTatualizar.Text = "Atualizar";
            BTatualizar.UseVisualStyleBackColor = true;
            BTatualizar.Click += BTatualizar_Click;
            // 
            // BTexcluir
            // 
            BTexcluir.Location = new Point(198, 252);
            BTexcluir.Name = "BTexcluir";
            BTexcluir.Size = new Size(70, 30);
            BTexcluir.TabIndex = 3;
            BTexcluir.Text = "Excluir";
            BTexcluir.UseVisualStyleBackColor = true;
            BTexcluir.Click += BTexcluir_Click;
            // 
            // TBcep
            // 
            TBcep.Location = new Point(12, 214);
            TBcep.Name = "TBcep";
            TBcep.Size = new Size(114, 23);
            TBcep.TabIndex = 5;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(12, 196);
            label15.Name = "label15";
            label15.Size = new Size(31, 15);
            label15.TabIndex = 1;
            label15.Text = "CEP:";
            // 
            // MTBtelefoneCelular
            // 
            MTBtelefoneCelular.Location = new Point(156, 150);
            MTBtelefoneCelular.Mask = "(00)00000-0000";
            MTBtelefoneCelular.Name = "MTBtelefoneCelular";
            MTBtelefoneCelular.Size = new Size(100, 23);
            MTBtelefoneCelular.TabIndex = 6;
            // 
            // MTBtelefoneFixo
            // 
            MTBtelefoneFixo.Location = new Point(279, 150);
            MTBtelefoneFixo.Mask = "(00)0000-0000";
            MTBtelefoneFixo.Name = "MTBtelefoneFixo";
            MTBtelefoneFixo.Size = new Size(100, 23);
            MTBtelefoneFixo.TabIndex = 6;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 544);
            Controls.Add(MTBtelefoneFixo);
            Controls.Add(MTBtelefoneCelular);
            Controls.Add(TBcep);
            Controls.Add(MTBdataNascimento);
            Controls.Add(BTexcluir);
            Controls.Add(BTatualizar);
            Controls.Add(BTcadastrar);
            Controls.Add(BTbuscar);
            Controls.Add(TBgenero);
            Controls.Add(TBcpf);
            Controls.Add(TBsobrenome);
            Controls.Add(TBuf);
            Controls.Add(TBcidade);
            Controls.Add(TBbairro);
            Controls.Add(TBnumero);
            Controls.Add(TBendereco);
            Controls.Add(TBemail);
            Controls.Add(TBnome);
            Controls.Add(TBid);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label8);
            Controls.Add(label12);
            Controls.Add(label15);
            Controls.Add(label11);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DGVclientes);
            Name = "Clientes";
            Text = "Clientes";
            Load += Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)DGVclientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGVclientes;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label8;
        private Label label13;
        private Label label14;
        private TextBox TBid;
        private Button BTbuscar;
        private TextBox TBnome;
        private TextBox TBsobrenome;
        private TextBox TBcpf;
        private MaskedTextBox MTBdataNascimento;
        private TextBox TBgenero;
        private TextBox TBemail;
        private TextBox TBendereco;
        private TextBox TBnumero;
        private TextBox TBbairro;
        private TextBox TBcidade;
        private TextBox TBuf;
        private Button BTcadastrar;
        private Button BTatualizar;
        private Button BTexcluir;
        private TextBox TBcep;
        private Label label15;
        private MaskedTextBox MTBtelefoneCelular;
        private MaskedTextBox MTBtelefoneFixo;
    }
}