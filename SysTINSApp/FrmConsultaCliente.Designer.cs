namespace SysTINSApp
{
    partial class FrmConsultaCliente
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
            dgvConsulta = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            btnSelecionar = new Button();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).BeginInit();
            SuspendLayout();
            // 
            // dgvConsulta
            // 
            dgvConsulta.AllowUserToAddRows = false;
            dgvConsulta.AllowUserToDeleteRows = false;
            dgvConsulta.AllowUserToResizeColumns = false;
            dgvConsulta.AllowUserToResizeRows = false;
            dgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsulta.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome });
            dgvConsulta.Location = new Point(12, 12);
            dgvConsulta.Name = "dgvConsulta";
            dgvConsulta.RowHeadersVisible = false;
            dgvConsulta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsulta.Size = new Size(643, 407);
            dgvConsulta.TabIndex = 3;
            dgvConsulta.CellClick += dgvConsulta_CellClick;
            dgvConsulta.CellContentClick += dgvConsulta_CellContentClick;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 50;
            // 
            // clnNome
            // 
            clnNome.FillWeight = 500F;
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 590;
            // 
            // btnSelecionar
            // 
            btnSelecionar.Location = new Point(695, 40);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(75, 23);
            btnSelecionar.TabIndex = 4;
            btnSelecionar.Text = "Selecionar";
            btnSelecionar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(695, 86);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 23);
            btnVoltar.TabIndex = 5;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // FrmConsultaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(btnSelecionar);
            Controls.Add(dgvConsulta);
            Name = "FrmConsultaCliente";
            Text = "FrmConsultaCliente";
            Load += FrmConsultaCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvConsulta;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private Button btnSelecionar;
        private Button btnVoltar;
    }
}