﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoLipa
{
    public partial class Estoquecs : Form
    {
        public Estoquecs()
        {
            InitializeComponent();
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            Cadastrar_Produto produto = new Cadastrar_Produto();
            produto.Show();
        }
    }
}
