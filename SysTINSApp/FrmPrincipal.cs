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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void NovoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PedidosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void NovoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new();
            frmUsuarios.MdiParent = this; // this é formulario pai ele indica como se falasse (EU) ou seja ele vire frmprincipal
                                          // para que não crie outra janela
            frmUsuarios.Show();//se eu colocar show dialog ele não fecha até que encerre 
        }



        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //var cmd = Banco.Abrir();
            //cmd.CommandText = "select * from niveis where id = 1";
            //var dr = cmd.ExecuteReader();// ele devolve um obj datareader que é um leitor de dados que mostra tabelas   
            //if (dr.Read())
            //// ele avanca o data reader para um proximo registro// ele vai ver se tem linhas na tabela se der verdadeiro ele funciona ai ele executa oq tiver dentro das chaves 
            //{
            //    MessageBox.Show($"Olá {dr.GetString(1)}");// id igual a 1 é um gerente
            //}
            //else
            //{
            //    MessageBox.Show($"nivel não encontrado");
            //}  

        }
    }
}
