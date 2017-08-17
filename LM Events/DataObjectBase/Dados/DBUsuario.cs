using LM_Events.DataObjectBase.Conexao;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace LM_Events.DataObjectBase
{
    public class DBUsuario
    {
        [Browsable(false)]
        public int UsuarioId { get; set; }
        [DisplayName("Nome Funcionário")]
        public string Nome { get; set; }
        [Browsable(false)]
        public string Email { get; set; }
        [DisplayName("Usuário")]
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string ConfirmaSenha { get; set; }
        [DisplayName("Data de Inscrição")]
        public DateTime DataInscricao { get; set; }
        [Browsable(false)]
        public string ImagemPerfil { get; set; }
        [Browsable(false)]
        public int Permissao_id { get; set; }

    }
}
