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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            string user = BoxUsuario.Text;
            string pass = BoxSenha.Text;
            Usuario? login = CRUD.BuscarUsuarioPorUser(user);
            if (login != null)
            {
                if (login.Senha == pass)
                {
                    FormPrincipal formPrincipal = new FormPrincipal();
                    formPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha inválidos!");
                }
            }
            else
            {
                MessageBox.Show("Usuário ou Senha inválidos!");
            }
        }
    }
}