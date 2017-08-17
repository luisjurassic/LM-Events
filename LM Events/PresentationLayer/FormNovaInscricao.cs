using LM_Events.DataAcessLayer;
using LM_Events.DataObjectBase;
using LM_Events.DataObjectBase.Dados;
using LM_Events.Validator;
using LM_Events.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using System.Windows.Forms;

namespace LM_Events.PresentationLayer
{
    public partial class FormNovaInscricao : Form
    {
        DadosPagamento dadosPag = new DadosPagamento();
        
        public FormNovaInscricao()
        {
            InitializeComponent();
        }

        private void buttonCancelarIncricao_Click(object sender, EventArgs e)
        {
            string msg = "Fechar tela de inscrição? Dados não comfirmados serão perdidos!";
            string titlle = "Atenção!";
            DialogResult res = MessageBox.Show(msg, titlle, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Funcao preenche combox do formulario com descontos
        /// </summary>
        private void InscricaoPagamento_Load(object sender, EventArgs e)
        {
            List<DBDescontos> tipoDescontos = ListasDAL.ObterDescontos();
            comboDescontos.DisplayMember = "Descricao";
            comboDescontos.ValueMember = "DescontosId";
            comboDescontos.DataSource = tipoDescontos;

            comboDescontos.Enabled = false;
            maskedData.Text = Convert.ToString(DateTime.Now.ToShortDateString());
            textInscritoPor.Text = Parametros.GetUser().Usuario;
        }

        private void dgvEvento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEvento.DataSource != null)
            {
                DBEvento evento = (DBEvento)dgvEvento.CurrentRow.DataBoundItem;
                textCodigoEvento.Text = Convert.ToString(evento.EventoId);

                dadosPag.ValorEvento = Convert.ToDouble(evento.ValorEvento);

                textCodigoEvento.Enabled = true;
                numericItem.Enabled = true;
                numericItem.Minimum = 1;
            }
            return;
        }
        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCliente.DataSource != null)
            {
                DBPessoaFisica cliente = (DBPessoaFisica)dgvCliente.CurrentRow.DataBoundItem;
                textCodigoCliente.Text = Convert.ToString(cliente.PessoaFisicaId);

                textCodigoCliente.Enabled = true;
                comboDescontos.Enabled = true;
            }
            return;
        }

        private void textProcurarCliente_TextChanged(object sender, EventArgs e)
        {
            if (textProcurarCliente.Text.Length > 3)
            {
                string nomeCliente = textProcurarCliente.Text;
                dgvCliente.DataSource = new PessoaFisicaDAL().GetPessoaFisica(nomeCliente);
            }
        }
        private void textProcurarEvento_TextChanged(object sender, EventArgs e)
        {
            if (textProcurarEvento.Text.Length > 3)
            {
                string nomeEvento = textProcurarEvento.Text;
                dgvEvento.DataSource = new EventosDAL().GetEventosLike(nomeEvento);
            }
        }

        private void buttonConfirmaInscricao_Click(object sender, EventArgs e)
        {
            ListaDeErros list = new ListaDeErros();
            DBInscricoes dadosInscricoes = new DBInscricoes();
            DBReservaInscricao reservaInscricao = new DBReservaInscricao();
            InscricoesDAL returnId = new InscricoesDAL();

            if (string.IsNullOrWhiteSpace(Convert.ToString(textCodigoEvento.Text)))
            {
                list.AddErro("O evento deve ser selecionado.");
            }
            else
            {
                dadosInscricoes.Evento_id = Convert.ToInt32(textCodigoEvento.Text);
            }
            if (string.IsNullOrWhiteSpace(Convert.ToString(textCodigoCliente.Text)))
            {
                list.AddErro("O cliente deve ser selecionado.");
            }
            else
            {
                dadosInscricoes.PessoaFisica_id = Convert.ToInt32(textCodigoCliente.Text);
            }
            if (numericItem.Value == 0)
            {
                list.AddErro("Nenhum item selecionado.");
            }
            else
            {
                dadosInscricoes.Itens = Convert.ToInt32(numericItem.Value);
            }
            if (string.IsNullOrWhiteSpace(textInscritoPor.Text))
            {
                list.AddErro("Nenhum usuário responsável pela inscrição informado.");
            }
            else
            {
                dadosInscricoes.InscritoPor = textInscritoPor.Text;
            }
            dadosInscricoes.Desconto_id = ((DBDescontos)comboDescontos.SelectedValue).DescontosId;
            dadosInscricoes.DataInscricao = Convert.ToDateTime(maskedData.Text);
            dadosInscricoes.Pago = "Não";

            if (list.IsValid)
            {
                dadosPag.pesquisaPcentDescontos(dadosInscricoes.Desconto_id);
                dadosPag.Itens = dadosInscricoes.Itens;
                dadosPag.ID_Inscricao = returnId.newInscricao(dadosInscricoes);
                reservaInscricao.Inscricao_id = dadosPag.ID_Inscricao;
                reservaInscricao.PessoaFisica_id = dadosInscricoes.PessoaFisica_id;
                new ReservaInscricaoDAL().newReserva(reservaInscricao);

                MessageBox.Show("Cliente inscrito com exito.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormPagamento pag = new FormPagamento(dadosPag);
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
