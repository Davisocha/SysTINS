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
    public partial class FrmNovoCliente : Form
    {
        public FrmNovoCliente()
        {
            InitializeComponent();
        }
        private void DgvClientesCellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaAtual = dgvClientes.CurrentRow.Index;
            int idUser = Convert.ToInt32(dgvClientes.Rows[linhaAtual].Cells[0].Value);//ele recupera o valor zero da linha id
            var cliente = Cliente.ObterClientePorID(idUser);
            ckbAtivo.Visible = true;
            txtId.Text = cliente.Id.ToString();
            txtNome.Text = cliente.Nome;
            txtCPF.Text = cliente.CPF;
            txtTelefone.Text = cliente.Telefone;
            txtEmail.Text = cliente.Email;
            dtpData_nasc.Value = (DateTime)cliente.Data_nasc;
            ckbAtivo.Checked = cliente.Ativo;
            btnAtualizar.Visible = true;
            btnAtualizar.Enabled = true;

        }

        private void FrmNovoCliente_Load(object sender, EventArgs e)
        {
            CarregaGridDeClientes();

        }
        private void CarregaGridDeClientes()
        {
            var listaCliente = Cliente.ObterListaClientes();
            dgvClientes.Rows.Clear();
            int linha = 0;
            foreach (var cliente in listaCliente)
            {
                dgvClientes.Rows.Add();
                dgvClientes.Rows[linha].Cells[0].Value = cliente.Id;
                dgvClientes.Rows[linha].Cells[1].Value = cliente.Nome;
                dgvClientes.Rows[linha].Cells[2].Value = cliente.CPF;
                dgvClientes.Rows[linha].Cells[3].Value = cliente.Telefone;
                dgvClientes.Rows[linha].Cells[4].Value = cliente.Email;
                dgvClientes.Rows[linha].Cells[5].Value = cliente.Data_nasc;
                dgvClientes.Rows[linha].Cells[6].Value = cliente.Data_cad;
                dgvClientes.Rows[linha].Cells[7].Value = cliente.Ativo;
                linha++;

            }
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new(
                txtNome.Text,
                txtCPF.Text,
                txtTelefone.Text,
                txtEmail.Text,
                Convert.ToDateTime(dtpData_nasc.Value)
                );

            cliente.InserirCliente();
            if (cliente.Id > 0)
            {
                txtId.Text = cliente.Id.ToString();
                CarregaGridDeClientes();

                //MessageBox.Show($"Cliente Cadastrado com o ID {cliente.Id}");

            }
            else
            {
                MessageBox.Show("Falha ao Inserir Cliente!");
            }
        }
        public void mensagem()
        {
            FrmNovoCliente testDialog = new();
            {
                if (testDialog.ShowDialog(this) == DialogResult.OK)
                {
                    FrmAdicionarEndereco frmadicionarEndereco = new();
                    frmadicionarEndereco.MdiParent = this;

                    frmadicionarEndereco.Show();
                }
                testDialog.Dispose();


            }


        }

        private void button1_Click(object sender, EventArgs e)//adicionar endereço
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }

}

