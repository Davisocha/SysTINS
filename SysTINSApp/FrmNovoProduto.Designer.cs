namespace SysTINSApp
{
    partial class FrmNovoProduto
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
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            dgvCategorias = new DataGridView();
            clnID = new DataGridViewTextBoxColumn();
            clnCod_Bar = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValor_Unit = new DataGridViewTextBoxColumn();
            clnUnidadeVenda = new DataGridViewTextBoxColumn();
            clnCategoria = new DataGridViewTextBoxColumn();
            clnEstoque_min = new DataGridViewTextBoxColumn();
            clnClasse_Desconto = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(165, 84);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(32, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(302, 25);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(32, 84);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(302, 84);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 6;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(32, 157);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(370, 106);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 8);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 9;
            label1.Text = "Código de Barras";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 139);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 9;
            label2.Text = "Descrição";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(302, 7);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 9;
            label3.Text = "Valor Unitário";
            label3.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(302, 65);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 9;
            label4.Text = "Unidade Venda";
            label4.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(165, 65);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 9;
            label5.Text = "Categoria";
            label5.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 66);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 10;
            label6.Text = "Classe Desconto";
            // 
            // button1
            // 
            button1.Location = new Point(489, 231);
            button1.Name = "button1";
            button1.Size = new Size(101, 32);
            button1.TabIndex = 11;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.AllowUserToResizeColumns = false;
            dgvCategorias.AllowUserToResizeRows = false;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Columns.AddRange(new DataGridViewColumn[] { clnID, clnCod_Bar, clnDescricao, clnValor_Unit, clnUnidadeVenda, clnCategoria, clnEstoque_min, clnClasse_Desconto });
            dgvCategorias.Location = new Point(32, 288);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersVisible = false;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(752, 150);
            dgvCategorias.TabIndex = 12;
            dgvCategorias.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // clnID
            // 
            clnID.Frozen = true;
            clnID.HeaderText = "ID";
            clnID.Name = "clnID";
            clnID.ReadOnly = true;
            clnID.Width = 50;
            // 
            // clnCod_Bar
            // 
            clnCod_Bar.Frozen = true;
            clnCod_Bar.HeaderText = "Código de Barras";
            clnCod_Bar.Name = "clnCod_Bar";
            clnCod_Bar.ReadOnly = true;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            // 
            // clnValor_Unit
            // 
            clnValor_Unit.Frozen = true;
            clnValor_Unit.HeaderText = "Valor Unitário";
            clnValor_Unit.Name = "clnValor_Unit";
            clnValor_Unit.ReadOnly = true;
            // 
            // clnUnidadeVenda
            // 
            clnUnidadeVenda.Frozen = true;
            clnUnidadeVenda.HeaderText = "Unidade Venda";
            clnUnidadeVenda.Name = "clnUnidadeVenda";
            clnUnidadeVenda.ReadOnly = true;
            // 
            // clnCategoria
            // 
            clnCategoria.Frozen = true;
            clnCategoria.HeaderText = "Categoria";
            clnCategoria.Name = "clnCategoria";
            clnCategoria.ReadOnly = true;
            // 
            // clnEstoque_min
            // 
            clnEstoque_min.Frozen = true;
            clnEstoque_min.HeaderText = "Estoque Minímo";
            clnEstoque_min.Name = "clnEstoque_min";
            clnEstoque_min.ReadOnly = true;
            // 
            // clnClasse_Desconto
            // 
            clnClasse_Desconto.Frozen = true;
            clnClasse_Desconto.HeaderText = "Classe Desconto";
            clnClasse_Desconto.Name = "clnClasse_Desconto";
            clnClasse_Desconto.ReadOnly = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(489, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 131);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // FrmNovoProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(dgvCategorias);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Name = "FrmNovoProduto";
            Text = "FrmNovoProduto";
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private DataGridView dgvCategorias;
        private DataGridViewTextBoxColumn clnID;
        private DataGridViewTextBoxColumn clnCod_Bar;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValor_Unit;
        private DataGridViewTextBoxColumn clnUnidadeVenda;
        private DataGridViewTextBoxColumn clnCategoria;
        private DataGridViewTextBoxColumn clnEstoque_min;
        private DataGridViewTextBoxColumn clnClasse_Desconto;
        private PictureBox pictureBox1;
    }
}