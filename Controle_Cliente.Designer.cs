namespace TrabalhoLipa
{
    partial class Controle_Cliente
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
            dataGridView1 = new DataGridView();
            Adicionar = new Button();
            Limpar = new Button();
            BtnPesquisar = new Button();
            Situacao = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            label9 = new Label();
            Filtro = new ComboBox();
            Pesquisar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(288, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(480, 357);
            dataGridView1.TabIndex = 42;
            // 
            // Adicionar
            // 
            Adicionar.Anchor = AnchorStyles.None;
            Adicionar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Adicionar.Location = new Point(61, 374);
            Adicionar.Name = "Adicionar";
            Adicionar.Size = new Size(121, 44);
            Adicionar.TabIndex = 41;
            Adicionar.Text = "Adicionar";
            Adicionar.UseVisualStyleBackColor = true;
            Adicionar.Click += Adicionar_Click;
            // 
            // Limpar
            // 
            Limpar.Anchor = AnchorStyles.None;
            Limpar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Limpar.Location = new Point(61, 324);
            Limpar.Name = "Limpar";
            Limpar.Size = new Size(121, 44);
            Limpar.TabIndex = 40;
            Limpar.Text = "Limpar";
            Limpar.UseVisualStyleBackColor = true;
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.Anchor = AnchorStyles.None;
            BtnPesquisar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPesquisar.Location = new Point(61, 274);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(121, 44);
            BtnPesquisar.TabIndex = 39;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = true;
            // 
            // Situacao
            // 
            Situacao.FormattingEnabled = true;
            Situacao.Items.AddRange(new object[] { "Ativo", "Inativo" });
            Situacao.Location = new Point(33, 198);
            Situacao.Name = "Situacao";
            Situacao.Size = new Size(121, 23);
            Situacao.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 98);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 37;
            label2.Text = "Filtro:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 164);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 36;
            label1.Text = "Situação:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(33, 32);
            label9.Name = "label9";
            label9.Size = new Size(96, 25);
            label9.TabIndex = 35;
            label9.Text = "Pesquisar:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Filtro
            // 
            Filtro.FormattingEnabled = true;
            Filtro.Items.AddRange(new object[] { "Nenhum", "ID", "Nome", "CPF", "RG", "Email", "Telefone" });
            Filtro.Location = new Point(34, 132);
            Filtro.Name = "Filtro";
            Filtro.Size = new Size(121, 23);
            Filtro.TabIndex = 34;
            // 
            // Pesquisar
            // 
            Pesquisar.Location = new Point(34, 66);
            Pesquisar.Margin = new Padding(3, 2, 3, 2);
            Pesquisar.Name = "Pesquisar";
            Pesquisar.Size = new Size(160, 23);
            Pesquisar.TabIndex = 33;
            // 
            // Controle_Cliente
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
            Name = "Controle_Cliente";
            Text = "Controle_Cliente";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Adicionar;
        private Button Limpar;
        private Button BtnPesquisar;
        private ComboBox Situacao;
        private Label label2;
        private Label label1;
        private Label label9;
        private ComboBox Filtro;
        private TextBox Pesquisar;
    }
}