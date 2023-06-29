using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoLipa.Models;

namespace TrabalhoLipa
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        public FormPrincipal(string user)
        {
            InitializeComponent();
            USer.Text = user;
           
        }
        private void label2_Click(object sender, EventArgs e)
        {
            string userr = USer.Text;
            Registar_Venda venda = new Registar_Venda(userr);
            this.Hide();
            venda.ShowDialog();
            this.Show();
        }

        private void AddProduto_Click(object sender, EventArgs e)
        {
            Cadastrar_Produto cadastro = new Cadastrar_Produto();
            this.Hide();
            cadastro.ShowDialog();
            this.Show();
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CadCliente_Click(object sender, EventArgs e)
        {
            Cadastrar_Cliente cliente = new Cadastrar_Cliente();
            this.Hide();
            cliente.ShowDialog();
            this.Show();
        }

        private void CadUser_Click(object sender, EventArgs e)
        {
            Controle_Cliente client = new Controle_Cliente();
            client.Show();
        }

        private void Esto_Click(object sender, EventArgs e)
        {
            Estoquecs estoque = new Estoquecs();
            this.Hide();
            estoque.ShowDialog();
            this.Show();
        }

        private void H_venda_Click(object sender, EventArgs e)
        {
            Historico_de_Vendas venda = new Historico_de_Vendas();
            this.Hide();
            venda.ShowDialog();
            this.Show();
        }
    }
}
