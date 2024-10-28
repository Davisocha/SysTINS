using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysTINSClass;

namespace SysTINSApp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//btn entrar
        {
            //colocar a validação de login
            var usuario = Usuario.EfetuarLogin(txtEmail.Text, txtSenha.Text);
            if (usuario.Id > 0)
            {
            Close();
            }
            else
            {
                lblMensagem.Text = "Usuario e/ou Senha Inválidos";
            }
        }

        private void button2_Click(object sender, EventArgs e)//btn cancelar
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)//txtbox email
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)//txt senha
        {

        }
    }
}
