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
        public Usuario usuario;
        public Controle_Cliente(string user)
        {
            InitializeComponent();
            usuario = new Usuario();
            usuario.User = user;
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
                lista_Cliente.Rows.Add(
                    clien.Id, clien.NomeCompleto, clien.Situacao, clien.Cpf, clien.Rg,
                    clien.Genero, clien.DataNascimento, clien.EstadoCivil, clien.Profissao, clien.Nacionalidade,
                    clien.Email, clien.Observacoes, clien.DataCadastro, clien.Endereco, clien.Bairro,
                    clien.Numero, clien.Complemento, clien.Cep, clien.Cidade, clien.Uf,
                    clien.Telefone, clien.Whatsapp);

            }
            else
            {
                MessageBox.Show("ID invalido!");
            }
        }


        private void Excluir_Click(object sender, EventArgs e)
        {
            string novoUsuario = usuario.User;
            usuario = CRUD.BuscarUsuarioPorUser(novoUsuario);
            if(usuario.Administrador == "Sim")
            {
                int pesquisar = int.Parse(Pesquisar.Text);
                Cliente clien = CRUD.BuscarClientePorId(pesquisar);
                if (clien != null)
                {
                    MessageBox.Show("Cliente excluído com sucesso!");
                    CRUD.ExcluirCliente(clien);
                }
            }
            else
            {
                MessageBox.Show("Ação negada");
            }
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            int pesquisar = int.Parse(Pesquisar.Text);
            Cliente clien = CRUD.BuscarClientePorId(pesquisar);

            DataGridViewRow row = lista_Cliente.SelectedRows[1];
            if (row != null)
            {
                clien.Id = Convert.ToInt32(row.Cells[0].Value);
                clien.NomeCompleto = row.Cells[1].Value.ToString();
                clien.Situacao = row.Cells[2].Value.ToString();
                clien.Cpf = row.Cells[3].Value.ToString();
                clien.Rg = row.Cells[4].Value.ToString();
                clien.Genero = row.Cells[5].Value.ToString();
                clien.EstadoCivil = row.Cells[6].Value.ToString();
                clien.Profissao = row.Cells[8].Value.ToString();
                clien.Nacionalidade = row.Cells[9].Value.ToString();
                clien.Email = row.Cells[10].Value.ToString();
                clien.Observacoes = row.Cells[11].Value.ToString();
                clien.Endereco = row.Cells[12].Value.ToString();
                clien.Bairro = row.Cells[13].Value.ToString();
                clien.Numero = Convert.ToInt32(row.Cells[14].Value);
                clien.Complemento = row.Cells[15].Value.ToString();
                clien.Cep = row.Cells[16].Value.ToString();
                clien.Cidade = row.Cells[17].Value.ToString();
                clien.Uf = row.Cells[18].Value.ToString();
                clien.Telefone = row.Cells[19].Value.ToString();
            }
            CRUD.AlterarCliente(clien);
        }
    }
}

