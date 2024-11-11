namespace SysTINSApp
{
    partial class FrmUsuarios
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
            BtnInserir = new Button();
            BtnConsultar = new Button();
            BtnAtualizar = new Button();
            dgvUsuarios = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnNivel = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewCheckBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            CmbNivel = new ComboBox();
            label5 = new Label();
            chkAtivo = new CheckBox();
            TxtId = new TextBox();
            TxtNome = new TextBox();
            TxtEmail = new TextBox();
            TxtSenha = new TextBox();
            TxtConfSenha = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // BtnInserir
            // 
            BtnInserir.Location = new Point(35, 234);
            BtnInserir.Name = "BtnInserir";
            BtnInserir.Size = new Size(75, 23);
            BtnInserir.TabIndex = 0;
            BtnInserir.Text = "Inserir";
            BtnInserir.UseVisualStyleBackColor = true;
            BtnInserir.Click += BtnInserir_Click;
            // 
            // BtnConsultar
            // 
            BtnConsultar.Location = new Point(227, 234);
            BtnConsultar.Name = "BtnConsultar";
            BtnConsultar.Size = new Size(75, 23);
            BtnConsultar.TabIndex = 1;
            BtnConsultar.Text = "Consultar";
            BtnConsultar.UseVisualStyleBackColor = true;
            BtnConsultar.Click += BtnConsultar_Click;
            // 
            // BtnAtualizar
            // 
            BtnAtualizar.Enabled = false;
            BtnAtualizar.Location = new Point(401, 234);
            BtnAtualizar.Name = "BtnAtualizar";
            BtnAtualizar.Size = new Size(75, 23);
            BtnAtualizar.TabIndex = 2;
            BtnAtualizar.Text = "Atualizar";
            BtnAtualizar.UseVisualStyleBackColor = true;
            BtnAtualizar.Click += BtnAtualizar_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AllowUserToResizeColumns = false;
            dgvUsuarios.AllowUserToResizeRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnEmail, clnNivel, clnAtivo });
            dgvUsuarios.Location = new Point(31, 271);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(502, 150);
            dgvUsuarios.TabIndex = 3;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
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
            // clnEmail
            // 
            clnEmail.Frozen = true;
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            clnEmail.Width = 180;
            // 
            // clnNivel
            // 
            clnNivel.Frozen = true;
            clnNivel.HeaderText = "Nível";
            clnNivel.Name = "clnNivel";
            clnNivel.ReadOnly = true;
            clnNivel.Width = 60;
            // 
            // clnAtivo
            // 
            clnAtivo.Frozen = true;
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            clnAtivo.Width = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 58);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 4;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 58);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 112);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 6;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 165);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 7;
            label4.Text = "Senha";
            // 
            // CmbNivel
            // 
            CmbNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbNivel.FormattingEnabled = true;
            CmbNivel.Location = new Point(355, 130);
            CmbNivel.Name = "CmbNivel";
            CmbNivel.Size = new Size(121, 23);
            CmbNivel.TabIndex = 8;
            CmbNivel.SelectedIndexChanged += CmbNivel_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(355, 112);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 9;
            label5.Text = "Nível";
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Checked = true;
            chkAtivo.CheckState = CheckState.Checked;
            chkAtivo.Enabled = false;
            chkAtivo.Location = new Point(418, 185);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 10;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // TxtId
            // 
            TxtId.Location = new Point(31, 76);
            TxtId.Name = "TxtId";
            TxtId.ReadOnly = true;
            TxtId.Size = new Size(54, 23);
            TxtId.TabIndex = 11;
            TxtId.TextChanged += TxtId_TextChanged;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(109, 76);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(363, 23);
            TxtNome.TabIndex = 12;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(31, 130);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(318, 23);
            TxtEmail.TabIndex = 13;
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(31, 183);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(174, 23);
            TxtSenha.TabIndex = 14;
            TxtSenha.UseSystemPasswordChar = true;
            TxtSenha.TextChanged += TxtSenha_TextChanged;
            // 
            // TxtConfSenha
            // 
            TxtConfSenha.Location = new Point(211, 183);
            TxtConfSenha.Name = "TxtConfSenha";
            TxtConfSenha.Size = new Size(189, 23);
            TxtConfSenha.TabIndex = 14;
            TxtConfSenha.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(211, 165);
            label7.Name = "label7";
            label7.Size = new Size(96, 15);
            label7.TabIndex = 15;
            label7.Text = "Confirmar Senha";
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(TxtConfSenha);
            Controls.Add(TxtSenha);
            Controls.Add(TxtEmail);
            Controls.Add(TxtNome);
            Controls.Add(TxtId);
            Controls.Add(chkAtivo);
            Controls.Add(label5);
            Controls.Add(CmbNivel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvUsuarios);
            Controls.Add(BtnAtualizar);
            Controls.Add(BtnConsultar);
            Controls.Add(BtnInserir);
            Name = "FrmUsuarios";
            Text = "FrmUsuarios";
            Load += FrmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnInserir;
        private Button BtnConsultar;
        private Button BtnAtualizar;
        private DataGridView dgvUsuarios;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox CmbNivel;
        private Label label5;
        private CheckBox chkAtivo;
        private TextBox TxtId;
        private TextBox TxtNome;
        private TextBox TxtEmail;
        private TextBox TxtSenha;
        private Label label6;
        private TextBox TxtConfSenha;
        private Label label7;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnNivel;
        private DataGridViewCheckBoxColumn clnAtivo;
    }
}