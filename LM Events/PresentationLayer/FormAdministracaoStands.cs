using LM_Events.DataAcessLayer;
using LM_Events.DataObjectBase.Dados;
using LM_Events.GUI;
using LM_Events.Validator;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace LM_Events.PresentationLayer
{
    public partial class FormAdministracaoStands : Form
    {
        public FormAdministracaoStands()
        {
            InitializeComponent();
        }

        private void FormStands_Load(object sender, EventArgs e)
        {
            dgvStand.DataSource = new StandDAL().listaStandAdm();
            if (dgvStand.RowCount == 0)
            {
                MessageBox.Show("Nenhum Stand inserido.", "Nada Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            textNomeStand.Enabled = false;
            textTamanhoStand.Enabled = false;
            textValorStand.Enabled = false;
        }
        private void buttonFecharStand_Click(object sender, EventArgs e)
        {
            DialogResult rlt = MessageBox.Show("Deseja realmente sair? Dados não salvos seram perdidos", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (rlt == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void buttonZerar_Click(object sender, EventArgs e)
        {
            if (dgvStand.RowCount == 0)
            {
                MessageBox.Show("Stands já foram zerados.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
                DialogResult rlt = MessageBox.Show("Deseja realmente apagar todos os Stands?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (rlt == DialogResult.Yes)
                {
                    new ReservaStandsDAL().deleteAllReserva();
                    new StandDAL().deletarTodosStands();
                    MessageBox.Show("Stands apagados com sucesso.", "Stand Zerados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvStand.DataSource = new StandDAL().listaStandAdm();
                }
            FormCleaner.Clear(this);
            textNomeStand.Enabled = false;
            textTamanhoStand.Enabled = false;
            textValorStand.Enabled = false;
        }
        private void dgvStand_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStand.RowCount != 0)
            {
                DBStands row = (DBStands)dgvStand.CurrentRow.DataBoundItem;
                textNomeStand.Text = row.NomeStand;
                textTamanhoStand.Text = row.TamanhoStand;
                textValorStand.Text = Convert.ToString(row.ValorStand);
                textid.Text = Convert.ToString(row.StandsId);
                textNomeStand.Enabled = true;
                textNomeStand.ReadOnly = false;
                textTamanhoStand.Enabled = true;
                textTamanhoStand.ReadOnly = false;
                textValorStand.Enabled = true;
                textValorStand.ReadOnly = false;
            }
            else
            {
                MessageBox.Show("Nenhum Stand inserido.", "Nada Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonDeleteStands_Click(object sender, EventArgs e)
        {
            DBStands delStand = new DBStands();
            if (string.IsNullOrWhiteSpace(textid.Text))
            {
                MessageBox.Show("Favor selecione o item para excluir.", "Erro de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            delStand.StandsId = Convert.ToInt32(textid.Text);
            new StandDAL().deletarStand(delStand.StandsId);
            new ReservaStandsDAL().deleteReserva(delStand.StandsId);

            MessageBox.Show("Stand excluido com sucesso.", "Stand Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textNomeStand.Enabled = false;
            textTamanhoStand.Enabled = false;
            textValorStand.Enabled = false;
            dgvStand.DataSource = new StandDAL().listaStandAdm();
            FormCleaner.Clear(this);
        }
        private void buttonAlterarStand_Click(object sender, EventArgs e)
        {
            ListaDeErros list = new ListaDeErros();
            DBStands upStand = new DBStands();
            #region Validações
            if (string.IsNullOrWhiteSpace(textid.Text))
            {
                list.AddErro("Imposivel atualizar dados em branco.");
            }
            if (string.IsNullOrWhiteSpace(textNomeStand.Text))
            {
                list.AddErro("Nenhum nome foi informado.");
            }
            else if (textNomeStand.Text.Length < 4 || textNomeStand.Text.Length > 50)
            {
                list.AddErro("O nome deve conter entre 6 e 50 caracteres.");
            }
            if (string.IsNullOrWhiteSpace(textTamanhoStand.Text))
            {
                list.AddErro("Tamanho de Stand/Sala não foi informado.");
            }
            if (string.IsNullOrWhiteSpace(textValorStand.Text))
            {
                list.AddErro("O Valor não foi informado.");
            }
            #endregion
            if (list.IsValid)
            {
                upStand.StandsId = Convert.ToInt32(textid.Text);
                upStand.NomeStand = textNomeStand.Text;
                upStand.TamanhoStand = textTamanhoStand.Text;
                upStand.ValorStand = Convert.ToDouble(textValorStand.Text);
                new StandDAL().atualizarStands(upStand);

                MessageBox.Show("Stand atualizado com sucesso.", "Stand Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormCleaner.Clear(this);
                textNomeStand.Enabled = false;
                textTamanhoStand.Enabled = false;
                textValorStand.Enabled = false;
                dgvStand.DataSource = new StandDAL().listaStandAdm();
                return;
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.erros.Count; i++)
            {
                sb.AppendLine(list.erros[i]);
            }

            MessageBox.Show(sb.ToString(), "Erro de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            FormCleaner.Clear(this);
        }
    }
}
