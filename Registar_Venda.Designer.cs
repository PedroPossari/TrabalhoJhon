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
            dataGridView1 = new DataGridView();
            Produto = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            Condicao = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // nome_produto
            // 
            nome_produto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nome_produto.Location = new Point(26, 226);
            nome_produto.Name = "nome_produto";
            nome_produto.Size = new Size(367, 23);
            nome_produto.TabIndex = 13;
            // 
            // cliente
            // 
            cliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cliente.Location = new Point(26, 170);
            cliente.Name = "cliente";
            cliente.Size = new Size(367, 23);
            cliente.TabIndex = 14;
            // 
            // LblLogin
            // 
            LblLogin.Anchor = AnchorStyles.Top;
            LblLogin.AutoSize = true;
            LblLogin.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            LblLogin.Location = new Point(144, 47);
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
            LblUsuario.Location = new Point(26, 136);
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
            textDesconto.Location = new Point(26, 250);
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
            label2.Location = new Point(26, 193);
            label2.Name = "label2";
            label2.Size = new Size(207, 32);
            label2.TabIndex = 19;
            label2.Text = "Nome do Produto";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Qauntidade
            // 
            Qauntidade.Location = new Point(342, 260);
            Qauntidade.Name = "Qauntidade";
            Qauntidade.Size = new Size(51, 23);
            Qauntidade.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(237, 257);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 21;
            label3.Text = "Quantidade:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Desconto
            // 
            Desconto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Desconto.Location = new Point(26, 284);
            Desconto.Name = "Desconto";
            Desconto.Size = new Size(142, 23);
            Desconto.TabIndex = 23;
            Desconto.KeyPress += Desconto_KeyPress;
            // 
            // BtnFinalizar
            // 
            BtnFinalizar.Anchor = AnchorStyles.None;
            BtnFinalizar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnFinalizar.Location = new Point(620, 406);
            BtnFinalizar.Name = "BtnFinalizar";
            BtnFinalizar.Size = new Size(170, 34);
            BtnFinalizar.TabIndex = 24;
            BtnFinalizar.Text = "Finalizar Compra";
            BtnFinalizar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(26, 310);
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
            Adicionar_Prod.Location = new Point(237, 310);
            Adicionar_Prod.Name = "Adicionar_Prod";
            Adicionar_Prod.Size = new Size(156, 49);
            Adicionar_Prod.TabIndex = 26;
            Adicionar_Prod.Text = "Adicionar Produto";
            Adicionar_Prod.UseVisualStyleBackColor = true;
            Adicionar_Prod.Click += Adicionar_Prod_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Produto, Quantidade, Valor, Condicao });
            dataGridView1.Location = new Point(398, 154);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(391, 205);
            dataGridView1.TabIndex = 27;
            // 
            // Produto
            // 
            Produto.HeaderText = "Produto";
            Produto.MinimumWidth = 6;
            Produto.Name = "Produto";
            Produto.Width = 125;
            // 
            // Quantidade
            // 
            Quantidade.HeaderText = "Quantidade";
            Quantidade.MinimumWidth = 6;
            Quantidade.Name = "Quantidade";
            Quantidade.Width = 125;
            // 
            // Valor
            // 
            Valor.HeaderText = "Valor";
            Valor.MinimumWidth = 6;
            Valor.Name = "Valor";
            Valor.Width = 125;
            // 
            // Condicao
            // 
            Condicao.HeaderText = "Condicao";
            Condicao.MinimumWidth = 6;
            Condicao.Name = "Condicao";
            Condicao.Width = 125;
            // 
            // Registar_Venda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Produto;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Condicao;
    }
}