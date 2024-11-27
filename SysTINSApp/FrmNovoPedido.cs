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
            CarregaGridItens();

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

        private ItemPedido itemPedido = new();
        private void CarregaGridItens()
        {
            dgvItensPedido.Rows.Clear();
            var pedidoId = itemPedido;
            var ListadeDeUsuario = ItemPedido.ObterItemPorPedidoID(pedidoId.PedidoId);
            int sequencia = 1;
            int linha = 0;
            foreach (var item in ListadeDeUsuario)// para cada usuario dentro da lista de usuarios faça
            {
                dgvItensPedido.Rows.Add();//para cada usuarios adicione uma linha 
                dgvItensPedido.Rows[linha].Cells[0].Value = sequencia;// na linhas [linha que vale na posição 0] que cells[ posição da coluna 0] que tem o value de usuario.Id ou seja id do usuario
                dgvItensPedido.Rows[linha].Cells[1].Value = pedidoId.Produto.Cod_barras;
                dgvItensPedido.Rows[linha].Cells[2].Value = pedidoId.Produto.Descricao;
                dgvItensPedido.Rows[linha].Cells[3].Value = pedidoId.Produto.Valor_unit;
                dgvItensPedido.Rows[linha].Cells[4].Value = pedidoId.Quantidade;
                dgvItensPedido.Rows[linha].Cells[5].Value = pedidoId.Produto.Classe_desconto;
                dgvItensPedido.Rows[linha].Cells[6].Value = $"{pedidoId.Quantidade * pedidoId.Produto.Classe_desconto}";
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
            if (itemPedido.Id > 0)
            { 
            CarregaGridItens();
            MessageBox.Show($"item adicionado");
            btnAddItem.Enabled = false;
            }
            else
            {
                MessageBox.Show("Erro");
            }   
                
        }
    }
}
