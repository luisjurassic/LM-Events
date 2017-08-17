using System;
using System.ComponentModel;
using System.Data;

namespace LM_Events.DataObjectBase
{
    public class DBPessoaJuridica
    {
        [Browsable(false)]
        public int PessoaJuridicaId { get; set; }
        [DisplayName("Nome da Empresa")]
        public string NomeFantasia { get; set; }
        [DisplayName("Razão Social")]
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        [DisplayName("Inscrição Estadual")]
        public string InscricaoEstadual { get; set; }
        [Browsable(false)]
        public DateTime DataFundacao { get; set; }
        [Browsable(false)]
        public string Telefone { get; set; }
        [Browsable(false)]
        public string WebSite { get; set; }
        [Browsable(false)]
        public string Email { get; set; }
        [Browsable(false)]
        public int EnderecoPessoaJuridica_id { get; set; }
        [Browsable(false)]
        public int RamoAtividade_id { get; set; }
    }
}
