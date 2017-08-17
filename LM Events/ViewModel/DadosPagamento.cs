using LM_Events.DataObjectBase.Dados;
using System.Data.SqlClient;
using LM_Events.DataObjectBase.Conexao;
using System.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace LM_Events.ViewModel
{
    public class DadosPagamento
    {
        public int Itens { get; set; }
        public double ValorEvento { get; set; }
        public double Desconto { get; set; }
        public int ID_Inscricao { get; set; }
        public string Pago { get; set; }
        public double DinheiroEmCaixa { get; set; }

        public double pesquisaPcentDescontos(int idDesconto)
        {
            DBDescontos desc = new DBDescontos();
            SqlCommand cmd = new SqlCommand("SELECT PcentDesconto FROM Descontos WHERE DescontosId = @DescontosId");
            cmd.Parameters.AddWithValue("@DescontosId", idDesconto);

            DataTable dt = new DbUtils().Search(cmd);
            desc.PcentDesconto = (Decimal)dt.Rows[0]["PcentDesconto"];
            return Desconto = Convert.ToDouble(desc.PcentDesconto);
        }       
    }
}
