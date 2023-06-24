namespace TrabalhoLipa
{
    partial class Cadastrar_Produto
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
            Nome_Produto = new TextBox();
            LblUsuario = new Label();
            label1 = new Label();
            label5 = new Label();
            preco = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            Marca = new TextBox();
            DEscricao = new TextBox();
            textBox3 = new TextBox();
            Condicao = new TextBox();
            Altura = new TextBox();
            Largura = new TextBox();
            BtnFinalizar = new Button();
            label2 = new Label();
            Profundiade = new TextBox();
            label3 = new Label();
            Peso = new TextBox();
            SuspendLayout();
            // 
            // Nome_Produto
            // 
            Nome_Produto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Nome_Produto.Location = new Point(54, 64);
            Nome_Produto.Name = "Nome_Produto";
            Nome_Produto.Size = new Size(367, 23);
            Nome_Produto.TabIndex = 15;
            // 
            // LblUsuario
            // 
            LblUsuario.AutoSize = true;
            LblUsuario.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LblUsuario.Location = new Point(148, 341);
            LblUsuario.Name = "LblUsuario";
            LblUsuario.Size = new Size(98, 32);
            LblUsuario.TabIndex = 18;
            LblUsuario.Text = "Largura:";
            LblUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(52, 341);
            label1.Name = "label1";
            label1.Size = new Size(82, 32);
            label1.TabIndex = 19;
            label1.Text = "Altura:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(54, 182);
            label5.Name = "label5";
            label5.Size = new Size(119, 32);
            label5.TabIndex = 20;
            label5.Text = "Condição:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // preco
            // 
            preco.AutoSize = true;
            preco.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            preco.Location = new Point(54, 266);
            preco.Name = "preco";
            preco.Size = new Size(78, 32);
            preco.TabIndex = 21;
            preco.Text = "Preço:";
            preco.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(486, 18);
            label7.Name = "label7";
            label7.Size = new Size(121, 32);
            label7.TabIndex = 22;
            label7.Text = "Descrição:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(54, 102);
            label8.Name = "label8";
            label8.Size = new Size(84, 32);
            label8.TabIndex = 23;
            label8.Text = "Marca:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(54, 18);
            label9.Name = "label9";
            label9.Size = new Size(212, 32);
            label9.TabIndex = 24;
            label9.Text = "Nome do Produto:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Marca
            // 
            Marca.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Marca.Location = new Point(54, 147);
            Marca.Name = "Marca";
            Marca.Size = new Size(367, 23);
            Marca.TabIndex = 25;
            // 
            // DEscricao
            // 
            DEscricao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DEscricao.Location = new Point(486, 64);
            DEscricao.Multiline = true;
            DEscricao.Name = "DEscricao";
            DEscricao.Size = new Size(302, 133);
            DEscricao.TabIndex = 26;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(54, 301);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(133, 23);
            textBox3.TabIndex = 27;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // Condicao
            // 
            Condicao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Condicao.Location = new Point(54, 228);
            Condicao.Name = "Condicao";
            Condicao.Size = new Size(367, 23);
            Condicao.TabIndex = 28;
            // 
            // Altura
            // 
            Altura.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Altura.Location = new Point(52, 385);
            Altura.Name = "Altura";
            Altura.Size = new Size(66, 23);
            Altura.TabIndex = 29;
            Altura.KeyPress += Altura_KeyPress;
            // 
            // Largura
            // 
            Largura.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Largura.Location = new Point(163, 385);
            Largura.Name = "Largura";
            Largura.Size = new Size(66, 23);
            Largura.TabIndex = 30;
            Largura.KeyPress += Largura_KeyPress;
            // 
            // BtnFinalizar
            // 
            BtnFinalizar.Anchor = AnchorStyles.None;
            BtnFinalizar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnFinalizar.Location = new Point(541, 294);
            BtnFinalizar.Name = "BtnFinalizar";
            BtnFinalizar.Size = new Size(209, 70);
            BtnFinalizar.TabIndex = 31;
            BtnFinalizar.Text = "Cadastrar Produto";
            BtnFinalizar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(342, 341);
            label2.Name = "label2";
            label2.Size = new Size(163, 32);
            label2.TabIndex = 32;
            label2.Text = "Profundidade:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Profundiade
            // 
            Profundiade.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Profundiade.Location = new Point(385, 385);
            Profundiade.Name = "Profundiade";
            Profundiade.Size = new Size(66, 23);
            Profundiade.TabIndex = 33;
            Profundiade.KeyPress += Profundiade_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(260, 341);
            label3.Name = "label3";
            label3.Size = new Size(68, 32);
            label3.TabIndex = 34;
            label3.Text = "Peso:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Peso
            // 
            Peso.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Peso.Location = new Point(274, 385);
            Peso.Name = "Peso";
            Peso.Size = new Size(66, 23);
            Peso.TabIndex = 35;
            Peso.KeyPress += Peso_KeyPress;
            // 
            // Cadastrar_Produto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 442);
            Controls.Add(Peso);
            Controls.Add(label3);
            Controls.Add(Profundiade);
            Controls.Add(label2);
            Controls.Add(BtnFinalizar);
            Controls.Add(Largura);
            Controls.Add(Altura);
            Controls.Add(Condicao);
            Controls.Add(textBox3);
            Controls.Add(DEscricao);
            Controls.Add(Marca);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(preco);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(LblUsuario);
            Controls.Add(Nome_Produto);
            Name = "Cadastrar_Produto";
            Text = "Cadastrar_Produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Nome_Produto;
        private Label LblUsuario;
        private Label label1;
        private Label label5;
        private Label preco;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox Marca;
        private TextBox DEscricao;
        private TextBox textBox3;
        private TextBox Condicao;
        private TextBox Altura;
        private TextBox Largura;
        private Button BtnFinalizar;
        private Label label2;
        private TextBox Profundiade;
        private Label label3;
        private TextBox Peso;
    }
}