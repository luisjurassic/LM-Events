using LM_Events.DataAcessLayer;
using LM_Events.DataObjectBase;
using LM_Events.DataObjectBase.Dados;
using LM_Events.Validator;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Transactions;
using System.Windows.Forms;

namespace LM_Events.PresentationLayer
{
    public partial class FormAdministracaoUsuario : Form
    {
        public FormAdministracaoUsuario()
        {
            InitializeComponent();
        }
        private void buttonCancelarAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBuscaUser_Click(object sender, EventArgs e)
        {
            FormProcurarUsuario pUser = new FormProcurarUsuario(this);
            pUser.ShowDialog();
        }
        public void CarregarComboPermissao()
        {
            comboPermissaoAdmin.DataSource = new BindingSource(ListasDAL.ObterPermissao(), null);
            comboPermissaoAdmin.DisplayMember = "Descricao";
            comboPermissaoAdmin.ValueMember = "PermissaoId";
        }

        private void buttonExcluirUsuario_Click(object sender, EventArgs e)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                DBUsuario deleteUsuario = new DBUsuario();
                deleteUsuario.UsuarioId = Convert.ToInt32(textUsuarioID.Text);
                new UsuarioDAL().excluirUsuario(deleteUsuario.UsuarioId);
                File.Delete(labelLocalImagem.Text);
                scope.Complete();
            }
            MessageBox.Show("Usuário excluido com exito!" ,"Usuário Excluido",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }
        private void buttonAtualizarUsuario_Click(object sender, EventArgs e)
        {
            ListaDeErros list = new ListaDeErros();
            ValidaUsuario valUsuario = new ValidaUsuario();
            DBUsuario updateUsuario = new DBUsuario();

            updateUsuario.UsuarioId = Convert.ToInt32(textUsuarioID.Text);
            updateUsuario.Permissao_id = Convert.ToInt32(comboPermissaoAdmin.SelectedValue);
            updateUsuario.Nome = textNomeAdminUsuario.Text;
            updateUsuario.Email = textEmailAdminUsuario.Text;
            updateUsuario.Usuario = textUsuarioAdminUsuario.Text;
            updateUsuario.Senha = textSenhaAdminUsuario.Text;
            updateUsuario.ConfirmaSenha = textConfirmaSenhaAdminUsuario.Text;
            updateUsuario.ImagemPerfil = @"C:\lm-events\LM Events\GUI\Image\Users\" + textUsuarioAdminUsuario.Text + ".jpg";
            ListaDeErros resultadoUsuario = valUsuario.validaUsuario(updateUsuario);

            if (resultadoUsuario.IsValid)
            {
                pictureBoxPerfilAdmin.Image.Save(updateUsuario.ImagemPerfil);
                new UsuarioDAL().atualizarUsuario(updateUsuario);
                MessageBox.Show(updateUsuario.Nome + " atualizado com exito!", "Usuário Atualizado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
                return;
            }
            list.erros.AddRange(resultadoUsuario.erros);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.erros.Count; i++)
            {
                sb.AppendLine(list.erros[i]);
            }
            MessageBox.Show(sb.ToString(), "Erro de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textConfirmaSenhaAdminUsuario.Text = string.Empty;
            textSenhaAdminUsuario.Text = string.Empty;

        }

        private void btnImpotaImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog improtImagem = new OpenFileDialog();
            improtImagem.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            improtImagem.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
            if (improtImagem.ShowDialog(this) == DialogResult.OK)
            {
                Bitmap procurarImagem = new Bitmap(improtImagem.FileName);
                Bitmap imagemRecebida = new Bitmap(procurarImagem, pictureBoxPerfilAdmin.Size);
                pictureBoxPerfilAdmin.Image = imagemRecebida;
            }
        }
    }
}
