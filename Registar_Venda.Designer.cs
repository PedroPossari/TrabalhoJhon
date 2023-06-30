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
            Desconto = new TextBox();
            BtnFinalizar = new Button();
            button1 = new Button();
            Adicionar_Prod = new Button();
            Observacao = new TextBox();
            Observacao1 = new Label();
            Situacao1 = new Label();
            Situacao = new TextBox();
            Forma_de_pagamento1 = new Label();
            Forma_de_pagamento = new TextBox();
            SuspendLayout();
            // 
            // nome_produto
            // 
            nome_produto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nome_produto.Location = new Point(555, 109);
            nome_produto.Name = "nome_produto";
            nome_produto.Size = new Size(303, 23);
            nome_produto.TabIndex = 13;
            // 
            // cliente
            // 
            cliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cliente.Location = new Point(26, 109);
            cliente.Name = "cliente";
            cliente.Size = new Size(303, 23);
            cliente.TabIndex = 14;
            // 
            // LblLogin
            // 
            LblLogin.Anchor = AnchorStyles.Top;
            LblLogin.AutoSize = true;
            LblLogin.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            LblLogin.Location = new Point(235, 7);
            LblLogin.Name = "LblLogin";
            LblLogin.Size = new Size(438, 65);
            LblLogin.TabIndex = 16;
            LblLogin.Text = "Registro de Venda";
            LblLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblUsuario
            // 
            LblUsuario.AutoSize = true;
            LblUsuario.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LblUsuario.Location = new Point(26, 75);
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
            textDesconto.Location = new Point(26, 132);
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
            label2.Location = new Point(555, 75);
            label2.Name = "label2";
            label2.Size = new Size(207, 32);
            label2.TabIndex = 19;
            label2.Text = "Nome do Produto";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Qauntidade
            // 
            Qauntidade.Location = new Point(299, 142);
            Qauntidade.Name = "Qauntidade";
            Qauntidade.Size = new Size(30, 23);
            Qauntidade.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(190, 140);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 21;
            label3.Text = "Quantidade:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Desconto
            // 
            Desconto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Desconto.Location = new Point(26, 169);
            Desconto.Name = "Desconto";
            Desconto.Size = new Size(303, 23);
            Desconto.TabIndex = 23;
            Desconto.KeyPress += Desconto_KeyPress;
            // 
            // BtnFinalizar
            // 
            BtnFinalizar.Anchor = AnchorStyles.None;
            BtnFinalizar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnFinalizar.Location = new Point(688, 279);
            BtnFinalizar.Name = "BtnFinalizar";
            BtnFinalizar.Size = new Size(170, 34);
            BtnFinalizar.TabIndex = 24;
            BtnFinalizar.Text = "Finalizar Compra";
            BtnFinalizar.UseVisualStyleBackColor = true;
            BtnFinalizar.Click += BtnFinalizar_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(26, 264);
            button1.Name = "button1";
            button1.Size = new Size(142, 49);
            button1.TabIndex = 25;
            button1.Text = "Aplicar Desconto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Adicionar_Prod
            // 
            Adicionar_Prod.Anchor = AnchorStyles.None;
            Adicionar_Prod.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Adicionar_Prod.Location = new Point(190, 264);
            Adicionar_Prod.Name = "Adicionar_Prod";
            Adicionar_Prod.Size = new Size(139, 49);
            Adicionar_Prod.TabIndex = 26;
            Adicionar_Prod.Text = "Adicionar Produto";
            Adicionar_Prod.UseVisualStyleBackColor = true;
            Adicionar_Prod.Click += Adicionar_Prod_Click;
            // 
            // Observacao
            // 
            Observacao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Observacao.Location = new Point(555, 166);
            Observacao.Name = "Observacao";
            Observacao.Size = new Size(303, 23);
            Observacao.TabIndex = 28;
            // 
            // Observacao1
            // 
            Observacao1.AutoSize = true;
            Observacao1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Observacao1.Location = new Point(26, 192);
            Observacao1.Name = "Observacao1";
            Observacao1.Size = new Size(138, 32);
            Observacao1.TabIndex = 29;
            Observacao1.Text = "Observação";
            Observacao1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Situacao1
            // 
            Situacao1.AutoSize = true;
            Situacao1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Situacao1.Location = new Point(555, 132);
            Situacao1.Name = "Situacao1";
            Situacao1.Size = new Size(104, 32);
            Situacao1.TabIndex = 30;
            Situacao1.Text = "Situação";
            Situacao1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Situacao
            // 
            Situacao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Situacao.Location = new Point(26, 226);
            Situacao.Name = "Situacao";
            Situacao.Size = new Size(303, 23);
            Situacao.TabIndex = 31;
            // 
            // Forma_de_pagamento1
            // 
            Forma_de_pagamento1.AutoSize = true;
            Forma_de_pagamento1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Forma_de_pagamento1.Location = new Point(555, 192);
            Forma_de_pagamento1.Name = "Forma_de_pagamento1";
            Forma_de_pagamento1.Size = new Size(242, 32);
            Forma_de_pagamento1.TabIndex = 32;
            Forma_de_pagamento1.Text = "Forma de Pagamento";
            Forma_de_pagamento1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Forma_de_pagamento
            // 
            Forma_de_pagamento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Forma_de_pagamento.Location = new Point(555, 226);
            Forma_de_pagamento.Name = "Forma_de_pagamento";
            Forma_de_pagamento.Size = new Size(303, 23);
            Forma_de_pagamento.TabIndex = 33;
            // 
            // Registar_Venda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 324);
            Controls.Add(Forma_de_pagamento);
            Controls.Add(Forma_de_pagamento1);
            Controls.Add(Situacao);
            Controls.Add(Situacao1);
            Controls.Add(Observacao1);
            Controls.Add(Observacao);
            Controls.Add(Adicionar_Prod);
            Controls.Add(button1);
            Controls.Add(BtnFinalizar);
            Controls.Add(Desconto);
            Controls.Add(label3);
            Controls.Add(Qauntidade);
            Controls.Add(label2);
            Controls.Add(textDesconto);
            Controls.Add(LblUsuario);
            Controls.Add(LblLogin);
            Controls.Add(cliente);
            Controls.Add(nome_produto);
            Name = "Registar_Venda";
            Text = " ";
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
        private TextBox Desconto;
        private Button BtnFinalizar;
        private Button button1;
        private Button Adicionar_Prod;
        private TextBox Observacao;
        private Label Observacao1;
        private Label Situacao1;
        private TextBox Situacao;
        private Label Forma_de_pagamento1;
        private TextBox Forma_de_pagamento;
    }
}