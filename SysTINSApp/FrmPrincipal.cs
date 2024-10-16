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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pedidosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new();
            frmUsuarios.MdiParent = this; // this é formulario pai ele indica como se falasse (EU) ou seja ele vire frmprincipal
                                          // para que não crie outra janela
            frmUsuarios.Show();//se eu colocar show dialog ele não fecha até que encerre 
        }
    }
}
