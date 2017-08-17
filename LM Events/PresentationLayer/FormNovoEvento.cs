using LM_Events.DataAcessLayer;
using LM_Events.DataObjectBase;
using LM_Events.DataObjectBase.Dados;
using LM_Events.Validator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using System.Windows.Forms;

namespace LM_Events.PresentationLayer
{
    public partial class FormNovoEvento : Form
    {
        public FormNovoEvento()
        {
            InitializeComponent();
        }

        private void NovoEvento_Load(object sender, EventArgs e)
        {
            BindingSource bindingSourceTipoEvento = new BindingSource();
            List<DBTipoEvento> tipoEventoCombo = ListasDAL.ObterTipoEvento();
            bindingSourceTipoEvento.DataSource = tipoEventoCombo;
            comboBoxTipoEvento.DataSource = bindingSourceTipoEvento.DataSource;
            comboBoxTipoEvento.DisplayMember = "Descricao";
            comboBoxTipoEvento.ValueMember = "TipoEventoId";

            BindingSource bindingSourceCidade = new BindingSource();
            List<DBCidade> cidadeCombo = ListasDAL.ObterCidade();
            bindingSourceCidade.DataSource = cidadeCombo;
            comboCadastroCidadeEvento.DataSource = bindingSourceCidade.DataSource;
            comboCadastroCidadeEvento.DisplayMember = "Nome";
            comboCadastroCidadeEvento.ValueMember = "CidadeId";

            BindingSource bindingSourceEstado = new BindingSource();
            List<DBEstado> estadoCombo = ListasDAL.ObterEstado();
            bindingSourceEstado.DataSource = estadoCombo;
            comboCadastroUFEvento.DataSource = bindingSourceEstado.DataSource;
            comboCadastroUFEvento.DisplayMember = "Sigla";
            comboCadastroUFEvento.ValueMember = "EstadoId";

            comboCadastroCidadeEvento.SelectedValue = -1;
            comboCadastroUFEvento.SelectedValue = -1;
            comboBoxTipoEvento.SelectedValue = -1;
            mCFim.Visible = false;
            mCInicio.Visible = false;
        }
        private void buttonSalvarEvento_Click(object sender, EventArgs e)
        {
           
            ListaDeErros list = new ListaDeErros();
            ValidaEndereco valiendereco = new ValidaEndereco();
            ValidatorEvento valiEvento = new ValidatorEvento();
            DBEndereco enderecoEvento = new DBEndereco();
            DBEvento dadosEvento = new DBEvento();
            EnderecoDAL eDAL = new EnderecoDAL();
            EventosDAL evDAL = new EventosDAL();

            enderecoEvento.CEP = maskedCEPEvento.Text;
            enderecoEvento.Rua = textCadastroRuaEvento.Text;
            enderecoEvento.Bairro = textCadastroBairroEvento.Text;
            enderecoEvento.Numero = textCadastroNumeroEvento.Text;
            enderecoEvento.Complemento = textCadastroComplementoEvento.Text;
            enderecoEvento.Cidade_id = Convert.ToInt32(comboCadastroCidadeEvento.SelectedValue);
            enderecoEvento.Estado_id = Convert.ToInt32(comboCadastroUFEvento.SelectedValue);
            ListaDeErros resultEndereco = valiendereco.Validar(enderecoEvento);

            dadosEvento.TipoEvento_id = Convert.ToInt32(comboBoxTipoEvento.SelectedValue);
            dadosEvento.NomeEvento = textBoxNomeEvento.Text;
            #region  Data inicio evento
            if (string.IsNullOrWhiteSpace(Convert.ToString(dateEventoInicio.Text)))
            {
                list.AddErro("Data de inicio do evento deve ser informada");
            }
            else if (!(ValidaData.IsValidDOB(Convert.ToString(dateEventoInicio.Text))))
            {
                list.AddErro("Data de inicio do evento é invalida.");
            }
            else if (!(ValidaData.ValidateBirthday(Convert.ToString(dateEventoInicio.Text))))
            {
                list.AddErro("Data de inicio do evento deve estar acima de 01/01/1800");
            }
            else
            {
                dadosEvento.DataInicio = Convert.ToDateTime(dateEventoInicio.Text);
            }
            #endregion
            #region  Data fim evento
            if (string.IsNullOrWhiteSpace(Convert.ToString(dateEventoFim.Text)))
            {
                list.AddErro("Data de fim do evento deve ser informada");
            }
            else if (!(ValidaData.IsValidDOB(Convert.ToString(dateEventoFim.Text))))
            {
                list.AddErro("Data de fim do evento é invalida.");
            }
            else if (!(ValidaData.ValidateBirthday(Convert.ToString(dateEventoFim.Text))))
            {
                list.AddErro("Data de fim do evento deve estar acima de 01/01/1800");
            }
            else
            {
                dadosEvento.DataFim = Convert.ToDateTime(dateEventoFim.Text);
            }
            #endregion
            dadosEvento.HoraInicio = maskedHoraInicioEvento.Text;
            dadosEvento.HoraFim = maskedHoraFimEvento.Text;

            decimal d;
            if (!decimal.TryParse(txtValorInscricao.Text, out d))
            {
                list.AddErro("Caracter inválido para valor em dinheiro.");
            }
            else
            {
                dadosEvento.ValorEvento = Convert.ToDecimal(txtValorInscricao.Text);
            }
            ListaDeErros resultEvento = valiEvento.ValidarEvento(dadosEvento);

            if (resultEvento.IsValid && resultEndereco.IsValid && list.IsValid)
            {
                dadosEvento.EnderecoEvento_id = eDAL.inserirDadosEndereco(enderecoEvento);
                evDAL.inserirDadosPessoaFisica(dadosEvento);
                MessageBox.Show("Evento: " + textBoxNomeEvento.Text + " cadastrado com sucesso.", "Cadastro Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void buttonCancelarEvento_Click(object sender, EventArgs e)
        {
            DialogResult rlt = MessageBox.Show("Deseja realmente sair? Dados não salvos seram perdidos", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (rlt == DialogResult.Yes)
            {
                this.Close();
            }
        }

        #region Funções botão calendário
        private void btnDataInicio_Click(object sender, EventArgs e)
        {
            mCInicio.Visible = true;
        }
        private void mCInicio_MouseDown(object sender, MouseEventArgs e)
        {
            dateEventoInicio.Text = Convert.ToString(mCInicio.SelectionEnd);
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
            dateEventoFim.Text = Convert.ToString(mCFim.SelectionEnd);
        }
        private void mCFim_MouseLeave(object sender, EventArgs e)
        {
            mCFim.Visible = false;
        }
        #endregion

    }
}
