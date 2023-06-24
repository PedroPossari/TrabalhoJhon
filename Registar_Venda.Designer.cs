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
            nome_produto = new TextBox();
            cliente = new TextBox();
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
            SuspendLayout();
            // 
            // nome_produto
            // 
            nome_produto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nome_produto.Location = new Point(30, 379);
            nome_produto.Margin = new Padding(3, 4, 3, 4);
            nome_produto.Name = "nome_produto";
            nome_produto.Size = new Size(419, 27);
            nome_produto.TabIndex = 13;
            // 
            // cliente
            // 
            cliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cliente.Location = new Point(30, 277);
            cliente.Margin = new Padding(3, 4, 3, 4);
            cliente.Name = "cliente";
            cliente.Size = new Size(419, 27);
            cliente.TabIndex = 14;
            // 
            // LblLogin
            // 
            LblLogin.Anchor = AnchorStyles.Top;
            LblLogin.AutoSize = true;
            LblLogin.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            LblLogin.Location = new Point(295, 12);
            LblLogin.Name = "LblLogin";
            LblLogin.Size = new Size(356, 81);
            LblLogin.TabIndex = 16;
            LblLogin.Text = "Fazer Login";
            LblLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblUsuario
            // 
            LblUsuario.AutoSize = true;
            LblUsuario.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LblUsuario.Location = new Point(30, 231);
            LblUsuario.Name = "LblUsuario";
            LblUsuario.Size = new Size(117, 41);
            LblUsuario.TabIndex = 17;
            LblUsuario.Text = "Cliente:";
            LblUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textDesconto
            // 
            textDesconto.AutoSize = true;
            textDesconto.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textDesconto.Location = new Point(30, 433);
            textDesconto.Name = "textDesconto";
            textDesconto.Size = new Size(152, 41);
            textDesconto.TabIndex = 18;
            textDesconto.Text = "Desconto:";
            textDesconto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 332);
            label2.Name = "label2";
            label2.Size = new Size(260, 41);
            label2.TabIndex = 19;
            label2.Text = "Nome do Produto";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Qauntidade
            // 
            Qauntidade.Location = new Point(570, 377);
            Qauntidade.Margin = new Padding(3, 4, 3, 4);
            Qauntidade.Name = "Qauntidade";
            Qauntidade.Size = new Size(58, 27);
            Qauntidade.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(456, 375);
            label3.Name = "label3";
            label3.Size = new Size(119, 28);
            label3.TabIndex = 21;
            label3.Text = "Quantidade:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Lista_Produto
            // 
            Lista_Produto.FormattingEnabled = true;
            Lista_Produto.ItemHeight = 20;
            Lista_Produto.Location = new Point(515, 181);
            Lista_Produto.Margin = new Padding(3, 4, 3, 4);
            Lista_Produto.Name = "Lista_Produto";
            Lista_Produto.Size = new Size(350, 164);
            Lista_Produto.TabIndex = 22;
            // 
            // Desconto
            // 
            Desconto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Desconto.Location = new Point(30, 480);
            Desconto.Margin = new Padding(3, 4, 3, 4);
            Desconto.Name = "Desconto";
            Desconto.Size = new Size(162, 27);
            Desconto.TabIndex = 23;
            Desconto.KeyPress += Desconto_KeyPress;
            // 
            // BtnFinalizar
            // 
            BtnFinalizar.Anchor = AnchorStyles.None;
            BtnFinalizar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnFinalizar.Location = new Point(602, 461);
            BtnFinalizar.Margin = new Padding(3, 4, 3, 4);
            BtnFinalizar.Name = "BtnFinalizar";
            BtnFinalizar.Size = new Size(239, 93);
            BtnFinalizar.TabIndex = 24;
            BtnFinalizar.Text = "Finalizar Compra";
            BtnFinalizar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(235, 479);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(178, 65);
            button1.TabIndex = 25;
            button1.Text = "Aplicar Desconto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Registar_Venda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
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
            Controls.Add(cliente);
            Controls.Add(nome_produto);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Registar_Venda";
            Text = " ";
            FormClosing += Registar_Venda_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nome_produto;
        private TextBox cliente;
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
    }
}