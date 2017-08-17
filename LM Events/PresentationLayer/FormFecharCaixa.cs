using LM_Events.DataAcessLayer;
using LM_Events.DataObjectBase.Dados;
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
    public partial class FormFecharCaixa : Form
    {
        public FormFecharCaixa()
        {
            InitializeComponent();
        }
        private void FormFecharCaixa_Load(object sender, EventArgs e)
        {
            dgvCaixa.DataSource = new CaixaDAL().GetTotalCaixa();
        }

        private void buttonSairCaixa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonFinalizarCaixa_Click(object sender, EventArgs e)
        {
            string msg = "Fechar caixa?";
            string titlle = "Atenção!";
            DialogResult res = MessageBox.Show(msg, titlle, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                CaixaDAL dal = new CaixaDAL();
                CaixaDAL dal2 = new CaixaDAL();

                double DinheiroCaixa = dal.GetDinheiroCaixa();
                double Total = dal2.GetTotal();
                double finalizar = DinheiroCaixa + Total;

                DBCaixa caixa = new DBCaixa();
                caixa.DinheiroCaixa = 0.0;
                caixa.Total = finalizar;
                new CaixaDAL().finalizarCaixa(caixa);
                dgvCaixa.DataSource = new CaixaDAL().GetTotalCaixa();
            }
        }

    }
}
