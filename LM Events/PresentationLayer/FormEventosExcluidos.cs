using LM_Events.DataAcessLayer;
using LM_Events.DataObjectBase;
using LM_Events.DataObjectBase.Dados;
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
    public partial class FormEventosExcluidos : Form
    {
        public FormEventosExcluidos()
        {
            InitializeComponent();
        }

        private void FormInscricoesCanceladas_Load(object sender, EventArgs e)
        {
            dgvEventoCancelado.DataSource = new EventosDAL().GetEventosCancelados();
            if (dgvEventoCancelado.DataSource == null)
            {
                MessageBox.Show("Nenhum evento cancelado.", "Nada Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }
        private void dgvInscricaoCancelada_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView evento = (DataRowView)dgvEventoCancelado.CurrentRow.DataBoundItem;
            textCodigoEvento.Text = Convert.ToString((int)evento["Código do Evento"]);
        }
        private void buttonExcluirInscricao_Click(object sender, EventArgs e)
        {
            DBEvento eRestaurar = new DBEvento();
            eRestaurar.EventoId = Convert.ToInt32(textCodigoEvento.Text);
            DialogResult rlt = MessageBox.Show("Deseja realmente restaurar esse Evento?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (rlt == DialogResult.Yes)
            {
                new EventosDAL().restaurarEvento(eRestaurar.EventoId);
                MessageBox.Show("Evento restaurado com sucesso.", "Evento Restaurado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            dgvEventoCancelado.DataSource = new EventosDAL().GetEventosCancelados();
            if (dgvEventoCancelado.DataSource == null)
            {
                MessageBox.Show("Nenhum evento cancelado.", "Nada Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void buttonSairCancelaInscricao_Click(object sender, EventArgs e)
        {
            DialogResult rlt = MessageBox.Show("Deseja realmente sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (rlt == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
