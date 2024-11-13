namespace SysTINSApp
{
    partial class FrmNovoCliente
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
            txtCPF = new TextBox();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            gbClientes = new GroupBox();
            ckbAtivo = new CheckBox();
            dtpData_nasc = new DateTimePicker();
            txtId = new TextBox();
            button1 = new Button();
            button3 = new Button();
            btnAtualizar = new Button();
            btnInserir = new Button();
            label5 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            lbNome = new Label();
            dgvClientes = new DataGridView();
            clnID = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnCPF = new DataGridViewTextBoxColumn();
            clnTel = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnData_nasc = new DataGridViewTextBoxColumn();
            clnData_cad = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewTextBoxColumn();
            gbClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(264, 44);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(202, 23);
            txtCPF.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(18, 44);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(198, 23);
            txtNome.TabIndex = 1;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(18, 88);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(198, 23);
            txtTelefone.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(264, 88);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(202, 23);
            txtEmail.TabIndex = 1;
            // 
            // gbClientes
            // 
            gbClientes.Controls.Add(ckbAtivo);
            gbClientes.Controls.Add(dtpData_nasc);
            gbClientes.Controls.Add(txtId);
            gbClientes.Controls.Add(button1);
            gbClientes.Controls.Add(button3);
            gbClientes.Controls.Add(btnAtualizar);
            gbClientes.Controls.Add(btnInserir);
            gbClientes.Controls.Add(label5);
            gbClientes.Controls.Add(label1);
            gbClientes.Controls.Add(label3);
            gbClientes.Controls.Add(label4);
            gbClientes.Controls.Add(label2);
            gbClientes.Controls.Add(lbNome);
            gbClientes.Controls.Add(txtNome);
            gbClientes.Controls.Add(txtEmail);
            gbClientes.Controls.Add(txtCPF);
            gbClientes.Controls.Add(txtTelefone);
            gbClientes.Location = new Point(45, 12);
            gbClientes.Name = "gbClientes";
            gbClientes.Size = new Size(665, 192);
            gbClientes.TabIndex = 2;
            gbClientes.TabStop = false;
            gbClientes.Text = "Clientes";
            // 
            // ckbAtivo
            // 
            ckbAtivo.AutoSize = true;
            ckbAtivo.Location = new Point(539, 90);
            ckbAtivo.Name = "ckbAtivo";
            ckbAtivo.Size = new Size(54, 19);
            ckbAtivo.TabIndex = 8;
            ckbAtivo.Text = "Ativo";
            ckbAtivo.UseVisualStyleBackColor = true;
            ckbAtivo.Visible = false;
            // 
            // dtpData_nasc
            // 
            dtpData_nasc.Format = DateTimePickerFormat.Short;
            dtpData_nasc.Location = new Point(18, 141);
            dtpData_nasc.Name = "dtpData_nasc";
            dtpData_nasc.Size = new Size(166, 23);
            dtpData_nasc.TabIndex = 4;
            dtpData_nasc.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtId
            // 
            txtId.Location = new Point(539, 44);
            txtId.Name = "txtId";
            txtId.Size = new Size(60, 23);
            txtId.TabIndex = 7;
            txtId.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(503, 141);
            button1.Name = "button1";
            button1.Size = new Size(131, 23);
            button1.TabIndex = 6;
            button1.Text = "Adicionar Endereço";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(411, 141);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Inativar";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(320, 141);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 4;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Visible = false;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(225, 141);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 3;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(539, 26);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 2;
            label5.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 26);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 2;
            label1.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(264, 70);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 123);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 2;
            label4.Text = "Data de Nascimento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 70);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Telefone";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(18, 26);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 2;
            lbNome.Text = "Nome";
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { clnID, clnNome, clnCPF, clnTel, clnEmail, clnData_nasc, clnData_cad, clnAtivo });
            dgvClientes.Location = new Point(12, 240);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.Size = new Size(776, 198);
            dgvClientes.TabIndex = 3;
            dgvClientes.CellClick += DgvClientesCellClick;
            // 
            // clnID
            // 
            clnID.Frozen = true;
            clnID.HeaderText = "ID";
            clnID.Name = "clnID";
            clnID.ReadOnly = true;
            clnID.Width = 50;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 130;
            // 
            // clnCPF
            // 
            clnCPF.Frozen = true;
            clnCPF.HeaderText = "CPF";
            clnCPF.Name = "clnCPF";
            clnCPF.ReadOnly = true;
            clnCPF.Width = 120;
            // 
            // clnTel
            // 
            clnTel.Frozen = true;
            clnTel.HeaderText = "Telefone";
            clnTel.Name = "clnTel";
            clnTel.ReadOnly = true;
            // 
            // clnEmail
            // 
            clnEmail.Frozen = true;
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            // 
            // clnData_nasc
            // 
            clnData_nasc.Frozen = true;
            clnData_nasc.HeaderText = "Data de Nascimento";
            clnData_nasc.Name = "clnData_nasc";
            clnData_nasc.ReadOnly = true;
            // 
            // clnData_cad
            // 
            clnData_cad.Frozen = true;
            clnData_cad.HeaderText = "Data de Cadastro";
            clnData_cad.Name = "clnData_cad";
            clnData_cad.ReadOnly = true;
            // 
            // clnAtivo
            // 
            clnAtivo.Frozen = true;
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            clnAtivo.Width = 80;
            // 
            // FrmNovoCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvClientes);
            Controls.Add(gbClientes);
            Name = "FrmNovoCliente";
            Text = "FrmNovoCliente";
            Load += FrmNovoCliente_Load;
            gbClientes.ResumeLayout(false);
            gbClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtCPF;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private GroupBox gbClientes;
        private Label label1;
        private Label lbNome;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button3;
        private Button btnAtualizar;
        private Button btnInserir;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn clnID;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnCPF;
        private DataGridViewTextBoxColumn clnTel;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnData_nasc;
        private DataGridViewTextBoxColumn clnData_cad;
        private DataGridViewTextBoxColumn clnAtivo;
        private TextBox txtId;
        private Label label5;
        private DateTimePicker dtpData_nasc;
        private CheckBox ckbAtivo;
    }
}