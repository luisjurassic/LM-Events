using LM_Events.DataAcessLayer;
using LM_Events.DataObjectBase;
using LM_Events.DataObjectBase.Dados;
using System;
using System.Data;
using System.Windows.Forms;

namespace LM_Events.PresentationLayer
{
    public partial class FormInscricoesExcluidos : Form
    {
        public FormInscricoesExcluidos()
        {
            InitializeComponent();
        }

        private void FormInscricoesCanceladas_Load(object sender, EventArgs e)
        {
            InscricoesDAL inscricoes = new InscricoesDAL();
            dgvinscricoesCancelado.DataSource = inscricoes.InscricoesCanceladas();
            if (dgvinscricoesCancelado.DataSource == null)
            {
                MessageBox.Show("Nenhuma inscrição cancelada.", "Nada encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }
        private void dgvInscricaoCancelada_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView row = (DataRowView)dgvinscricoesCancelado.CurrentRow.DataBoundItem;
            textCodigoInscricoes.Text = Convert.ToString((int)row["Inscrição"]);
        }
        private void buttonExcluirInscricao_Click(object sender, EventArgs e)
        {
            DBInscricoes iRestaurar = new DBInscricoes();
            iRestaurar.InscricoesId = Convert.ToInt32(textCodigoInscricoes.Text);
            DialogResult rlt = MessageBox.Show("Deseja realmente restaurar essa Inscrição?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (rlt == DialogResult.Yes)
            {
                new InscricoesDAL().restaurarInscricao(iRestaurar.InscricoesId);
                MessageBox.Show(iRestaurar.PessoaFisica_id + "Inscrição restaurada com sucesso.", "Inscrição Restaurada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            dgvinscricoesCancelado.DataSource = new InscricoesDAL().InscricoesCanceladas();
            if (dgvinscricoesCancelado.DataSource == null)
            {
                MessageBox.Show("Nenhuma inscrição cancelada.", "Nada encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
