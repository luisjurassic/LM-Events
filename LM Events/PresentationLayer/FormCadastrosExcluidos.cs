using LM_Events.DataAcessLayer;
using LM_Events.DataObjectBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LM_Events.PresentationLayer
{
    public partial class FormCadastrosExcluidos : Form
    {
        public FormCadastrosExcluidos()
        {
            InitializeComponent();
        }
        private void dgvInscricaoCancelada_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (checkPF.Checked)
            {
                DBPessoaFisica pf = (DBPessoaFisica)dgvInscricaoCancelada.CurrentRow.DataBoundItem;
                textCodigoCliente.Text = Convert.ToString(pf.PessoaFisicaId);
            }
            else
            {
                DBPessoaJuridica pj = (DBPessoaJuridica)dgvInscricaoCancelada.CurrentRow.DataBoundItem;
                textCodigoEmpresa.Text = Convert.ToString(pj.PessoaJuridicaId);
            }
        }
        private void buttonExcluirInscricao_Click(object sender, EventArgs e)
        {
            if (dgvInscricaoCancelada.CurrentCell != null)
            {
                if (dgvInscricaoCancelada.CurrentRow.Selected)
                {

                    if (checkPF.Checked == true)
                    {
                        DBPessoaFisica pfRestaurar = new DBPessoaFisica();
                        pfRestaurar.PessoaFisicaId = Convert.ToInt32(textCodigoCliente.Text);
                        DialogResult rlt = MessageBox.Show("Deseja realmente restaurar esse cadastro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (rlt == DialogResult.Yes)
                        {
                            new PessoaFisicaDAL().restaurarPessoaFisica(pfRestaurar.PessoaFisicaId);
                            MessageBox.Show("Cadastro restaurado com sucesso.", "Cadastro Restaurado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvInscricaoCancelada.DataSource = new PessoaFisicaDAL().pessoaFisicaCanceladas();
                        }
                    }
                    else if (checkPJ.Checked == true)
                    {
                        DBPessoaJuridica pjRestaurar = new DBPessoaJuridica();
                        pjRestaurar.PessoaJuridicaId = Convert.ToInt32(textCodigoEmpresa.Text);
                        DialogResult rlt = MessageBox.Show("Deseja realmente restaurar esse cadastro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (rlt == DialogResult.Yes)
                        {
                            new PessoaJuridicaDAL().restaurarPessoaJuridica(pjRestaurar.PessoaJuridicaId);
                            MessageBox.Show("Cadastro restaurado com sucesso.", "Cadastro Restaurado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvInscricaoCancelada.DataSource = new PessoaJuridicaDAL().pessoaJuridicaCanceladas();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum item selecionado.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonSairCancelaInscricao_Click(object sender, EventArgs e)
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
                dgvInscricaoCancelada.DataSource = new PessoaFisicaDAL().pessoaFisicaCanceladas();
                if (dgvInscricaoCancelada.RowCount == 0)
                {
                    MessageBox.Show("Nenhum cadastro encontrado.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvInscricaoCancelada.DataSource = null;
                    return;
                }
            }
            else
            {
                dgvInscricaoCancelada.DataSource = null;
            }
        }

        private void checkPJ_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPJ.Checked == true)
            {
                checkPF.Checked = false;
                dgvInscricaoCancelada.DataSource = new PessoaJuridicaDAL().pessoaJuridicaCanceladas();
                if (dgvInscricaoCancelada.RowCount == 0)
                {
                    MessageBox.Show("Nenhum cadastro encontrado.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvInscricaoCancelada.DataSource = null;
                    return;
                }
            }
            else
            {
                dgvInscricaoCancelada.DataSource = null;
            }
        }
    }
}
