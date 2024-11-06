namespace SysTINSApp
{
    partial class FrmCategorias
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
            btnNovaCategoria = new Button();
            btnListar = new Button();
            btnAtualizar = new Button();
            txtNomeCategoria = new TextBox();
            txtSigla = new TextBox();
            txtId = new TextBox();
            DgvCategorias = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnSigla = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // btnNovaCategoria
            // 
            btnNovaCategoria.Location = new Point(21, 247);
            btnNovaCategoria.Name = "btnNovaCategoria";
            btnNovaCategoria.Size = new Size(75, 23);
            btnNovaCategoria.TabIndex = 1;
            btnNovaCategoria.Text = "Novo";
            btnNovaCategoria.UseVisualStyleBackColor = true;
            btnNovaCategoria.Click += btnNovaCategoria_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(137, 247);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 1;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(253, 247);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 1;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // txtNomeCategoria
            // 
            txtNomeCategoria.Location = new Point(21, 196);
            txtNomeCategoria.Name = "txtNomeCategoria";
            txtNomeCategoria.Size = new Size(198, 23);
            txtNomeCategoria.TabIndex = 2;
            // 
            // txtSigla
            // 
            txtSigla.Location = new Point(225, 196);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(62, 23);
            txtSigla.TabIndex = 3;
            // 
            // txtId
            // 
            txtId.Location = new Point(301, 196);
            txtId.Name = "txtId";
            txtId.Size = new Size(44, 23);
            txtId.TabIndex = 3;
            // 
            // DgvCategorias
            // 
            DgvCategorias.AllowUserToAddRows = false;
            DgvCategorias.AllowUserToDeleteRows = false;
            DgvCategorias.AllowUserToResizeColumns = false;
            DgvCategorias.AllowUserToResizeRows = false;
            DgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCategorias.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnSigla });
            DgvCategorias.Location = new Point(21, 288);
            DgvCategorias.Name = "DgvCategorias";
            DgvCategorias.RowHeadersVisible = false;
            DgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvCategorias.Size = new Size(324, 150);
            DgvCategorias.TabIndex = 4;
            DgvCategorias.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 40;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 180;
            // 
            // clnSigla
            // 
            clnSigla.Frozen = true;
            clnSigla.HeaderText = "Sigla";
            clnSigla.Name = "clnSigla";
            clnSigla.ReadOnly = true;
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DgvCategorias);
            Controls.Add(txtId);
            Controls.Add(txtSigla);
            Controls.Add(txtNomeCategoria);
            Controls.Add(btnAtualizar);
            Controls.Add(btnListar);
            Controls.Add(btnNovaCategoria);
            Name = "FrmCategorias";
            Text = "FrmCategorias";
            ((System.ComponentModel.ISupportInitialize)DgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnNovaCategoria;
        private Button btnListar;
        private Button btnAtualizar;
        private TextBox txtNomeCategoria;
        private TextBox txtSigla;
        private TextBox txtId;
        private DataGridView DgvCategorias;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnSigla;
    }
}