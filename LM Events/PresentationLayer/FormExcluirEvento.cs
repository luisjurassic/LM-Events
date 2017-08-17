using LM_Events.DataAcessLayer;
using LM_Events.DataObjectBase.Dados;
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
    public partial class FormExcluirEvento : Form
    {
        public FormExcluirEvento()
        {
            InitializeComponent();
        }

        private void btnDataInicio_Click(object sender, EventArgs e)
        {
            calendarioEventos.Visible = true;
        }
        private void calendarioEventos_MouseLeave(object sender, EventArgs e)
        {
            calendarioEventos.Visible = false;
        }
        private void calendarioEventos_MouseDown(object sender, MouseEventArgs e)
        {
            EventosDAL dal = new EventosDAL();
            if (radioButtonDia.Checked)
            {
                dgvCancelarEvento.DataSource = dal.GetEventosPorDia(calendarioEventos.SelectionEnd.Date);
                return;
            }
            else if (radioButtonMes.Checked)
            {
                dgvCancelarEvento.DataSource = dal.GetEventosPorMes(calendarioEventos.SelectionEnd.Month, calendarioEventos.SelectionEnd.Year);
                return;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNome.Checked)
            {
                dgvCancelarEvento.DataSource = null;
                textBuscaEventoCancelar.Enabled = true;
                btnDataInicio.Enabled = false;
            }
            else
            {
                textBuscaEventoCancelar.Enabled = false;
                textBuscaEventoCancelar.Text = string.Empty;
                btnDataInicio.Enabled = true;
            }
        }
        private void radioButtonDia_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDia.Checked)
            {
                dgvCancelarEvento.DataSource = null;
            }
        }
        private void radioButtonMes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMes.Checked)
            {
                dgvCancelarEvento.DataSource = null;
            }
        }
        private void textBuscaEventoCancelar_TextChanged(object sender, EventArgs e)
        {
            EventosDAL dal2 = new EventosDAL();
            dgvCancelarEvento.DataSource = null;
            textBuscaEventoCancelar.Enabled = true;
            if (textBuscaEventoCancelar.TextLength > 3)
            {
                string evento = textBuscaEventoCancelar.Text;
                dgvCancelarEvento.DataSource = null;
                dgvCancelarEvento.DataSource = dal2.GetEventosLike(evento);
            }
        }
        private void buttonSairCancelaEvento_Click(object sender, EventArgs e)
        {
            DialogResult rlt = MessageBox.Show("Fechar tela de Cancelamento de Inscrição?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (rlt == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvCancelarEvento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DBEvento dbe = (DBEvento)dgvCancelarEvento.CurrentRow.DataBoundItem;
            textCodigoInscricao.Text = Convert.ToString(dbe.EventoId);
            textNomeExcluirCadastro.Text = dbe.NomeEvento;
        }

        private void buttonExcluirEvento_Click(object sender, EventArgs e)
        {
            ListaDeErros list = new ListaDeErros();
            DBEvento delEvento = new DBEvento();
            if (string.IsNullOrWhiteSpace(textCodigoInscricao.Text))
            {
                list.AddErro("O código do Evento é obrigatório.");
            }
            else
            {
                delEvento.EventoId = Convert.ToInt32(textCodigoInscricao.Text);
            }
            if (string.IsNullOrWhiteSpace(textNomeExcluirCadastro.Text))
            {
                list.AddErro("O nome do evento não foi informado.");
            }
            else
            {
                delEvento.NomeEvento =textNomeExcluirCadastro.Text;
            }
            
            if (list.IsValid)
            {
                new EventosDAL().excluirEvento(delEvento.EventoId);
                MessageBox.Show("Inscrição cancelada com exito.", "Cancelamento Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.erros.Count; i++)
            {
                sb.AppendLine(list.erros[i]);
            }
            MessageBox.Show(sb.ToString(), "Erro de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
