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
        private int tentativa = 0;
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
                // caso login tenha obtido sucesso!
                Program.usuariologado = usuario;
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                tentativa++;
                if (tentativa < 3)
                {
                
                 lblMensagem.Text = $"Usuario e/ou Senha Inválidos \n Restam {tentativa + 1}/3 tentativas ";
                }
                else
                {
                    lblMensagem.Text = "Número de tentativas de login excedido!";
                    this.DialogResult = DialogResult.No;
                    Close();
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)//btn cancelar
        {
            DialogResult = DialogResult.Cancel; 
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
