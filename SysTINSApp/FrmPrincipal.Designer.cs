namespace SysTINSApp
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            buscarToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            novoinserirToolStripMenuItem = new ToolStripMenuItem();
            buscarConsultarToolStripMenuItem = new ToolStripMenuItem();
            manterToolStripMenuItem = new ToolStripMenuItem();
            usúariosToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem3 = new ToolStripMenuItem();
            consultarToolStripMenuItem3 = new ToolStripMenuItem();
            niveisToolStripMenuItem = new ToolStripMenuItem();
            movimentoToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem2 = new ToolStripMenuItem();
            consultarToolStripMenuItem1 = new ToolStripMenuItem();
            listarToolStripMenuItem = new ToolStripMenuItem();
            orçamentoToolStripMenuItem = new ToolStripMenuItem();
            trocasEDevoluçõesToolStripMenuItem = new ToolStripMenuItem();
            materiaisToolStripMenuItem = new ToolStripMenuItem();
            caixaToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem2 = new ToolStripMenuItem();
            encerrarToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            manutençãoToolStripMenuItem = new ToolStripMenuItem();
            sairLogoutToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem1 = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            níveisToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            tsslUsuario = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, movimentoToolStripMenuItem, materiaisToolStripMenuItem, manutençãoToolStripMenuItem, sairLogoutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, produtosToolStripMenuItem, usúariosToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "&Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem, buscarToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(180, 22);
            clientesToolStripMenuItem.Text = "&Clientes";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(180, 22);
            novoToolStripMenuItem.Text = "&Novo";
            novoToolStripMenuItem.Click += novoToolStripMenuItem_Click;
            // 
            // buscarToolStripMenuItem
            // 
            buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            buscarToolStripMenuItem.Size = new Size(180, 22);
            buscarToolStripMenuItem.Text = "&Buscar";
            buscarToolStripMenuItem.Click += buscarToolStripMenuItem_Click;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoinserirToolStripMenuItem, buscarConsultarToolStripMenuItem, manterToolStripMenuItem });
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(180, 22);
            produtosToolStripMenuItem.Text = "&Produtos";
            // 
            // novoinserirToolStripMenuItem
            // 
            novoinserirToolStripMenuItem.Name = "novoinserirToolStripMenuItem";
            novoinserirToolStripMenuItem.Size = new Size(171, 22);
            novoinserirToolStripMenuItem.Text = "&Novo (inserir)";
            novoinserirToolStripMenuItem.Click += novoinserirToolStripMenuItem_Click;
            // 
            // buscarConsultarToolStripMenuItem
            // 
            buscarConsultarToolStripMenuItem.Name = "buscarConsultarToolStripMenuItem";
            buscarConsultarToolStripMenuItem.Size = new Size(171, 22);
            buscarConsultarToolStripMenuItem.Text = "&Buscar (Consultar)";
            // 
            // manterToolStripMenuItem
            // 
            manterToolStripMenuItem.Name = "manterToolStripMenuItem";
            manterToolStripMenuItem.Size = new Size(171, 22);
            manterToolStripMenuItem.Text = "&Manter";
            manterToolStripMenuItem.Click += manterToolStripMenuItem_Click;
            // 
            // usúariosToolStripMenuItem
            // 
            usúariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem3, consultarToolStripMenuItem3, niveisToolStripMenuItem });
            usúariosToolStripMenuItem.Name = "usúariosToolStripMenuItem";
            usúariosToolStripMenuItem.Size = new Size(180, 22);
            usúariosToolStripMenuItem.Text = "&Usuarios";
            usúariosToolStripMenuItem.Click += usúariosToolStripMenuItem_Click;
            // 
            // novoToolStripMenuItem3
            // 
            novoToolStripMenuItem3.Name = "novoToolStripMenuItem3";
            novoToolStripMenuItem3.Size = new Size(125, 22);
            novoToolStripMenuItem3.Text = "&Novo";
            novoToolStripMenuItem3.Click += novoToolStripMenuItem3_Click;
            // 
            // consultarToolStripMenuItem3
            // 
            consultarToolStripMenuItem3.Name = "consultarToolStripMenuItem3";
            consultarToolStripMenuItem3.Size = new Size(125, 22);
            consultarToolStripMenuItem3.Text = "&Consultar";
            // 
            // niveisToolStripMenuItem
            // 
            niveisToolStripMenuItem.Name = "niveisToolStripMenuItem";
            niveisToolStripMenuItem.Size = new Size(125, 22);
            niveisToolStripMenuItem.Text = "&Niveis";
            // 
            // movimentoToolStripMenuItem
            // 
            movimentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pedidosToolStripMenuItem, orçamentoToolStripMenuItem, trocasEDevoluçõesToolStripMenuItem });
            movimentoToolStripMenuItem.Name = "movimentoToolStripMenuItem";
            movimentoToolStripMenuItem.Size = new Size(81, 20);
            movimentoToolStripMenuItem.Text = "&Movimento";
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem2, consultarToolStripMenuItem1, listarToolStripMenuItem });
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(180, 22);
            pedidosToolStripMenuItem.Text = "&Pedido";
            // 
            // novoToolStripMenuItem2
            // 
            novoToolStripMenuItem2.Name = "novoToolStripMenuItem2";
            novoToolStripMenuItem2.Size = new Size(125, 22);
            novoToolStripMenuItem2.Text = "&Novo";
            novoToolStripMenuItem2.Click += novoToolStripMenuItem2_Click;
            // 
            // consultarToolStripMenuItem1
            // 
            consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            consultarToolStripMenuItem1.Size = new Size(125, 22);
            consultarToolStripMenuItem1.Text = "&Consultar";
            // 
            // listarToolStripMenuItem
            // 
            listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            listarToolStripMenuItem.Size = new Size(125, 22);
            listarToolStripMenuItem.Text = "&Listar";
            // 
            // orçamentoToolStripMenuItem
            // 
            orçamentoToolStripMenuItem.Name = "orçamentoToolStripMenuItem";
            orçamentoToolStripMenuItem.Size = new Size(180, 22);
            orçamentoToolStripMenuItem.Text = "&Orçamento";
            // 
            // trocasEDevoluçõesToolStripMenuItem
            // 
            trocasEDevoluçõesToolStripMenuItem.Name = "trocasEDevoluçõesToolStripMenuItem";
            trocasEDevoluçõesToolStripMenuItem.Size = new Size(180, 22);
            trocasEDevoluçõesToolStripMenuItem.Text = "&Trocas e Devoluções";
            // 
            // materiaisToolStripMenuItem
            // 
            materiaisToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { caixaToolStripMenuItem, toolStripMenuItem2 });
            materiaisToolStripMenuItem.Name = "materiaisToolStripMenuItem";
            materiaisToolStripMenuItem.Size = new Size(75, 20);
            materiaisToolStripMenuItem.Text = "&Operações";
            // 
            // caixaToolStripMenuItem
            // 
            caixaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, consultarToolStripMenuItem2, encerrarToolStripMenuItem, listarToolStripMenuItem1 });
            caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            caixaToolStripMenuItem.Size = new Size(106, 22);
            caixaToolStripMenuItem.Text = "&Caixa";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(125, 22);
            abrirToolStripMenuItem.Text = "&Abrir";
            // 
            // consultarToolStripMenuItem2
            // 
            consultarToolStripMenuItem2.Name = "consultarToolStripMenuItem2";
            consultarToolStripMenuItem2.Size = new Size(125, 22);
            consultarToolStripMenuItem2.Text = "&Consultar";
            // 
            // encerrarToolStripMenuItem
            // 
            encerrarToolStripMenuItem.Name = "encerrarToolStripMenuItem";
            encerrarToolStripMenuItem.Size = new Size(125, 22);
            encerrarToolStripMenuItem.Text = "&Encerrar";
            // 
            // listarToolStripMenuItem1
            // 
            listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            listarToolStripMenuItem1.Size = new Size(125, 22);
            listarToolStripMenuItem1.Text = "&Listar";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(106, 22);
            toolStripMenuItem2.Text = "Venda";
            // 
            // manutençãoToolStripMenuItem
            // 
            manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            manutençãoToolStripMenuItem.Size = new Size(86, 20);
            manutençãoToolStripMenuItem.Text = "M&anutenção";
            // 
            // sairLogoutToolStripMenuItem
            // 
            sairLogoutToolStripMenuItem.Name = "sairLogoutToolStripMenuItem";
            sairLogoutToolStripMenuItem.Size = new Size(90, 20);
            sairLogoutToolStripMenuItem.Text = "&Sair ( logout )";
            // 
            // novoToolStripMenuItem1
            // 
            novoToolStripMenuItem1.Name = "novoToolStripMenuItem1";
            novoToolStripMenuItem1.Size = new Size(180, 22);
            novoToolStripMenuItem1.Text = "&Novo";
            novoToolStripMenuItem1.Click += novoToolStripMenuItem1_Click_2;
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(180, 22);
            consultarToolStripMenuItem.Text = "&Consultar";
            // 
            // níveisToolStripMenuItem
            // 
            níveisToolStripMenuItem.Name = "níveisToolStripMenuItem";
            níveisToolStripMenuItem.Size = new Size(180, 22);
            níveisToolStripMenuItem.Text = "&Níveis";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslUsuario });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsslUsuario
            // 
            tsslUsuario.Name = "tsslUsuario";
            tsslUsuario.Size = new Size(12, 17);
            tsslUsuario.Text = "-";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "SysTINS - Syspeças TI97 -ver 0.0.1";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void NovoToolStripMenuItem1_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem buscarToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem novoinserirToolStripMenuItem;
        private ToolStripMenuItem buscarConsultarToolStripMenuItem;
        private ToolStripMenuItem usúariosToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem1;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem níveisToolStripMenuItem;
        private ToolStripMenuItem movimentoToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem2;
        private ToolStripMenuItem consultarToolStripMenuItem1;
        private ToolStripMenuItem listarToolStripMenuItem;
        private ToolStripMenuItem orçamentoToolStripMenuItem;
        private ToolStripMenuItem trocasEDevoluçõesToolStripMenuItem;
        private ToolStripMenuItem materiaisToolStripMenuItem;
        private ToolStripMenuItem caixaToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem2;
        private ToolStripMenuItem encerrarToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem manutençãoToolStripMenuItem;
        private ToolStripMenuItem sairLogoutToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem3;
        private ToolStripMenuItem consultarToolStripMenuItem3;
        private ToolStripMenuItem niveisToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslUsuario;
        private ToolStripMenuItem manterToolStripMenuItem;
    }
}