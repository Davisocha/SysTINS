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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CmbNivel.DataSource = Nivel.ObterLista();// obj de lista de niveis contendo todos os níveis da tabela Niveis
            CmbNivel.DisplayMember = "Nome";//exiba o nome 
            CmbNivel.ValueMember = "Id"; // se eu escolher o nome vai mostrar o valor do ID

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            Usuario usuario = new(
                TxtNome.Text,
                TxtEmail.Text,
                TxtSenha.Text,
                Nivel.ObterPorId(Convert.ToInt32(CmbNivel.SelectedValue)));
                
            usuario.Inserir();
            if (usuario.Id > 0)
            {
                MessageBox.Show($"Usuário {usuario.Id} inserido com sucesso");
                BtnInserir.Enabled = false;
            }
        }
    }
}
