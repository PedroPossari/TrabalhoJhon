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
            BtnEntrar.Location = new Point(248, 384);
            BtnEntrar.Margin = new Padding(3, 4, 3, 4);
            BtnEntrar.Name = "BtnEntrar";
            BtnEntrar.Size = new Size(193, 79);
            BtnEntrar.TabIndex = 14;
            BtnEntrar.Text = "Entrar";
            BtnEntrar.UseVisualStyleBackColor = true;
            BtnEntrar.Click += BtnEntrar_Click;
            // 
            // BoxSenha
            // 
            BoxSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BoxSenha.Location = new Point(248, 312);
            BoxSenha.Margin = new Padding(3, 4, 3, 4);
            BoxSenha.Name = "BoxSenha";
            BoxSenha.Size = new Size(419, 27);
            BoxSenha.TabIndex = 13;
            // 
            // BoxUsuario
            // 
            BoxUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BoxUsuario.Location = new Point(248, 199);
            BoxUsuario.Margin = new Padding(3, 4, 3, 4);
            BoxUsuario.Name = "BoxUsuario";
            BoxUsuario.Size = new Size(419, 27);
            BoxUsuario.TabIndex = 12;
            // 
            // LblSenha
            // 
            LblSenha.AutoSize = true;
            LblSenha.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LblSenha.Location = new Point(248, 265);
            LblSenha.Name = "LblSenha";
            LblSenha.Size = new Size(106, 41);
            LblSenha.TabIndex = 11;
            LblSenha.Text = "Senha:";
            LblSenha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblUsuario
            // 
            LblUsuario.AutoSize = true;
            LblUsuario.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LblUsuario.Location = new Point(248, 152);
            LblUsuario.Name = "LblUsuario";
            LblUsuario.Size = new Size(126, 41);
            LblUsuario.TabIndex = 10;
            LblUsuario.Text = "Usuário:";
            LblUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblLogin
            // 
            LblLogin.Anchor = AnchorStyles.Top;
            LblLogin.AutoSize = true;
            LblLogin.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            LblLogin.Location = new Point(258, 32);
            LblLogin.Name = "LblLogin";
            LblLogin.Size = new Size(400, 81);
            LblLogin.TabIndex = 15;
            LblLogin.Text = "Ralizar Login";
            LblLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Cadastro
            // 
            Cadastro.Anchor = AnchorStyles.None;
            Cadastro.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Cadastro.Location = new Point(474, 384);
            Cadastro.Margin = new Padding(3, 4, 3, 4);
            Cadastro.Name = "Cadastro";
            Cadastro.Size = new Size(193, 79);
            Cadastro.TabIndex = 16;
            Cadastro.Text = "Cadastrar";
            Cadastro.UseVisualStyleBackColor = true;
            Cadastro.Click += Cadastro_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(Cadastro);
            Controls.Add(LblLogin);
            Controls.Add(BtnEntrar);
            Controls.Add(BoxSenha);
            Controls.Add(BoxUsuario);
            Controls.Add(LblSenha);
            Controls.Add(LblUsuario);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormLogin";
            Text = "FormLogin";
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