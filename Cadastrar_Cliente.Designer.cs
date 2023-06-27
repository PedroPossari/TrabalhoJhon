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
            Numeros = new TextBox();
            Cidade = new TextBox();
            Endereco = new TextBox();
            Celular = new TextBox();
            Email = new TextBox();
            Telefone = new TextBox();
            Nacionalidade = new TextBox();
            CEP = new TextBox();
            UF = new ComboBox();
            Finalizar = new Button();
            WhatsApp = new CheckBox();
            data_de_nascimento = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(336, 12);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(175, 35);
            label1.TabIndex = 6;
            label1.Text = "Cadastrar Cliente";
            // 
            // RG
            // 
            RG.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RG.Location = new Point(34, 272);
            RG.Margin = new Padding(3, 4, 3, 4);
            RG.Name = "RG";
            RG.Size = new Size(131, 27);
            RG.TabIndex = 36;
            RG.KeyPress += RG_KeyPress;
            // 
            // CPF
            // 
            CPF.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CPF.Location = new Point(34, 181);
            CPF.Margin = new Padding(3, 4, 3, 4);
            CPF.Name = "CPF";
            CPF.Size = new Size(131, 27);
            CPF.TabIndex = 34;
            CPF.KeyPress += CPF_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(34, 53);
            label9.Name = "label9";
            label9.Size = new Size(251, 41);
            label9.TabIndex = 33;
            label9.Text = "Nome do Cliente:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(34, 135);
            label8.Name = "label8";
            label8.Size = new Size(76, 41);
            label8.TabIndex = 32;
            label8.Text = "CPF:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // preco
            // 
            preco.AutoSize = true;
            preco.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            preco.Location = new Point(34, 307);
            preco.Name = "preco";
            preco.Size = new Size(123, 41);
            preco.TabIndex = 31;
            preco.Text = "Gênero:";
            preco.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(34, 225);
            label5.Name = "label5";
            label5.Size = new Size(64, 41);
            label5.TabIndex = 30;
            label5.Text = "RG:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NomeCliente
            // 
            NomeCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NomeCliente.Location = new Point(34, 100);
            NomeCliente.Margin = new Padding(3, 4, 3, 4);
            NomeCliente.Name = "NomeCliente";
            NomeCliente.Size = new Size(149, 27);
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
            Genero.Location = new Point(34, 357);
            Genero.Margin = new Padding(3, 4, 3, 4);
            Genero.Name = "Genero";
            Genero.Size = new Size(182, 28);
            Genero.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(336, 53);
            label2.Name = "label2";
            label2.Size = new Size(145, 41);
            label2.TabIndex = 38;
            label2.Text = "Profissão:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(34, 392);
            label3.Name = "label3";
            label3.Size = new Size(294, 41);
            label3.TabIndex = 38;
            label3.Text = "Data de Nascimento:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(34, 473);
            label4.Name = "label4";
            label4.Size = new Size(176, 41);
            label4.TabIndex = 39;
            label4.Text = "Estado Cívil:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(336, 489);
            label6.Name = "label6";
            label6.Size = new Size(149, 41);
            label6.TabIndex = 40;
            label6.Text = "Endereço:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(489, 323);
            label7.Name = "label7";
            label7.Size = new Size(93, 23);
            label7.TabIndex = 41;
            label7.Text = "WhatsApp:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(336, 396);
            label10.Name = "label10";
            label10.Size = new Size(107, 41);
            label10.TabIndex = 42;
            label10.Text = "E-mail:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(336, 307);
            label11.Name = "label11";
            label11.Size = new Size(116, 41);
            label11.TabIndex = 43;
            label11.Text = "Celular:";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(336, 216);
            label12.Name = "label12";
            label12.Size = new Size(137, 41);
            label12.TabIndex = 44;
            label12.Text = "Telefone:";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(586, 489);
            label13.Name = "label13";
            label13.Size = new Size(76, 41);
            label13.TabIndex = 45;
            label13.Text = "CEP:";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(586, 311);
            label15.Name = "label15";
            label15.Size = new Size(118, 41);
            label15.TabIndex = 47;
            label15.Text = "Cidade:";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(586, 396);
            label16.Name = "label16";
            label16.Size = new Size(61, 41);
            label16.TabIndex = 48;
            label16.Text = "UF:";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(586, 216);
            label17.Name = "label17";
            label17.Size = new Size(102, 41);
            label17.TabIndex = 49;
            label17.Text = "Bairro:";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(586, 135);
            label18.Name = "label18";
            label18.Size = new Size(193, 37);
            label18.TabIndex = 50;
            label18.Text = "Complemento:";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(586, 53);
            label19.Name = "label19";
            label19.Size = new Size(134, 41);
            label19.TabIndex = 51;
            label19.Text = "Número:";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(336, 135);
            label20.Name = "label20";
            label20.Size = new Size(214, 41);
            label20.TabIndex = 52;
            label20.Text = "Nacionalidade:";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EstadoCivil
            // 
            EstadoCivil.FormattingEnabled = true;
            EstadoCivil.Items.AddRange(new object[] { "", "Solteiro", "Casado", "Divorciado", "Viúvo" });
            EstadoCivil.Location = new Point(34, 520);
            EstadoCivil.Margin = new Padding(3, 4, 3, 4);
            EstadoCivil.Name = "EstadoCivil";
            EstadoCivil.Size = new Size(182, 28);
            EstadoCivil.TabIndex = 53;
            // 
            // Profissao
            // 
            Profissao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Profissao.Location = new Point(336, 100);
            Profissao.Margin = new Padding(3, 4, 3, 4);
            Profissao.Name = "Profissao";
            Profissao.Size = new Size(149, 27);
            Profissao.TabIndex = 54;
            // 
            // Bairro
            // 
            Bairro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Bairro.Location = new Point(586, 263);
            Bairro.Margin = new Padding(3, 4, 3, 4);
            Bairro.Name = "Bairro";
            Bairro.Size = new Size(149, 27);
            Bairro.TabIndex = 55;
            // 
            // Complemento
            // 
            Complemento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Complemento.Location = new Point(586, 181);
            Complemento.Margin = new Padding(3, 4, 3, 4);
            Complemento.Name = "Complemento";
            Complemento.Size = new Size(149, 27);
            Complemento.TabIndex = 56;
            // 
            // Numeros
            // 
            Numeros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Numeros.Location = new Point(586, 100);
            Numeros.Margin = new Padding(3, 4, 3, 4);
            Numeros.Name = "Numeros";
            Numeros.Size = new Size(149, 27);
            Numeros.TabIndex = 57;
            Numeros.KeyPress += Numero_KeyPress;
            // 
            // Cidade
            // 
            Cidade.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Cidade.Location = new Point(586, 357);
            Cidade.Margin = new Padding(3, 4, 3, 4);
            Cidade.Name = "Cidade";
            Cidade.Size = new Size(149, 27);
            Cidade.TabIndex = 58;
            // 
            // Endereco
            // 
            Endereco.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Endereco.Location = new Point(336, 536);
            Endereco.Margin = new Padding(3, 4, 3, 4);
            Endereco.Name = "Endereco";
            Endereco.Size = new Size(149, 27);
            Endereco.TabIndex = 59;
            // 
            // Celular
            // 
            Celular.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Celular.Location = new Point(336, 357);
            Celular.Margin = new Padding(3, 4, 3, 4);
            Celular.Name = "Celular";
            Celular.Size = new Size(149, 27);
            Celular.TabIndex = 60;
            Celular.KeyPress += Celular_KeyPress;
            // 
            // Email
            // 
            Email.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Email.Location = new Point(336, 443);
            Email.Margin = new Padding(3, 4, 3, 4);
            Email.Name = "Email";
            Email.Size = new Size(149, 27);
            Email.TabIndex = 61;
            // 
            // Telefone
            // 
            Telefone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Telefone.Location = new Point(336, 263);
            Telefone.Margin = new Padding(3, 4, 3, 4);
            Telefone.Name = "Telefone";
            Telefone.Size = new Size(149, 27);
            Telefone.TabIndex = 62;
            Telefone.KeyPress += Telefone_KeyPress;
            // 
            // Nacionalidade
            // 
            Nacionalidade.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Nacionalidade.Location = new Point(336, 181);
            Nacionalidade.Margin = new Padding(3, 4, 3, 4);
            Nacionalidade.Name = "Nacionalidade";
            Nacionalidade.Size = new Size(149, 27);
            Nacionalidade.TabIndex = 63;
            // 
            // CEP
            // 
            CEP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CEP.Location = new Point(586, 536);
            CEP.Margin = new Padding(3, 4, 3, 4);
            CEP.Name = "CEP";
            CEP.Size = new Size(149, 27);
            CEP.TabIndex = 66;
            CEP.KeyPress += CEP_KeyPress;
            // 
            // UF
            // 
            UF.FormattingEnabled = true;
            UF.Items.AddRange(new object[] { "", "RO", "AC", "AM", "RR", "PA", "AP", "TO", "MA", "PI", "CE", "RN", "PB", "PE", "AL", "SE", "BA", "MG", "ES", "RJ", "SP", "PR", "SC", "RS", "MS", "MT", "GO", "DF" });
            UF.Location = new Point(586, 443);
            UF.Margin = new Padding(3, 4, 3, 4);
            UF.Name = "UF";
            UF.Size = new Size(92, 28);
            UF.TabIndex = 67;
            // 
            // Finalizar
            // 
            Finalizar.Anchor = AnchorStyles.None;
            Finalizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Finalizar.Location = new Point(767, 489);
            Finalizar.Margin = new Padding(3, 4, 3, 4);
            Finalizar.Name = "Finalizar";
            Finalizar.Size = new Size(135, 69);
            Finalizar.TabIndex = 68;
            Finalizar.Text = "Finalizar Cadastro";
            Finalizar.UseVisualStyleBackColor = true;
            Finalizar.Click += Finalizar_Click;
            // 
            // WhatsApp
            // 
            WhatsApp.AutoSize = true;
            WhatsApp.Location = new Point(504, 356);
            WhatsApp.Name = "WhatsApp";
            WhatsApp.Size = new Size(18, 17);
            WhatsApp.TabIndex = 69;
            WhatsApp.UseVisualStyleBackColor = true;
            // 
            // data_de_nascimento
            // 
            data_de_nascimento.Location = new Point(43, 441);
            data_de_nascimento.Name = "data_de_nascimento";
            data_de_nascimento.Size = new Size(250, 27);
            data_de_nascimento.TabIndex = 70;
            // 
            // Cadastrar_Cliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(data_de_nascimento);
            Controls.Add(WhatsApp);
            Controls.Add(Finalizar);
            Controls.Add(UF);
            Controls.Add(CEP);
            Controls.Add(Nacionalidade);
            Controls.Add(Telefone);
            Controls.Add(Email);
            Controls.Add(Celular);
            Controls.Add(Endereco);
            Controls.Add(Cidade);
            Controls.Add(Numeros);
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
            Controls.Add(CPF);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(preco);
            Controls.Add(label5);
            Controls.Add(NomeCliente);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Cadastrar_Cliente";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox RG;
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
        private TextBox Numeros;
        private TextBox Cidade;
        private TextBox Endereco;
        private TextBox Celular;
        private TextBox Email;
        private TextBox Telefone;
        private TextBox Nacionalidade;
        private TextBox CEP;
        private ComboBox UF;
        private Button Finalizar;
        private CheckBox WhatsApp;
        private DateTimePicker data_de_nascimento;
    }
}