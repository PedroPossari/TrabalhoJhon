namespace TrabalhoLipa
{
    partial class FormPrincipal
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
            label1 = new Label();
            reg_venda = new Label();
            Esto = new Label();
            AddProduto = new Label();
            H_venda = new Label();
            CadCliente = new Label();
            CadUser = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(322, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(220, 74);
            label1.TabIndex = 5;
            label1.Text = "      BEM VIND@!\r\nO que deseja fazer?";
            // 
            // reg_venda
            // 
            reg_venda.BorderStyle = BorderStyle.FixedSingle;
            reg_venda.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            reg_venda.Location = new Point(53, 111);
            reg_venda.Margin = new Padding(4, 0, 4, 0);
            reg_venda.Name = "reg_venda";
            reg_venda.Padding = new Padding(28, 35, 0, 0);
            reg_venda.Size = new Size(170, 97);
            reg_venda.TabIndex = 8;
            reg_venda.Text = "Registrar Venda";
            reg_venda.UseWaitCursor = true;
            reg_venda.Click += label2_Click;
            // 
            // Esto
            // 
            Esto.BorderStyle = BorderStyle.FixedSingle;
            Esto.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Esto.Location = new Point(339, 263);
            Esto.Margin = new Padding(4, 0, 4, 0);
            Esto.Name = "Esto";
            Esto.Padding = new Padding(50, 35, 0, 0);
            Esto.Size = new Size(170, 97);
            Esto.TabIndex = 7;
            Esto.Text = "Estoque";
            // 
            // AddProduto
            // 
            AddProduto.BorderStyle = BorderStyle.FixedSingle;
            AddProduto.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddProduto.Location = new Point(339, 111);
            AddProduto.Margin = new Padding(4, 0, 4, 0);
            AddProduto.Name = "AddProduto";
            AddProduto.Padding = new Padding(23, 35, 0, 0);
            AddProduto.Size = new Size(170, 97);
            AddProduto.TabIndex = 8;
            AddProduto.Text = "Adicionar Produto";
            // 
            // H_venda
            // 
            H_venda.BorderStyle = BorderStyle.FixedSingle;
            H_venda.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            H_venda.Location = new Point(53, 263);
            H_venda.Margin = new Padding(4, 0, 4, 0);
            H_venda.Name = "H_venda";
            H_venda.Padding = new Padding(13, 35, 0, 0);
            H_venda.Size = new Size(170, 97);
            H_venda.TabIndex = 9;
            H_venda.Text = "Histórico de Vendas";
            // 
            // CadCliente
            // 
            CadCliente.BorderStyle = BorderStyle.FixedSingle;
            CadCliente.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CadCliente.Location = new Point(625, 111);
            CadCliente.Margin = new Padding(4, 0, 4, 0);
            CadCliente.Name = "CadCliente";
            CadCliente.Padding = new Padding(25, 35, 0, 0);
            CadCliente.Size = new Size(170, 97);
            CadCliente.TabIndex = 11;
            CadCliente.Text = "Cadastrar Cliente";
            // 
            // CadUser
            // 
            CadUser.BorderStyle = BorderStyle.FixedSingle;
            CadUser.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CadUser.Location = new Point(625, 263);
            CadUser.Margin = new Padding(4, 0, 4, 0);
            CadUser.Name = "CadUser";
            CadUser.Padding = new Padding(20, 35, 0, 0);
            CadUser.Size = new Size(170, 97);
            CadUser.TabIndex = 10;
            CadUser.Text = "Cadastrar Usuário";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 415);
            Controls.Add(CadCliente);
            Controls.Add(CadUser);
            Controls.Add(H_venda);
            Controls.Add(AddProduto);
            Controls.Add(Esto);
            Controls.Add(reg_venda);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormPrincipal";
            Text = "Main";
            FormClosing += Main_FormClosing;
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label reg_venda;
        private System.Windows.Forms.Label Esto;
        private System.Windows.Forms.Label AddProduto;
        private System.Windows.Forms.Label H_venda;
        private System.Windows.Forms.Label CadCliente;
        private System.Windows.Forms.Label CadUser;
    }
}