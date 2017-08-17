using LM_Events.DataObjectBase;
using LM_Events.GUI;
using LM_Events.Validator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace LM_Events.PresentationLayer
{
    public partial class FormCadastroPessoaJuridica : Form
    {
        public FormCadastroPessoaJuridica()
        {
            InitializeComponent();
            NomeCampoDeTextoEmpresa.Focus();
        }

        private void buttonCancelarCadastro_Click(object sender, EventArgs e)
        {
            DialogResult rlt = MessageBox.Show("Deseja realmente sair? Dados não salvos seram perdidos", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (rlt == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void CadastrarEmpresa_Click(object sender, EventArgs e)
        {
            ListaDeErros list = new ListaDeErros();
            ValidaEndereco valiendereco = new ValidaEndereco();
            ValidaPessoaJuridica valiJuridica = new ValidaPessoaJuridica();
            DBEndereco recebeEnderecoEmpresa = new DBEndereco();
            EnderecoDAL dadosRecebidoEnderecoEmpresa = new EnderecoDAL();
            DBPessoaJuridica recebeDadosPessoasJuridicas = new DBPessoaJuridica();
            PessoaJuridicaDAL dadosRecebidosEmpresa = new PessoaJuridicaDAL();

            recebeEnderecoEmpresa.Rua = textEmpresaRua.Text;
            recebeEnderecoEmpresa.Bairro = textEmpresaBairro.Text;
            recebeEnderecoEmpresa.Numero = textEmpresaNumero.Text;
            recebeEnderecoEmpresa.Complemento = textEmpresaComplemento.Text;
            recebeEnderecoEmpresa.Cidade_id = Convert.ToInt32(comboEmpresaCidade.SelectedValue);
            recebeEnderecoEmpresa.Estado_id = Convert.ToInt32(comboEmpresaUF.SelectedValue);
            recebeEnderecoEmpresa.CEP = maskedTextEmpresaCEP.Text;
            ListaDeErros resultEndereco = valiendereco.Validar(recebeEnderecoEmpresa);

            recebeDadosPessoasJuridicas.NomeFantasia = NomeCampoDeTextoEmpresa.Text;
            recebeDadosPessoasJuridicas.RazaoSocial = RazaoSocialCampoDeTextoPessoaJuridica.Text;
            recebeDadosPessoasJuridicas.CNPJ = CNPJCampoDeTextoEmpresa.Text;
            recebeDadosPessoasJuridicas.RamoAtividade_id = Convert.ToInt32(AtividadeCampoComboEmpresa.SelectedValue);
            recebeDadosPessoasJuridicas.InscricaoEstadual = InscricaoEstadualCampoDeTextoPessoaJuridica.Text;
            recebeDadosPessoasJuridicas.Email = EmailCampodeTextoEmpresa.Text;
            recebeDadosPessoasJuridicas.WebSite = WebsiteCanpodeTextoEmpresa.Text;
            recebeDadosPessoasJuridicas.Telefone = maskedTextEmpresaTelefoneResidencial.Text;

            if (string.IsNullOrWhiteSpace(Convert.ToString(DataFundacaoCampoDeTextoPessoaJuridica.Text)))
            {
                list.AddErro("A data deve ser informada");
            }
            else if (!(ValidaData.IsValidDOB(Convert.ToString(DataFundacaoCampoDeTextoPessoaJuridica.Text))))
            {
                list.AddErro("Data de fundação invalida.");
            }
            else if (!(ValidaData.ValidateBirthday(Convert.ToString(DataFundacaoCampoDeTextoPessoaJuridica.Text))))
            {
                list.AddErro("Data de fundação invalida. Deve estar acima de 01/01/1800");
            }
            else
            {
                recebeDadosPessoasJuridicas.DataFundacao = Convert.ToDateTime(DataFundacaoCampoDeTextoPessoaJuridica.Text);
            }
            ListaDeErros resultJuridica = valiJuridica.ValidarEmpresa(recebeDadosPessoasJuridicas);

            if (resultJuridica.IsValid && resultEndereco.IsValid)
            {
                recebeDadosPessoasJuridicas.EnderecoPessoaJuridica_id = dadosRecebidoEnderecoEmpresa.inserirDadosEndereco(recebeEnderecoEmpresa);
                dadosRecebidosEmpresa.inserirDadosPessoaJuridica(recebeDadosPessoasJuridicas);
                MessageBox.Show(recebeDadosPessoasJuridicas.NomeFantasia + " inserido com sucesso!", "Imformação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormCleaner.Clear(this);
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

        private void CadastrarEmpresas_Load(object sender, EventArgs e)
        {
            BindingSource bindingSourceCidade = new BindingSource();
            List<DBCidade> cidadeCombo = ListasDAL.ObterCidade();
            bindingSourceCidade.DataSource = cidadeCombo;
            comboEmpresaCidade.DataSource = bindingSourceCidade.DataSource;
            comboEmpresaCidade.DisplayMember = "Nome";
            comboEmpresaCidade.ValueMember = "CidadeId";

            BindingSource bindingSourceEstado = new BindingSource();
            List<DBEstado> estadoCombo = ListasDAL.ObterEstado();
            bindingSourceEstado.DataSource = estadoCombo;
            comboEmpresaUF.DataSource = bindingSourceEstado.DataSource;
            comboEmpresaUF.DisplayMember = "Sigla";
            comboEmpresaUF.ValueMember = "EstadoId";

            BindingSource bindingSourceAtividade = new BindingSource();
            List<DBRamoAtividade> atividadeCombo = ListasDAL.ObterRamoAtividade();
            bindingSourceAtividade.DataSource = atividadeCombo;
            AtividadeCampoComboEmpresa.DataSource = bindingSourceAtividade.DataSource;
            AtividadeCampoComboEmpresa.DisplayMember = "Atividade";
            AtividadeCampoComboEmpresa.ValueMember = "RamoAtividadeId";

            comboEmpresaCidade.SelectedValue = -1;
            comboEmpresaUF.SelectedValue = -1;
            AtividadeCampoComboEmpresa.SelectedValue = -1;
        }

        private void CNPJCampoDeTextoEmpresa_Leave(object sender, EventArgs e)
        {
            DBPessoaJuridica cnpj = new DBPessoaJuridica();
            cnpj.CNPJ = CNPJCampoDeTextoEmpresa.Text;
            if (CNPJCampoDeTextoEmpresa.Text != "")
            {
                if (new PessoaJuridicaDAL().VerificaCNPJ(cnpj.CNPJ))
                {
                    MessageBox.Show("CNPJ já existente. Digite um CNPJ diferrente!", "CNPJ Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CNPJCampoDeTextoEmpresa.Text = string.Empty;
                    CNPJCampoDeTextoEmpresa.Focus();
                }
            }
        }
    }
}
