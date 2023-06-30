using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoLipa.Models;

namespace TrabalhoLipa
{
    public partial class Historico_de_Vendas : Form
    {
        public Venda vend;
        public Usuario usi;
        public Historico_de_Vendas(string user)
        {

            InitializeComponent();
            vend = new Venda();
            usi = new Usuario();
            usi.User = user;
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            int pesquisar = int.Parse(Pesquisar.Text);
            string[] Colunas =
            {
                "ID_VENDA",
                "DataVenda",
                "TotalItens",
                "Subtotal",
                "Desconto",
                "ValorTotal",
                "FormaPagamento",
                "Situacao",
                "Observacoes",
                "DataCadastro",
                "ClienteId",
                "UsuarioId"
            };
            foreach (string col in Colunas)
            {
                Lista_Venda.Columns.Add(col, col);
            }
            vend = CRUD.BuscarVendaPorId(pesquisar);
            if (vend != null)
            {
                Lista_Venda.Rows.Clear();
                Lista_Venda.Rows.Add(vend.Id, vend.DataVenda, vend.TotalItens, vend.Subtotal, vend.Desconto,
                    vend.ValorTotal, vend.FormaPagamento, vend.Situacao, vend.Observacoes,
                    vend.DataCadastro, vend.ClienteId, vend.UsuarioId);
            }
            else
            {
                MessageBox.Show("ID invalido!");
            }
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            string usia = usi.User.ToString();
            Registar_Venda venda = new Registar_Venda(usia);
            venda.Show();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            string novoUsuario = usi.User;
            usi = CRUD.BuscarUsuarioPorUser(novoUsuario);
            if (usi.Administrador == "Sim")
            {
                int pesquisar = int.Parse(Pesquisar.Text);
                Venda prod = CRUD.BuscarVendaPorId(pesquisar);
                DialogResult dialogResult = MessageBox.Show("Sim", "Não", MessageBoxButtons.YesNo);
                if (prod != null)
                {
                    if (dialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show("Registro de venda excluido!");
                        CRUD.ExcluirVenda(prod);
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
