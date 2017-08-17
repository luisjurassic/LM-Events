
using System.ComponentModel;
namespace LM_Events.DataObjectBase.Dados
{
    class DBStands
    {
        [Browsable(false)]
        public int StandsId { get; set; }
        [DisplayName("Nome do Stand")]
        public string NomeStand { get; set; }
        [DisplayName("Tamanho(m²)")]
        public string TamanhoStand { get; set; }
        [DisplayName("Valor do Stand")]
        public double ValorStand { get; set; }
        [DisplayName("Stand do Evento")]
        public string Evento_id { get; set; }
        [Browsable(false)]
        public string Pago { get; set; }
        [Browsable(false)]
        public bool Disponivel { get; set; }
        [Browsable(false)]
        public bool Ativo { get; set; }


    }
}
