using LM_Events.DataObjectBase;
using LM_Events.GUI;
using LM_Events.Validator;
using System;
using System.Text;
using System.Transactions;
using System.Windows.Forms;


namespace LM_Events
{

    public partial class FormAtualizarCadastroPessoaFisica : Form
    {
        public FormAtualizarCadastroPessoaFisica()
        {
            InitializeComponent();
        }

        private void buttonCancelarAtualizar_Click(object sender, EventArgs e)
        {
            string msg = "Deseja realmente sair? Dados não salvos seram perdidos";
            string titlle = "Atenção!";
            DialogResult rlt = MessageBox.Show(msg, titlle, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (rlt == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void botaobuscaratualizar_Click(object sender, EventArgs e)
        {
            FormProcurarPessoaFisica sPF = new FormProcurarPessoaFisica(this);
            sPF.ShowDialog();
        }

        public void CarregarComboCidade()
        {
            comboAtualizarCidade.DataSource = new BindingSource(ListasDAL.ObterCidade(), null);
            comboAtualizarCidade.DisplayMember = "Nome";
            comboAtualizarCidade.ValueMember = "CidadeId";
        }
        public void CarregarComboEstado()
        {
            comboAtualizarUF.DataSource = new BindingSource(ListasDAL.ObterEstado(), null);
            comboAtualizarUF.DisplayMember = "Sigla";
            comboAtualizarUF.ValueMember = "EstadoId";
        }
        public void CarregarComboEstadoCivil()
        {
            comboAtualizarEstadoCivil.DataSource = new BindingSource(ListasDAL.ObterEstadoCivil(), null);
            comboAtualizarEstadoCivil.DisplayMember = "Descricao";
            comboAtualizarEstadoCivil.ValueMember = "EstadoCivilId";
        }
        public void CarregarComboTipoCadastro()
        {
            comboAtualizarTipoCadastro.DataSource = new BindingSource(ListasDAL.ObterTipoCadastro(), null);
            comboAtualizarTipoCadastro.DisplayMember = "Descricao";
            comboAtualizarTipoCadastro.ValueMember = "TipoCadastroId";
        }

        private void buttonSalvarAtualizar_Click(object sender, EventArgs e)
        {
            ListaDeErros list = new ListaDeErros();
            ValidaAtualizarEndereco valiendereco = new ValidaAtualizarEndereco();
            ValidaAtualizarPessoaFisica valifisica = new ValidaAtualizarPessoaFisica();
            PessoaFisicaDAL dadosUpdatePF = new PessoaFisicaDAL();
            DBPessoaFisica atualizarPF = new DBPessoaFisica();
            DBEndereco atualizarEnderecoPF = new DBEndereco();
            EnderecoDAL dadosEnderecoPF = new EnderecoDAL();

            atualizarPF.CPF = CpfAtualizar.Text;
            atualizarPF.Nome = textAtualizarNome.Text;

            if (string.IsNullOrWhiteSpace(Convert.ToString(maskedTextAtualizarDataNascimento.Text)))
            {
                list.AddErro("A data deve ser informada");
            }
            else if (!(ValidaData.IsValidDOB(Convert.ToString(maskedTextAtualizarDataNascimento.Text))))
            {
                list.AddErro("Data de nascimento invalida.");
            }
            else if (!(ValidaData.ValidateBirthday(Convert.ToString(maskedTextAtualizarDataNascimento.Text))))
            {
                list.AddErro("Data de nascimento está abaixo de 1900.");
            }
            else
            {
                atualizarPF.DataNascimento = Convert.ToDateTime(maskedTextAtualizarDataNascimento.Text);
            }

            atualizarPF.TelefoneResidencial = maskedTextAtualizarTelefoneResidencial.Text;
            atualizarPF.TelefoneCelular = maskedTextAtualizarTelefoneCelular.Text;
            atualizarPF.TipoCadastro_id = Convert.ToInt32(comboAtualizarTipoCadastro.SelectedValue);
            atualizarPF.EstadoCivil_id = Convert.ToInt32(comboAtualizarEstadoCivil.SelectedValue);
            ListaDeErros resulfisica = valifisica.Validar(atualizarPF);

            int idREcebidoPF = atualizarPF.EnderecoPessoaFisica_id;
            atualizarEnderecoPF.EnderecoId = idREcebidoPF;
            atualizarEnderecoPF.CEP = maskedTextAtualizarCEP.Text;
            atualizarEnderecoPF.Rua = textAtualizarRua.Text;
            atualizarEnderecoPF.Bairro = textAtualizarBairro.Text;
            atualizarEnderecoPF.Numero = textAtualizarNumero.Text;
            atualizarEnderecoPF.Complemento = textAtualizarComplemento.Text;
            atualizarEnderecoPF.Cidade_id = Convert.ToInt32(comboAtualizarCidade.SelectedValue);
            atualizarEnderecoPF.Estado_id = Convert.ToInt32(comboAtualizarUF.SelectedValue);
            ListaDeErros resultendere = valiendereco.Validar(atualizarEnderecoPF);

            if (resulfisica.IsValid && resultendere.IsValid)
            {
                dadosUpdatePF.atualizarDadosPessoaFisica(atualizarPF);
                dadosEnderecoPF.atualizarDadosEndereco(atualizarEnderecoPF);
                MessageBox.Show(atualizarPF.Nome + " atualizado com sucesso.");
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

    }
}












