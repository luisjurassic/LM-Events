using LM_Events.DataAcessLayer;
using LM_Events.DataObjectBase.Dados;
using LM_Events.GUI;
using LM_Events.Validator;
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
    public partial class FormAdministrarDescontos : Form
    {
        string mensagem;
        string titlle = "Informação";
        public FormAdministrarDescontos()
        {
            InitializeComponent();
        }
        private void AdministrarDescontos_Load(object sender, EventArgs e)
        {
            dataGridViewDescontos.DataSource = ListasDAL.ObterDescontos();
        }
        private void dataGridViewDescontos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DBDescontos descontos = (DBDescontos)dataGridViewDescontos.CurrentRow.DataBoundItem;
            textBoxTipoDesconto.Text = descontos.Descricao;
            maskedPorcentDesconto.Text = Convert.ToString(descontos.PcentDesconto);
            txtIdDesconto.Text = Convert.ToString(descontos.DescontosId);
        }
        private void buttonInserirDescontos_Click(object sender, EventArgs e)
        {
            DBDescontos newDados = new DBDescontos();
            ValidatorDesconto validaDescontos = new ValidatorDesconto();
            ListaDeErros listErro = new ListaDeErros();

            newDados.Descricao = textBoxTipoDesconto.Text;

            if (maskedPorcentDesconto.Text != "")
            {
                newDados.PcentDesconto = Convert.ToDecimal(maskedPorcentDesconto.Text);
            }
            ListaDeErros resultado = validaDescontos.ValidarDescontos(newDados);

            if (resultado.IsValid)
            {
                new DescontosDAL().inserirDesconto(newDados);
                mensagem = "Desconto inserido com sucesso.";
                MessageBox.Show(mensagem, titlle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormCleaner.Clear(this);
                dataGridViewDescontos.DataSource = ListasDAL.ObterDescontos();
                return;
            }

            listErro.erros.AddRange(resultado.erros);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < listErro.erros.Count; i++)
            {
                sb.AppendLine(listErro.erros[i]);
            }
            MessageBox.Show(sb.ToString(), "Erro de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            FormCleaner.Clear(this);

        }
        private void buttonAlterarDesconto_Click(object sender, EventArgs e)
        {
            ListaDeErros list = new ListaDeErros();
            DBDescontos updateDados = new DBDescontos();
            ValidaAtualizarDesconto valiDesconto = new ValidaAtualizarDesconto();
            if (txtIdDesconto.Text == "")
            {
                MessageBox.Show("Nenhum item selecionado.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            updateDados.Descricao = textBoxTipoDesconto.Text;
            updateDados.PcentDesconto = Convert.ToDecimal(maskedPorcentDesconto.Text);
            updateDados.DescontosId = Convert.ToInt32(txtIdDesconto.Text);
            ListaDeErros resulDesconto = valiDesconto.ValidarDescontos(updateDados);
            if (resulDesconto.IsValid)
            {
                new DescontosDAL().atualizarDescontos(updateDados);
                mensagem = "Desconto atualizado com sucesso.";
                MessageBox.Show(mensagem, titlle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            list.erros.AddRange(resulDesconto.erros);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.erros.Count; i++)
            {
                sb.AppendLine(list.erros[i]);
            }
            MessageBox.Show(sb.ToString(), "Erro de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            FormCleaner.Clear(this);
            dataGridViewDescontos.DataSource = ListasDAL.ObterDescontos();

        }
        private void buttonDeletarDesconto_Click(object sender, EventArgs e)
        {
            DBDescontos delDados = new DBDescontos();

            if (txtIdDesconto.Text == "")
            {
                MessageBox.Show("Nenhum item selecionado.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            delDados.DescontosId = Convert.ToInt32(txtIdDesconto.Text);
            new DescontosDAL().deletarDesconto(delDados);
            mensagem = "Desconto excluido com sucesso.";
            MessageBox.Show(mensagem, titlle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormCleaner.Clear(this);
            dataGridViewDescontos.DataSource = ListasDAL.ObterDescontos();
        }
        private void buttonCancelarDescontos_Click(object sender, EventArgs e)
        {
            DialogResult rlt = MessageBox.Show("Deseja realmente sair? Dados não salvos seram perdidos", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (rlt == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void textBoxTipoDesconto_Leave(object sender, EventArgs e)
        {
            DBDescontos verificaDesconto = new DBDescontos();
            verificaDesconto.Descricao = textBoxTipoDesconto.Text;
            if (textBoxTipoDesconto.Text != "")
            {
                if (!dataGridViewDescontos.CurrentCell.Selected)
                {
                    if (new DescontosDAL().VerificaDesconto(verificaDesconto.Descricao))
                    {
                        MessageBox.Show("Desconto já existente. Digite um desconto diferente!", "Desconto Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        FormCleaner.Clear(this);
                        textBoxTipoDesconto.Focus();
                    }
                }
            }
        }

    }
}
