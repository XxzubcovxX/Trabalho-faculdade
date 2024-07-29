namespace App_PetHouse
{
    partial class RegistroMedicoAnimal
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
            TBid = new TextBox();
            BTbuscar = new Button();
            label2 = new Label();
            RTBhistoricoVacinacao = new RichTextBox();
            label3 = new Label();
            RTBmeicamentosPrescritos = new RichTextBox();
            label4 = new Label();
            label5 = new Label();
            TXTdono = new Label();
            TXTnomeDoAnimal = new Label();
            label6 = new Label();
            RTBtratamentosRealizados = new RichTextBox();
            label7 = new Label();
            RTBconsultas = new RichTextBox();
            label8 = new Label();
            RTBalergias = new RichTextBox();
            label9 = new Label();
            RTBcondicoes = new RichTextBox();
            label10 = new Label();
            RTBexames = new RichTextBox();
            label11 = new Label();
            RTBresultados = new RichTextBox();
            label12 = new Label();
            RTBobservacoes = new RichTextBox();
            BTatualizar = new Button();
            BTcadastrar = new Button();
            BTexcluir = new Button();
            DGVregistro = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGVregistro).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "ID do registro:";
            // 
            // TBid
            // 
            TBid.Location = new Point(12, 27);
            TBid.Name = "TBid";
            TBid.Size = new Size(65, 23);
            TBid.TabIndex = 1;
            // 
            // BTbuscar
            // 
            BTbuscar.Location = new Point(83, 27);
            BTbuscar.Name = "BTbuscar";
            BTbuscar.Size = new Size(75, 23);
            BTbuscar.TabIndex = 2;
            BTbuscar.Text = "Buscar";
            BTbuscar.UseVisualStyleBackColor = true;
            BTbuscar.Click += BTbuscar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 119);
            label2.Name = "label2";
            label2.Size = new Size(130, 15);
            label2.TabIndex = 0;
            label2.Text = "Histórico de vacinação:";
            // 
            // RTBhistoricoVacinacao
            // 
            RTBhistoricoVacinacao.Location = new Point(12, 137);
            RTBhistoricoVacinacao.Name = "RTBhistoricoVacinacao";
            RTBhistoricoVacinacao.Size = new Size(453, 48);
            RTBhistoricoVacinacao.TabIndex = 3;
            RTBhistoricoVacinacao.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 188);
            label3.Name = "label3";
            label3.Size = new Size(143, 15);
            label3.TabIndex = 0;
            label3.Text = "Medicamentos Prescritos:";
            // 
            // RTBmeicamentosPrescritos
            // 
            RTBmeicamentosPrescritos.Location = new Point(12, 206);
            RTBmeicamentosPrescritos.Name = "RTBmeicamentosPrescritos";
            RTBmeicamentosPrescritos.Size = new Size(453, 64);
            RTBmeicamentosPrescritos.TabIndex = 3;
            RTBmeicamentosPrescritos.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 70);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 0;
            label4.Text = "Nome do animal:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 95);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 0;
            label5.Text = "Dono:";
            // 
            // TXTdono
            // 
            TXTdono.AutoSize = true;
            TXTdono.Location = new Point(150, 95);
            TXTdono.Name = "TXTdono";
            TXTdono.Size = new Size(32, 15);
            TXTdono.TabIndex = 0;
            TXTdono.Text = "Error";
            TXTdono.Click += TXTdono_Click;
            // 
            // TXTnomeDoAnimal
            // 
            TXTnomeDoAnimal.AutoSize = true;
            TXTnomeDoAnimal.Location = new Point(150, 70);
            TXTnomeDoAnimal.Name = "TXTnomeDoAnimal";
            TXTnomeDoAnimal.Size = new Size(32, 15);
            TXTnomeDoAnimal.TabIndex = 0;
            TXTnomeDoAnimal.Text = "Error";
            TXTnomeDoAnimal.Click += TXTnomeDoAnimal_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 273);
            label6.Name = "label6";
            label6.Size = new Size(133, 15);
            label6.TabIndex = 0;
            label6.Text = "Tratamentos Realizados:";
            // 
            // RTBtratamentosRealizados
            // 
            RTBtratamentosRealizados.Location = new Point(12, 291);
            RTBtratamentosRealizados.Name = "RTBtratamentosRealizados";
            RTBtratamentosRealizados.Size = new Size(453, 57);
            RTBtratamentosRealizados.TabIndex = 3;
            RTBtratamentosRealizados.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 354);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 0;
            label7.Text = "Consultas:";
            // 
            // RTBconsultas
            // 
            RTBconsultas.Location = new Point(12, 372);
            RTBconsultas.Name = "RTBconsultas";
            RTBconsultas.Size = new Size(453, 57);
            RTBconsultas.TabIndex = 3;
            RTBconsultas.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 438);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 0;
            label8.Text = "Alergias:";
            // 
            // RTBalergias
            // 
            RTBalergias.Location = new Point(12, 456);
            RTBalergias.Name = "RTBalergias";
            RTBalergias.Size = new Size(453, 57);
            RTBalergias.TabIndex = 3;
            RTBalergias.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 517);
            label9.Name = "label9";
            label9.Size = new Size(116, 15);
            label9.TabIndex = 0;
            label9.Text = "Condições de saúde:";
            // 
            // RTBcondicoes
            // 
            RTBcondicoes.Location = new Point(12, 535);
            RTBcondicoes.Name = "RTBcondicoes";
            RTBcondicoes.Size = new Size(453, 57);
            RTBcondicoes.TabIndex = 3;
            RTBcondicoes.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 594);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 0;
            label10.Text = "Exames:";
            // 
            // RTBexames
            // 
            RTBexames.Location = new Point(12, 612);
            RTBexames.Name = "RTBexames";
            RTBexames.Size = new Size(453, 57);
            RTBexames.TabIndex = 3;
            RTBexames.Text = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(548, 119);
            label11.Name = "label11";
            label11.Size = new Size(67, 15);
            label11.TabIndex = 0;
            label11.Text = "Resultados:";
            // 
            // RTBresultados
            // 
            RTBresultados.Location = new Point(548, 137);
            RTBresultados.Name = "RTBresultados";
            RTBresultados.Size = new Size(453, 57);
            RTBresultados.TabIndex = 3;
            RTBresultados.Text = "";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(548, 195);
            label12.Name = "label12";
            label12.Size = new Size(77, 15);
            label12.TabIndex = 0;
            label12.Text = "Observações:";
            // 
            // RTBobservacoes
            // 
            RTBobservacoes.Location = new Point(548, 213);
            RTBobservacoes.Name = "RTBobservacoes";
            RTBobservacoes.Size = new Size(453, 156);
            RTBobservacoes.TabIndex = 3;
            RTBobservacoes.Text = "";
            // 
            // BTatualizar
            // 
            BTatualizar.Location = new Point(548, 391);
            BTatualizar.Name = "BTatualizar";
            BTatualizar.Size = new Size(85, 38);
            BTatualizar.TabIndex = 2;
            BTatualizar.Text = "Atualizar";
            BTatualizar.UseVisualStyleBackColor = true;
            BTatualizar.Click += BTatualizar_Click;
            // 
            // BTcadastrar
            // 
            BTcadastrar.Location = new Point(639, 391);
            BTcadastrar.Name = "BTcadastrar";
            BTcadastrar.Size = new Size(85, 38);
            BTcadastrar.TabIndex = 2;
            BTcadastrar.Text = "Cadastrar";
            BTcadastrar.UseVisualStyleBackColor = true;
            BTcadastrar.Click += BTcadastrar_Click;
            // 
            // BTexcluir
            // 
            BTexcluir.Location = new Point(730, 391);
            BTexcluir.Name = "BTexcluir";
            BTexcluir.Size = new Size(85, 38);
            BTexcluir.TabIndex = 2;
            BTexcluir.Text = "Excluir";
            BTexcluir.UseVisualStyleBackColor = true;
            BTexcluir.Click += BTexcluir_Click;
            // 
            // DGVregistro
            // 
            DGVregistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVregistro.Location = new Point(548, 442);
            DGVregistro.Name = "DGVregistro";
            DGVregistro.RowTemplate.Height = 25;
            DGVregistro.Size = new Size(500, 150);
            DGVregistro.TabIndex = 4;
            DGVregistro.CellClick += DGVregistro_CellClick;
            // 
            // RegistroMedicoAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 678);
            Controls.Add(DGVregistro);
            Controls.Add(RTBobservacoes);
            Controls.Add(RTBresultados);
            Controls.Add(RTBexames);
            Controls.Add(label12);
            Controls.Add(RTBcondicoes);
            Controls.Add(label11);
            Controls.Add(RTBalergias);
            Controls.Add(label10);
            Controls.Add(RTBconsultas);
            Controls.Add(label9);
            Controls.Add(RTBtratamentosRealizados);
            Controls.Add(label8);
            Controls.Add(RTBmeicamentosPrescritos);
            Controls.Add(label7);
            Controls.Add(RTBhistoricoVacinacao);
            Controls.Add(label6);
            Controls.Add(BTexcluir);
            Controls.Add(BTcadastrar);
            Controls.Add(BTatualizar);
            Controls.Add(BTbuscar);
            Controls.Add(label3);
            Controls.Add(TBid);
            Controls.Add(label2);
            Controls.Add(TXTdono);
            Controls.Add(label5);
            Controls.Add(TXTnomeDoAnimal);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "RegistroMedicoAnimal";
            Text = "RegistroMedicoAnimal";
            Load += RegistroMedicoAnimal_Load;
            ((System.ComponentModel.ISupportInitialize)DGVregistro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TBid;
        private Button BTbuscar;
        private Label label2;
        private RichTextBox RTBhistoricoVacinacao;
        private Label label3;
        private RichTextBox RTBmeicamentosPrescritos;
        private Label label4;
        private Label label5;
        private Label TXTdono;
        private Label TXTnomeDoAnimal;
        private Label label6;
        private RichTextBox RTBtratamentosRealizados;
        private Label label7;
        private RichTextBox RTBconsultas;
        private Label label8;
        private RichTextBox RTBalergias;
        private Label label9;
        private RichTextBox RTBcondicoes;
        private Label label10;
        private RichTextBox RTBexames;
        private Label label11;
        private RichTextBox RTBresultados;
        private Label label12;
        private RichTextBox RTBobservacoes;
        private Button BTatualizar;
        private Button BTcadastrar;
        private Button BTexcluir;
        private DataGridView DGVregistro;
    }
}