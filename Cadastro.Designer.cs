﻿namespace TrabalhoLipa
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
            Nome_Completo.Location = new Point(253, 192);
            Nome_Completo.Name = "Nome_Completo";
            Nome_Completo.Size = new Size(419, 27);
            Nome_Completo.TabIndex = 0;
            // 
            // Senha
            // 
            Senha.Location = new Point(253, 380);
            Senha.Name = "Senha";
            Senha.Size = new Size(419, 27);
            Senha.TabIndex = 1;
            // 
            // Confirma_Senha
            // 
            Confirma_Senha.Location = new Point(253, 495);
            Confirma_Senha.Name = "Confirma_Senha";
            Confirma_Senha.Size = new Size(419, 27);
            Confirma_Senha.TabIndex = 2;
            // 
            // Btn_Cadastro
            // 
            Btn_Cadastro.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Cadastro.Location = new Point(357, 567);
            Btn_Cadastro.Name = "Btn_Cadastro";
            Btn_Cadastro.Size = new Size(199, 79);
            Btn_Cadastro.TabIndex = 3;
            Btn_Cadastro.Text = "Cadastro";
            Btn_Cadastro.UseVisualStyleBackColor = true;
            Btn_Cadastro.Click += Btn_Cadastro_Click;
            // 
            // User
            // 
            User.Location = new Point(253, 284);
            User.Name = "User";
            User.Size = new Size(419, 27);
            User.TabIndex = 4;
            // 
            // LblUsuario
            // 
            LblUsuario.AutoSize = true;
            LblUsuario.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LblUsuario.Location = new Point(253, 125);
            LblUsuario.Name = "LblUsuario";
            LblUsuario.Size = new Size(247, 41);
            LblUsuario.TabIndex = 11;
            LblUsuario.Text = "Nome Completo:";
            LblUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblLogin
            // 
            LblLogin.Anchor = AnchorStyles.Top;
            LblLogin.AutoSize = true;
            LblLogin.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            LblLogin.Location = new Point(306, 12);
            LblLogin.Name = "LblLogin";
            LblLogin.Size = new Size(283, 81);
            LblLogin.TabIndex = 16;
            LblLogin.Text = "Cadastro";
            LblLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(253, 225);
            label1.Name = "label1";
            label1.Size = new Size(126, 41);
            label1.TabIndex = 17;
            label1.Text = "Usuário:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(253, 317);
            label2.Name = "label2";
            label2.Size = new Size(106, 41);
            label2.TabIndex = 18;
            label2.Text = "Senha:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(253, 429);
            label3.Name = "label3";
            label3.Size = new Size(245, 41);
            label3.TabIndex = 19;
            label3.Text = "Confirmar Senha:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 680);
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