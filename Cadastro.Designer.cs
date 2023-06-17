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
            LblUsuario = new Label();
            LblLogin = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // Nome_Completo
            // 
            Nome_Completo.Location = new Point(221, 144);
            Nome_Completo.Margin = new Padding(3, 2, 3, 2);
            Nome_Completo.Name = "Nome_Completo";
            Nome_Completo.Size = new Size(367, 23);
            Nome_Completo.TabIndex = 0;
            // 
            // Senha
            // 
            Senha.Location = new Point(221, 285);
            Senha.Margin = new Padding(3, 2, 3, 2);
            Senha.Name = "Senha";
            Senha.Size = new Size(367, 23);
            Senha.TabIndex = 1;
            // 
            // Confirma_Senha
            // 
            Confirma_Senha.Location = new Point(221, 371);
            Confirma_Senha.Margin = new Padding(3, 2, 3, 2);
            Confirma_Senha.Name = "Confirma_Senha";
            Confirma_Senha.Size = new Size(367, 23);
            Confirma_Senha.TabIndex = 2;
            // 
            // Btn_Cadastro
            // 
            Btn_Cadastro.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Cadastro.Location = new Point(312, 425);
            Btn_Cadastro.Margin = new Padding(3, 2, 3, 2);
            Btn_Cadastro.Name = "Btn_Cadastro";
            Btn_Cadastro.Size = new Size(174, 59);
            Btn_Cadastro.TabIndex = 3;
            Btn_Cadastro.Text = "Cadastro";
            Btn_Cadastro.UseVisualStyleBackColor = true;
            Btn_Cadastro.Click += Btn_Cadastro_Click;
            // 
            // User
            // 
            User.Location = new Point(221, 213);
            User.Margin = new Padding(3, 2, 3, 2);
            User.Name = "User";
            User.Size = new Size(367, 23);
            User.TabIndex = 4;
            // 
            // LblUsuario
            // 
            LblUsuario.AutoSize = true;
            LblUsuario.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LblUsuario.Location = new Point(221, 94);
            LblUsuario.Name = "LblUsuario";
            LblUsuario.Size = new Size(197, 32);
            LblUsuario.TabIndex = 11;
            LblUsuario.Text = "Nome Completo:";
            LblUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblLogin
            // 
            LblLogin.Anchor = AnchorStyles.Top;
            LblLogin.AutoSize = true;
            LblLogin.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            LblLogin.Location = new Point(268, 9);
            LblLogin.Name = "LblLogin";
            LblLogin.Size = new Size(286, 65);
            LblLogin.TabIndex = 16;
            LblLogin.Text = "Fazer Login";
            LblLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(221, 169);
            label1.Name = "label1";
            label1.Size = new Size(99, 32);
            label1.TabIndex = 17;
            label1.Text = "Usuário:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(221, 238);
            label2.Name = "label2";
            label2.Size = new Size(85, 32);
            label2.TabIndex = 18;
            label2.Text = "Senha:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(221, 322);
            label3.Name = "label3";
            label3.Size = new Size(198, 32);
            label3.TabIndex = 19;
            label3.Text = "Confirmar Senha:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 510);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LblLogin);
            Controls.Add(LblUsuario);
            Controls.Add(User);
            Controls.Add(Btn_Cadastro);
            Controls.Add(Confirma_Senha);
            Controls.Add(Senha);
            Controls.Add(Nome_Completo);
            Margin = new Padding(3, 2, 3, 2);
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
        private Label LblUsuario;
        private Label LblLogin;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}