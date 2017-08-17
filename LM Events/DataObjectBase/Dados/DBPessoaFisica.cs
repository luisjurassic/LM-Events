
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
namespace LM_Events.DataObjectBase
{
    public class DBPessoaFisica
    {
        [Browsable(false)]
        public int PessoaFisicaId { get; set; }
        [DisplayName("Nome")]
        public string Nome { get; set; }
        public string CPF { get; set; }
        [DisplayName("Registro Geral")]
        public string RG { get; set; }
        public string Sexo { get; set; }
        [Browsable(false)]
        public DateTime DataNascimento { get; set; }
        [Browsable(false)]
        public string TelefoneResidencial { get; set; }
        [Browsable(false)]
        public string TelefoneCelular { get; set; }
        [Browsable(false)]
        public int TipoCadastro_id { get; set; }
        [Browsable(false)]
        public int EstadoCivil_id { get; set; }
        [Browsable(false)]
        public int EnderecoPessoaFisica_id { get; set; }
    }
}
