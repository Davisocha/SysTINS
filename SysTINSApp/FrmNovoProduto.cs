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
    public partial class FrmNovoProduto : Form
    {
        public FrmNovoProduto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmNovoProduto_Load(object sender, EventArgs e)
        {
            cmbCategorias.DataSource = Categoria.ListaCategorias();// obj de lista de niveis contendo todos os níveis da tabela Niveis
            cmbCategorias.DisplayMember = "Nome";//exiba o nome 
            cmbCategorias.ValueMember = "Id"; // se eu escolher o nome vai mostrar o valor do ID
            //carregando o datagrid de usúarios
            CarregaGridCategorias();
        }
        private void CarregaGridCategorias()
        {
            dgvProdutos.Rows.Clear();
            var ListadeProdutos = Produto.ObterListaDeProdutos();
            int linha = 0;
            foreach (var produto in ListadeProdutos)// para cada usuario dentro da lista de usuarios faça
            {
                dgvProdutos.Rows.Add();//para cada usuarios adicione uma linha 
                dgvProdutos.Rows[linha].Cells[0].Value = produto.Id;// na linhas [linha que vale na posição 0] que cells[ posição da coluna 0] que tem o value de usuario.Id ou seja id do usuario
                dgvProdutos.Rows[linha].Cells[1].Value = produto.Cod_barras;
                dgvProdutos.Rows[linha].Cells[3].Value = produto.Valor_unit;
                dgvProdutos.Rows[linha].Cells[4].Value = produto.Unidade_venda;
                dgvProdutos.Rows[linha].Cells[5].Value = produto.Categoria_id;
                dgvProdutos.Rows[linha].Cells[6].Value = produto.Estoque_minimo;// na linhas [linha que vale na posição 0] que cells[ posição da coluna 0] que tem o value de usuario.Id ou seja id do usuario
                dgvProdutos.Rows[linha].Cells[7].Value = produto.Classe_desconto;// na linhas [linha que vale na posição 0] que cells[ posição da coluna 0] que tem o value de usuario.Id ou seja id do usuario
                linha++;//ele pula a linha

            }
        }
        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaAtual = dgvUsuarios.CurrentRow.Index;
            int idUser = Convert.ToInt32(dgvUsuarios.Rows[linhaAtual].Cells[0].Value);//ele recupera o valor zero da linha id
            var usuario = Usuario.ObterPorId(idUser);
            TxtId.Text = usuario.Id.ToString();
            TxtNome.Text = usuario.Nome;
            TxtEmail.Text = usuario.Email;
            chkAtivo.Checked = usuario.Ativo;
            CmbNiveis.SelectedValue = usuario.Nivel.Id;
            BtnAtualizar.Enabled = true;// o botão ficará true quando clicar nele, ai funcionará
            // MessageBox.Show(idUser.ToString());//vai mostrar o indice da linha
        }




    }
}