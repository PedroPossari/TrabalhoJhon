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
    public partial class Registar_Venda : Form
    {
        FormPrincipal principal = new FormPrincipal();
        public Registar_Venda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pesquisar = int.Parse(cliente.Text);
            string produto = nome_produto.Text;
            string descont = Desconto.Text;
            Cliente client = CRUD.BuscarClientePorId(pesquisar);
            Produto? Prod = CRUD.BuscarProdutoPorNome(produto);
            Venda venda1 = new Venda();
            ItemVenda itemVenda = new ItemVenda();
            Produto produto1 = new Produto();
            if(nome_produto.Text != "")
            {
               
            }
           

        }
        private void Desconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void Adicionar_Prod_Click(object sender, EventArgs e)
        {
            string user = cliente.Text;
            string produto = nome_produto.Text;
            string descont = Desconto.Text;
            Usuario? client = CRUD.BuscarUsuarioPorUser(user);
            Produto? Prod = CRUD.BuscarProdutoPorNome(produto);
            if (client != null)
            {
                if (client.User == user)
                {
                    if (Prod != null)
                    {
                        this.dataGridView1.Rows.Add(client.User, Prod.Nome, descont);



                    }
                }
            }

        }
    }
}
