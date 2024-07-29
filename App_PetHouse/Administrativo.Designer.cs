namespace App_PetHouse
{
    partial class Administrativo
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TBid = new TextBox();
            TBnome = new TextBox();
            TBsobrenome = new TextBox();
            TBusuario = new TextBox();
            TBsenha = new TextBox();
            CBgrau = new ComboBox();
            BTbuscar = new Button();
            DGVfuncionarios = new DataGridView();
            label7 = new Label();
            label8 = new Label();
            TBemail = new TextBox();
            BTcadastrar = new Button();
            BTexcluir = new Button();
            BTatualizar = new Button();
            MTBtelefone = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)DGVfuncionarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "ID do funcionario:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 0;
            label2.Text = "Nome:";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 50);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 0;
            label3.Text = "Sobrenome:";
            label3.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(286, 50);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 0;
            label4.Text = "Usuario:";
            label4.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(427, 50);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 0;
            label5.Text = "Senha:";
            label5.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(164, 112);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 0;
            label6.Text = "Grau:";
            label6.Click += label1_Click;
            // 
            // TBid
            // 
            TBid.Location = new Point(12, 27);
            TBid.Name = "TBid";
            TBid.Size = new Size(56, 23);
            TBid.TabIndex = 1;
            // 
            // TBnome
            // 
            TBnome.Location = new Point(12, 64);
            TBnome.Name = "TBnome";
            TBnome.Size = new Size(105, 23);
            TBnome.TabIndex = 1;
            // 
            // TBsobrenome
            // 
            TBsobrenome.Location = new Point(135, 64);
            TBsobrenome.Name = "TBsobrenome";
            TBsobrenome.Size = new Size(105, 23);
            TBsobrenome.TabIndex = 1;
            // 
            // TBusuario
            // 
            TBusuario.Location = new Point(286, 64);
            TBusuario.Name = "TBusuario";
            TBusuario.Size = new Size(105, 23);
            TBusuario.TabIndex = 1;
            // 
            // TBsenha
            // 
            TBsenha.Location = new Point(427, 64);
            TBsenha.Name = "TBsenha";
            TBsenha.Size = new Size(105, 23);
            TBsenha.TabIndex = 1;
            // 
            // CBgrau
            // 
            CBgrau.FormattingEnabled = true;
            CBgrau.Items.AddRange(new object[] { "1", "2", "3" });
            CBgrau.Location = new Point(162, 130);
            CBgrau.Name = "CBgrau";
            CBgrau.Size = new Size(121, 23);
            CBgrau.TabIndex = 2;
            // 
            // BTbuscar
            // 
            BTbuscar.Location = new Point(74, 27);
            BTbuscar.Name = "BTbuscar";
            BTbuscar.Size = new Size(68, 23);
            BTbuscar.TabIndex = 3;
            BTbuscar.Text = "Buscar";
            BTbuscar.UseVisualStyleBackColor = true;
            BTbuscar.Click += BTbuscar_Click;
            // 
            // DGVfuncionarios
            // 
            DGVfuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVfuncionarios.Location = new Point(12, 229);
            DGVfuncionarios.Name = "DGVfuncionarios";
            DGVfuncionarios.RowTemplate.Height = 25;
            DGVfuncionarios.Size = new Size(988, 294);
            DGVfuncionarios.TabIndex = 4;
            DGVfuncionarios.CellClick += DGVfuncionarios_CellClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(590, 50);
            label7.Name = "label7";
            label7.Size = new Size(109, 15);
            label7.TabIndex = 0;
            label7.Text = "Email para contato:";
            label7.Click += label1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 112);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 0;
            label8.Text = "Telefone";
            label8.Click += label1_Click;
            // 
            // TBemail
            // 
            TBemail.Location = new Point(590, 64);
            TBemail.Name = "TBemail";
            TBemail.Size = new Size(133, 23);
            TBemail.TabIndex = 1;
            // 
            // BTcadastrar
            // 
            BTcadastrar.Location = new Point(12, 176);
            BTcadastrar.Name = "BTcadastrar";
            BTcadastrar.Size = new Size(86, 34);
            BTcadastrar.TabIndex = 3;
            BTcadastrar.Text = "Cadastrar";
            BTcadastrar.UseVisualStyleBackColor = true;
            BTcadastrar.Click += BTcadastrar_Click;
            // 
            // BTexcluir
            // 
            BTexcluir.Location = new Point(196, 176);
            BTexcluir.Name = "BTexcluir";
            BTexcluir.Size = new Size(86, 34);
            BTexcluir.TabIndex = 3;
            BTexcluir.Text = "Excluir";
            BTexcluir.UseVisualStyleBackColor = true;
            BTexcluir.Click += BTexcluir_Click;
            // 
            // BTatualizar
            // 
            BTatualizar.Location = new Point(104, 176);
            BTatualizar.Name = "BTatualizar";
            BTatualizar.Size = new Size(86, 34);
            BTatualizar.TabIndex = 3;
            BTatualizar.Text = "Atualizar";
            BTatualizar.UseVisualStyleBackColor = true;
            BTatualizar.Click += BTatualizar_Click;
            // 
            // MTBtelefone
            // 
            MTBtelefone.Location = new Point(5, 130);
            MTBtelefone.Mask = "(00)00000-0000";
            MTBtelefone.Name = "MTBtelefone";
            MTBtelefone.Size = new Size(112, 23);
            MTBtelefone.TabIndex = 5;
            // 
            // Administrativo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 553);
            Controls.Add(MTBtelefone);
            Controls.Add(DGVfuncionarios);
            Controls.Add(BTatualizar);
            Controls.Add(BTexcluir);
            Controls.Add(BTcadastrar);
            Controls.Add(BTbuscar);
            Controls.Add(CBgrau);
            Controls.Add(TBemail);
            Controls.Add(TBsenha);
            Controls.Add(TBusuario);
            Controls.Add(TBsobrenome);
            Controls.Add(TBnome);
            Controls.Add(TBid);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Administrativo";
            Text = "Administrativo";
            Load += Administrativo_Load;
            ((System.ComponentModel.ISupportInitialize)DGVfuncionarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TBid;
        private TextBox TBnome;
        private TextBox TBsobrenome;
        private TextBox TBusuario;
        private TextBox TBsenha;
        private ComboBox CBgrau;
        private Button BTbuscar;
        private DataGridView DGVfuncionarios;
        private Label label7;
        private Label label8;
        private TextBox TBemail;
        private Button BTcadastrar;
        private Button BTexcluir;
        private Button BTatualizar;
        private MaskedTextBox MTBtelefone;
    }
}