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
            Adicionar = new Button();
            BtnPesquisar = new Button();
            label9 = new Label();
            Pesquisar = new TextBox();
            lista_Cliente = new DataGridView();
            Excluir = new Button();
            Editar = new Button();
            ((System.ComponentModel.ISupportInitialize)lista_Cliente).BeginInit();
            SuspendLayout();
            // 
            // Adicionar
            // 
            Adicionar.Anchor = AnchorStyles.None;
            Adicionar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Adicionar.Location = new Point(38, 371);
            Adicionar.Margin = new Padding(3, 4, 3, 4);
            Adicionar.Name = "Adicionar";
            Adicionar.Size = new Size(138, 59);
            Adicionar.TabIndex = 41;
            Adicionar.Text = "Adicionar";
            Adicionar.UseVisualStyleBackColor = true;
            Adicionar.Click += Adicionar_Click;
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.Anchor = AnchorStyles.None;
            BtnPesquisar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPesquisar.Location = new Point(39, 304);
            BtnPesquisar.Margin = new Padding(3, 4, 3, 4);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(138, 59);
            BtnPesquisar.TabIndex = 39;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = true;
            BtnPesquisar.Click += BtnPesquisar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(38, 43);
            label9.Name = "label9";
            label9.Size = new Size(188, 32);
            label9.TabIndex = 35;
            label9.Text = "Pesquisar por id:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Pesquisar
            // 
            Pesquisar.Location = new Point(39, 88);
            Pesquisar.Name = "Pesquisar";
            Pesquisar.Size = new Size(182, 27);
            Pesquisar.TabIndex = 33;
            // 
            // lista_Cliente
            // 
            lista_Cliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lista_Cliente.Location = new Point(253, 43);
            lista_Cliente.Name = "lista_Cliente";
            lista_Cliente.RowHeadersWidth = 51;
            lista_Cliente.RowTemplate.Height = 29;
            lista_Cliente.Size = new Size(649, 448);
            lista_Cliente.TabIndex = 42;
            // 
            // Excluir
            // 
            Excluir.Anchor = AnchorStyles.None;
            Excluir.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Excluir.Location = new Point(38, 491);
            Excluir.Margin = new Padding(3, 4, 3, 4);
            Excluir.Name = "Excluir";
            Excluir.Size = new Size(138, 59);
            Excluir.TabIndex = 43;
            Excluir.Text = "Excluir";
            Excluir.UseVisualStyleBackColor = true;
            Excluir.Click += Excluir_Click;
            // 
            // Editar
            // 
            Editar.Anchor = AnchorStyles.None;
            Editar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Editar.Location = new Point(38, 432);
            Editar.Margin = new Padding(3, 4, 3, 4);
            Editar.Name = "Editar";
            Editar.Size = new Size(138, 59);
            Editar.TabIndex = 44;
            Editar.Text = "Editar";
            Editar.UseVisualStyleBackColor = true;
            Editar.Click += Editar_Click;
            // 
            // Controle_Cliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(Editar);
            Controls.Add(Excluir);
            Controls.Add(lista_Cliente);
            Controls.Add(Adicionar);
            Controls.Add(BtnPesquisar);
            Controls.Add(label9);
            Controls.Add(Pesquisar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Controle_Cliente";
            Text = "Controle_Cliente";
            ((System.ComponentModel.ISupportInitialize)lista_Cliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Adicionar;
        private Button BtnPesquisar;
        private Label label9;
        private TextBox Pesquisar;
        private DataGridView lista_Cliente;
        private Button Excluir;
        private Button Editar;
    }
}