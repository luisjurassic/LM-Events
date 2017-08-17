using LM_Events.DataAcessLayer;
using LM_Events.DataObjectBase.Dados;
using LM_Events.Validator;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace LM_Events.PresentationLayer
{
    public partial class FormExcluirInscricao : Form
    {
        public FormExcluirInscricao()
        {
            InitializeComponent();
        }

        private void FormExcluirInscricao_Load(object sender, EventArgs e)
        {
            dgvCancelarInscricao.DataSource = null;
            dgvCancelarInscricao.DataSource = new InscricoesDAL().TabelaDeInscricoes();
        }

        private void dgvCancelarInscricao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView row = (DataRowView)dgvCancelarInscricao.CurrentRow.DataBoundItem;
            textNomeExcluirCadastro.Text = Convert.ToString((string)row["Nome do Evento"]);
            textCodigoInscricao.Text = Convert.ToString((int)row["Inscrição"]);
            textCodigoCliente.Text = Convert.ToString((int)row["Código Cliente"]);
        }

        private void buttonSairCancelaInscricao_Click(object sender, EventArgs e)
        {
            DialogResult rlt = MessageBox.Show("Fechar tela de Cancelamento de Inscrição?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (rlt == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buttonExcluirInscricao_Click(object sender, EventArgs e)
        {
            ListaDeErros list = new ListaDeErros();
            DBInscricoes delInscricao = new DBInscricoes();
            if (string.IsNullOrWhiteSpace(textCodigoInscricao.Text))
            {
                list.AddErro("O código de inscrição é obrigatório.");
            }
            else
            {
                delInscricao.InscricoesId = Convert.ToInt32(textCodigoInscricao.Text);
            }
            if (string.IsNullOrWhiteSpace(textCodigoCliente.Text))
            {
                list.AddErro("O código do cliente é obrigatório");
            }
            else
            {
                delInscricao.PessoaFisica_id = Convert.ToInt32(textCodigoCliente.Text);
            }
            if (string.IsNullOrWhiteSpace(textNomeExcluirCadastro.Text))
            {
                list.AddErro("o nome do evento não foi informado.");
            }

            if (list.IsValid)
            {
                new ReservaInscricaoDAL().deleteReserva(delInscricao.InscricoesId);
                new InscricoesDAL().excluirInscricao(delInscricao.InscricoesId, delInscricao.PessoaFisica_id);
                MessageBox.Show("Inscrição cancelada com exito.", "Cancelamento Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.erros.Count; i++)
            {
                sb.AppendLine(list.erros[i]);
            }
            MessageBox.Show(sb.ToString(), "Erro de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
