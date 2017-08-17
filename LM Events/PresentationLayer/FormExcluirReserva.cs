using LM_Events.DataAcessLayer;
using LM_Events.DataObjectBase.Dados;
using LM_Events.GUI;
using System;
using System.Data;
using System.Windows.Forms;

namespace LM_Events.PresentationLayer
{
    public partial class FormExcluirReserva : Form
    {
        public FormExcluirReserva()
        {
            InitializeComponent();
        }

        private void FormExcluirReserva_Load(object sender, EventArgs e)
        {
            dgvExcluirReserva.DataSource = new ReservaStandsDAL().standsReservados();
            if (dgvExcluirReserva.RowCount == 0)
            {
                MessageBox.Show("Nenhuma reserva disponível.", "Cancelamento de Reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void dgvExcluirReserva_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView row = (DataRowView)dgvExcluirReserva.CurrentRow.DataBoundItem;
            textCodigoInscricao.Text = Convert.ToString(row["Código Stand"]);
        }

        private void buttonSairReserva_Click(object sender, EventArgs e)
        {
            DialogResult rlt = MessageBox.Show("Deseja realmente sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (rlt == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buttonExcluirReserva_Click(object sender, EventArgs e)
        {
            DBReservaStands reserva = new DBReservaStands();
            reserva.Stand_id = Convert.ToInt32(textCodigoInscricao.Text);
            
            DialogResult rlt = MessageBox.Show("Deseja realmente excluir essa reserva?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (rlt == DialogResult.Yes)
            {
                new ReservaStandsDAL().deleteReserva(reserva.Stand_id);
                new StandDAL().excluirReserva(reserva.Stand_id, "Não");
                MessageBox.Show("Reserva excluida com sucesso.", "Reserva Excluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormCleaner.Clear(this);
            }
            dgvExcluirReserva.DataSource = new ReservaStandsDAL().standsReservados();
            if (dgvExcluirReserva.RowCount == 0)
            {
                MessageBox.Show("Nenhuma reserva disponível.", "Cancelamento de Reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
        }
    }
}
