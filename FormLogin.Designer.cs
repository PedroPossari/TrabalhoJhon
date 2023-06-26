namespace TrabalhoLipa
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnEntrar = new Button();
            BoxSenha = new TextBox();
            BoxUsuario = new TextBox();
            LblSenha = new Label();
            LblUsuario = new Label();
            LblLogin = new Label();
            Cadastro = new Button();
            SuspendLayout();
            // 
            // BtnEntrar
            // 
            BtnEntrar.Anchor = AnchorStyles.None;
            BtnEntrar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEntrar.Location = new Point(217, 330);
            BtnEntrar.Name = "BtnEntrar";
            BtnEntrar.Size = new Size(174, 59);
            BtnEntrar.TabIndex = 14;
            BtnEntrar.Text = "Entrar";
            BtnEntrar.UseVisualStyleBackColor = true;
            BtnEntrar.Click += BtnEntrar_Click;
            // 
            // BoxSenha
            // 
            BoxSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BoxSenha.Location = new Point(217, 234);
            BoxSenha.Name = "BoxSenha";
            BoxSenha.Size = new Size(367, 23);
            BoxSenha.TabIndex = 13;
            // 
            // BoxUsuario
            // 
            BoxUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BoxUsuario.Location = new Point(217, 149);
            BoxUsuario.Name = "BoxUsuario";
            BoxUsuario.Size = new Size(367, 23);
            BoxUsuario.TabIndex = 12;
            // 
            // LblSenha
            // 
            LblSenha.AutoSize = true;
            LblSenha.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LblSenha.Location = new Point(217, 199);
            LblSenha.Name = "LblSenha";
            LblSenha.Size = new Size(85, 32);
            LblSenha.TabIndex = 11;
            LblSenha.Text = "Senha:";
            LblSenha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblUsuario
            // 
            LblUsuario.AutoSize = true;
            LblUsuario.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LblUsuario.Location = new Point(217, 114);
            LblUsuario.Name = "LblUsuario";
            LblUsuario.Size = new Size(99, 32);
            LblUsuario.TabIndex = 10;
            LblUsuario.Text = "Usuário:";
            LblUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblLogin
            // 
            LblLogin.Anchor = AnchorStyles.Top;
            LblLogin.AutoSize = true;
            LblLogin.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            LblLogin.Location = new Point(257, 9);
            LblLogin.Name = "LblLogin";
            LblLogin.Size = new Size(286, 65);
            LblLogin.TabIndex = 15;
            LblLogin.Text = "Fazer Login";
            LblLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Cadastro
            // 
            Cadastro.Anchor = AnchorStyles.None;
            Cadastro.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Cadastro.Location = new Point(410, 330);
            Cadastro.Name = "Cadastro";
            Cadastro.Size = new Size(174, 59);
            Cadastro.TabIndex = 16;
            Cadastro.Text = "Cadastro";
            Cadastro.UseVisualStyleBackColor = true;
            Cadastro.Click += Cadastro_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Cadastro);
            Controls.Add(LblLogin);
            Controls.Add(BtnEntrar);
            Controls.Add(BoxSenha);
            Controls.Add(BoxUsuario);
            Controls.Add(LblSenha);
            Controls.Add(LblUsuario);
            Name = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnEntrar;
        private TextBox BoxSenha;
        private TextBox BoxUsuario;
        private Label LblSenha;
        private Label LblUsuario;
        private Label LblLogin;
        private Button Cadastro;
    }
}