using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM_Events.DataObjectBase.Dados
{
    class DBInscricoes
    {
        public int InscricoesId { get; set; }
        public string InscritoPor { get; set; }
        public DateTime DataInscricao { get; set; }
        public int Evento_id { get; set; }
        public int PessoaFisica_id { get; set; }
        public int Itens { get; set; }
        public int Desconto_id { get; set; }
        public string Pago { get; set; }
        public bool Ativo { get; set; }
    }
}
