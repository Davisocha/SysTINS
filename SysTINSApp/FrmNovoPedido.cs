using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            txtUsuario.Text = Convert.ToString(usuario.Id);
        }
    }
}
