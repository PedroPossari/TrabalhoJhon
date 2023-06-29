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
            label9 = new Label();
            BtnPesquisar = new Button();
            Editar = new Button();
            Adicionar = new Button();
            Lista_Produtos = new DataGridView();
            Excluir = new Button();
            ((System.ComponentModel.ISupportInitialize)Lista_Produtos).BeginInit();
            SuspendLayout();
            // 
            // Pesquisar
            // 
            Pesquisar.Location = new Point(14, 87);
            Pesquisar.Name = "Pesquisar";
            Pesquisar.Size = new Size(182, 27);
            Pesquisar.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(13, 41);
            label9.Name = "label9";
            label9.Size = new Size(118, 32);
            label9.TabIndex = 25;
            label9.Text = "Pesquisar:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.Anchor = AnchorStyles.None;
            BtnPesquisar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPesquisar.Location = new Point(45, 271);
            BtnPesquisar.Margin = new Padding(3, 4, 3, 4);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(138, 59);
            BtnPesquisar.TabIndex = 29;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = true;
            BtnPesquisar.Click += BtnPesquisar_Click;
            // 
            // Editar
            // 
            Editar.Anchor = AnchorStyles.None;
            Editar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Editar.Location = new Point(45, 405);
            Editar.Margin = new Padding(3, 4, 3, 4);
            Editar.Name = "Editar";
            Editar.Size = new Size(138, 59);
            Editar.TabIndex = 30;
            Editar.Text = "Editar";
            Editar.UseVisualStyleBackColor = true;
            // 
            // Adicionar
            // 
            Adicionar.Anchor = AnchorStyles.None;
            Adicionar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Adicionar.Location = new Point(45, 338);
            Adicionar.Margin = new Padding(3, 4, 3, 4);
            Adicionar.Name = "Adicionar";
            Adicionar.Size = new Size(138, 59);
            Adicionar.TabIndex = 31;
            Adicionar.Text = "Adicionar";
            Adicionar.UseVisualStyleBackColor = true;
            // 
            // Lista_Produtos
            // 
            Lista_Produtos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Lista_Produtos.Location = new Point(304, 41);
            Lista_Produtos.Margin = new Padding(3, 4, 3, 4);
            Lista_Produtos.Name = "Lista_Produtos";
            Lista_Produtos.RowHeadersWidth = 51;
            Lista_Produtos.RowTemplate.Height = 25;
            Lista_Produtos.Size = new Size(549, 476);
            Lista_Produtos.TabIndex = 32;
            // 
            // Excluir
            // 
            Excluir.Anchor = AnchorStyles.None;
            Excluir.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Excluir.Location = new Point(45, 472);
            Excluir.Margin = new Padding(3, 4, 3, 4);
            Excluir.Name = "Excluir";
            Excluir.Size = new Size(138, 59);
            Excluir.TabIndex = 33;
            Excluir.Text = "Excluir";
            Excluir.UseVisualStyleBackColor = true;
            Excluir.Click += Excluir_Click;
            // 
            // Estoquecs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(Excluir);
            Controls.Add(Lista_Produtos);
            Controls.Add(Adicionar);
            Controls.Add(Editar);
            Controls.Add(BtnPesquisar);
            Controls.Add(label9);
            Controls.Add(Pesquisar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Estoquecs";
            Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)Lista_Produtos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Pesquisar;
        private Label label9;
        private Button BtnPesquisar;
        private Button Editar;
        private Button Adicionar;
        private DataGridView Lista_Produtos;
        private Button Excluir;
    }
}