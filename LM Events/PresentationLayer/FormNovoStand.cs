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
    public partial class FormNovoStand : Form
    {
        public FormNovoStand()
        {
            InitializeComponent();
        }

        private void buttonInserirStand_Click(object sender, EventArgs e)
        {
            ListaDeErros list = new ListaDeErros();
            DBStands stand = new DBStands();
            StandDAL standDal = new StandDAL();
            #region Validações de dados dos novos Stands
            if (string.IsNullOrWhiteSpace(textNomeStand.Text))
            {
                list.AddErro("Nenhum nome foi informado.");
            }
            else if (textNomeStand.Text.Length < 4 || textNomeStand.Text.Length > 50)
            {
                list.AddErro("O nome deve conter entre 6 e 50 caracteres.");
            }
            if (numericQuantidade.Value == 0)
            {
                list.AddErro("A quantidade de inscrição de ser informada.");
            }
            if (string.IsNullOrWhiteSpace(textTamanho.Text))
            {
                list.AddErro("Tamanho dos Stands não foi informado.");
            }
            
            if (string.IsNullOrWhiteSpace(txtValorStand.Text))
            {
                list.AddErro("O valor não foi informado.");
            }
            if (string.IsNullOrWhiteSpace(textIdEvento.Text))
            {
                list.AddErro("O evento não foi informado.");
            }
            if (string.IsNullOrWhiteSpace(textStandEvento.Text))
            {
                list.AddErro("O nome do evento não foi informado.");
            }
            #endregion
            
            if (list.IsValid)
            {
                decimal Qtd = numericQuantidade.Value + 1;
                for (int i = 1; i < Qtd; i++)
                {
                    stand.NomeStand = textNomeStand.Text + " " + i;
                    stand.TamanhoStand = textTamanho.Text;
                    stand.ValorStand = Convert.ToDouble(txtValorStand.Text);
                    stand.Evento_id = textIdEvento.Text;
                    stand.Disponivel = true;
                    stand.Pago = "Não";
                    stand.Ativo = true;
                    standDal.inserirStand(stand);
                }
                if (Qtd > 1)
                {
                    MessageBox.Show("Stands inseridos com sucesso.", "Stands Inseridos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Stand inserido com sucesso.", "Stand Inserido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

        private void buttonBuscaEventos_Click(object sender, EventArgs e)
        {
            FormProcurarEvento procuraevento = new FormProcurarEvento(this);
            procuraevento.ShowDialog();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
