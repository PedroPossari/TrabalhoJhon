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
            BtnPesquisar = new Button();
            label9 = new Label();
            Pesquisar = new TextBox();
            Lista_Venda = new DataGridView();
            Adicionar = new Button();
            Editar = new Button();
            Excluir = new Button();
            ((System.ComponentModel.ISupportInitialize)Lista_Venda).BeginInit();
            SuspendLayout();
            // 
            // BtnPesquisar
            // 
            BtnPesquisar.Anchor = AnchorStyles.None;
            BtnPesquisar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPesquisar.Location = new Point(35, 136);
            BtnPesquisar.Name = "BtnPesquisar";
            BtnPesquisar.Size = new Size(121, 44);
            BtnPesquisar.TabIndex = 38;
            BtnPesquisar.Text = "Pesquisar";
            BtnPesquisar.UseVisualStyleBackColor = true;
            BtnPesquisar.Click += BtnPesquisar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(17, 39);
            label9.Name = "label9";
            label9.Size = new Size(151, 25);
            label9.TabIndex = 34;
            label9.Text = "Pesquisar por Id:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Pesquisar
            // 
            Pesquisar.Location = new Point(18, 73);
            Pesquisar.Margin = new Padding(3, 2, 3, 2);
            Pesquisar.Name = "Pesquisar";
            Pesquisar.Size = new Size(160, 23);
            Pesquisar.TabIndex = 32;
            // 
            // Lista_Venda
            // 
            Lista_Venda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Lista_Venda.Location = new Point(262, 39);
            Lista_Venda.Name = "Lista_Venda";
            Lista_Venda.RowTemplate.Height = 25;
            Lista_Venda.Size = new Size(480, 357);
            Lista_Venda.TabIndex = 40;
            // 
            // Adicionar
            // 
            Adicionar.Anchor = AnchorStyles.None;
            Adicionar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Adicionar.Location = new Point(35, 186);
            Adicionar.Name = "Adicionar";
            Adicionar.Size = new Size(121, 44);
            Adicionar.TabIndex = 41;
            Adicionar.Text = "Adicionar";
            Adicionar.UseVisualStyleBackColor = true;
            Adicionar.Click += Adicionar_Click;
            // 
            // Editar
            // 
            Editar.Anchor = AnchorStyles.None;
            Editar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Editar.Location = new Point(35, 236);
            Editar.Name = "Editar";
            Editar.Size = new Size(121, 44);
            Editar.TabIndex = 42;
            Editar.Text = "Editar";
            Editar.UseVisualStyleBackColor = true;
            // 
            // Excluir
            // 
            Excluir.Anchor = AnchorStyles.None;
            Excluir.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Excluir.Location = new Point(35, 286);
            Excluir.Name = "Excluir";
            Excluir.Size = new Size(121, 44);
            Excluir.TabIndex = 43;
            Excluir.Text = "Excluir";
            Excluir.UseVisualStyleBackColor = true;
            Excluir.Click += Excluir_Click;
            // 
            // Historico_de_Vendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Excluir);
            Controls.Add(Editar);
            Controls.Add(Adicionar);
            Controls.Add(Lista_Venda);
            Controls.Add(BtnPesquisar);
            Controls.Add(label9);
            Controls.Add(Pesquisar);
            Name = "Historico_de_Vendas";
            Text = "Historico de Vendas";
            ((System.ComponentModel.ISupportInitialize)Lista_Venda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnPesquisar;
        private Label label9;
        private TextBox Pesquisar;
        private DataGridView Lista_Venda;
        private Button Adicionar;
        private Button Editar;
        private Button Excluir;
    }
}