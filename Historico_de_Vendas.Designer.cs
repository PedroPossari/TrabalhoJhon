namespace TrabalhoLipa
{
    partial class Historico_de_Vendas
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
            Limpar = new Button();
            BtnPesquisar = new Button();
            Situacao = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            label9 = new Label();
            Filtro = new ComboBox();
            Pesquisar = new TextBox();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // Limpar
            // 
            Limpar.Anchor = AnchorStyles.None;
            Limpar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Limpar.Location = new Point(45, 351);
            Limpar.Name = "Limpar";
            Limpar.Size = new Size(121, 44);
            Limpar.TabIndex = 39;
            Limpar.Text = "Limpar";
            Limpar.UseVisualStyleBackColor = true;
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.Anchor = AnchorStyles.None;
            BtnPesquisar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPesquisar.Location = new Point(45, 291);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(121, 44);
            BtnPesquisar.TabIndex = 38;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = true;
            // 
            // Situacao
            // 
            Situacao.FormattingEnabled = true;
            Situacao.Items.AddRange(new object[] { "Todas", "Em Aberto", "Pago", "Finalizada/Entregue" });
            Situacao.Location = new Point(17, 205);
            Situacao.Name = "Situacao";
            Situacao.Size = new Size(121, 23);
            Situacao.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 105);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 36;
            label2.Text = "Filtro:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 171);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 35;
            label1.Text = "Situação:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(17, 39);
            label9.Name = "label9";
            label9.Size = new Size(96, 25);
            label9.TabIndex = 34;
            label9.Text = "Pesquisar:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Filtro
            // 
            Filtro.FormattingEnabled = true;
            Filtro.Items.AddRange(new object[] { "Nenhum", "Número da Venda", "Código do Cliente", "Código do Funcionário", "Forma de Pagamento", "Valor Total" });
            Filtro.Location = new Point(18, 139);
            Filtro.Name = "Filtro";
            Filtro.Size = new Size(121, 23);
            Filtro.TabIndex = 33;
            // 
            // Pesquisar
            // 
            Pesquisar.Location = new Point(18, 73);
            Pesquisar.Margin = new Padding(3, 2, 3, 2);
            Pesquisar.Name = "Pesquisar";
            Pesquisar.Size = new Size(160, 23);
            Pesquisar.TabIndex = 32;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(235, 21);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(548, 409);
            listBox1.TabIndex = 31;
            // 
            // Historico_de_Vendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Limpar);
            Controls.Add(BtnPesquisar);
            Controls.Add(Situacao);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(Filtro);
            Controls.Add(Pesquisar);
            Controls.Add(listBox1);
            Name = "Historico_de_Vendas";
            Text = "Historico de Vendas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Limpar;
        private Button BtnPesquisar;
        private ComboBox Situacao;
        private Label label2;
        private Label label1;
        private Label label9;
        private ComboBox Filtro;
        private TextBox Pesquisar;
        private ListBox listBox1;
    }
}