using LM_Events.DataObjectBase;
using LM_Events.DataObjectBase.Dados;
using LM_Events.GUI;
using System.IO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LM_Events.Validator;
using System.Text;

namespace LM_Events.PresentationLayer
{
    public partial class FormNovoUsuario : Form
    {
        public FormNovoUsuario()
        {
            InitializeComponent();
        }

        private void buttonCancelarAdmin_Click(object sender, EventArgs e)
        {
            DialogResult rlt = MessageBox.Show("Deseja realmente sair? Dados não salvos seram perdidos", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (rlt == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void NovoUsuario_Load(object sender, EventArgs e)
        {
            BindingSource permissao = new BindingSource();
            List<DBPermissao> listaPermissao = ListasDAL.ObterPermissao();
            permissao.DataSource = listaPermissao;
            comboPermissao.DataSource = permissao.DataSource;
            comboPermissao.DisplayMember = "Descricao";
            comboPermissao.ValueMember = "PermissaoId";

            maskedDataInscrição.Text = DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString();
        }
        private void buttonSalvarNovoUsuario_Click(object sender, EventArgs e)
        {
            ListaDeErros list = new ListaDeErros();
            ValidaUsuario valiUsuario = new ValidaUsuario();
            DBUsuario recebeNovoUsuario = new DBUsuario();
            UsuarioDAL NovoUsuario = new UsuarioDAL();

            recebeNovoUsuario.Permissao_id = Convert.ToInt32(comboPermissao.SelectedValue);
            recebeNovoUsuario.Nome = textNomeNovoCadastro.Text;
            recebeNovoUsuario.DataInscricao = Convert.ToDateTime(maskedDataInscrição.Text);
            recebeNovoUsuario.Email = textEmailNovoCadastro.Text;
            recebeNovoUsuario.Usuario = textUsuarioNovoCadastro.Text;
            recebeNovoUsuario.Senha = textSenhaNovoCadastro.Text;
            recebeNovoUsuario.ImagemPerfil = @"C:\lm-events\LM Events\GUI\Image\Users\" + recebeNovoUsuario.Usuario + ".jpg";
            recebeNovoUsuario.ConfirmaSenha = textConfirmaSenhaNovoCadastro.Text;
            maskedDataInscrição.Text = DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString();
            ListaDeErros resultUsuario = valiUsuario.validaUsuario(recebeNovoUsuario);

            if (resultUsuario.IsValid)
            {
                if (pictureBoxPerfil.WaitOnLoad == true)
                {
                    pictureBoxPerfil.Image.Save(recebeNovoUsuario.ImagemPerfil);
                }
                NovoUsuario.inserirNovoLogin(recebeNovoUsuario);
                MessageBox.Show(recebeNovoUsuario.Nome + " cadastrado com sucesso!", "Usuário Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            list.erros.AddRange(resultUsuario.erros);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.erros.Count; i++)
            {
                sb.AppendLine(list.erros[i]);
            }
            MessageBox.Show(sb.ToString(), "Erro de dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            FormCleaner.Clear(this);
            maskedDataInscrição.Text = DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString();
            textNomeNovoCadastro.Focus();
        }
        private void btnImpotaImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog improtImagem = new OpenFileDialog();
            improtImagem.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            improtImagem.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
            
            if (improtImagem.ShowDialog(this) == DialogResult.OK)
            {
                Bitmap procurarImagem = new Bitmap(improtImagem.FileName);
                Bitmap imagemRecebida = new Bitmap(procurarImagem, pictureBoxPerfil.Size);
                pictureBoxPerfil.Image = imagemRecebida;
                pictureBoxPerfil.WaitOnLoad = true;
            }
        }
        private void textUsuarioNovoCadastro_Leave(object sender, EventArgs e)
        {
            DBUsuario u = new DBUsuario();
            u.Usuario = textUsuarioNovoCadastro.Text;
            if (textUsuarioNovoCadastro.Text != "")
            {
                if (new UsuarioDAL().VerificaUsuario(u.Usuario))
                {
                    MessageBox.Show("Usuário já existente. Digite um usuário diferente!", "Usuário Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textUsuarioNovoCadastro.Text = string.Empty;
                    textUsuarioNovoCadastro.Focus();
                }
            }
        }
        private void textEmailNovoCadastro_Leave(object sender, EventArgs e)
        {
            DBUsuario email = new DBUsuario();
            email.Email = textEmailNovoCadastro.Text;
            if (textEmailNovoCadastro.Text != "")
            {
                if (new UsuarioDAL().VerificaEmail(email.Email))
                {
                    MessageBox.Show("Email já existente. Digite um email diferrente!", "Email Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textEmailNovoCadastro.Text = string.Empty;
                    textEmailNovoCadastro.Focus();
                }
            }
        }
    }
}
