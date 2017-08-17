using LM_Events.DataObjectBase;
using System;
using System.Windows.Forms;

namespace LM_Events.PresentationLayer
{
    public partial class FormProcurarUsuario : Form
    {
        FormAdministracaoUsuario recebe = new FormAdministracaoUsuario();
        public FormProcurarUsuario(FormAdministracaoUsuario dados)
        {
            InitializeComponent();
            recebe = dados;
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DBUsuario userView = (DBUsuario)dgvUsuarios.CurrentRow.DataBoundItem;
            recebe.pictureBoxPerfilAdmin.ImageLocation = userView.ImagemPerfil;
            recebe.labelLocalImagem.Text = userView.ImagemPerfil;
            recebe.textNomeAdminUsuario.Text = userView.Nome;
            recebe.textUsuarioID.Text = Convert.ToString(userView.UsuarioId);
            recebe.maskedDataInscriçãoAdminUsuario.Text = Convert.ToString(userView.DataInscricao);
            recebe.textUsuarioAdminUsuario.Text = userView.Usuario;
            recebe.textEmailAdminUsuario.Text = userView.Email;
            recebe.textSenhaAdminUsuario.Text = userView.Senha;
            recebe.textConfirmaSenhaAdminUsuario.Text = userView.Senha;
            recebe.CarregarComboPermissao();
            recebe.comboPermissaoAdmin.SelectedValue = userView.Permissao_id;
            recebe.panelUsuario.Visible = true;
            this.Close();
        }
        private void ProcurarUsuario_Load(object sender, EventArgs e)
        {
            string userUsuario = recebe.textUsuarioBusca.Text;
            dgvUsuarios.DataSource = new UsuarioDAL().GetUsuario(userUsuario);
        }
    }
}
