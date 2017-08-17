using LM_Events.DataObjectBase.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM_Events.DataObjectBase
{
    class Parametros
    {
        private static DBUsuario nome;
        public static void SetNome(DBUsuario _nome)
        {
            nome = _nome;
        }
        public static DBUsuario GetNome()
        {
            if (nome == null)
            {
                throw new Exception("Autenticação inválida");
            }
            return nome;
        }

        private static DBUsuario user;
        public static void SetUser(DBUsuario _user)
        {
            user = _user;
        }
        public static DBUsuario GetUser()
        {
            if (user == null)
            {
                throw new Exception("Autenticação inválida");
            }
            return user;
        }

        private static DBUsuario permissao;
        public static void SetAcesso(DBUsuario _permissao)
        {
            permissao = _permissao;
        }
        public static DBUsuario GetAcesso()
        {
            if (permissao == null)
            {
                throw new Exception("Autenticação inválida");
            }
            return permissao;
        }

        private static DBUsuario data;
        public static void SetData(DBUsuario _data)
        {
            data = _data;
        }
        public static DBUsuario GetData()
        {
            if (data == null)
            {
                throw new Exception("Autenticação inválida");
            }
            return data;
        }

        private static DBUsuario imagem;
        public static void SetImagem(DBUsuario _imagem)
        {
            imagem = _imagem;
        }
        public static DBUsuario GetImagem()
        {
            if (imagem == null)
            {
                throw new Exception("Autenticação inválida");
            }
            return imagem;
        }        
    }
}
