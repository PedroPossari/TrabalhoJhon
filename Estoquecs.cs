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
    public partial class Estoquecs : Form
    {
        public Usuario usuario;
        public Estoquecs(string user)
        {
            InitializeComponent();
            usuario = new Usuario();
            usuario.User = user;
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            Cadastrar_Produto produto = new Cadastrar_Produto();
            produto.Show();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisar = Pesquisar.Text;
            string[] Colunas =
            {

            "Id",       "Nome",       "Descricao",         "CodigoBarras", "Marca",
            "Peso",     "Largura",    "Altura",            "Profundidade", "Situacao",
            "Condicao", "PrecoVenda", "QuantidadeEstoque", "DataCadastro"

            };

            foreach (string col in Colunas)
            {
                Lista_Produtos.Columns.Add(col, col);
            }
            Produto prod = CRUD.BuscarProdutoPorNome(pesquisar);
            if (prod != null)
            {
                Lista_Produtos.Rows.Clear();
                Lista_Produtos.Rows.Add(
                    prod.Id, prod.Nome, prod.Descricao, prod.QuantidadeEstoque, prod.Marca,
                    prod.Peso, prod.Largura, prod.Altura, prod.Profundidade, prod.Situacao,
                    prod.Condicao, prod.PrecoVenda, prod.QuantidadeEstoque, prod.DataCadastro);

            }
            else
            {
                MessageBox.Show("Nome não foi encontrado!");
            }
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            string novoUsuario = usuario.User;
            usuario = CRUD.BuscarUsuarioPorUser(novoUsuario);
            if (usuario.Administrador == "Sim")
            {
                string pesquisar = Pesquisar.Text;
                Produto prod = CRUD.BuscarProdutoPorNome(pesquisar);
                DialogResult dialogResult = MessageBox.Show("Sim", "Não", MessageBoxButtons.YesNo);
                if (prod != null)
                {
                    if (dialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show("Produto excluido!");
                        CRUD.ExcluirProduto(prod);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Ação cancelada");
                    }
                }
            }
            else
            {
                MessageBox.Show("Ação negada");
            }
        }
    }
}

