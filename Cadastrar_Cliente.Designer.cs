namespace TrabalhoLipa
{
    partial class Cadastrar_Cliente
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
            RG = new TextBox();
            DataNascimento = new TextBox();
            CPF = new TextBox();
            label9 = new Label();
            label8 = new Label();
            preco = new Label();
            label5 = new Label();
            NomeCliente = new TextBox();
            mySqlCommand1 = new MySqlConnector.MySqlCommand();
            Genero = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            EstadoCivil = new ComboBox();
            Profissao = new TextBox();
            Bairro = new TextBox();
            Complemento = new TextBox();
            Numero = new TextBox();
            Cidade = new TextBox();
            Endereco = new TextBox();
            Celular = new TextBox();
            Email = new TextBox();
            Telefone = new TextBox();
            Nacionalidade = new TextBox();
            WhatsApp = new ComboBox();
            CEP = new TextBox();
            UF = new ComboBox();
            Finalizar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(294, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(153, 26);
            label1.TabIndex = 6;
            label1.Text = "Cadastrar Cliente";
            // 
            // RG
            // 
            RG.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RG.Location = new Point(30, 204);
            RG.Name = "RG";
            RG.Size = new Size(115, 23);
            RG.TabIndex = 36;
            RG.KeyPress += RG_KeyPress;
            // 
            // DataNascimento
            // 
            DataNascimento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DataNascimento.Location = new Point(30, 329);
            DataNascimento.Name = "DataNascimento";
            DataNascimento.Size = new Size(133, 23);
            DataNascimento.TabIndex = 35;
            DataNascimento.KeyPress += DataNascimento_KeyPress;
            // 
            // CPF
            // 
            CPF.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CPF.Location = new Point(30, 136);
            CPF.Name = "CPF";
            CPF.Size = new Size(115, 23);
            CPF.TabIndex = 34;
            CPF.KeyPress += CPF_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(30, 40);
            label9.Name = "label9";
            label9.Size = new Size(202, 32);
            label9.TabIndex = 33;
            label9.Text = "Nome do Cliente:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(30, 101);
            label8.Name = "label8";
            label8.Size = new Size(59, 32);
            label8.TabIndex = 32;
            label8.Text = "CPF:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // preco
            // 
            preco.AutoSize = true;
            preco.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            preco.Location = new Point(30, 230);
            preco.Name = "preco";
            preco.Size = new Size(97, 32);
            preco.TabIndex = 31;
            preco.Text = "Gênero:";
            preco.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(30, 169);
            label5.Name = "label5";
            label5.Size = new Size(49, 32);
            label5.TabIndex = 30;
            label5.Text = "RG:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NomeCliente
            // 
            NomeCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NomeCliente.Location = new Point(30, 75);
            NomeCliente.Name = "NomeCliente";
            NomeCliente.Size = new Size(131, 23);
            NomeCliente.TabIndex = 29;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CommandTimeout = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.Transaction = null;
            mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // Genero
            // 
            Genero.FormattingEnabled = true;
            Genero.Items.AddRange(new object[] { "", "Masculino", "Feminino", "Outro" });
            Genero.Location = new Point(30, 268);
            Genero.Name = "Genero";
            Genero.Size = new Size(160, 23);
            Genero.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(294, 40);
            label2.Name = "label2";
            label2.Size = new Size(114, 32);
            label2.TabIndex = 38;
            label2.Text = "Profissão:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 294);
            label3.Name = "label3";
            label3.Size = new Size(236, 32);
            label3.TabIndex = 38;
            label3.Text = "Data de Nascimento:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(30, 355);
            label4.Name = "label4";
            label4.Size = new Size(141, 32);
            label4.TabIndex = 39;
            label4.Text = "Estado Cívil:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(294, 367);
            label6.Name = "label6";
            label6.Size = new Size(118, 32);
            label6.TabIndex = 40;
            label6.Text = "Endereço:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(428, 242);
            label7.Name = "label7";
            label7.Size = new Size(71, 17);
            label7.TabIndex = 41;
            label7.Text = "WhatsApp:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(294, 297);
            label10.Name = "label10";
            label10.Size = new Size(86, 32);
            label10.TabIndex = 42;
            label10.Text = "E-mail:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(294, 230);
            label11.Name = "label11";
            label11.Size = new Size(93, 32);
            label11.TabIndex = 43;
            label11.Text = "Celular:";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(294, 162);
            label12.Name = "label12";
            label12.Size = new Size(111, 32);
            label12.TabIndex = 44;
            label12.Text = "Telefone:";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(513, 367);
            label13.Name = "label13";
            label13.Size = new Size(59, 32);
            label13.TabIndex = 45;
            label13.Text = "CEP:";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(513, 233);
            label15.Name = "label15";
            label15.Size = new Size(93, 32);
            label15.TabIndex = 47;
            label15.Text = "Cidade:";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(513, 297);
            label16.Name = "label16";
            label16.Size = new Size(47, 32);
            label16.TabIndex = 48;
            label16.Text = "UF:";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(513, 162);
            label17.Name = "label17";
            label17.Size = new Size(81, 32);
            label17.TabIndex = 49;
            label17.Text = "Bairro:";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(513, 101);
            label18.Name = "label18";
            label18.Size = new Size(149, 30);
            label18.TabIndex = 50;
            label18.Text = "Complemento:";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(513, 40);
            label19.Name = "label19";
            label19.Size = new Size(107, 32);
            label19.TabIndex = 51;
            label19.Text = "Número:";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(294, 101);
            label20.Name = "label20";
            label20.Size = new Size(171, 32);
            label20.TabIndex = 52;
            label20.Text = "Nacionalidade:";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EstadoCivil
            // 
            EstadoCivil.FormattingEnabled = true;
            EstadoCivil.Items.AddRange(new object[] { "", "Solteiro", "Casado", "Divorciado", "Viúvo" });
            EstadoCivil.Location = new Point(30, 390);
            EstadoCivil.Name = "EstadoCivil";
            EstadoCivil.Size = new Size(160, 23);
            EstadoCivil.TabIndex = 53;
            // 
            // Profissao
            // 
            Profissao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Profissao.Location = new Point(294, 75);
            Profissao.Name = "Profissao";
            Profissao.Size = new Size(131, 23);
            Profissao.TabIndex = 54;
            // 
            // Bairro
            // 
            Bairro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Bairro.Location = new Point(513, 197);
            Bairro.Name = "Bairro";
            Bairro.Size = new Size(131, 23);
            Bairro.TabIndex = 55;
            // 
            // Complemento
            // 
            Complemento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Complemento.Location = new Point(513, 136);
            Complemento.Name = "Complemento";
            Complemento.Size = new Size(131, 23);
            Complemento.TabIndex = 56;
            // 
            // Numero
            // 
            Numero.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Numero.Location = new Point(513, 75);
            Numero.Name = "Numero";
            Numero.Size = new Size(131, 23);
            Numero.TabIndex = 57;
            Numero.KeyPress += Numero_KeyPress;
            // 
            // Cidade
            // 
            Cidade.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Cidade.Location = new Point(513, 268);
            Cidade.Name = "Cidade";
            Cidade.Size = new Size(131, 23);
            Cidade.TabIndex = 58;
            // 
            // Endereco
            // 
            Endereco.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Endereco.Location = new Point(294, 402);
            Endereco.Name = "Endereco";
            Endereco.Size = new Size(131, 23);
            Endereco.TabIndex = 59;
            // 
            // Celular
            // 
            Celular.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Celular.Location = new Point(294, 268);
            Celular.Name = "Celular";
            Celular.Size = new Size(131, 23);
            Celular.TabIndex = 60;
            Celular.KeyPress += Celular_KeyPress;
            // 
            // Email
            // 
            Email.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Email.Location = new Point(294, 332);
            Email.Name = "Email";
            Email.Size = new Size(131, 23);
            Email.TabIndex = 61;
            // 
            // Telefone
            // 
            Telefone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Telefone.Location = new Point(294, 197);
            Telefone.Name = "Telefone";
            Telefone.Size = new Size(131, 23);
            Telefone.TabIndex = 62;
            Telefone.KeyPress += Telefone_KeyPress;
            // 
            // Nacionalidade
            // 
            Nacionalidade.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Nacionalidade.Location = new Point(294, 136);
            Nacionalidade.Name = "Nacionalidade";
            Nacionalidade.Size = new Size(131, 23);
            Nacionalidade.TabIndex = 63;
            // 
            // WhatsApp
            // 
            WhatsApp.FormattingEnabled = true;
            WhatsApp.Items.AddRange(new object[] { "", "Sim", "Não" });
            WhatsApp.Location = new Point(431, 268);
            WhatsApp.Name = "WhatsApp";
            WhatsApp.Size = new Size(68, 23);
            WhatsApp.TabIndex = 64;
            // 
            // CEP
            // 
            CEP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CEP.Location = new Point(513, 402);
            CEP.Name = "CEP";
            CEP.Size = new Size(131, 23);
            CEP.TabIndex = 66;
            CEP.KeyPress += CEP_KeyPress;
            // 
            // UF
            // 
            UF.FormattingEnabled = true;
            UF.Items.AddRange(new object[] { "", "RO", "AC", "AM", "RR", "PA", "AP", "TO", "MA", "PI", "CE", "RN", "PB", "PE", "AL", "SE", "BA", "MG", "ES", "RJ", "SP", "PR", "SC", "RS", "MS", "MT", "GO", "DF" });
            UF.Location = new Point(513, 332);
            UF.Name = "UF";
            UF.Size = new Size(81, 23);
            UF.TabIndex = 67;
            // 
            // Finalizar
            // 
            Finalizar.Anchor = AnchorStyles.None;
            Finalizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Finalizar.Location = new Point(670, 329);
            Finalizar.Name = "Finalizar";
            Finalizar.Size = new Size(118, 52);
            Finalizar.TabIndex = 68;
            Finalizar.Text = "Finalizar Cadastro";
            Finalizar.UseVisualStyleBackColor = true;
            // 
            // Cadastrar_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Finalizar);
            Controls.Add(UF);
            Controls.Add(CEP);
            Controls.Add(WhatsApp);
            Controls.Add(Nacionalidade);
            Controls.Add(Telefone);
            Controls.Add(Email);
            Controls.Add(Celular);
            Controls.Add(Endereco);
            Controls.Add(Cidade);
            Controls.Add(Numero);
            Controls.Add(Complemento);
            Controls.Add(Bairro);
            Controls.Add(Profissao);
            Controls.Add(EstadoCivil);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Genero);
            Controls.Add(RG);
            Controls.Add(DataNascimento);
            Controls.Add(CPF);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(preco);
            Controls.Add(label5);
            Controls.Add(NomeCliente);
            Controls.Add(label1);
            Name = "Cadastrar_Cliente";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox RG;
        private TextBox DataNascimento;
        private TextBox CPF;
        private Label label9;
        private Label label8;
        private Label preco;
        private Label label5;
        private TextBox NomeCliente;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private ComboBox Genero;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private ComboBox EstadoCivil;
        private TextBox Profissao;
        private TextBox Bairro;
        private TextBox Complemento;
        private TextBox Numero;
        private TextBox Cidade;
        private TextBox Endereco;
        private TextBox Celular;
        private TextBox Email;
        private TextBox Telefone;
        private TextBox Nacionalidade;
        private ComboBox WhatsApp;
        private TextBox CEP;
        private ComboBox UF;
        private Button Finalizar;
    }
}