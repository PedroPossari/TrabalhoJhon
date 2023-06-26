namespace TrabalhoLipa
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            label1 = new Label();
            reg_venda = new Label();
            Esto = new Label();
            AddProduto = new Label();
            H_venda = new Label();
            CadCliente = new Label();
            CadUser = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            USer = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(322, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(175, 45);
            label1.TabIndex = 5;
            label1.Text = "Bem Vindo\r\nO que deseja fazer?";
            // 
            // reg_venda
            // 
            reg_venda.BorderStyle = BorderStyle.FixedSingle;
            reg_venda.Cursor = Cursors.Hand;
            reg_venda.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            reg_venda.ImageAlign = ContentAlignment.BottomLeft;
            reg_venda.Location = new Point(53, 111);
            reg_venda.Margin = new Padding(4, 0, 4, 0);
            reg_venda.Name = "reg_venda";
            reg_venda.Padding = new Padding(20, 5, 0, 0);
            reg_venda.Size = new Size(170, 97);
            reg_venda.TabIndex = 8;
            reg_venda.Text = "Registrar Venda";
            reg_venda.UseWaitCursor = true;
            reg_venda.Click += label2_Click;
            // 
            // Esto
            // 
            Esto.BorderStyle = BorderStyle.FixedSingle;
            Esto.Cursor = Cursors.Hand;
            Esto.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Esto.Location = new Point(339, 263);
            Esto.Margin = new Padding(4, 0, 4, 0);
            Esto.Name = "Esto";
            Esto.Padding = new Padding(50, 5, 0, 0);
            Esto.Size = new Size(170, 97);
            Esto.TabIndex = 7;
            Esto.Text = "Estoque";
            Esto.Click += Esto_Click;
            // 
            // AddProduto
            // 
            AddProduto.BackColor = Color.Transparent;
            AddProduto.BorderStyle = BorderStyle.FixedSingle;
            AddProduto.Cursor = Cursors.Hand;
            AddProduto.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            AddProduto.Location = new Point(339, 111);
            AddProduto.Margin = new Padding(4, 0, 4, 0);
            AddProduto.Name = "AddProduto";
            AddProduto.Padding = new Padding(15, 5, 0, 0);
            AddProduto.Size = new Size(170, 97);
            AddProduto.TabIndex = 8;
            AddProduto.Text = "Adicionar Produto";
            AddProduto.Click += AddProduto_Click;
            // 
            // H_venda
            // 
            H_venda.BorderStyle = BorderStyle.FixedSingle;
            H_venda.Cursor = Cursors.Hand;
            H_venda.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            H_venda.Location = new Point(53, 263);
            H_venda.Margin = new Padding(4, 0, 4, 0);
            H_venda.Name = "H_venda";
            H_venda.Padding = new Padding(10, 5, 0, 0);
            H_venda.Size = new Size(170, 97);
            H_venda.TabIndex = 9;
            H_venda.Text = "Histórico de Vendas";
            H_venda.Click += H_venda_Click;
            // 
            // CadCliente
            // 
            CadCliente.BorderStyle = BorderStyle.FixedSingle;
            CadCliente.Cursor = Cursors.Hand;
            CadCliente.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CadCliente.Location = new Point(625, 111);
            CadCliente.Margin = new Padding(4, 0, 4, 0);
            CadCliente.Name = "CadCliente";
            CadCliente.Padding = new Padding(15, 5, 0, 0);
            CadCliente.Size = new Size(170, 97);
            CadCliente.TabIndex = 11;
            CadCliente.Text = "Cadastrar Cliente";
            CadCliente.Click += CadCliente_Click;
            // 
            // CadUser
            // 
            CadUser.BorderStyle = BorderStyle.FixedSingle;
            CadUser.Cursor = Cursors.Hand;
            CadUser.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CadUser.Location = new Point(625, 263);
            CadUser.Margin = new Padding(4, 0, 4, 0);
            CadUser.Name = "CadUser";
            CadUser.Padding = new Padding(10, 5, 0, 0);
            CadUser.Size = new Size(170, 97);
            CadUser.TabIndex = 10;
            CadUser.Text = "Cadastrar Usuário";
            CadUser.Click += CadUser_Click;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(89, 148);
            label2.Name = "label2";
            label2.Size = new Size(95, 54);
            label2.TabIndex = 12;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Cursor = Cursors.Hand;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(664, 148);
            label3.Name = "label3";
            label3.Size = new Size(95, 54);
            label3.TabIndex = 13;
            label3.Click += CadCliente_Click;
            // 
            // label4
            // 
            label4.Cursor = Cursors.Hand;
            label4.Image = Properties.Resources.Produto;
            label4.Location = new Point(376, 148);
            label4.Name = "label4";
            label4.Size = new Size(95, 54);
            label4.TabIndex = 14;
            label4.Click += AddProduto_Click;
            // 
            // label5
            // 
            label5.Cursor = Cursors.Hand;
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.Location = new Point(376, 300);
            label5.Name = "label5";
            label5.Size = new Size(95, 54);
            label5.TabIndex = 15;
            label5.Click += Esto_Click;
            // 
            // label7
            // 
            label7.Cursor = Cursors.Hand;
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.Location = new Point(665, 300);
            label7.Name = "label7";
            label7.Size = new Size(95, 54);
            label7.TabIndex = 17;
            label7.Click += CadUser_Click;
            // 
            // label6
            // 
            label6.Cursor = Cursors.Hand;
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.Location = new Point(91, 300);
            label6.Name = "label6";
            label6.Size = new Size(95, 54);
            label6.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Image = Properties.Resources.Ícone_Carrinho_de_Compras_PNG;
            label8.Location = new Point(185, 148);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 19;
            label8.Text = "label8";
            label8.Visible = false;
            // 
            // USer
            // 
            USer.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            USer.Location = new Point(416, 9);
            USer.Margin = new Padding(4, 0, 4, 0);
            USer.Name = "USer";
            USer.Size = new Size(383, 22);
            USer.TabIndex = 20;
            USer.Text = "AAA";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 415);
            Controls.Add(USer);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CadCliente);
            Controls.Add(CadUser);
            Controls.Add(H_venda);
            Controls.Add(Esto);
            Controls.Add(reg_venda);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(AddProduto);
            Controls.Add(label8);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormPrincipal";
            FormClosing += Main_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label reg_venda;
        private System.Windows.Forms.Label Esto;
        private System.Windows.Forms.Label AddProduto;
        private System.Windows.Forms.Label H_venda;
        private System.Windows.Forms.Label CadCliente;
        private System.Windows.Forms.Label CadUser;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label8;
        private Label USer;
    }
}