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
            DgvCategorias = new DataGridView();
            btnNovaCategoria = new Button();
            btnListar = new Button();
            btnAtualizar = new Button();
            Nome = new DataGridViewTextBoxColumn();
            Sigla = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // DgvCategorias
            // 
            DgvCategorias.AllowUserToAddRows = false;
            DgvCategorias.AllowUserToDeleteRows = false;
            DgvCategorias.AllowUserToResizeColumns = false;
            DgvCategorias.AllowUserToResizeRows = false;
            DgvCategorias.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCategorias.Columns.AddRange(new DataGridViewColumn[] { Nome, Sigla });
            DgvCategorias.Location = new Point(21, 286);
            DgvCategorias.Name = "DgvCategorias";
            DgvCategorias.Size = new Size(333, 152);
            DgvCategorias.TabIndex = 0;
            // 
            // btnNovaCategoria
            // 
            btnNovaCategoria.Location = new Point(21, 247);
            btnNovaCategoria.Name = "btnNovaCategoria";
            btnNovaCategoria.Size = new Size(75, 23);
            btnNovaCategoria.TabIndex = 1;
            btnNovaCategoria.Text = "Novo";
            btnNovaCategoria.UseVisualStyleBackColor = true;
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
            // 
            // Nome
            // 
            Nome.Frozen = true;
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 200;
            // 
            // Sigla
            // 
            Sigla.Frozen = true;
            Sigla.HeaderText = "Sigla";
            Sigla.Name = "Sigla";
            Sigla.ReadOnly = true;
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAtualizar);
            Controls.Add(btnListar);
            Controls.Add(btnNovaCategoria);
            Controls.Add(DgvCategorias);
            Name = "FrmCategorias";
            Text = "FrmCategorias";
            ((System.ComponentModel.ISupportInitialize)DgvCategorias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvCategorias;
        private Button btnNovaCategoria;
        private Button btnListar;
        private Button btnAtualizar;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Sigla;
    }
}