namespace TrabalhoLipa
{
    partial class Estoquecs
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
            Pesquisar = new TextBox();
            Filtro = new ComboBox();
            label9 = new Label();
            label1 = new Label();
            label2 = new Label();
            Situacao = new ComboBox();
            BtnPesquisar = new Button();
            Limpar = new Button();
            Adicionar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Pesquisar
            // 
            Pesquisar.Location = new Point(12, 65);
            Pesquisar.Margin = new Padding(3, 2, 3, 2);
            Pesquisar.Name = "Pesquisar";
            Pesquisar.Size = new Size(160, 23);
            Pesquisar.TabIndex = 1;
            // 
            // Filtro
            // 
            Filtro.FormattingEnabled = true;
            Filtro.Items.AddRange(new object[] { "Nenhum", "ID", "Nome", "Preço", "Marca" });
            Filtro.Location = new Point(12, 131);
            Filtro.Name = "Filtro";
            Filtro.Size = new Size(121, 23);
            Filtro.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(11, 31);
            label9.Name = "label9";
            label9.Size = new Size(96, 25);
            label9.TabIndex = 25;
            label9.Text = "Pesquisar:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 163);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 26;
            label1.Text = "Situação:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 97);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 27;
            label2.Text = "Filtro:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Situacao
            // 
            Situacao.FormattingEnabled = true;
            Situacao.Items.AddRange(new object[] { "Ativo", "Inativo" });
            Situacao.Location = new Point(11, 197);
            Situacao.Name = "Situacao";
            Situacao.Size = new Size(121, 23);
            Situacao.TabIndex = 28;
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.Anchor = AnchorStyles.None;
            BtnPesquisar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPesquisar.Location = new Point(39, 273);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(121, 44);
            BtnPesquisar.TabIndex = 29;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = true;
            // 
            // Limpar
            // 
            Limpar.Anchor = AnchorStyles.None;
            Limpar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Limpar.Location = new Point(39, 323);
            Limpar.Name = "Limpar";
            Limpar.Size = new Size(121, 44);
            Limpar.TabIndex = 30;
            Limpar.Text = "Limpar";
            Limpar.UseVisualStyleBackColor = true;
            // 
            // Adicionar
            // 
            Adicionar.Anchor = AnchorStyles.None;
            Adicionar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Adicionar.Location = new Point(39, 373);
            Adicionar.Name = "Adicionar";
            Adicionar.Size = new Size(121, 44);
            Adicionar.TabIndex = 31;
            Adicionar.Text = "Adicionar";
            Adicionar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(266, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(480, 357);
            dataGridView1.TabIndex = 32;
            // 
            // Estoquecs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(Adicionar);
            Controls.Add(Limpar);
            Controls.Add(BtnPesquisar);
            Controls.Add(Situacao);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(Filtro);
            Controls.Add(Pesquisar);
            Name = "Estoquecs";
            Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Pesquisar;
        private ComboBox Filtro;
        private Label label9;
        private Label label1;
        private Label label2;
        private ComboBox Situacao;
        private Button BtnPesquisar;
        private Button Limpar;
        private Button Adicionar;
        private DataGridView dataGridView1;
    }
}