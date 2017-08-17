using LM_Events.DataAcessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LM_Events.PresentationLayer
{
    public partial class FormStandReservado : Form
    {
        public FormStandReservado()
        {
            InitializeComponent();
        }

        private void btnSairListaEventos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormStandReservado_Load(object sender, EventArgs e)
        {
            dgvListaReserva.DataSource = new ReservaStandsDAL().standsReservados();
            if (dgvListaReserva == null)
            {
                MessageBox.Show("Nenhuma Stand reservado.", "Stand Reservados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
