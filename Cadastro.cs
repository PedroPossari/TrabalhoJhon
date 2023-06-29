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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Btn_Cadastro_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            if (Nome_Completo.Text != "" && Senha.Text != "" && Confirma_Senha.Text != "" && User.Text != "")
            {
                if (Confirma_Senha.Text == Senha.Text)
                {
                    user.NomeCompleto = Nome_Completo.Text;
                    user.User = User.Text;
                    user.Senha = Senha.Text;

                    CRUD.InserirUsuario(user);

                    MessageBox.Show("Usuario cadastrado com Sucesso!");

                    FormLogin formLogin = new FormLogin();
                    formLogin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("A senha não corresponde!");
                }

            }
            else
            {
                MessageBox.Show("Usuário ou Senha não estão preenchidos!");
            }

        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            FormLogin Login = new FormLogin();
            Login.Show();
            this.Hide();
        }
    }
}
