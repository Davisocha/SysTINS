using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf;
using SysTINSClass;

namespace SysTINSApp
{
    public partial class FrmNovoPedido : Form
    {

        public FrmNovoPedido()
        {
            InitializeComponent();
        }


        private void FrmNovoPedido_Load(object sender, EventArgs e)
        {
            idUsuario();

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
        private void idUsuario()
        {
            var usuario = Program.usuariologado;
            txtIdUsuario.Text = Convert.ToString(usuario.Id + "- - -" + usuario.Nome);
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            FrmConsultaCliente frmConsultaCliente = new();

            if (frmConsultaCliente.ShowDialog() == DialogResult.OK)
            {
                txtIdCliente.Text = FrmConsultaCliente.ClienteSelecionadoId.ToString();
                txtNomeCliente.Text = FrmConsultaCliente.ClienteSelecionadoNome;
                btnInserePedido.Enabled = true;
                btnInserePedido.Visible = true;

            }
        }
        private void txtIdPedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInserePedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new(
              Usuario.ObterPorId(Program.usuariologado.Id),
              Cliente.ObterClientePorID(int.Parse(txtIdCliente.Text))
              );

            pedido.InserirPedido();
            txtIdPedido.Text = pedido.Id.ToString();
            grbIndentificacao.Enabled = false;//o groupbox desativa 
            grbItens.Enabled = true;
            btnInserePedido.Enabled = false;
        }

        private void dgvItensPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CarregaGridItens(ItemPedido itemPedido)
        {
            dgvItensPedido.Rows.Clear();

            var ListadeDeUsuario = ItemPedido.ObterItemPorPedidoID(itemPedido.PedidoId);
            int sequencia = 1;
            int linha = 0;
            foreach (var item in ListadeDeUsuario)// para cada usuario dentro da lista de usuarios faça
            {
                dgvItensPedido.Rows.Add();//para cada usuarios adicione uma linha 
                dgvItensPedido.Rows[linha].Cells[0].Value = sequencia;// na linhas [linha que vale na posição 0] que cells[ posição da coluna 0] que tem o value de usuario.Id ou seja id do usuario
                dgvItensPedido.Rows[linha].Cells[1].Value = itemPedido.Produto.Cod_barras;
                dgvItensPedido.Rows[linha].Cells[2].Value = itemPedido.Produto.Descricao;
                dgvItensPedido.Rows[linha].Cells[3].Value = itemPedido.Produto.Valor_unit;
                dgvItensPedido.Rows[linha].Cells[4].Value = itemPedido.Quantidade;
                dgvItensPedido.Rows[linha].Cells[5].Value = itemPedido.Produto.Classe_desconto;
                dgvItensPedido.Rows[linha].Cells[6].Value = $"{itemPedido.Quantidade * itemPedido.Produto.Classe_desconto}";
                sequencia++;
                linha++;//ele pula a linha
            }

        }
        private void dgvItensPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Produto produto = new();
             ItemPedido itemPedido = new(
                Convert.ToInt32(txtIdPedido.Text),
                Produto.ObterPorId(produto.Id),
                Convert.ToDouble(txtQuantidade.Text),
                Convert.ToDouble(txtQuantidade.Text)
                );
            MessageBox.Show($"item adicionado");
        }
    }
}
