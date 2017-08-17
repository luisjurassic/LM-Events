using LM_Events.DataObjectBase;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LM_Events
{
    public partial class FormProcurarPessoaFisica : Form
    {
        FormAtualizarCadastroPessoaFisica recebe = new FormAtualizarCadastroPessoaFisica();
        public FormProcurarPessoaFisica(FormAtualizarCadastroPessoaFisica dados)
        {
            InitializeComponent();
            recebe = dados;
        }

        private void ProcurarCadastroPessoaFisica_Load(object sender, EventArgs e)
        {
            string nomePF = recebe.textBuscaAtualizarPF.Text;
            dgvPessoasFisicas.DataSource = new PessoaFisicaDAL().GetPessoaFisica(nomePF);
        }
        private void dgvProcura_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DBPessoaFisica PF = (DBPessoaFisica)dgvPessoasFisicas.CurrentRow.DataBoundItem;
            recebe.CpfAtualizar.Text = PF.CPF;
            recebe.CarregarComboTipoCadastro();
            recebe.comboAtualizarTipoCadastro.SelectedValue = PF.TipoCadastro_id;
            recebe.textAtualizarNome.Text = PF.Nome;
            recebe.maskedTextAtualizarDataNascimento.Text = Convert.ToString(PF.DataNascimento);
            recebe.CarregarComboEstadoCivil();
            recebe.comboAtualizarEstadoCivil.SelectedValue = PF.EstadoCivil_id;
            recebe.maskedTextAtualizarTelefoneResidencial.Text = PF.TelefoneResidencial;
            recebe.maskedTextAtualizarTelefoneCelular.Text = PF.TelefoneCelular;

            int atualizarEndereco = PF.EnderecoPessoaFisica_id;
            EnderecoDAL upEndereco = new EnderecoDAL();
            DBEndereco End = upEndereco.pesquisaAtualizarEnderecoPessoaFisica(atualizarEndereco);
            recebe.maskedTextAtualizarCEP.Text = End.CEP;
            recebe.textAtualizarRua.Text = End.Rua;
            recebe.textAtualizarBairro.Text = End.Bairro;
            recebe.textAtualizarNumero.Text = Convert.ToString(End.Numero);
            recebe.textAtualizarComplemento.Text = End.Complemento;
            recebe.CarregarComboCidade();
            recebe.comboAtualizarCidade.SelectedValue = End.Cidade_id;
            recebe.CarregarComboEstado();
            recebe.comboAtualizarUF.SelectedValue = End.Estado_id;

            recebe.groupDadosPessoais.Visible = true;
            recebe.groupEndereco.Visible = true;
            recebe.buttonSalvarAtualizar.Visible = true;
            this.Close();
        }
    }
}
