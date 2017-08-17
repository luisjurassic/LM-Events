using LM_Events.DataObjectBase;
using System;
using System.Windows.Forms;
using LM_Events.GUI;
using LM_Events.PresentationLayer;
using LM_Events.DataObjectBase.Dados;
using System.Collections.Generic;

namespace LM_Events
{
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            entrar();
        }
        private void entrar()
        {
            string usuario = textUsuario.Text;
            string senha = textSenha.Text;

            UsuarioDAL objetoConsulta = new UsuarioDAL();
            if (objetoConsulta.VerificaUsuarioLogin(usuario, senha))
            {
                string userUsuario = usuario;
                UsuarioDAL dados = new UsuarioDAL();
                DBUsuario nome = new DBUsuario();
                DBUsuario acesso = new DBUsuario();
                DBUsuario user = new DBUsuario();
                DBUsuario data = new DBUsuario();
                DBUsuario imagem = new DBUsuario();

                DBUsuario nuser = dados.pesquisarUsuario(userUsuario);
                nome.Nome = nuser.Nome;
                acesso.Permissao_id = nuser.Permissao_id;
                user.Usuario = nuser.Usuario;
                data.DataInscricao = nuser.DataInscricao;
                imagem.ImagemPerfil = nuser.ImagemPerfil;

                Parametros.SetNome(nome);
                Parametros.SetAcesso(acesso);
                Parametros.SetUser(user);
                Parametros.SetData(data);
                Parametros.SetImagem(imagem);

                this.Close();
                MessageBox.Show("Login aceito! Bem vindo...", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormPaginaInicial ini = new FormPaginaInicial();
                ini.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha não encontrados. Tente novamente!", "Erro no login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormCleaner.Clear(this);
                textUsuario.Placeholder = "Digite um usuário...";
                textSenha.Placeholder = "Senha...";
                textUsuario.ForeColor = System.Drawing.Color.FromArgb(192, 192, 192);
                textSenha.ForeColor = System.Drawing.Color.FromArgb(192, 192, 192);
                textUsuario.Focus();
            }
        }

        private void buttonSairLogin_Click(object sender, EventArgs e)
        {
            SairLogin();
        }
        public void SairLogin()
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textSenha.UseSystemPasswordChar = false;
            }
            else
            {
                textSenha.UseSystemPasswordChar = true;
            }
        }
        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    entrar();
                    break;
                case Keys.Escape:
                    SairLogin();
                    break;
            }
        }
    }
}
