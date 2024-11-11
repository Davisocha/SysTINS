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
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            CarregaComboCategoria();
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            var listaProduto = Produto.ObterLista();
            dgvProdutos.Rows.Clear();
            int linha = 0;
            foreach (var produto in listaProduto)
            {
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[linha].Cells[0].Value = produto.Id;
                dgvProdutos.Rows[linha].Cells[1].Value = produto.Cod_barras;
                dgvProdutos.Rows[linha].Cells[2].Value = produto.Descricao;
                dgvProdutos.Rows[linha].Cells[3].Value = "R$ " + produto.Valor_unit.ToString("#0.00");
                dgvProdutos.Rows[linha].Cells[4].Value = produto.Unidade_venda;
                dgvProdutos.Rows[linha].Cells[5].Value = produto.Categoria.Nome;
                dgvProdutos.Rows[linha].Cells[6].Value = produto.Estoque_minimo;
                dgvProdutos.Rows[linha].Cells[7].Value = (produto.Classe_desconto * 100 + "%");
                dgvProdutos.Rows[linha].Cells[8].Value = produto.Data_cad;
                linha++;

            }
        }

        private void CarregaComboCategoria()
        {
            var categorias = Categoria.ListaCategorias();
            categorias.Add(new(0, ">>>>>>>>>>Nova Categoria<<<<<<<<<<", "NWC"));
            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.ValueMember = "Id";
        }
        private void gpProdutos_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Produto produto = new(
                txtCodBar.Text,
                txtDescricao.Text,
                double.Parse(txtValorUnit.Text),
                txtUnidadeVenda.Text,
                Categoria.ObterPorID(Convert.ToInt32(cmbCategoria.SelectedValue)),
                (double)npEstoqueMinimo.Value,//cast é tambem um tipo de conversão
                double.Parse(txtDesconto.Text)//ele convert para text
                );
            produto.InserirProduto();
            if (produto.Id > 0)
            {
                txtId.Text = produto.Id.ToString();
                CarregaGrid();
                MessageBox.Show($"Produto Cadastrado com o ID {produto.Id}");
            }
            else
            {
                MessageBox.Show("Falha ao Inserir Produto!");
            }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.ValueMember != ""/*diferente de vazio*/ && Convert.ToInt32(cmbCategoria.SelectedValue) == 0)// e cmb categoria for igual a zero é pq o valor selecionado é igual a zero
            {
                panel1.Visible = true;
                txtNewCat.Focus();//txt vai aparecer com o cursor piscando nele
                gpProdutos.Enabled = false;//quando eu tiver cadastrando uma categoria eu não posso fazer mais nada além da categoria

            }
            else//caso o value member foi diferente de vazio ele não serve pra mim
            {
                panel1.Visible = false;
            }





        }
        private void button1_Click(object sender, EventArgs e)
        {
            Categoria categoria = new(txtNewCat.Text, txtNewCatSigla.Text);
            categoria.InserirCategoria();
            txtNewCat.Clear();
            CarregaComboCategoria();// ele ja carrega assim que eu inserir a categoria
            cmbCategoria.SelectedValue = categoria.Id;
            panel1.Visible = false;//some o inserir categoria
            gpProdutos.Enabled = true;// e aparece
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            gpProdutos.Enabled = true;
            cmbCategoria.SelectedIndex = 0;// ele cancela a operação de inserir categorias e volta a operação normal
        }
    }
}


