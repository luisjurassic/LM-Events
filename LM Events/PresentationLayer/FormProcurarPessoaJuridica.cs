using LM_Events.DataObjectBase;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LM_Events.PresentationLayer
{
    public partial class FormProcurarPessoaJuridica : Form
    {
        FormAtualizarCadastroPessoaJuridica recebe = new FormAtualizarCadastroPessoaJuridica();
        public FormProcurarPessoaJuridica(FormAtualizarCadastroPessoaJuridica dados)
        {
            InitializeComponent();
            recebe = dados;        
        }

        private void ProcurarCadastroPessoaJuridica_Load(object sender, EventArgs e)
        {
            string nomePJ = recebe.textBuscaAtualizarPJ.Text;
            dgvPessoasJuridica.DataSource = new PessoaJuridicaDAL().GetPessoaJuridica(nomePJ);
        }
        private void dgvPessoasJuridica_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DBPessoaJuridica PJ = (DBPessoaJuridica)dgvPessoasJuridica.CurrentRow.DataBoundItem;
            recebe.atualizarNomeCampoDeTextoEmpresa.Text = PJ.NomeFantasia;
            recebe.atualizarRazaoSocialCampoDeTextoPessoaJuridica.Text = PJ.RazaoSocial;
            recebe.CnpjAtualizar.Text = PJ.CNPJ;
            recebe.atualizarInscricaoEstadualCampoDeTextoPessoaJuridica.Text = PJ.InscricaoEstadual;
            recebe.atualizarDataFundacaoCampoDeTextoPessoaJuridica.Text = Convert.ToString(PJ.DataFundacao);
            recebe.atualizarTelefoneEmpresa.Text = PJ.Telefone;
            recebe.atualizarWebsiteCanpodeTextoEmpresa.Text = PJ.WebSite;
            recebe.atualizarEmailCampodeTextoEmpresa.Text = PJ.Email;
            recebe.CarregarComboAtividade();
            recebe.atualizarAtividadeCampoComboEmpresa.SelectedValue = PJ.RamoAtividade_id;

            int atualizarEndereco = PJ.EnderecoPessoaJuridica_id;
            EnderecoDAL upEndereco = new EnderecoDAL();
            DBEndereco End = upEndereco.pesquisaAtualizarEnderecoPessoaJuridica(atualizarEndereco);
            recebe.atualizarEmpresaCEP.Text = End.CEP;
            recebe.atualizarEmpresaRua.Text = End.Rua;
            recebe.atualizarEmpresaBairro.Text = End.Bairro;
            recebe.atualizarEmpresaNumero.Text = Convert.ToString(End.Numero);
            recebe.atualizarEmpresaComplemento.Text = End.Complemento;
            recebe.CarregarComboCidade();
            recebe.comboatualizarEmpresaCidade.SelectedValue = End.Cidade_id;
            recebe.CarregarComboEstado();
            recebe.comboatualizarEmpresaUF.SelectedValue = End.Estado_id;

            recebe.groupDadosEmpresa.Visible = true;
            recebe.groupEnderecoEmpresa.Visible = true;
            recebe.buttonAtualizarEmpresa.Visible = true;
            this.Close();
        }
    }
}
