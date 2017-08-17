using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM_Events.DataObjectBase.Dados
{
    class DBCaixa
    {
        [Browsable(false)]
        public int CaixaId { get; set; }       
        public double DinheiroCaixa { get; set; }
        public double Total { get; set; }
    }
}
