using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class Cadastrar_Cliente : Form
    {
        public Cadastrar_Cliente()
        {
            InitializeComponent();
        }

        private void CPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void RG_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void DataNascimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void Telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void Celular_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void CEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void Finalizar_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            cli.NomeCompleto = NomeCliente.Text;
            cli.Profissao = Profissao.Text;
            int numeros = int.Parse(Numeros.Text);
            cli.Numero = numeros;
            cli.Cpf = CPF.Text;
            cli.Nacionalidade = Nacionalidade.Text;
            cli.Complemento = Complemento.Text;
            cli.Rg = RG.Text;
            cli.Telefone = Telefone.Text;
            cli.Bairro = Bairro.Text;
            cli.Genero = Genero.Text;
            cli.Celular = Celular.Text;
            if (WhatsApp.Checked)
            {
                cli.Whatsapp = true;
            }
            else { cli.Whatsapp = false; }
            cli.Cidade = Cidade.Text;
            cli.DataNascimento = data_de_nascimento.Value;
            cli.Email = Email.Text;
            cli.Uf =
            cli.Cep = CEP.Text;

        }
    }
}
