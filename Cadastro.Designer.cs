namespace TrabalhoLipa
{
    partial class Cadastro
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
            Nome_Completo = new TextBox();
            Senha = new TextBox();
            Confirma_Senha = new TextBox();
            Btn_Cadastro = new Button();
            User = new TextBox();
            SuspendLayout();
            // 
            // Nome_Completo
            // 
            Nome_Completo.Location = new Point(338, 59);
            Nome_Completo.Name = "Nome_Completo";
            Nome_Completo.Size = new Size(125, 27);
            Nome_Completo.TabIndex = 0;
            // 
            // Senha
            // 
            Senha.Location = new Point(338, 168);
            Senha.Name = "Senha";
            Senha.Size = new Size(125, 27);
            Senha.TabIndex = 1;
            // 
            // Confirma_Senha
            // 
            Confirma_Senha.Location = new Point(338, 234);
            Confirma_Senha.Name = "Confirma_Senha";
            Confirma_Senha.Size = new Size(125, 27);
            Confirma_Senha.TabIndex = 2;
            // 
            // Btn_Cadastro
            // 
            Btn_Cadastro.Location = new Point(348, 323);
            Btn_Cadastro.Name = "Btn_Cadastro";
            Btn_Cadastro.Size = new Size(94, 29);
            Btn_Cadastro.TabIndex = 3;
            Btn_Cadastro.Text = "Cadastro";
            Btn_Cadastro.UseVisualStyleBackColor = true;
            Btn_Cadastro.Click += Btn_Cadastro_Click;
            // 
            // User
            // 
            User.Location = new Point(338, 109);
            User.Name = "User";
            User.Size = new Size(125, 27);
            User.TabIndex = 4;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(User);
            Controls.Add(Btn_Cadastro);
            Controls.Add(Confirma_Senha);
            Controls.Add(Senha);
            Controls.Add(Nome_Completo);
            Name = "Cadastro";
            Text = "\\";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Nome_Completo;
        private TextBox Senha;
        private TextBox Confirma_Senha;
        private Button Btn_Cadastro;
        private TextBox User;
    }
}