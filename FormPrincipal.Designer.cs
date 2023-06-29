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
            USer = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            CadCliente = new Label();
            CadUser = new Label();
            H_venda = new Label();
            Esto = new Label();
            reg_venda = new Label();
            label1 = new Label();
            label4 = new Label();
            AddProduto = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // USer
            // 
            USer.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            USer.Location = new Point(472, 16);
            USer.Margin = new Padding(5, 0, 5, 0);
            USer.Name = "USer";
            USer.Size = new Size(438, 29);
            USer.TabIndex = 35;
            USer.Text = "AAA";
            // 
            // label6
            // 
            label6.Cursor = Cursors.Hand;
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.Location = new Point(101, 417);
            label6.Name = "label6";
            label6.Size = new Size(109, 72);
            label6.TabIndex = 33;
            label6.Click += H_venda_Click;
            // 
            // label7
            // 
            label7.Cursor = Cursors.Hand;
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.Location = new Point(752, 406);
            label7.Name = "label7";
            label7.Size = new Size(109, 72);
            label7.TabIndex = 32;
            label7.Click += CadUser_Click;
            // 
            // label5
            // 
            label5.Cursor = Cursors.Hand;
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.Location = new Point(426, 417);
            label5.Name = "label5";
            label5.Size = new Size(109, 72);
            label5.TabIndex = 31;
            label5.Click += Esto_Click;
            // 
            // label3
            // 
            label3.Cursor = Cursors.Hand;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(752, 206);
            label3.Name = "label3";
            label3.Size = new Size(109, 72);
            label3.TabIndex = 29;
            label3.Click += CadCliente_Click;
            // 
            // label2
            // 
            label2.Cursor = Cursors.Hand;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(98, 215);
            label2.Name = "label2";
            label2.Size = new Size(109, 72);
            label2.TabIndex = 28;
            label2.Click += label2_Click;
            // 
            // CadCliente
            // 
            CadCliente.BorderStyle = BorderStyle.FixedSingle;
            CadCliente.Cursor = Cursors.Hand;
            CadCliente.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CadCliente.Location = new Point(711, 165);
            CadCliente.Margin = new Padding(5, 0, 5, 0);
            CadCliente.Name = "CadCliente";
            CadCliente.Padding = new Padding(17, 7, 0, 0);
            CadCliente.Size = new Size(194, 129);
            CadCliente.TabIndex = 27;
            CadCliente.Text = "Cadastrar Cliente";
            CadCliente.Click += CadCliente_Click;
            // 
            // CadUser
            // 
            CadUser.BorderStyle = BorderStyle.FixedSingle;
            CadUser.Cursor = Cursors.Hand;
            CadUser.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CadUser.Location = new Point(711, 368);
            CadUser.Margin = new Padding(5, 0, 5, 0);
            CadUser.Name = "CadUser";
            CadUser.Padding = new Padding(11, 7, 0, 0);
            CadUser.Size = new Size(194, 129);
            CadUser.TabIndex = 26;
            CadUser.Text = "Procurar Cliente";
            CadUser.Click += CadUser_Click;
            // 
            // H_venda
            // 
            H_venda.BorderStyle = BorderStyle.FixedSingle;
            H_venda.Cursor = Cursors.Hand;
            H_venda.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            H_venda.Location = new Point(57, 368);
            H_venda.Margin = new Padding(5, 0, 5, 0);
            H_venda.Name = "H_venda";
            H_venda.Padding = new Padding(11, 7, 0, 0);
            H_venda.Size = new Size(194, 129);
            H_venda.TabIndex = 25;
            H_venda.Text = "Histórico de Vendas";
            H_venda.Click += H_venda_Click;
            // 
            // Esto
            // 
            Esto.BorderStyle = BorderStyle.FixedSingle;
            Esto.Cursor = Cursors.Hand;
            Esto.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Esto.Location = new Point(384, 368);
            Esto.Margin = new Padding(5, 0, 5, 0);
            Esto.Name = "Esto";
            Esto.Padding = new Padding(57, 7, 0, 0);
            Esto.Size = new Size(200, 129);
            Esto.TabIndex = 22;
            Esto.Text = "Estoque";
            Esto.Click += Esto_Click;
            // 
            // reg_venda
            // 
            reg_venda.BorderStyle = BorderStyle.FixedSingle;
            reg_venda.Cursor = Cursors.Hand;
            reg_venda.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            reg_venda.ImageAlign = ContentAlignment.BottomLeft;
            reg_venda.Location = new Point(57, 165);
            reg_venda.Margin = new Padding(5, 0, 5, 0);
            reg_venda.Name = "reg_venda";
            reg_venda.Padding = new Padding(23, 7, 0, 0);
            reg_venda.Size = new Size(194, 129);
            reg_venda.TabIndex = 23;
            reg_venda.Text = "Registrar Venda";
            reg_venda.UseWaitCursor = true;
            reg_venda.Click += label2_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(365, 16);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 60);
            label1.TabIndex = 21;
            label1.Text = "Bem Vindo\r\nO que deseja fazer?";
            // 
            // label4
            // 
            label4.Cursor = Cursors.Hand;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(426, 215);
            label4.Name = "label4";
            label4.Size = new Size(109, 72);
            label4.TabIndex = 30;
            label4.Click += AddProduto_Click;
            // 
            // AddProduto
            // 
            AddProduto.BackColor = Color.Transparent;
            AddProduto.BorderStyle = BorderStyle.FixedSingle;
            AddProduto.Cursor = Cursors.Hand;
            AddProduto.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            AddProduto.Location = new Point(384, 165);
            AddProduto.Margin = new Padding(5, 0, 5, 0);
            AddProduto.Name = "AddProduto";
            AddProduto.Padding = new Padding(17, 7, 0, 0);
            AddProduto.Size = new Size(200, 129);
            AddProduto.TabIndex = 24;
            AddProduto.Text = "Adicionar Produto";
            AddProduto.Click += AddProduto_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(208, 215);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 34;
            label8.Text = "label8";
            label8.Visible = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 553);
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
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormPrincipal";
            Text = "Main";
            FormClosing += Main_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label USer;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label CadCliente;
        private Label CadUser;
        private Label H_venda;
        private Label Esto;
        private Label reg_venda;
        private Label label1;
        private Label label4;
        private Label AddProduto;
        private Label label8;
    }
}