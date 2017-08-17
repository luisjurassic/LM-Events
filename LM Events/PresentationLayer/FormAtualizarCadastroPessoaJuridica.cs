using LM_Events.DataObjectBase;
using System;
using System.Transactions;
using System.Windows.Forms;
using System.Text;
using LM_Events.Validator;

namespace LM_Events.PresentationLayer
{
    public partial class FormAtualizarCadastroPessoaJuridica : Form
    {
        public FormAtualizarCadastroPessoaJuridica()
        {
            InitializeComponent();
        }
        private void buttonSairAtualzarEmpresa_Click(object sender, EventArgs e)
        {
            string msg = "Deseja realmente sair? Dados não salvos seram perdidos";
            string titlle = "Atenção!";
            DialogResult rlt = MessageBox.Show(msg, titlle, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (rlt == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void buttonBuscarPJ_Click(object sender, EventArgs e)
        {
            FormProcurarPessoaJuridica sPJ = new FormProcurarPessoaJuridica(this);
            sPJ.ShowDialog();
        }

        public void CarregarComboCidade()
        {
            comboatualizarEmpresaCidade.DataSource = new BindingSource(ListasDAL.ObterCidade(), null);
            comboatualizarEmpresaCidade.DisplayMember = "Nome";
            comboatualizarEmpresaCidade.ValueMember = "CidadeId";
        }
        public void CarregarComboEstado()
        {
            comboatualizarEmpresaUF.DataSource = new BindingSource(ListasDAL.ObterEstado(), null);
            comboatualizarEmpresaUF.DisplayMember = "Sigla";
            comboatualizarEmpresaUF.ValueMember = "EstadoId";
        }
        public void CarregarComboAtividade()
        {
            atualizarAtividadeCampoComboEmpresa.DataSource = new BindingSource(ListasDAL.ObterRamoAtividade(), null);
            atualizarAtividadeCampoComboEmpresa.DisplayMember = "Atividade";
            atualizarAtividadeCampoComboEmpresa.ValueMember = "RamoAtividadeId";
        }

        private void buttonAtualizarEmpresa_Click(object sender, EventArgs e)
        {
            ListaDeErros list = new ListaDeErros();
            ValidaAtualizarEndereco valiendereco = new ValidaAtualizarEndereco();
            ValidaAtualizarPessoaJuridica valiJuridica = new ValidaAtualizarPessoaJuridica();
            DBPessoaJuridica atualizarPJ = new DBPessoaJuridica();
            PessoaJuridicaDAL dadosUpdatePJ = new PessoaJuridicaDAL();
            EnderecoDAL dadosEnderecoPJ = new EnderecoDAL();
            DBEndereco atualizarEnderecoPJ = new DBEndereco();

            atualizarPJ.NomeFantasia = atualizarNomeCampoDeTextoEmpresa.Text;
            atualizarPJ.RazaoSocial = atualizarRazaoSocialCampoDeTextoPessoaJuridica.Text;
            atualizarPJ.CNPJ = CnpjAtualizar.Text;
            atualizarPJ.InscricaoEstadual = atualizarInscricaoEstadualCampoDeTextoPessoaJuridica.Text;
            #region Validação Data Fundação
            if (string.IsNullOrWhiteSpace(Convert.ToString(atualizarDataFundacaoCampoDeTextoPessoaJuridica.Text)))
            {
                list.AddErro("A data deve ser informada");
            }
            else if (!(ValidaData.IsValidDOB(Convert.ToString(atualizarDataFundacaoCampoDeTextoPessoaJuridica.Text))))
            {
                list.AddErro("Data de fundação invalida.");
            }
            else if (!(ValidaData.ValidateBirthday(Convert.ToString(atualizarDataFundacaoCampoDeTextoPessoaJuridica.Text))))
            {
                list.AddErro("Data de fundação invalida. Deve estar acima de 01/01/1800");
            }
            else
            {
                atualizarPJ.DataFundacao = Convert.ToDateTime(atualizarDataFundacaoCampoDeTextoPessoaJuridica.Text);
            }
            #endregion

            atualizarPJ.Telefone = atualizarTelefoneEmpresa.Text;
            atualizarPJ.WebSite = atualizarWebsiteCanpodeTextoEmpresa.Text;
            atualizarPJ.Email = atualizarEmailCampodeTextoEmpresa.Text;
            atualizarPJ.RamoAtividade_id = Convert.ToInt32(atualizarAtividadeCampoComboEmpresa.SelectedValue);
            ListaDeErros resultJuridica = valiJuridica.ValidarEmpresa(atualizarPJ);

            int idRecebidoPJ = atualizarPJ.EnderecoPessoaJuridica_id;
            atualizarEnderecoPJ.EnderecoId = idRecebidoPJ;
            atualizarEnderecoPJ.CEP = atualizarEmpresaCEP.Text;
            atualizarEnderecoPJ.Rua = atualizarEmpresaRua.Text;
            atualizarEnderecoPJ.Bairro = atualizarEmpresaBairro.Text;
            atualizarEnderecoPJ.Numero = atualizarEmpresaNumero.Text;
            atualizarEnderecoPJ.Complemento = atualizarEmpresaComplemento.Text;
            atualizarEnderecoPJ.Cidade_id = Convert.ToInt32(comboatualizarEmpresaCidade.SelectedValue);
            atualizarEnderecoPJ.Estado_id = Convert.ToInt32(comboatualizarEmpresaUF.SelectedValue);
            ListaDeErros resultEndereco = valiendereco.Validar(atualizarEnderecoPJ);

            if (resultJuridica.IsValid && resultEndereco.IsValid)
            {
                dadosUpdatePJ.atualizarDadosPessoaJuridica(atualizarPJ);
                dadosEnderecoPJ.atualizarDadosEndereco(atualizarEnderecoPJ);
                MessageBox.Show(atualizarPJ.NomeFantasia + " atualizado com sucesso.");
                this.Close();
                return;
            }

            list.erros.AddRange(resultEndereco.erros);
            list.erros.AddRange(resultJuridica.erros);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.erros.Count; i++)
            {
                sb.AppendLine(list.erros[i]);
            }
            MessageBox.Show(sb.ToString(), "Erro de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
