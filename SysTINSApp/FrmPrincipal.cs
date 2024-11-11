﻿using System;
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
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Hide();
            FrmLogin frmLogin = new();
            if (frmLogin.ShowDialog() == DialogResult.OK)//se ele retornar ok quer dizer que dialogresult no frmpricipal vai dar true e permitir a entrada
            {
                tsslUsuario.Text = Program.usuariologado.Nome + " - " + Program.usuariologado.Nivel.Nome;//o usuario vai ser indentificado e escrito no status e chama o nome e o nome do nivel dele
                Show();
            }
            else
                Application.Exit();
            // ele vai mostrar o formulario de login e o frmprincipal vai estar ocultado e só sera mostrado se o entrar for fechado

        }

        private void novoToolStripMenuItem1_Click_2(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new(); // criauma instância (objeto) do FrmUsuarios
            frmUsuarios.MdiParent = this; // associa esta instância ao container (MDI) FrmPrincipal
                                          // this é formulario pai ele indica como se falasse (EU) ou seja ele vire frmprincipal
                                          // para que não crie outra janela
            frmUsuarios.Show();// exibe o form Usuarios na janela do sistema
                               //se eu colocar show dialog ele não fecha até que encerre 
        }

        private void usúariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new(); // criauma instância (objeto) do FrmUsuarios
            frmUsuarios.MdiParent = this; // associa esta instância ao container (MDI) FrmPrincipal
                                          // this é formulario pai ele indica como se falasse (EU) ou seja ele vire frmprincipal
                                          // para que não crie outra janela
            frmUsuarios.Show();// exibe o form Usuarios na janela do sistema
                               //se eu colocar show dialog ele não fecha até que encerre 
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria frmCategorias = new();
            frmCategorias.MdiParent = this;
            frmCategorias.Show();
        }
    }
}
