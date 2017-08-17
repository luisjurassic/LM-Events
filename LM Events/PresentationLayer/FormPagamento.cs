using LM_Events.DataAcessLayer;
using LM_Events.DataObjectBase.Dados;
using System.Collections.Generic;
using LM_Events.ViewModel;
using System;
using System.Windows.Forms;
using System.Data;
using LM_Events.GUI;

namespace LM_Events.PresentationLayer
{
    public partial class FormPagamento : Form
    {
        DadosPagamento dadosPagamento2 = new DadosPagamento();
        DadosReserva dadosReservas2 = new DadosReserva();
        CaixaDAL caixaDAL = new CaixaDAL();

        public FormPagamento()
        {
            InitializeComponent();
            textValorRecebido.Focus();
        }

        DadosReserva dadosReservas = null;
        public FormPagamento(DadosReserva dadosr)
        {
            InitializeComponent();
            dadosReservas = dadosr;
        }

        DadosPagamento dadosPagamento = null;
        public FormPagamento(DadosPagamento dados)
        {
            InitializeComponent();
            dadosPagamento = dados;
            textValorRecebido.Focus();
        }

        private void Pagamento_Load(object sender, EventArgs e)
        {
            List<DBTipoPagamento> tipoPagamento = ListasDAL.ObterTipoPagamento();
            comboTipoPagamento.DisplayMember = "Descricao";
            comboTipoPagamento.ValueMember = "TipoPagamentoId";
            comboTipoPagamento.DataSource = tipoPagamento;
            #region Caregar dados após inscrição
            if (dadosPagamento != null)
            {
                int itens = dadosPagamento.Itens;
                double porcentagem = Convert.ToDouble(dadosPagamento.Desconto) / 100;
                double valor = dadosPagamento.ValorEvento;
                double valorDesconto = valor * porcentagem;
                double ValorTotal = (valor - valorDesconto) * itens;
                textValorTotal.Text = string.Format("{0:0.00}", ValorTotal);

                dadosPagamento.DinheiroEmCaixa = new CaixaDAL().GetDinheiroCaixa();

                dgvPagamento.DataSource = new InscricoesDAL().InscricaoID(dadosPagamento.ID_Inscricao);
                checkInscricoes.Enabled = false;
                checkStands.Enabled = false;
            }
            #endregion
            #region Carrega dados apos reserva
            if (dadosReservas != null)
            {
                double valorT = dadosReservas.ValorReserva;
                textValorTotal.Text = string.Format("{0:0.00}", valorT);

                dadosReservas.DinheiroEmCaixa = new CaixaDAL().GetDinheiroCaixa();

                dgvPagamento.DataSource = new StandDAL().PagamentoReservaID(dadosReservas.idStands);
                checkInscricoes.Enabled = false;
                checkStands.Enabled = false;
            }
            #endregion
        }
        private void buttonFecharPagamento_Click(object sender, EventArgs e)
        {
            string msg = "Fechar tela de Pagamento e  pagar e inscrição posteriormente?";
            string titlle = "Atenção!";
            DialogResult res = MessageBox.Show(msg, titlle, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {

                this.Close();
            }
        }
        private void buttonConfirmaPagamento_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(comboTipoPagamento.SelectedValue)))
            {
                MessageBox.Show("Favor selecione o tipo de pagamento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textValorRecebido.Text = "";
                textValorTroco.Text = "";
                return;
            }

            if (textValorTotal.Text != "" && textValorRecebido.Text != "")
            {
                double ValorTotal = Convert.ToDouble(textValorTotal.Text);
                double ValorRecebido = Convert.ToDouble(textValorRecebido.Text);

                if (ValorRecebido >= ValorTotal)
                {
                    DBInscricoes inscricao = new DBInscricoes();
                    DBStands stands = new DBStands();
                    DBCaixa caixaDB = new DBCaixa();
                    //   DBCaixa caixaDB2 = new DBCaixa();
                    #region Pagar inscrição
                    if (dadosPagamento != null)
                    {
                        inscricao.InscricoesId = dadosPagamento.ID_Inscricao;
                        inscricao.Pago = "Sim";
                        double DinheiroEmCaixa = dadosPagamento.DinheiroEmCaixa;

                        caixaDB.DinheiroCaixa = ValorTotal + DinheiroEmCaixa;

                        new InscricoesDAL().atualizarSituacao(inscricao);
                        new CaixaDAL().updateCaixa(caixaDB);

                        MessageBox.Show("Pagamento efetuado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        return;
                    }
                    else if (dadosPagamento2.ID_Inscricao != 0)
                    {
                        inscricao.InscricoesId = dadosPagamento2.ID_Inscricao;
                        inscricao.Pago = "Sim";
                        double DinheiroEmCaixa2 = dadosPagamento2.DinheiroEmCaixa;

                        caixaDB.DinheiroCaixa = ValorTotal + dadosPagamento2.DinheiroEmCaixa;

                        new InscricoesDAL().atualizarSituacao(inscricao);
                        new CaixaDAL().updateCaixa(caixaDB);

                        MessageBox.Show("Pagamento efetuado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormCleaner.Clear(this);
                        dgvPagamento.DataSource = new InscricoesDAL().GetTodasInscricoes();
                        dadosPagamento2.ID_Inscricao = 0;
                        return;
                    }
                    #endregion
                    #region Pagar Stands
                    if (dadosReservas != null)
                    {
                        stands.StandsId = dadosReservas.idStands;
                        stands.Pago = "Sim";
                        double DinheiroEmCaixa = dadosReservas.DinheiroEmCaixa;

                        caixaDB.DinheiroCaixa = ValorTotal + DinheiroEmCaixa;

                        new StandDAL().atualizarSituacaoReserva(stands);
                        new CaixaDAL().updateCaixa(caixaDB);

                        MessageBox.Show("Pagamento efetuado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        return;
                    }
                    else if (dadosReservas2.idStands != 0)
                    {
                        stands.StandsId = dadosReservas2.idStands;
                        stands.Pago = "Sim";
                        double DinheiroEmCaixa = dadosReservas2.DinheiroEmCaixa;

                        caixaDB.DinheiroCaixa = ValorTotal + DinheiroEmCaixa;

                        new StandDAL().atualizarSituacaoReserva(stands);
                        new CaixaDAL().updateCaixa(caixaDB);

                        MessageBox.Show("Pagamento efetuado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormCleaner.Clear(this);
                        dgvPagamento.DataSource = new StandDAL().PagamentoReserva();
                        dadosReservas2.idStands = 0;
                        return;
                    }
                    #endregion
                }
                else
                {
                    MessageBox.Show("Valor informado é inválido. Digite novamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textValorRecebido.Text = "";
                    textValorTroco.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Nenhum valor informado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textValorRecebido_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textValorTotal.Text))
            {
                if (textValorRecebido.TextLength > 1)
                {
                    double ValorRecebido = Convert.ToDouble(textValorRecebido.Text);
                    double ValorTotal = Convert.ToDouble(textValorTotal.Text);
                    double Troco = (ValorRecebido - ValorTotal);
                    decimal formatTroco = Convert.ToDecimal(Troco);
                    textValorTroco.Text = string.Format("{0:0.00}", formatTroco);

                }
            }
            return;
        }

        private void dgvPagamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (checkInscricoes.Checked == true)
            {
                
                DataRowView row = (DataRowView)dgvPagamento.CurrentRow.DataBoundItem;
                dadosPagamento2.Pago = (string)row["Pago"];
                if (dadosPagamento2.Pago == "Sim")
                {
                    MessageBox.Show("Inscrição já foi paga. Selecione um item não pago!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dadosPagamento2.ID_Inscricao = (int)row["Inscrição"];
                    dadosPagamento2.Itens = (int)row["Itens"];
                    dadosPagamento2.ValorEvento = Convert.ToDouble((decimal)row["Valor do Evento"]);
                    dadosPagamento2.Desconto = Convert.ToDouble((decimal)row["Porcentagem de Desconto"]);

                    int itens = dadosPagamento2.Itens;
                    double porcentagem = Convert.ToDouble(dadosPagamento2.Desconto) / 100;
                    double valor = dadosPagamento2.ValorEvento;
                    double valorDesconto = valor * porcentagem;
                    double ValorTotal = (valor - valorDesconto) * itens;

                    textValorTotal.Text = string.Format("{0:0.00}", ValorTotal);
                    dadosPagamento2.DinheiroEmCaixa = (Double)caixaDAL.GetDinheiroCaixa();
                }
                return;
            }
            else if (checkStands.Checked == true)
            {
                DataRowView row = (DataRowView)dgvPagamento.CurrentRow.DataBoundItem;
                dadosReservas2.Pago = (string)row["Pago"];
                if (dadosReservas2.Pago == "Sim")
                {
                    MessageBox.Show("Stand já foi pago. Selecione um item não pago!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dadosReservas2.idStands = (int)row["Código Stand"];
                    dadosReservas2.ValorReserva = Convert.ToDouble((string)row["Valor do Stand"]);
                    double valor = dadosReservas2.ValorReserva;
                    textValorTotal.Text = string.Format("{0:0.00}", valor);
                    dadosReservas2.DinheiroEmCaixa = (Double)caixaDAL.GetDinheiroCaixa();
                }
            }

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkInscricoes.Checked == true)
            {
                checkStands.Checked = false;
                InscricoesDAL inscricoesDAL2 = new InscricoesDAL();
                dgvPagamento.DataSource = null;
                dgvPagamento.DataSource = inscricoesDAL2.GetTodasInscricoes();
            }
            else
            {
                dgvPagamento.DataSource = null;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkStands.Checked == true)
            {
                checkInscricoes.Checked = false;
                StandDAL stands = new StandDAL();
                dgvPagamento.DataSource = null;
                dgvPagamento.DataSource = stands.PagamentoReserva();
            }
            else
            {
                dgvPagamento.DataSource = null;
            }
        }
    }
}
