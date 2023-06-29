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
        public Venda vend;
        public Produto prod;
        public ItemVenda item;
        public Registar_Venda(string user)
        {
            
            InitializeComponent();
            vend = new Venda();
            prod = new Produto();
            item = new ItemVenda();
            vend.Usuario = CRUD.BuscarUsuarioPorUser(user);
        }
            private void Desconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //double desconto = double.Parse(Desconto.Text);
            //vend.ValorTotal = prod.PrecoVenda * - desconto;
            //vend.Desconto = desconto;

        }
        






        private void Adicionar_Prod_Click(object sender, EventArgs e)
        {
            string produto = nome_produto.Text;
            

            prod = CRUD.BuscarProdutoPorNome(produto);

          

            int quantidade = int.Parse(Qauntidade.Text);

            if (quantidade <= prod.QuantidadeEstoque)
            {
               
                item.Quantidade = quantidade;
                item.Produto = prod;
                vend.Itemvenda.Add(item);
            }
            else
            {
                MessageBox.Show("A quantidade ultrapassou o estoque!");
            }
            
            

        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            double desconto = double.Parse(Desconto.Text);
            int descontin = int.Parse(Desconto.Text);
            vend.Desconto = desconto;
            if (cliente.Text == "" || Observacao.Text == "" || Situacao.Text == "" ||
                Forma_de_pagamento.Text == "")
            {
                MessageBox.Show("Existem Campos Vazios");
            }
            else
            {
                int quant = int.Parse(Qauntidade.Text);
                string nome = cliente.Text;
                string obs = Observacao.Text;
                string situ = Situacao.Text;
                string formapa = Forma_de_pagamento.Text;
                vend.ValorTotal = (prod.PrecoVenda * quant) - desconto;
                vend.FormaPagamento = formapa;
                vend.Observacoes = obs;
                vend.Situacao = situ;
                vend.Desconto = desconto;
                vend.Subtotal = prod.PrecoVenda;
                prod.QuantidadeEstoque = prod.QuantidadeEstoque - quant;
                vend.Cliente = CRUD.BuscarClientePorNome(nome);
                CRUD.AlterarProduto(prod);

                CRUD.InserirVenda(vend);
                MessageBox.Show("Venda inserida");
            }
        }
    }
}
