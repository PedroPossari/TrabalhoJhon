namespace TrabalhoLipa
{
    partial class Registar_Venda
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
            BoxNProduto = new TextBox();
            txtCliente = new TextBox();
            LblLogin = new Label();
            LblUsuario = new Label();
            textDesconto = new Label();
            label2 = new Label();
            Qauntidade = new TextBox();
            label3 = new Label();
            Lista_Produto = new ListBox();
            Desconto = new TextBox();
            BtnFinalizar = new Button();
            button1 = new Button();
            Adicionar_Produto = new Button();
            SuspendLayout();
            // 
            // BoxNProduto
            // 
            BoxNProduto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BoxNProduto.Location = new Point(26, 284);
            BoxNProduto.Name = "BoxNProduto";
            BoxNProduto.Size = new Size(367, 23);
            BoxNProduto.TabIndex = 13;
            // 
            // txtCliente
            // 
            txtCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCliente.Location = new Point(26, 208);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(367, 23);
            txtCliente.TabIndex = 14;
            // 
            // LblLogin
            // 
            LblLogin.Anchor = AnchorStyles.Top;
            LblLogin.AutoSize = true;
            LblLogin.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            LblLogin.Location = new Point(206, 9);
            LblLogin.Name = "LblLogin";
            LblLogin.Size = new Size(397, 65);
            LblLogin.TabIndex = 16;
            LblLogin.Text = "Realizar Compra";
            LblLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblUsuario
            // 
            LblUsuario.AutoSize = true;
            LblUsuario.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LblUsuario.Location = new Point(26, 173);
            LblUsuario.Name = "LblUsuario";
            LblUsuario.Size = new Size(94, 32);
            LblUsuario.TabIndex = 17;
            LblUsuario.Text = "Cliente:";
            LblUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textDesconto
            // 
            textDesconto.AutoSize = true;
            textDesconto.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textDesconto.Location = new Point(26, 325);
            textDesconto.Name = "textDesconto";
            textDesconto.Size = new Size(120, 32);
            textDesconto.TabIndex = 18;
            textDesconto.Text = "Desconto:";
            textDesconto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 249);
            label2.Name = "label2";
            label2.Size = new Size(207, 32);
            label2.TabIndex = 19;
            label2.Text = "Nome do Produto";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Qauntidade
            // 
            Qauntidade.Location = new Point(499, 283);
            Qauntidade.Name = "Qauntidade";
            Qauntidade.Size = new Size(51, 23);
            Qauntidade.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(399, 281);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 21;
            label3.Text = "Quantidade:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lista_Produto
            // 
            Lista_Produto.FormattingEnabled = true;
            Lista_Produto.ItemHeight = 15;
            Lista_Produto.Location = new Point(451, 136);
            Lista_Produto.Name = "Lista_Produto";
            Lista_Produto.Size = new Size(307, 124);
            Lista_Produto.TabIndex = 22;
            // 
            // Desconto
            // 
            Desconto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Desconto.Location = new Point(26, 360);
            Desconto.Name = "Desconto";
            Desconto.Size = new Size(142, 23);
            Desconto.TabIndex = 23;
            // 
            // BtnFinalizar
            // 
            BtnFinalizar.Anchor = AnchorStyles.None;
            BtnFinalizar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnFinalizar.Location = new Point(527, 346);
            BtnFinalizar.Name = "BtnFinalizar";
            BtnFinalizar.Size = new Size(209, 70);
            BtnFinalizar.TabIndex = 24;
            BtnFinalizar.Text = "Finalizar Compra";
            BtnFinalizar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(206, 359);
            button1.Name = "button1";
            button1.Size = new Size(156, 49);
            button1.TabIndex = 25;
            button1.Text = "Aplicar Desconto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Adicionar_Produto
            // 
            Adicionar_Produto.Anchor = AnchorStyles.None;
            Adicionar_Produto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Adicionar_Produto.Location = new Point(556, 273);
            Adicionar_Produto.Name = "Adicionar_Produto";
            Adicionar_Produto.Size = new Size(152, 50);
            Adicionar_Produto.TabIndex = 26;
            Adicionar_Produto.Text = "Adicionar Produto";
            Adicionar_Produto.UseVisualStyleBackColor = true;
            // 
            // Registar_Venda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Adicionar_Produto);
            Controls.Add(button1);
            Controls.Add(BtnFinalizar);
            Controls.Add(Desconto);
            Controls.Add(Lista_Produto);
            Controls.Add(label3);
            Controls.Add(Qauntidade);
            Controls.Add(label2);
            Controls.Add(textDesconto);
            Controls.Add(LblUsuario);
            Controls.Add(LblLogin);
            Controls.Add(txtCliente);
            Controls.Add(BoxNProduto);
            Name = "Registar_Venda";
            Text = " ";
            FormClosing += Registar_Venda_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox BoxNProduto;
        private TextBox txtCliente;
        private Label LblLogin;
        private Label LblUsuario;
        private Label textDesconto;
        private Label label2;
        private TextBox Qauntidade;
        private Label label3;
        private ListBox Lista_Produto;
        private TextBox Desconto;
        private Button BtnFinalizar;
        private Button button1;
        private Button Adicionar_Produto;
    }
}