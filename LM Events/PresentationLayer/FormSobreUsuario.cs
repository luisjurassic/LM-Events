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
    public partial class FormSobreUsuario : Form
    {
        public FormSobreUsuario()
        {
            InitializeComponent();
        }

        private void SobreUsuario_Load(object sender, EventArgs e)
        {
            pictureBoxPerfilAdmin.ImageLocation = Parametros.GetImagem().ImagemPerfil;
            txtNome.Text = Parametros.GetNome().Nome;
            txtData.Text = Convert.ToString(Parametros.GetData().DataInscricao);

            if (Parametros.GetAcesso().Permissao_id == 1)
            {
                txtAcesso.Text = "Funcionário";
            }
            else
            {
                txtAcesso.Text = "Administrador";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
