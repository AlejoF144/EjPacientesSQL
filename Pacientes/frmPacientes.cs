using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacientes
{
    public partial class frmPacientes : Form
    {
        public frmPacientes()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNuevoPaciente frm = new frmNuevoPaciente();
            frm.Show();
        }

        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            DataTable dt = Pacientes.BuscarTodo();
            LlenarGrilla(dt);
        }
        private void LlenarGrilla(DataTable dt)
        {
            dgvPacientes.DataSource = null;
            dgvPacientes.DataSource = dt;
        }

        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
