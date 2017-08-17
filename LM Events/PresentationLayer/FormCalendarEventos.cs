using LM_Events.DataAcessLayer;
using System;
using System.Windows.Forms;

namespace LM_Events.PresentationLayer
{
    public partial class FormCalendarEventos : Form
    {
        public FormCalendarEventos()
        {
            InitializeComponent();
        }
        private void btnDataInicio_Click(object sender, EventArgs e)
        {
            calendarioEventos.Visible = true;
        }
        private void calendarioEventos_MouseLeave(object sender, EventArgs e)
        {
            calendarioEventos.Visible = false;
        }
        private void btnSairListaEventos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void calendarioEventos_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (radioButtonDia.Checked)
            {               
                EventosDAL dal = new EventosDAL();
                dgvListaEvento.DataSource = dal.GetEventosPorDia(calendarioEventos.SelectionEnd.Date);
            }
            else if(radioButtonMes.Checked)
            {
                EventosDAL dal = new EventosDAL();
                dgvListaEvento.DataSource = dal.GetEventosPorMes(calendarioEventos.SelectionEnd.Month, calendarioEventos.SelectionEnd.Year);
            }
           
        }
        private void FormCalendarEventos_Load(object sender, EventArgs e)
        {
            btnDataInicio.Enabled = false;
        }
        private void radioButtonDia_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDia.Checked)
            {
                btnDataInicio.Enabled = true;
            }            
            else
            {
                btnDataInicio.Enabled = false;
            }
        }
        private void radioButtonMes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMes.Checked)
            {
                btnDataInicio.Enabled = true;
            }
            else
            {
                btnDataInicio.Enabled = false;
            }
        }
    }
}
