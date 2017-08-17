using LM_Events.DataObjectBase.Conexao;
using LM_Events.DataObjectBase.Dados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM_Events.DataAcessLayer
{
    class ReservaStandsDAL
    {
        public void newReserva(DBReservaStands instanciaReserva)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO ReservaStands(Stand_id, PessoaJuridica_id) VALUES(@Stand_id, @PessoaJuridica_id)");
            cmd.Parameters.AddWithValue("@Stand_id", instanciaReserva.Stand_id);
            cmd.Parameters.AddWithValue("@PessoaJuridica_id", instanciaReserva.PessoaJuridica_id);
            new DbUtils().Execute(cmd);
        }
        public void deleteAllReserva()
        {
            SqlCommand cmd = new SqlCommand("TRUNCATE TABLE ReservaStands");
            new DbUtils().Execute(cmd);
        }
        public void deleteReserva(int idDelete)
        {
            SqlCommand cmd = new SqlCommand("DELETE ReservaStands WHERE Stand_id = @Stand_id");
            cmd.Parameters.AddWithValue("@Stand_id", idDelete);
            new DbUtils().Execute(cmd);
        }
        public DataTable standsReservados()
        {
            SqlCommand cmd = new SqlCommand(@"SELECT ReservaStands.Stand_id AS 'Código Stand',
                                                     Stands.NomeStand AS 'Nome do Stand', 
                                                     Stands.TamanhoStand AS 'Tamanho(m²)', 
                                                     PessoaJuridica.RazaoSocial AS 'Resercado Para', 
                                                     Evento.NomeEvento AS 'Stand do Evento'
                                              FROM ReservaStands INNER JOIN Stands ON Stands.StandsId = ReservaStands.Stand_id 
                                              INNER JOIN PessoaJuridica ON PessoaJuridica.PessoaJuridicaId = ReservaStands.PessoaJuridica_id
                                              INNER JOIN Evento ON Evento.EventoId = Stands.Evento_id ORDER BY Stands.NomeStand");
            DataTable dt = new DbUtils().Search(cmd);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            return dt;
        }
    }
}
