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
            nome_produto.Location = new Point(634, 145);
            nome_produto.Margin = new Padding(3, 4, 3, 4);
            nome_produto.Name = "nome_produto";
            nome_produto.Size = new Size(346, 27);
            nome_produto.TabIndex = 13;
            // 
            // cliente
            // 
            cliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cliente.Location = new Point(30, 145);
            cliente.Margin = new Padding(3, 4, 3, 4);
            cliente.Name = "cliente";
            cliente.Size = new Size(346, 27);
            cliente.TabIndex = 14;
            // 
            // LblLogin
            // 
            LblLogin.Anchor = AnchorStyles.Top;
            LblLogin.AutoSize = true;
            LblLogin.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            LblLogin.Location = new Point(269, 9);
            LblLogin.Name = "LblLogin";
            LblLogin.Size = new Size(545, 81);
            LblLogin.TabIndex = 16;
            LblLogin.Text = "Registro de Venda";
            LblLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblUsuario
            // 
            LblUsuario.AutoSize = true;
            LblUsuario.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LblUsuario.Location = new Point(30, 100);
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
            textDesconto.Location = new Point(30, 176);
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
            label2.Location = new Point(634, 100);
            label2.Name = "label2";
            label2.Size = new Size(260, 41);
            label2.TabIndex = 19;
            label2.Text = "Nome do Produto";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Qauntidade
            // 
            Qauntidade.Location = new Point(342, 190);
            Qauntidade.Margin = new Padding(3, 4, 3, 4);
            Qauntidade.Name = "Qauntidade";
            Qauntidade.Size = new Size(34, 27);
            Qauntidade.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(217, 186);
            label3.Name = "label3";
            label3.Size = new Size(119, 28);
            label3.TabIndex = 21;
            label3.Text = "Quantidade:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Desconto
            // 
            Desconto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Desconto.Location = new Point(30, 225);
            Desconto.Margin = new Padding(3, 4, 3, 4);
            Desconto.Name = "Desconto";
            Desconto.Size = new Size(346, 27);
            Desconto.TabIndex = 23;
            Desconto.KeyPress += Desconto_KeyPress;
            // 
            // BtnFinalizar
            // 
            BtnFinalizar.Anchor = AnchorStyles.None;
            BtnFinalizar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnFinalizar.Location = new Point(786, 374);
            BtnFinalizar.Margin = new Padding(3, 4, 3, 4);
            BtnFinalizar.Name = "BtnFinalizar";
            BtnFinalizar.Size = new Size(194, 45);
            BtnFinalizar.TabIndex = 24;
            BtnFinalizar.Text = "Finalizar Compra";
            BtnFinalizar.UseVisualStyleBackColor = true;
            BtnFinalizar.Click += BtnFinalizar_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(30, 352);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(162, 65);
            button1.TabIndex = 25;
            button1.Text = "Aplicar Desconto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Adicionar_Prod
            // 
            Adicionar_Prod.Anchor = AnchorStyles.None;
            Adicionar_Prod.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Adicionar_Prod.Location = new Point(217, 352);
            Adicionar_Prod.Margin = new Padding(3, 4, 3, 4);
            Adicionar_Prod.Name = "Adicionar_Prod";
            Adicionar_Prod.Size = new Size(159, 65);
            Adicionar_Prod.TabIndex = 26;
            Adicionar_Prod.Text = "Adicionar Produto";
            Adicionar_Prod.UseVisualStyleBackColor = true;
            Adicionar_Prod.Click += Adicionar_Prod_Click;
            // 
            // Observacao
            // 
            Observacao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Observacao.Location = new Point(634, 221);
            Observacao.Margin = new Padding(3, 4, 3, 4);
            Observacao.Name = "Observacao";
            Observacao.Size = new Size(346, 27);
            Observacao.TabIndex = 28;
            // 
            // Observacao1
            // 
            Observacao1.AutoSize = true;
            Observacao1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Observacao1.Location = new Point(30, 256);
            Observacao1.Name = "Observacao1";
            Observacao1.Size = new Size(174, 41);
            Observacao1.TabIndex = 29;
            Observacao1.Text = "Observação";
            Observacao1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Situacao1
            // 
            Situacao1.AutoSize = true;
            Situacao1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Situacao1.Location = new Point(634, 176);
            Situacao1.Name = "Situacao1";
            Situacao1.Size = new Size(130, 41);
            Situacao1.TabIndex = 30;
            Situacao1.Text = "Situação";
            Situacao1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Situacao
            // 
            Situacao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Situacao.Location = new Point(30, 301);
            Situacao.Margin = new Padding(3, 4, 3, 4);
            Situacao.Name = "Situacao";
            Situacao.Size = new Size(346, 27);
            Situacao.TabIndex = 31;
            // 
            // Forma_de_pagamento1
            // 
            Forma_de_pagamento1.AutoSize = true;
            Forma_de_pagamento1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Forma_de_pagamento1.Location = new Point(634, 256);
            Forma_de_pagamento1.Name = "Forma_de_pagamento1";
            Forma_de_pagamento1.Size = new Size(303, 41);
            Forma_de_pagamento1.TabIndex = 32;
            Forma_de_pagamento1.Text = "Forma de Pagamento";
            Forma_de_pagamento1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Forma_de_pagamento
            // 
            Forma_de_pagamento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Forma_de_pagamento.Location = new Point(634, 301);
            Forma_de_pagamento.Margin = new Padding(3, 4, 3, 4);
            Forma_de_pagamento.Name = "Forma_de_pagamento";
            Forma_de_pagamento.Size = new Size(346, 27);
            Forma_de_pagamento.TabIndex = 33;
            // 
            // Registar_Venda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 432);
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
            Margin = new Padding(3, 4, 3, 4);
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