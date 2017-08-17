using LM_Events.DataObjectBase.Conexao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LM_Events.DataObjectBase
{
    public class UsuarioDAL
    {
        /// <summary>
        /// tela de login verifica usuario e senha existentes no dbo
        /// </summary>
        public bool VerificaUsuarioLogin(string loginUsuario, string loginSenha)
        {
            ConnectionHelper con = new ConnectionHelper();
            SqlCommand comandoVerificaDados = new SqlCommand(@"SELECT Usuario,Senha FROM Usuario 
                                                                           WHERE Usuario = @Usuario 
                                                                           AND Senha = @Senha");
            SqlParameter parametroUsuario = new SqlParameter("@Usuario", SqlDbType.NVarChar, 15);
            parametroUsuario.Value = loginUsuario;
            comandoVerificaDados.Parameters.Add(parametroUsuario);

            SqlParameter parametroSenha = new SqlParameter("@Senha", SqlDbType.NVarChar, 150);
            parametroSenha.Value = loginSenha;
            comandoVerificaDados.Parameters.Add(parametroSenha);

            con.AttachCommand(comandoVerificaDados);
            SqlDataReader drLogin = comandoVerificaDados.ExecuteReader();
            if (drLogin.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// rotina para inserir um novo login de acesso
        /// </summary>
        public void inserirNovoLogin(DBUsuario instancialogin)
        {
            SqlCommand cmdDados = new SqlCommand(@"INSERT INTO Usuario(Nome,DataInscricao,Email,Usuario,Senha,ImagemPerfil,Permissao_id) 
                                                   VALUES(@Nome,@DataInscricao,@Email,@Usuario,@Senha,@ImagemPerfil,@Permissao_id)");
            cmdDados.Parameters.AddWithValue("@Nome", instancialogin.Nome);
            cmdDados.Parameters.AddWithValue("@DataInscricao", instancialogin.DataInscricao);
            cmdDados.Parameters.AddWithValue("@Email", instancialogin.Email);
            cmdDados.Parameters.AddWithValue("@Usuario", instancialogin.Usuario);
            cmdDados.Parameters.AddWithValue("@Senha", instancialogin.Senha);
            cmdDados.Parameters.AddWithValue("@ImagemPerfil", instancialogin.ImagemPerfil);
            cmdDados.Parameters.AddWithValue("@Permissao_id", instancialogin.Permissao_id);

            new DbUtils().Execute(cmdDados);
        }
        /// <summary>
        /// pesquisa usuario e retorna dados em uma grid
        /// </summary>
        public DBUsuario pesquisarUsuario(string userUsuario)
        {
            DBUsuario searchUsuario = new DBUsuario();
            ConnectionHelper con = new ConnectionHelper();
            SqlCommand comandoSearch = new SqlCommand(@"SELECT *FROM Usuario WHERE Usuario = @Usuario");
            comandoSearch.Parameters.AddWithValue("@Usuario", userUsuario);

            con.AttachCommand(comandoSearch);
            SqlDataReader drLogin = comandoSearch.ExecuteReader();
            if (!drLogin.Read())
            {
                throw new Exception("Usuário não encontrado. Tente novamente");
            }
            searchUsuario.UsuarioId = (int)drLogin["UsuarioId"];
            searchUsuario.Nome = (string)drLogin["Nome"];
            searchUsuario.DataInscricao = (DateTime)drLogin["DataInscricao"];
            searchUsuario.Email = (string)drLogin["Email"];
            searchUsuario.Usuario = (string)drLogin["Usuario"];
            searchUsuario.Senha = (string)drLogin["Senha"];
            searchUsuario.Permissao_id = (int)drLogin["Permissao_id"];
            searchUsuario.ImagemPerfil = (string)drLogin["ImagemPerfil"];

            return searchUsuario;
        }
        /// <summary>
        /// rotina aguardo o retorno "ID" para exclusão do usuario
        /// </summary>
        public void excluirUsuario(int id)
        {
            SqlCommand comandoInserirDados = new SqlCommand("DELETE FROM Usuario WHERE UsuarioId = @UsuarioId");
            comandoInserirDados.Parameters.AddWithValue("@UsuarioId", id);
            new DbUtils().ExecuteOnIdentity(comandoInserirDados);
        }
        /// <summary>
        /// rotina para atualizar dados do usuario
        /// </summary>
        public void atualizarUsuario(DBUsuario updateUsuario)
        {
            SqlCommand comandoUpdate = new SqlCommand(@"UPDATE Usuario SET Nome = @Nome, Email = @Email, Usuario = @Usuario, Senha = @Senha, Permissao_id = @Permissao_id, ImagemPerfil = @ImagemPerfil
                                                        WHERE UsuarioId = @UsuarioId");
            comandoUpdate.Parameters.AddWithValue("@Nome", updateUsuario.Nome);
            comandoUpdate.Parameters.AddWithValue("@Email", updateUsuario.Email);
            comandoUpdate.Parameters.AddWithValue("@Usuario", updateUsuario.Usuario);
            comandoUpdate.Parameters.AddWithValue("@Senha", updateUsuario.Senha);
            comandoUpdate.Parameters.AddWithValue("@Permissao_id", updateUsuario.Permissao_id);
            comandoUpdate.Parameters.AddWithValue("@ImagemPerfil", updateUsuario.ImagemPerfil);
            comandoUpdate.Parameters.AddWithValue("@UsuarioId", updateUsuario.UsuarioId);
            new DbUtils().Execute(comandoUpdate);
        }
        /// <summary>
        /// Lista de usuários
        /// </summary>
        public List<DBUsuario> GetUsuario(string usuario)
        {
            ConnectionHelper con = new ConnectionHelper();
            List<DBUsuario> listUsers = new List<DBUsuario>();
            SqlCommand comandoSearch = new SqlCommand(@"SELECT *FROM Usuario WHERE Usuario LIKE '%'+ @Usuario +'%'");
            comandoSearch.Parameters.AddWithValue("@Usuario", usuario);

            con.AttachCommand(comandoSearch);
            SqlDataReader drLogin = comandoSearch.ExecuteReader();
            while (drLogin.Read())
            {
                DBUsuario searchUsuario = new DBUsuario();
                searchUsuario.UsuarioId = (int)drLogin["UsuarioId"];
                searchUsuario.Nome = (string)drLogin["Nome"];
                searchUsuario.DataInscricao = (DateTime)drLogin["DataInscricao"];
                searchUsuario.Email = (string)drLogin["Email"];
                searchUsuario.Usuario = (string)drLogin["Usuario"];
                searchUsuario.Senha = (string)drLogin["Senha"];
                searchUsuario.Permissao_id = (int)drLogin["Permissao_id"];
                searchUsuario.ImagemPerfil = (string)drLogin["ImagemPerfil"];
                listUsers.Add(searchUsuario);
            }
            return listUsers;
        }
        /// <summary>
        /// Verifica se usuaário ja existe na tabela
        /// </summary>
        public bool VerificaUsuario(string usuario)
        {
            ConnectionHelper con = new ConnectionHelper();
            SqlCommand comandoVerificaDados = new SqlCommand(@"SELECT Usuario FROM Usuario 
                                                                           WHERE Usuario = @Usuario");
            SqlParameter parametroUsuario = new SqlParameter("@Usuario", SqlDbType.VarChar, 15);
            parametroUsuario.Value = usuario;
            comandoVerificaDados.Parameters.Add(parametroUsuario);

            con.AttachCommand(comandoVerificaDados);
            SqlDataReader drLogin = comandoVerificaDados.ExecuteReader();
            if (drLogin.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Verifica se email já existe na tabela
        /// </summary>
        public bool VerificaEmail(string email)
        {
            ConnectionHelper con = new ConnectionHelper();
            SqlCommand comandoVerificaDados = new SqlCommand(@"SELECT Email FROM Usuario 
                                                                           WHERE Email = @Email");
            SqlParameter parametroEmail = new SqlParameter("@Email", SqlDbType.VarChar, 50);
            parametroEmail.Value = email;
            comandoVerificaDados.Parameters.Add(parametroEmail);

            con.AttachCommand(comandoVerificaDados);
            SqlDataReader drLogin = comandoVerificaDados.ExecuteReader();
            if (drLogin.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
