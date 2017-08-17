using LM_Events.DataObjectBase;
using LM_Events.DataObjectBase.Dados;
using LM_Events.GUI;
using LM_Events.PresentationLayer;
using LM_Events.Validator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using System.Windows.Forms;

namespace LM_Events
{
    public partial class FormCadastroPessoaFisica : Form
    {

        public FormCadastroPessoaFisica()
        {
            InitializeComponent();
            comboCadastroTipoCadastro.Focus();
        }
        /// <summary>
        /// Exibi uma messagem de comfirmacao para sair
        /// </summary>
        private void buttonCancelarCadastro_Click(object sender, EventArgs e)
        {
            DialogResult rlt = MessageBox.Show("Deseja realmente sair? Dados não salvos seram perdidos", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (rlt == DialogResult.Yes)
            {
                this.Close();
            }
        }
        /// <summary>
        /// Funcao recebe os dados do formulario e preenche o dbo
        /// </summary>
        private void buttonSalvarCadastro_Click(object sender, EventArgs e)
        {
            ListaDeErros list = new ListaDeErros();
            ValidaEndereco valiendereco = new ValidaEndereco();
            ValidaPessoaFisica valifisica = new ValidaPessoaFisica();
            DBEndereco recebeEndereco = new DBEndereco();
            DBPessoaFisica recebePessoaFisica = new DBPessoaFisica();
            EnderecoDAL dadosRecebidoEndereco = new EnderecoDAL();
            PessoaFisicaDAL dadosRecebidoPessoaFisica = new PessoaFisicaDAL();

            recebeEndereco.Rua = textCadastroRua.Text;
            recebeEndereco.Bairro = textCadastroBairro.Text;
            recebeEndereco.Numero = textCadastroNumero.Text;
            recebeEndereco.Complemento = textCadastroComplemento.Text;
            recebeEndereco.Cidade_id = Convert.ToInt32(comboCadastroCidade.SelectedValue);
            recebeEndereco.Estado_id = Convert.ToInt32(comboCadastroUF.SelectedValue);
            recebeEndereco.CEP = maskedTextCadastroCEP.Text;
            ListaDeErros resultendere = valiendereco.Validar(recebeEndereco);

            recebePessoaFisica.Nome = textCadastroNome.Text;
            recebePessoaFisica.CPF = maskedTextCadastroCPF.Text;
            recebePessoaFisica.RG = maskedTextCadastroRG.Text;
            recebePessoaFisica.Sexo = comboCadastroSexo.Text;

            if (string.IsNullOrWhiteSpace(Convert.ToString(maskedTextCadastroDataNascimento.Text)))
            {
                list.AddErro("A data deve ser informada");
            }
            else if (!(ValidaData.IsValidDOB(Convert.ToString(maskedTextCadastroDataNascimento.Text))))
            {
                list.AddErro("Data de nascimento invalida.");
            }
            else if (!(ValidaData.ValidateBirthday(Convert.ToString(maskedTextCadastroDataNascimento.Text))))
            {
                list.AddErro("Data de nascimento está abaixo de 1900.");
            }
            else
            {
                recebePessoaFisica.DataNascimento = DateTime.Parse(maskedTextCadastroDataNascimento.Text);
            }
            recebePessoaFisica.TelefoneResidencial = maskedTextCadastroTelefoneResidencial.Text;
            recebePessoaFisica.TelefoneCelular = maskedTextCadastroTelefoneCelular.Text;
            recebePessoaFisica.TipoCadastro_id = Convert.ToInt32(comboCadastroTipoCadastro.SelectedValue);
            recebePessoaFisica.EstadoCivil_id = Convert.ToInt32(comboEstadoCivil.SelectedValue);
            ListaDeErros resulfisica = valifisica.Validar(recebePessoaFisica);

            if (resulfisica.IsValid && resultendere.IsValid)
            {
                recebePessoaFisica.EnderecoPessoaFisica_id = dadosRecebidoEndereco.inserirDadosEndereco(recebeEndereco);
                dadosRecebidoPessoaFisica.inserirDadosPessoaFisica(recebePessoaFisica);
                MessageBox.Show(recebePessoaFisica.Nome + " cadastrado com sucesso. ");
                FormCleaner.Clear(this);
                this.Close();
                return;
            }

            list.erros.AddRange(resultendere.erros);
            list.erros.AddRange(resulfisica.erros);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.erros.Count; i++)
            {
                sb.AppendLine(list.erros[i]);
            }
            MessageBox.Show(sb.ToString(), "Erro de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        /// <summary>
        /// Funcao preenche combox's do formulario de novo cadastro pessoa fisica
        /// </summary>
        private void NovoCadastro_Load(object sender, EventArgs e)
        {
            BindingSource bindingSourceTipoCadastro = new BindingSource();
            List<DBTipoCadastro> tipoCadastrocombo = ListasDAL.ObterTipoCadastro();
            bindingSourceTipoCadastro.DataSource = tipoCadastrocombo;
            comboCadastroTipoCadastro.DataSource = bindingSourceTipoCadastro.DataSource;
            comboCadastroTipoCadastro.DisplayMember = "Descricao";
            comboCadastroTipoCadastro.ValueMember = "TipoCadastroId";

            BindingSource bindingSourceEstadoCivil = new BindingSource();
            List<DBEstadoCivil> EstadoCivilcombo = ListasDAL.ObterEstadoCivil();
            bindingSourceEstadoCivil.DataSource = EstadoCivilcombo;
            comboEstadoCivil.DataSource = bindingSourceEstadoCivil.DataSource;
            comboEstadoCivil.DisplayMember = "Descricao";
            comboEstadoCivil.ValueMember = "EstadoCivilId";

            BindingSource bindingSourceCidade = new BindingSource();
            List<DBCidade> cidadeCombo = ListasDAL.ObterCidade();
            bindingSourceCidade.DataSource = cidadeCombo;
            comboCadastroCidade.DataSource = bindingSourceCidade.DataSource;
            comboCadastroCidade.DisplayMember = "Nome";
            comboCadastroCidade.ValueMember = "CidadeId";

            BindingSource bindingSourceEstado = new BindingSource();
            List<DBEstado> estadoCombo = ListasDAL.ObterEstado();
            bindingSourceEstado.DataSource = estadoCombo;
            comboCadastroUF.DataSource = bindingSourceEstado.DataSource;
            comboCadastroUF.DisplayMember = "Sigla";
            comboCadastroUF.ValueMember = "EstadoId";

            comboCadastroTipoCadastro.SelectedValue = -1;
            comboCadastroCidade.SelectedValue = -1;
            comboCadastroUF.SelectedValue = -1;
            comboEstadoCivil.SelectedValue = -1;
        }

        private void maskedTextCadastroCPF_Leave(object sender, EventArgs e)
        {
            DBPessoaFisica cpf = new DBPessoaFisica();
            cpf.CPF = maskedTextCadastroCPF.Text;
            if (maskedTextCadastroCPF.Text != "")
            {
                if (new PessoaFisicaDAL().VerificaCPF(cpf.CPF))
                {
                    MessageBox.Show("CPF já existente. Digite um CPF diferrente!", "CPF Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    maskedTextCadastroCPF.Text = string.Empty;
                    maskedTextCadastroCPF.Focus();
                }
            }
        }
    }
}
