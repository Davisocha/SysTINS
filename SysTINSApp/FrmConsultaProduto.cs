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
    public partial class FrmConsultaProduto : Form
    {
        public int IdProdutoConsulta { get; internal set; }
        public string Cod_barra { get; internal set; }
        public string? Descricao { get; internal set; }
        public double Valor_unit { get; internal set; }
        public double? Classe_desconto { get; internal set; }



        public FrmConsultaProduto()
        {
            InitializeComponent();
        }

        private void FrmConsultaProduto_Load(object sender, EventArgs e)
        {
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
                dgvProdutos.Rows[linha].Cells[3].Value = "$"+ produto.Valor_unit.ToString("#0.00");
                dgvProdutos.Rows[linha].Cells[4].Value = produto.Unidade_venda;
                dgvProdutos.Rows[linha].Cells[5].Value = produto.Categoria.Nome;
                dgvProdutos.Rows[linha].Cells[6].Value = produto.Estoque_minimo;
                dgvProdutos.Rows[linha].Cells[7].Value = produto.Classe_desconto * 0.01 + "%";
                dgvProdutos.Rows[linha].Cells[8].Value = produto.Data_cad;
                linha++;

            }
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var produto = Produto.ObterPorId(Convert.ToInt32(dgvProdutos.Rows[e.RowIndex].Cells[0].Value));

                //string iduser = dgvProdutos.Rows[e.RowIndex].Cells[1].ToString();
                //string descricao = Convert.ToString(dgvProdutos.Rows[e.RowIndex].Cells[2].Value);
                //double valor_unit = Convert.ToDouble(dgvProdutos.Rows[e.RowIndex].Cells[3].Value);
                //double classe_desconto = Convert.ToDouble(dgvProdutos.Rows[e.RowIndex].Cells[7].Value);
                IdProdutoConsulta = produto.Id;
                Cod_barra = produto.Cod_barras; 
                Descricao = produto.Descricao;
                Valor_unit = produto.Valor_unit;
                Classe_desconto = produto.Classe_desconto;




                //
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
