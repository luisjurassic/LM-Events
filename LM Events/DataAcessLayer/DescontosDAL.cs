using LM_Events.DataObjectBase.Conexao;
using LM_Events.DataObjectBase.Dados;
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
    class DescontosDAL
    {
        public void inserirDesconto(DBDescontos newDesconto)
        {
            SqlCommand cmdDados = new SqlCommand(@"INSERT INTO Descontos(Descricao,PcentDesconto) 
                                                   VALUES(@Descricao,@PcentDesconto)");
            cmdDados.Parameters.AddWithValue("@Descricao", newDesconto.Descricao);
            cmdDados.Parameters.AddWithValue("@PcentDesconto", newDesconto.PcentDesconto);
            new DbUtils().Execute(cmdDados);
        }
        public void atualizarDescontos(DBDescontos updDesconto)
        {
            SqlCommand comandoUpdate = new SqlCommand(@"UPDATE Descontos SET  Descricao = @Descricao, PcentDesconto = @PcentDesconto 
                                                        WHERE DescontosId =@DescontoId");
            comandoUpdate.Parameters.AddWithValue("@Descricao", updDesconto.Descricao);
            comandoUpdate.Parameters.AddWithValue("@PcentDesconto", updDesconto.PcentDesconto);
            comandoUpdate.Parameters.AddWithValue("@DescontoId", updDesconto.DescontosId);
            new DbUtils().Execute(comandoUpdate);
        }
        public void deletarDesconto(DBDescontos delDesconto)
        {
            SqlCommand comandoDelete = new SqlCommand(@"DELETE Descontos WHERE DescontosId = @DescontosId");
            comandoDelete.Parameters.AddWithValue("@DescontosId", delDesconto.DescontosId);
            new DbUtils().Execute(comandoDelete);
        }
        
        public bool VerificaDesconto(string desconto)
        {
            ConnectionHelper con = new ConnectionHelper();
            SqlCommand comandoVerificaDados = new SqlCommand(@"SELECT Descricao FROM Descontos 
                                                                           WHERE Descricao = @Descricao");
            SqlParameter parametroDesconto = new SqlParameter("@Descricao", SqlDbType.NChar, 20);
            parametroDesconto.Value = desconto;
            comandoVerificaDados.Parameters.Add(parametroDesconto);

            con.AttachCommand(comandoVerificaDados);
            SqlDataReader drLogin = comandoVerificaDados.ExecuteReader();
            if (drLogin.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DBDescontos pesquisaPcentDescontos(int idDesconto)
        {
            DBDescontos desc = new DBDescontos();
            SqlCommand cmd = new SqlCommand("SELECT PcentDesconto FROM Descontos WHERE DescontosId = @DescontosId");
            cmd.Parameters.AddWithValue("@DescontosId", idDesconto);

            DataTable dt = new DbUtils().Search(cmd);
            desc.PcentDesconto = (Decimal)dt.Rows[0]["PcentDesconto"];
            return desc;
        }
    }
}
