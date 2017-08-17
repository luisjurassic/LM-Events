using LM_Events.DataObjectBase;
using LM_Events.DataObjectBase.Conexao;
using LM_Events.DataObjectBase.Dados;
using LM_Events.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LM_Events.DataAcessLayer
{
    class CaixaDAL
    {
        public void updateCaixa(DBCaixa instanciaCaixa)
        {
            SqlCommand comando = new SqlCommand(@"Update Caixa SET DinheiroCaixa = @DinheiroCaixa");
            comando.Parameters.AddWithValue("@DinheiroCaixa", instanciaCaixa.DinheiroCaixa);
            new DbUtils().Execute(comando);
        }
        public void finalizarCaixa(DBCaixa instanciaCaixa)
        {
            SqlCommand comando = new SqlCommand(@"Update Caixa SET DinheiroCaixa = @DinheiroCaixa, Total = @Total");
            comando.Parameters.AddWithValue("@DinheiroCaixa", instanciaCaixa.DinheiroCaixa);
            comando.Parameters.AddWithValue("@Total",instanciaCaixa.Total);
            new DbUtils().Execute(comando);
        }
        public void iniciarCaixa()
        {
            SqlCommand comandoDelete = new SqlCommand(@"Update Caixa SET DinheiroCaixa = '0' , Total = '0'");
            new DbUtils().Execute(comandoDelete);
        }
        public double GetDinheiroCaixa()
        {
            SqlCommand cmd = new SqlCommand(@"SELECT DinheiroCaixa FROM Caixa");
            DataTable dt = new DbUtils().Search(cmd);
            return Convert.ToDouble(dt.Rows[0][0]);
        }
        public DataTable GetTotalCaixa()
        {
            SqlCommand cmd = new SqlCommand(@"SELECT DinheiroCaixa AS 'Dinheiro em Caixa',Total AS 'Total' FROM Caixa");
            DataTable dt = new DbUtils().Search(cmd);
            return dt;
        }
        public double GetTotal()
        {
            SqlCommand cmd = new SqlCommand(@"SELECT Total AS 'Total' FROM Caixa");
            DataTable dt = new DbUtils().Search(cmd);
            return Convert.ToDouble(dt.Rows[0][0]);
        }
      

    }
}
//1715,55