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
            Condicao = new TextBox();
            textBox3 = new TextBox();
            Marca = new TextBox();
            label9 = new Label();
            label8 = new Label();
            preco = new Label();
            label5 = new Label();
            Nome_Produto = new TextBox();
            mySqlCommand1 = new MySqlConnector.MySqlCommand();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
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
            // Condicao
            // 
            Condicao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Condicao.Location = new Point(30, 204);
            Condicao.Name = "Condicao";
            Condicao.Size = new Size(115, 23);
            Condicao.TabIndex = 36;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(30, 329);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(133, 23);
            textBox3.TabIndex = 35;
            // 
            // Marca
            // 
            Marca.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Marca.Location = new Point(30, 136);
            Marca.Name = "Marca";
            Marca.Size = new Size(115, 23);
            Marca.TabIndex = 34;
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
            // Nome_Produto
            // 
            Nome_Produto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Nome_Produto.Location = new Point(30, 75);
            Nome_Produto.Name = "Nome_Produto";
            Nome_Produto.Size = new Size(131, 23);
            Nome_Produto.TabIndex = 29;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CommandTimeout = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.Transaction = null;
            mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Masculino", "Feminino", "Outro" });
            comboBox1.Location = new Point(30, 268);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(160, 23);
            comboBox1.TabIndex = 37;
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
            label6.Location = new Point(646, 233);
            label6.Name = "label6";
            label6.Size = new Size(97, 32);
            label6.TabIndex = 40;
            label6.Text = "Gênero:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(654, 241);
            label7.Name = "label7";
            label7.Size = new Size(97, 32);
            label7.TabIndex = 41;
            label7.Text = "Gênero:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(662, 249);
            label10.Name = "label10";
            label10.Size = new Size(97, 32);
            label10.TabIndex = 42;
            label10.Text = "Gênero:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(670, 257);
            label11.Name = "label11";
            label11.Size = new Size(97, 32);
            label11.TabIndex = 43;
            label11.Text = "Gênero:";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(294, 162);
            label12.Name = "label12";
            label12.Size = new Size(97, 32);
            label12.TabIndex = 44;
            label12.Text = "Gênero:";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(552, 297);
            label13.Name = "label13";
            label13.Size = new Size(97, 32);
            label13.TabIndex = 45;
            label13.Text = "Gênero:";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(560, 305);
            label14.Name = "label14";
            label14.Size = new Size(97, 32);
            label14.TabIndex = 46;
            label14.Text = "Gênero:";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(568, 313);
            label15.Name = "label15";
            label15.Size = new Size(97, 32);
            label15.TabIndex = 47;
            label15.Text = "Gênero:";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(576, 321);
            label16.Name = "label16";
            label16.Size = new Size(97, 32);
            label16.TabIndex = 48;
            label16.Text = "Gênero:";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(584, 329);
            label17.Name = "label17";
            label17.Size = new Size(97, 32);
            label17.TabIndex = 49;
            label17.Text = "Gênero:";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(592, 337);
            label18.Name = "label18";
            label18.Size = new Size(97, 32);
            label18.TabIndex = 50;
            label18.Text = "Gênero:";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(600, 345);
            label19.Name = "label19";
            label19.Size = new Size(97, 32);
            label19.TabIndex = 51;
            label19.Text = "Gênero:";
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
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Solteiro", "Casado", "Divorciado", "Viúvo" });
            comboBox2.Location = new Point(30, 390);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(160, 23);
            comboBox2.TabIndex = 53;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(294, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(131, 23);
            textBox1.TabIndex = 54;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(548, 37);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(131, 23);
            textBox2.TabIndex = 55;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(556, 45);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(131, 23);
            textBox4.TabIndex = 56;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox5.Location = new Point(564, 53);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(131, 23);
            textBox5.TabIndex = 57;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox6.Location = new Point(572, 61);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(131, 23);
            textBox6.TabIndex = 58;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox7.Location = new Point(580, 69);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(131, 23);
            textBox7.TabIndex = 59;
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox8.Location = new Point(588, 77);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(131, 23);
            textBox8.TabIndex = 60;
            // 
            // textBox9
            // 
            textBox9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox9.Location = new Point(596, 85);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(131, 23);
            textBox9.TabIndex = 61;
            // 
            // textBox10
            // 
            textBox10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox10.Location = new Point(604, 93);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(131, 23);
            textBox10.TabIndex = 62;
            // 
            // textBox11
            // 
            textBox11.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox11.Location = new Point(294, 136);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(131, 23);
            textBox11.TabIndex = 63;
            // 
            // Cadastrar_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(Condicao);
            Controls.Add(textBox3);
            Controls.Add(Marca);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(preco);
            Controls.Add(label5);
            Controls.Add(Nome_Produto);
            Controls.Add(label1);
            Name = "Cadastrar_Cliente";
            Text = "Cadastrar_Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Condicao;
        private TextBox textBox3;
        private TextBox Marca;
        private Label label9;
        private Label label8;
        private Label preco;
        private Label label5;
        private TextBox Nome_Produto;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
    }
}