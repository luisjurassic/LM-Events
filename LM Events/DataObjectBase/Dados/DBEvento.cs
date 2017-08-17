using System;
using System.ComponentModel;

namespace LM_Events.DataObjectBase.Dados
{
    class DBEvento
    {
        [Browsable(false)]
        public int EventoId { get; set; }
        [DisplayName("Nome do Evento")]
        public string NomeEvento { get; set; }
        [DisplayName("Data de Inicio")]
        public DateTime DataInicio { get; set; }
        [DisplayName("Data do Fim")]
        public DateTime DataFim { get; set; }
        [DisplayName("Horário de Inicio")]
        public string HoraInicio { get; set; }
        [DisplayName("Horário do Fim")]
        public string HoraFim { get; set; }
        [Browsable(false)]
        public int TipoEvento_id { get; set; }
        [DisplayName("Valor do Evento")]
        public Decimal ValorEvento { get; set; }
        [Browsable(false)]
        public int EnderecoEvento_id { get; set; }
    }
}