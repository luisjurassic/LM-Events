using LM_Events.DataObjectBase;
using LM_Events.GUI;
using System;
using System.Data;
using System.Windows.Forms;

namespace LM_Events
{
    public partial class FormExcluirCadastro : Form
    {
        public FormExcluirCadastro()
        {
            InitializeComponent();
        }
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (dgvExcluirCadastros.CurrentCell == null)
            {
                MessageBox.Show("Nenhum item selecionado.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!dgvExcluirCadastros.CurrentRow.Selected)
            {
                MessageBox.Show("Nenhum item selecionado.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dgvExcluirCadastros.RowCount == 0)
            {
                MessageBox.Show("Nenhum cadastro encontrado.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkPF.Checked == true)
                {
                    DBPessoaFisica dadosExcluirPessoa = new DBPessoaFisica();
                    dadosExcluirPessoa.CPF = mskCPFCNPJ.Text;
                    dadosExcluirPessoa.RG = mskRGInscricao.Text;
                    new PessoaFisicaDAL().ExcluirPessoaFisica(dadosExcluirPessoa);
                    MessageBox.Show(dadosExcluirPessoa.Nome + " excluido com sucesso!", "Imformação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvExcluirCadastros.DataSource = new PessoaFisicaDAL().PesquisarExcluirPF();
                    FormCleaner.Clear(this);
                }
                else
                {
                    DBPessoaJuridica dadosExcluirPessoaJ = new DBPessoaJuridica();
                    dadosExcluirPessoaJ.CNPJ = mskCPFCNPJ.Text;
                    dadosExcluirPessoaJ.InscricaoEstadual = mskRGInscricao.Text;
                    new PessoaJuridicaDAL().ExcluirPessoaJuridica(dadosExcluirPessoaJ);
                    MessageBox.Show(dadosExcluirPessoaJ.NomeFantasia + " excluido com sucesso!", "Imformação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvExcluirCadastros.DataSource = new PessoaJuridicaDAL().PesquisarExcluirPJ();
                    FormCleaner.Clear(this);
                }
            }
            groupConfirmacao.Visible = false;

        }
        private void dgvExcluirCadastros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvExcluirCadastros != null)
            {
                DataRowView row = (DataRowView)dgvExcluirCadastros.CurrentRow.DataBoundItem;
                if (checkPF.Checked == true)
                {
                    labelNomes.Text = "Nome Pessoa Física";
                    textNome.Text = row["Nome"].ToString();

                    labelCPFCNPJ.Text = "CPF";
                    mskCPFCNPJ.Mask = "000.000.000-00";
                    mskCPFCNPJ.Text = row["CPF"].ToString();

                    labelRGInscricaoEstadual.Text = "RG";
                    mskRGInscricao.Mask = "0.000.000";
                    mskRGInscricao.Text = row["RG"].ToString();
                }
                else if (checkPJ.Checked == true)
                {
                    labelNomes.Text = "Nome Pessoa Jurídica";
                    textNome.Text = row["Nome da Empresa"].ToString();

                    labelCPFCNPJ.Text = "CNPJ";
                    mskCPFCNPJ.Mask = "00.000.000/0000-00";
                    mskCPFCNPJ.Text = row["CNPJ"].ToString();

                    labelRGInscricaoEstadual.Text = "Inscrição Estadual";
                    mskRGInscricao.Mask = "000.000.000";
                    mskRGInscricao.Text = row["Inscrição Estadual"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Nenhuma cadastro encontrado.", "Nada Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupConfirmacao.Visible = false;
                FormCleaner.Clear(this);
            }
            groupConfirmacao.Visible = true;
            textNome.ReadOnly = true;
            mskRGInscricao.ReadOnly = true;
            mskCPFCNPJ.ReadOnly = true;
        }

        private void buttonCancelarExcluirCadastro_Click(object sender, EventArgs e)
        {
            DialogResult rlt = MessageBox.Show("Deseja realmente sair?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (rlt == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void checkPF_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPF.Checked == true)
            {
                checkPJ.Checked = false;
                groupConfirmacao.Visible = false;
                dgvExcluirCadastros.DataSource = new PessoaFisicaDAL().PesquisarExcluirPF();
                if (dgvExcluirCadastros.RowCount == 0)
                {
                    MessageBox.Show("Nenhum cadastro encontrado.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvExcluirCadastros.DataSource = null;
                    return;
                }
            }
            else
            {
                dgvExcluirCadastros.DataSource = null;
            }
        }
        private void checkPJ_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPJ.Checked == true)
            {
                checkPF.Checked = false;
                groupConfirmacao.Visible = false;
                dgvExcluirCadastros.DataSource = new PessoaJuridicaDAL().PesquisarExcluirPJ();
                if (dgvExcluirCadastros.RowCount == 0)
                {
                    MessageBox.Show("Nenhum cadastro encontrado.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvExcluirCadastros.DataSource = null;
                    return;
                }
            }
            else
            {
                dgvExcluirCadastros.DataSource = null;
            }
        }

        private void FormExcluirCadastro_Load(object sender, EventArgs e)
        {
            groupConfirmacao.Visible = false;
        }
    }
}
