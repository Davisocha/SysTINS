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
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void btnNovaCategoria_Click(object sender, EventArgs e)
        {
            Categoria categoria = new(
                txtNomeCategoria.Text,
                txtSigla.Text
                );
            categoria.InserirCategoria();
            if (categoria.Id > 0)
            {
                MessageBox.Show($"Categoria {categoria.Nome} inserido com sucesso");
                btnNovaCategoria.Enabled = false;
            }




        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Usuario categoria = new();
            categoria.Id= int.Parse(txtId.Text); 
            categoria.Nome = txtNomeCategoria.Text;
            categoria.Senha = txtSigla.Text;

            if (categoria.Atualizar())// se o metodo atualizar der true, irá mostrar uma messagebox
            {
                DgvCategorias_CellContentClick();
                MessageBox.Show("Categoria atualizada com sucesso!");
            }
        }

        private void DgvCategorias_CellContentClick()
        {
            DgvCategorias.Rows.Clear();
            var ListaDeCategoria = Categoria.ListaCategorias();
            int linha = 0;
            foreach (var categoria in ListaDeCategoria)// para cada usuario dentro da lista de usuarios faça
            {
                DgvCategorias.Rows.Add();//para cada usuarios adicione uma linha 
                DgvCategorias.Rows[linha].Cells[0].Value = categoria.Id;// na linhas [linha que vale na posição 0] que cells[ posição da coluna 0] que tem o value de usuario.Id ou seja id do usuario
                DgvCategorias.Rows[linha].Cells[1].Value = categoria.Nome;
                DgvCategorias.Rows[linha].Cells[2].Value = categoria.Sigla;

                linha++;//ele pula a linha
            }
        }

        private void DgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaAtual = DgvCategorias.CurrentRow.Index;
            int idUser = Convert.ToInt32(DgvCategorias.Rows[linhaAtual].Cells[0].Value);//ele recupera o valor zero da linha id
            var categoria = Categoria.ObterPorID(idUser);
            txtId.Text = categoria.Id.ToString();
            txtNomeCategoria.Text = categoria.Nome;
            txtSigla.Text = categoria.Sigla;
            btnAtualizar.Enabled = true;
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
