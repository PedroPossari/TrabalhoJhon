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
    public partial class Controle_Cliente : Form
    {
        public Controle_Cliente()
        {
            InitializeComponent();
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            int pesquisar = int.Parse(Pesquisar.Text);
            string[] Colunas =
            {
            "ID_Cliente",
            "Nome",
            "Situação",
            "CPF",
            "RG",
            "Gênero",
            "Data Nascimento",
            "Estado Civil",
            "Profissão",
            "Nacionalidade",
            "Email",
            "Observações",
            "Data de Cadastro",
            "Rua",
            "Bairro",
            "Numero",
            "Complemento",
            "CEP",
            "Cidade",
            "UF",
            "Telefone",
            "Celular",
            "É Whatssap"
        };
            foreach (string col in Colunas)
            {
                lista_Cliente.Columns.Add(col, col);
            }
            Cliente clien = CRUD.BuscarClientePorId(pesquisar);
            if (clien != null)
            {

                lista_Cliente.Rows.Clear();
                lista_Cliente.Rows.Add(clien.Id, clien.NomeCompleto, clien.Situacao, clien.Cpf, clien.Rg, clien.Genero,
                    clien.DataNascimento, clien.EstadoCivil, clien.Profissao, clien.Nacionalidade, clien.Email, clien.Observacoes, clien.DataCadastro,
                    clien.Endereco, clien.Bairro, clien.Numero, clien.Complemento, clien.Cep, clien.Cidade, clien.Uf, clien.Telefone, clien.Whatsapp);
                DataGridViewRow row = lista_Cliente.SelectedRows[0];
                clien.Id = Convert.ToInt32(row.Cells[0].Value);
            }
            else
            {
                MessageBox.Show("ID invalido!");
            }
        }
        

        private void Excluir_Click(object sender, EventArgs e)
        {
            int pesquisar = int.Parse(Pesquisar.Text);
            Cliente clien = CRUD.BuscarClientePorId(pesquisar);
            if(clien != null)
            {
                CRUD.ExcluirCliente(clien);
            }
        }
    }
}

