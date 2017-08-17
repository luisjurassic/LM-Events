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
    public partial class FormInscricaoReservada : Form
    {
        public FormInscricaoReservada()
        {
            InitializeComponent();
        }

        private void FormInscricaoReservada_Load(object sender, EventArgs e)
        {
            dgvListaInscricao.DataSource = new ReservaInscricaoDAL().inscricoesReservados();
        }

        private void btnSairLista_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
