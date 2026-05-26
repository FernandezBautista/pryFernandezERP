using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFernandezERP
{
    public partial class frmAuditoria : Form
    {
        public frmAuditoria()
        {
            InitializeComponent();
        }

        private void frmInformacion_Load(object sender, EventArgs e)
        {
            CAuditoria.Grabar("Ingreso a Auditoria");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbFechayHora_SelectedIndexChanged(object sender, EventArgs e)
        {
                    }

        private void grpFiltrar_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbAccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void btnTodo_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void dgvAuditoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
