using LM_Events.DataAcessLayer;
using LM_Events.DataObjectBase;
using LM_Events.DataObjectBase.Dados;
using LM_Events.GUI;
using LM_Events.Validator;
using LM_Events.ViewModel;
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
    public partial class FormReservaStand : Form
    {
        DadosReserva dadosRes = new DadosReserva();
        public FormReservaStand()
        {
            InitializeComponent();
        }

        private void textProcurarCliente_TextChanged(object sender, EventArgs e)
        {
            if (textProcurarCliente.Text.Length > 3)
            {
                string exposito = textProcurarCliente.Text;
                dgvExpositor.DataSource = new PessoaJuridicaDAL().GetPessoaJuridica(exposito);
            }
        }
        private void FormReservaStand_Load(object sender, EventArgs e)
        {

            dgvStands.DataSource = new StandDAL().listaStandParaReserva();
            if (dgvStands.RowCount == 0)
            {
                MessageBox.Show("Stand para reserva indisponíveis.", "Stand Esgotados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dgvStands_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStands.RowCount != 0)
            {
                DBStands stan = (DBStands)dgvStands.CurrentRow.DataBoundItem;
                textCodigoEvento.Text = Convert.ToString(stan.StandsId);

                dadosRes.ValorReserva = Convert.ToDouble(stan.ValorStand);
                textCodigoEvento.Enabled = true;
            }
        }
        private void dgvExpositor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvExpositor.RowCount != 0)
            {
                DBPessoaJuridica cliente = (DBPessoaJuridica)dgvExpositor.CurrentRow.DataBoundItem;
                textCodigoCliente.Text = Convert.ToString(cliente.PessoaJuridicaId);

                dadosRes.idPessoa = cliente.PessoaJuridicaId;

                textCodigoCliente.Enabled = true;
            }
            return;
        }
        private void buttonCancelarReserva_Click(object sender, EventArgs e)
        {
            string msg = "Fechar tela de reserva? Dados não comfirmados serão perdidos!";
            string titlle = "Atenção!";
            DialogResult res = MessageBox.Show(msg, titlle, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void buttonConfirmaReserva_Click(object sender, EventArgs e)
        {
            ListaDeErros list = new ListaDeErros();
            DBStands dadosStands = new DBStands();
            DBReservaStands reservaDB = new DBReservaStands();
            #region Validações
            if (string.IsNullOrWhiteSpace(Convert.ToString(textCodigoEvento.Text)))
            {
                list.AddErro("O Stand deve ser selecionado.");
            }
            else
            {
                dadosStands.StandsId = Convert.ToInt32(textCodigoEvento.Text);
                dadosRes.idStands = dadosStands.StandsId;
                reservaDB.Stand_id = dadosRes.idStands;
            }
            if (string.IsNullOrWhiteSpace(Convert.ToString(textCodigoCliente.Text)))
            {
                list.AddErro("O expositor deve ser selecionado.");
            }
            else
            {
                reservaDB.PessoaJuridica_id = Convert.ToInt32(textCodigoCliente.Text);
            }
            dadosStands.Pago = "Nao";
            dadosStands.Disponivel = false;
            #endregion

            if (list.IsValid)
            {
                new ReservaStandsDAL().newReserva(reservaDB);
                new StandDAL().Reserva(dadosStands);

                MessageBox.Show("Stand reservado com exito.", "Stand Reservado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (checkReserva.Checked == true)
                {
                    dadosStands.Pago = "Sim";
                    new StandDAL().atualizarSituacaoReserva(dadosStands);
                    dgvStands.DataSource = new StandDAL().listaStandParaReserva();
                    FormCleaner.Clear(this);
                    if (dgvStands.RowCount == 0)
                    {
                        MessageBox.Show("Stand para reserva indisponíveis.", "Stand Esgotados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    return;
                }
                FormPagamento pag = new FormPagamento(dadosRes);
                this.Hide();
                pag.ShowDialog();
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
