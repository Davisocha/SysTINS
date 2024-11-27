namespace SysTINSApp
{
    partial class FrmLogin
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
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            Label1 = new Label();
            label2 = new Label();
            btnEntrar = new Button();
            btnCancelar = new Button();
            lblMensagem = new Label();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(33, 43);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(356, 23);
            txtEmail.TabIndex = 0;
            txtEmail.Text = "davi@davi.com";
            txtEmail.TextChanged += textBox1_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(33, 101);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(359, 23);
            txtSenha.TabIndex = 1;
            txtSenha.Text = "123456";
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Sitka Small", 12F);
            Label1.ForeColor = SystemColors.ControlLightLight;
            Label1.Location = new Point(33, 16);
            Label1.Name = "Label1";
            Label1.Size = new Size(57, 24);
            Label1.TabIndex = 2;
            Label1.Text = "Email";
            Label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 12F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(33, 74);
            label2.Name = "label2";
            label2.Size = new Size(58, 24);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(65, 180);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(140, 36);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += button1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(220, 180);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(145, 36);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += button2_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMensagem.ForeColor = Color.Brown;
            lblMensagem.Location = new Point(34, 129);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(0, 21);
            lblMensagem.TabIndex = 6;
            // 
            // FrmLogin
            // 
            AcceptButton = btnEntrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            CancelButton = btnCancelar;
            ClientSize = new Size(434, 239);
            ControlBox = false;
            Controls.Add(lblMensagem);
            Controls.Add(btnCancelar);
            Controls.Add(btnEntrar);
            Controls.Add(label2);
            Controls.Add(Label1);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            ForeColor = SystemColors.ControlText;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtSenha;
        private Label Label1;
        private Label label2;
        private Button btnEntrar;
        private Button btnCancelar;
        private Label lblMensagem;
    }
}