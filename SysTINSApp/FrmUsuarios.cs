using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
            //carregando o datagrid de usúarios
            CarregaGridUsuarios();
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
                //carrega grid
                CarregaGridUsuarios();
                MessageBox.Show($"Usuário {usuario.Nome} inserido com sucesso");
                BtnInserir.Enabled = false;
            }
        }
        private void CarregaGridUsuarios()
        {
            dgvUsuarios.Rows.Clear();
            var ListadeDeUsuario = Usuario.ObterLista();
            int linha = 0;
            foreach (var Usuario in ListadeDeUsuario)// para cada usuario dentro da lista de usuarios faça
            {
                dgvUsuarios.Rows.Add();//para cada usuarios adicione uma linha 
                dgvUsuarios.Rows[linha].Cells[0].Value = Usuario.Id;// na linhas [linha que vale na posição 0] que cells[ posição da coluna 0] que tem o value de usuario.Id ou seja id do usuario
                dgvUsuarios.Rows[linha].Cells[1].Value = Usuario.Nome;
                dgvUsuarios.Rows[linha].Cells[2].Value = Usuario.Email;
                dgvUsuarios.Rows[linha].Cells[3].Value = Usuario.Nivel.Nome;// ele retorna o nome do Nivel (valor do nivel retornando o nome)
                dgvUsuarios.Rows[linha].Cells[4].Value = Usuario.Ativo;
                linha++;//ele pula a linha
            }
        }
        private void CmbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaAtual = dgvUsuarios.CurrentRow.Index;
            int idUser = Convert.ToInt32(dgvUsuarios.Rows[linhaAtual].Cells[0].Value);//ele recupera o valor zero da linha id
            var usuario = Usuario.ObterPorId(idUser);
            TxtId.Text = usuario.Id.ToString();
            TxtNome.Text = usuario.Nome;
            TxtEmail.Text = usuario.Email;
            chkAtivo.Checked = usuario.Ativo;
            CmbNivel.SelectedValue = usuario.Nivel.Id;
            BtnAtualizar.Enabled = true;// o botão ficará true quando clicar nele, ai funcionará
            // MessageBox.Show(idUser.ToString());//vai mostrar o indice da linha
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new();
            usuario.Id = int.Parse(TxtId.Text);// pega o id do usuario converte para texto 
            usuario.Nome = TxtNome.Text;
            usuario.Senha = TxtSenha.Text;
            usuario.Nivel = Nivel.ObterPorId(Convert.ToInt32(CmbNivel.SelectedValue));//pega o metodo obter por id, vai pegar o id converter em int para o cmbnivel
            if (usuario.Atualizar())// se o metodo atualizar der true, irá mostrar uma messagebox
            {
                CarregaGridUsuarios();
                MessageBox.Show("Usuário atualizado com sucesso!");
            }
        }
    }

}

 


