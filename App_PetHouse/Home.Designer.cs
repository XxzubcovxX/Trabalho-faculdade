namespace App_PetHouse
{
    partial class Home
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
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            BTMestoque = new ToolStripMenuItem();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            BTMcliente = new ToolStripMenuItem();
            BTManimais = new ToolStripMenuItem();
            BTMagendamento = new ToolStripMenuItem();
            BTMadministrativo = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            TBusuario = new TextBox();
            TBsenha = new TextBox();
            BTentrar = new Button();
            BTsair = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, BTMestoque, cadastrosToolStripMenuItem, BTMagendamento, BTMadministrativo });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(957, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(52, 20);
            homeToolStripMenuItem.Text = "Home";
            // 
            // BTMestoque
            // 
            BTMestoque.Name = "BTMestoque";
            BTMestoque.Size = new Size(61, 20);
            BTMestoque.Text = "Estoque";
            BTMestoque.Click += BTMestoque_Click;
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { BTMcliente, BTManimais });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // BTMcliente
            // 
            BTMcliente.Name = "BTMcliente";
            BTMcliente.Size = new Size(117, 22);
            BTMcliente.Text = "Clientes";
            BTMcliente.Click += BTMcliente_Click;
            // 
            // BTManimais
            // 
            BTManimais.Name = "BTManimais";
            BTManimais.Size = new Size(117, 22);
            BTManimais.Text = "Animais";
            BTManimais.Click += BTManimais_Click;
            // 
            // BTMagendamento
            // 
            BTMagendamento.Name = "BTMagendamento";
            BTMagendamento.Size = new Size(95, 20);
            BTMagendamento.Text = "Agendamento";
            BTMagendamento.Click += BTMagendamento_Click;
            // 
            // BTMadministrativo
            // 
            BTMadministrativo.Name = "BTMadministrativo";
            BTMadministrativo.Size = new Size(97, 20);
            BTMadministrativo.Text = "Administrativo";
            BTMadministrativo.Click += BTMadministrativo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(385, 98);
            label1.Name = "label1";
            label1.Size = new Size(108, 37);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(394, 196);
            label2.Name = "label2";
            label2.Size = new Size(89, 37);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // TBusuario
            // 
            TBusuario.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            TBusuario.Location = new Point(357, 138);
            TBusuario.Name = "TBusuario";
            TBusuario.Size = new Size(168, 43);
            TBusuario.TabIndex = 2;
            // 
            // TBsenha
            // 
            TBsenha.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            TBsenha.Location = new Point(357, 236);
            TBsenha.Name = "TBsenha";
            TBsenha.Size = new Size(168, 43);
            TBsenha.TabIndex = 2;
            // 
            // BTentrar
            // 
            BTentrar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BTentrar.Location = new Point(394, 285);
            BTentrar.Name = "BTentrar";
            BTentrar.Size = new Size(99, 43);
            BTentrar.TabIndex = 3;
            BTentrar.Text = "Entrar";
            BTentrar.UseVisualStyleBackColor = true;
            BTentrar.Click += BTentrar_Click;
            // 
            // BTsair
            // 
            BTsair.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BTsair.Location = new Point(499, 285);
            BTsair.Name = "BTsair";
            BTsair.Size = new Size(90, 43);
            BTsair.TabIndex = 4;
            BTsair.Text = "Sair";
            BTsair.UseVisualStyleBackColor = true;
            BTsair.Click += BTsair_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(957, 522);
            Controls.Add(BTsair);
            Controls.Add(BTentrar);
            Controls.Add(TBsenha);
            Controls.Add(TBusuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PetHouse";
            Load += Home_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem BTMestoque;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem BTMcliente;
        private ToolStripMenuItem BTManimais;
        private ToolStripMenuItem BTMagendamento;
        private ToolStripMenuItem BTMadministrativo;
        private Label label1;
        private Label label2;
        private TextBox TBusuario;
        private TextBox TBsenha;
        private Button BTentrar;
        private Button BTsair;
    }
}