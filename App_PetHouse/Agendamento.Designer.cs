namespace App_PetHouse
{
    partial class Agendamento
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
            TBcpfCliente = new TextBox();
            label2 = new Label();
            label3 = new Label();
            CBservico = new ComboBox();
            label5 = new Label();
            MTBdiaAgendamento = new MaskedTextBox();
            DVGagentamentos = new DataGridView();
            BTbuscar = new Button();
            BTcadastrar = new Button();
            BTatualizar = new Button();
            BTexcluir = new Button();
            TBnomeCliente = new TextBox();
            TBtelefone = new TextBox();
            CBhoraAgendamento = new ComboBox();
            TBemail = new TextBox();
            TBnomeAnimal = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            TBpesoAnimal = new TextBox();
            TBidadeAnimal = new TextBox();
            TBracaAnimal = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)DVGagentamentos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Cpf do cliente:";
            // 
            // TBcpfCliente
            // 
            TBcpfCliente.Location = new Point(12, 27);
            TBcpfCliente.Name = "TBcpfCliente";
            TBcpfCliente.Size = new Size(151, 23);
            TBcpfCliente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 126);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 0;
            label2.Text = "Nome do animal:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 185);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 0;
            label3.Text = "Tipo de serviço: ";
            // 
            // CBservico
            // 
            CBservico.DropDownStyle = ComboBoxStyle.DropDownList;
            CBservico.FormattingEnabled = true;
            CBservico.Items.AddRange(new object[] { "", "Banho e tosa", "Clínico", "Adestramento", "Serviços de hospedagem", "Transporte" });
            CBservico.Location = new Point(13, 207);
            CBservico.Name = "CBservico";
            CBservico.Size = new Size(121, 23);
            CBservico.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(170, 185);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 0;
            label5.Text = "Dia agendado:";
            // 
            // MTBdiaAgendamento
            // 
            MTBdiaAgendamento.Location = new Point(170, 207);
            MTBdiaAgendamento.Mask = "00/00/0000";
            MTBdiaAgendamento.Name = "MTBdiaAgendamento";
            MTBdiaAgendamento.Size = new Size(100, 23);
            MTBdiaAgendamento.TabIndex = 3;
            MTBdiaAgendamento.ValidatingType = typeof(DateTime);
            // 
            // DVGagentamentos
            // 
            DVGagentamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DVGagentamentos.Location = new Point(12, 288);
            DVGagentamentos.Name = "DVGagentamentos";
            DVGagentamentos.RowTemplate.Height = 25;
            DVGagentamentos.Size = new Size(870, 247);
            DVGagentamentos.TabIndex = 5;
            DVGagentamentos.CellClick += DVGagentamentos_CellClick;
            // 
            // BTbuscar
            // 
            BTbuscar.Location = new Point(170, 27);
            BTbuscar.Name = "BTbuscar";
            BTbuscar.Size = new Size(75, 23);
            BTbuscar.TabIndex = 6;
            BTbuscar.Text = "Buscar";
            BTbuscar.UseVisualStyleBackColor = true;
            BTbuscar.Click += BTbuscar_Click;
            // 
            // BTcadastrar
            // 
            BTcadastrar.Location = new Point(12, 247);
            BTcadastrar.Name = "BTcadastrar";
            BTcadastrar.Size = new Size(86, 33);
            BTcadastrar.TabIndex = 6;
            BTcadastrar.Text = "Cadastrar";
            BTcadastrar.UseVisualStyleBackColor = true;
            BTcadastrar.Click += BTcadastrar_Click;
            // 
            // BTatualizar
            // 
            BTatualizar.Location = new Point(104, 247);
            BTatualizar.Name = "BTatualizar";
            BTatualizar.Size = new Size(86, 33);
            BTatualizar.TabIndex = 6;
            BTatualizar.Text = "Atualizar";
            BTatualizar.UseVisualStyleBackColor = true;
            BTatualizar.Click += BTatualizar_Click;
            // 
            // BTexcluir
            // 
            BTexcluir.Location = new Point(196, 247);
            BTexcluir.Name = "BTexcluir";
            BTexcluir.Size = new Size(86, 33);
            BTexcluir.TabIndex = 6;
            BTexcluir.Text = "Excluir";
            BTexcluir.UseVisualStyleBackColor = true;
            BTexcluir.Click += BTexcluir_Click;
            // 
            // TBnomeCliente
            // 
            TBnomeCliente.Location = new Point(12, 86);
            TBnomeCliente.Name = "TBnomeCliente";
            TBnomeCliente.Size = new Size(233, 23);
            TBnomeCliente.TabIndex = 7;
            // 
            // TBtelefone
            // 
            TBtelefone.Location = new Point(284, 86);
            TBtelefone.Name = "TBtelefone";
            TBtelefone.Size = new Size(151, 23);
            TBtelefone.TabIndex = 8;
            // 
            // CBhoraAgendamento
            // 
            CBhoraAgendamento.DropDownStyle = ComboBoxStyle.DropDownList;
            CBhoraAgendamento.FormattingEnabled = true;
            CBhoraAgendamento.Items.AddRange(new object[] { "", "08:00:00", "08:30:00", "09:00:00", "09:30:00", "10:00:00", "10:30:00", "11:00:00", "11:30:00", "12:00:00", "12:30:00", "13:00:00", "13:30:00", "14:00:00", "14:30:00", "15:00:00", "15:30:00", "16:00:00", "16:30:00" });
            CBhoraAgendamento.Location = new Point(314, 207);
            CBhoraAgendamento.Name = "CBhoraAgendamento";
            CBhoraAgendamento.Size = new Size(121, 23);
            CBhoraAgendamento.TabIndex = 11;
            // 
            // TBemail
            // 
            TBemail.Location = new Point(471, 86);
            TBemail.Name = "TBemail";
            TBemail.Size = new Size(151, 23);
            TBemail.TabIndex = 15;
            // 
            // TBnomeAnimal
            // 
            TBnomeAnimal.Location = new Point(12, 148);
            TBnomeAnimal.Name = "TBnomeAnimal";
            TBnomeAnimal.Size = new Size(123, 23);
            TBnomeAnimal.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(471, 64);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 17;
            label4.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(284, 64);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 18;
            label6.Text = "Telefone:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 64);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 19;
            label7.Text = "Nome do cliente:";
            // 
            // TBpesoAnimal
            // 
            TBpesoAnimal.Location = new Point(482, 148);
            TBpesoAnimal.Name = "TBpesoAnimal";
            TBpesoAnimal.Size = new Size(123, 23);
            TBpesoAnimal.TabIndex = 20;
            // 
            // TBidadeAnimal
            // 
            TBidadeAnimal.Location = new Point(329, 148);
            TBidadeAnimal.Name = "TBidadeAnimal";
            TBidadeAnimal.Size = new Size(123, 23);
            TBidadeAnimal.TabIndex = 21;
            // 
            // TBracaAnimal
            // 
            TBracaAnimal.Location = new Point(170, 148);
            TBracaAnimal.Name = "TBracaAnimal";
            TBracaAnimal.Size = new Size(123, 23);
            TBracaAnimal.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(170, 126);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 23;
            label8.Text = "Raça:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(329, 126);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 24;
            label9.Text = "Idade:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(482, 126);
            label10.Name = "label10";
            label10.Size = new Size(32, 15);
            label10.TabIndex = 25;
            label10.Text = "Peso";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(314, 185);
            label11.Name = "label11";
            label11.Size = new Size(91, 15);
            label11.TabIndex = 26;
            label11.Text = "Hora agendada:";
            // 
            // Agendamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 543);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(TBracaAnimal);
            Controls.Add(TBidadeAnimal);
            Controls.Add(TBpesoAnimal);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(TBnomeAnimal);
            Controls.Add(TBemail);
            Controls.Add(CBhoraAgendamento);
            Controls.Add(TBtelefone);
            Controls.Add(TBnomeCliente);
            Controls.Add(BTexcluir);
            Controls.Add(BTatualizar);
            Controls.Add(BTcadastrar);
            Controls.Add(BTbuscar);
            Controls.Add(DVGagentamentos);
            Controls.Add(MTBdiaAgendamento);
            Controls.Add(CBservico);
            Controls.Add(TBcpfCliente);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Agendamento";
            Text = "Agendamento";
            Load += Agendamento_Load;
            ((System.ComponentModel.ISupportInitialize)DVGagentamentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TBcpfCliente;
        private Label label2;
        private Label label3;
        private ComboBox CBservico;
        private Label label5;
        private MaskedTextBox MTBdiaAgendamento;
        private DataGridView DVGagentamentos;
        private Button BTbuscar;
        private Button BTcadastrar;
        private Button BTatualizar;
        private Button BTexcluir;
        private TextBox TBnomeCliente;
        private TextBox TBtelefone;
        private ComboBox CBhoraAgendamento;
        private TextBox TBemail;
        private TextBox TBnomeAnimal;
        private Label label4;
        private Label label6;
        private Label label7;
        private TextBox TBpesoAnimal;
        private TextBox TBidadeAnimal;
        private TextBox TBracaAnimal;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}