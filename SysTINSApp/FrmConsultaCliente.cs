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
    public partial class FrmConsultaCliente : Form
    {
        public FrmConsultaCliente()
        {
            InitializeComponent();

        }

        private void FrmConsultaCliente_Load(object sender, EventArgs e)
        {
            CarregaGridUsuarios();

        }

        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CarregaGridUsuarios()
        {
            dgvConsulta.Rows.Clear();
            var ListadeDeClientes = Cliente.ObterListaClientes();
            int linha = 0;
            foreach (var cliente in ListadeDeClientes)// para cada usuario dentro da lista de usuarios faça
            {
                dgvConsulta.Rows.Add();//para cada usuarios adicione uma linha 
                dgvConsulta.Rows[linha].Cells[0].Value = cliente.Id;// na linhas [linha que vale na posição 0] que cells[ posição da coluna 0] que tem o value de usuario.Id ou seja id do usuario
                dgvConsulta.Rows[linha].Cells[1].Value = cliente.Id;
                linha++;//ele pula a linha
            }
        }
        private void dgvConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
