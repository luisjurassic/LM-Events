using LM_Events.DataAcessLayer;
using LM_Events.DataObjectBase;
using LM_Events.DataObjectBase.Dados;
using LM_Events.Validator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace LM_Events.PresentationLayer
{
    public partial class FormAtualizarEventos : Form
    {
        public FormAtualizarEventos()
        {
            InitializeComponent();
        }

        private void buttonCancelarEvento_Click(object sender, EventArgs e)
        {
            DialogResult rlt = MessageBox.Show("Deseja realmente sair? Dados não salvos seram perdidos", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (rlt == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void AtualizarEventos_Load(object sender, EventArgs e)
        {
            mCFim.Visible = false;
            mCInicio.Visible = false;
        }
        private void buttonBuscaEventos_Click(object sender, EventArgs e)
        {
            FormProcurarEvento ATEventos = new FormProcurarEvento(this);
            ATEventos.ShowDialog();
        }
        public void CarregarComboCidade()
        {
            comboCadastroCidadeEventoupATU.DataSource = new BindingSource(ListasDAL.ObterCidade(), null);
            comboCadastroCidadeEventoupATU.DisplayMember = "Nome";
            comboCadastroCidadeEventoupATU.ValueMember = "CidadeId";
        }
        public void CarregarComboEstado()
        {
            comboCadastroUFEventoupATU.DataSource = new BindingSource(ListasDAL.ObterEstado(), null);
            comboCadastroUFEventoupATU.DisplayMember = "Sigla";
            comboCadastroUFEventoupATU.ValueMember = "EstadoId";
        }
        public void CarregarComboTipoEvento()
        {
            TextTipoEventoATU.DataSource = new BindingSource(ListasDAL.ObterTipoEvento(), null);
            TextTipoEventoATU.DisplayMember = "Descricao";
            TextTipoEventoATU.ValueMember = "TipoEventoId";
        }

        private void buttonSalvarEvento_Click(object sender, EventArgs e)
        {
            ListaDeErros list = new ListaDeErros();
            ValidaAtualizarEndereco valiendereco = new ValidaAtualizarEndereco();
            ValidaAtualizarEvento valiAtualizarEvento = new ValidaAtualizarEvento();
            DBEndereco atualizarEnderecoPF = new DBEndereco();
            DBEvento atualizarevento = new DBEvento();
            EnderecoDAL enderecoevento = new EnderecoDAL();
            EventosDAL dadosUpdateEvento = new EventosDAL();

            atualizarevento.EventoId = Convert.ToInt32(EventoIdUp.Text);
            atualizarevento.NomeEvento = TextNomeEventoATu.Text;
            #region  Atualizar data inicio evento
            if (string.IsNullOrWhiteSpace(Convert.ToString(dateEventoInicioupATU.Text)))
            {
                list.AddErro("Data de inicio do evento deve ser informada");
            }
            else if (!(ValidaData.IsValidDOB(Convert.ToString(dateEventoInicioupATU.Text))))
            {
                list.AddErro("Data de inicio do evento é invalida.");
            }
            else if (!(ValidaData.ValidateBirthday(Convert.ToString(dateEventoInicioupATU.Text))))
            {
                list.AddErro("Data de inicio do evento deve estar acima de 01/01/1800");
            }
            else
            {
                atualizarevento.DataInicio = Convert.ToDateTime(dateEventoInicioupATU.Text);
            }
            #endregion
            #region  Atualizar data fim evento
            if (string.IsNullOrWhiteSpace(Convert.ToString(dateEventoFimupATU.Text)))
            {
                list.AddErro("Data de fim do evento deve ser informada");
            }
            else if (!(ValidaData.IsValidDOB(Convert.ToString(dateEventoFimupATU.Text))))
            {
                list.AddErro("Data de fim do evento é invalida.");
            }
            else if (!(ValidaData.ValidateBirthday(Convert.ToString(dateEventoFimupATU.Text))))
            {
                list.AddErro("Data de fim do evento deve estar acima de 01/01/1800");
            }
            else
            {
                atualizarevento.DataFim = Convert.ToDateTime(dateEventoFimupATU.Text);
            }
            #endregion
            atualizarevento.HoraInicio = maskedHoraInicioEventoATU.Text;
            atualizarevento.HoraFim = maskedHoraFimEventoATU.Text;
            decimal d;
            if (!decimal.TryParse(txtValorInscricaoATU.Text, out d))
            {
                list.AddErro("Caracter inválido para valor em dinheiro.");
            }
            else
            {
                atualizarevento.ValorEvento = Convert.ToDecimal(txtValorInscricaoATU.Text);
            }
            ListaDeErros resultEvento = valiAtualizarEvento.ValidarEvento(atualizarevento);

            int idREcebido = atualizarevento.EnderecoEvento_id;
            atualizarEnderecoPF.EnderecoId = idREcebido;
            atualizarEnderecoPF.CEP = maskedCEPEventoupATU.Text;
            atualizarEnderecoPF.Rua = textCadastroRuaEventoupATU.Text;
            atualizarEnderecoPF.Bairro = textCadastroBairroEventoupATU.Text;
            atualizarEnderecoPF.Numero = textCadastroNumeroEventoupATU.Text;
            atualizarEnderecoPF.Complemento = textCadastroComplementoEventoupATu.Text;
            atualizarEnderecoPF.Cidade_id = Convert.ToInt32(comboCadastroCidadeEventoupATU.SelectedValue);
            atualizarEnderecoPF.Estado_id = Convert.ToInt32(comboCadastroUFEventoupATU.SelectedValue);
            ListaDeErros resultEndereco = valiendereco.Validar(atualizarEnderecoPF);

            if (resultEvento.IsValid && resultEndereco.IsValid && list.IsValid)
            {
                dadosUpdateEvento.atualizardadoseventosUPA(atualizarevento);
                enderecoevento.atualizarDadosEndereco(atualizarEnderecoPF);
                MessageBox.Show(atualizarevento.NomeEvento + " atualizado com sucesso.");
                this.Close();
                return;
            }

            list.erros.AddRange(resultEndereco.erros);
            list.erros.AddRange(resultEvento.erros);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.erros.Count; i++)
            {
                sb.AppendLine(list.erros[i]);
            }
            MessageBox.Show(sb.ToString(), "Erro de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #region Funções botão calendário
        private void btnDataInicio_Click(object sender, EventArgs e)
        {
            mCInicio.Visible = true;
        }
        private void mCInicio_MouseDown(object sender, MouseEventArgs e)
        {
            dateEventoInicioupATU.Text = Convert.ToString(mCInicio.SelectionEnd);
        }
        private void mCInicio_MouseLeave(object sender, EventArgs e)
        {
            mCInicio.Visible = false;
        }

        private void btnDataFim_Click(object sender, EventArgs e)
        {
            mCFim.Visible = true;
        }
        private void mCFim_MouseDown(object sender, MouseEventArgs e)
        {
            dateEventoFimupATU.Text = Convert.ToString(mCFim.SelectionEnd);
        }
        private void mCFim_MouseLeave(object sender, EventArgs e)
        {
            mCFim.Visible = false;
        }
        #endregion

    }
}
