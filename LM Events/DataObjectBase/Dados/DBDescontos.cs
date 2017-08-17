using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM_Events.DataObjectBase.Dados
{
    class DBDescontos
    {
        [Browsable(false)]
        public int DescontosId { get; set; }
        [DisplayName("Descrição de Desconto")]
        public string Descricao { get; set; }
        [DisplayName("Porcentagem de Desconto")]
        public decimal PcentDesconto { get; set; }
    }
}
