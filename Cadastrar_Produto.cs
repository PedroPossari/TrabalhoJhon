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
    public partial class Cadastrar_Produto : Form
    {
        public Cadastrar_Produto()
        {
            InitializeComponent();
        }

        private void Altura_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void Largura_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void Peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void Profundiade_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            Produto pro = new Produto();
            if (Nome_Produto.Text == "" || (Profundiade.Text == "" || Profundiade.Text == "404") || (Peso.Text == "" || Peso.Text == "404") || DEscricao.Text == "" || (preco.Text == "" || preco.Text == "404") || (Largura.Text == "404" || Largura.Text == "") || Marca.Text == "" || Condicao.Text == "" || (Altura.Text == "" || Altura.Text == "404"))
            {
                MessageBox.Show("Existem Campos Vazios");
            }
            else 
            {
                if (Profundiade.Text == "" && Peso.Text == "" && preco.Text == "" && Altura.Text == "" && Largura.Text == "")
                {
                    double profundidade = 404;
                    
                }
                else
                {
                    double profundidade = double.Parse(Profundiade.Text);
                    double peso = double.Parse(Peso.Text);
                    double precos = double.Parse(preco.Text);
                    double altura = double.Parse(Altura.Text);
                    double largura = double.Parse(Largura.Text);
                    pro.Profundidade = profundidade;
                    pro.Peso = peso;
                    pro.PrecoVenda = precos;
                    pro.Altura = altura;
                    pro.Largura = largura;
                }
            int quantidade = int.Parse(Quantidade.Text);
            string nome = Nome_Produto.Text;
            Produto? duto = CRUD.BuscarProdutoPorNome(nome);
            if (duto != null)
            {
                MessageBox.Show("Produto Existente");
            }
            else
            {
                pro.Nome = Nome_Produto.Text;
                pro.Descricao = DEscricao.Text;
                pro.Marca = Marca.Text;
                pro.Condicao = Condicao.Text;
                pro.QuantidadeEstoque = pro.QuantidadeEstoque + quantidade;
                CRUD.InserirProduto(pro);
                MessageBox.Show("Foi");
            }   
            }
        }

        private void Mais_Click(object sender, EventArgs e)
        {
            int preço = int.Parse(Quantidade.Text);
            preço = preço + 1;
            Quantidade.Text = preço.ToString();
        }

        private void Menos_Click(object sender, EventArgs e)
        {
            int preço = int.Parse(Quantidade.Text);
            if (preço > 0)
            {
                preço = preço - 1;
                Quantidade.Text = preço.ToString();
            }
            else
            {
                MessageBox.Show("Operação Invalida!");
            }

        }
    }
}