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
            txtIdUsuario.Text = Convert.ToString(usuario.Id);
        }




        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            FrmConsultaCliente frmConsultaCliente = new();

            if (frmConsultaCliente.ShowDialog() == DialogResult.OK)
            {
                txtIdCliente.Text = FrmConsultaCliente.ClienteSelecionadoId.ToString();
                txtNomeCliente.Text = FrmConsultaCliente.ClienteSelecionadoNome;
                btnInserePedido.Visible = true;
            }
        }

        private void btnInserePedido_Click(object sender, EventArgs e)
        {
            //Pedido pedido = new(
            //   txtIdUsuario.Text,
            //   txtIdUsuario.Text
            //   );

            //pedido.InserirPedido();
            //if (pedido.Id > 0)
            //{

            //}
        }

        private void txtIdPedido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
