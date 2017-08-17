using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM_Events.ViewModel
{
    public class DadosReserva
    {
        public double ValorReserva { get; set; }
        public double DinheiroEmCaixa { get; set; }
        public int idPessoa { get; set; }
        public int idStands { get; set; }
        public string Pago { get; set; }
    }
}
