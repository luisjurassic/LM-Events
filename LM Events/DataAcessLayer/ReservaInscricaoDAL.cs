using LM_Events.DataObjectBase.Conexao;
using LM_Events.DataObjectBase.Dados;
using System.Data;
using System.Data.SqlClient;

namespace LM_Events.DataAcessLayer
{
    class ReservaInscricaoDAL
    {
        public void newReserva(DBReservaInscricao instanciaReserva)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO ReservaInscricao(Inscricao_id, PessoaFisica_id) VALUES(@Inscricao_id, @PessoaFisica_id)");
            cmd.Parameters.AddWithValue("@Inscricao_id", instanciaReserva.Inscricao_id);
            cmd.Parameters.AddWithValue("@PessoaFisica_id", instanciaReserva.PessoaFisica_id);
            new DbUtils().Execute(cmd);
        }
        public void deleteReserva(int idDelete)
        {
            SqlCommand cmd = new SqlCommand("DELETE ReservaInscricao WHERE Inscricao_id = @Inscricao_id");
            cmd.Parameters.AddWithValue("@Inscricao_id", idDelete);
            new DbUtils().Execute(cmd);
        }
        public DataTable inscricoesReservados()
        {
            SqlCommand cmd = new SqlCommand(@"SELECT ReservaInscricao.Inscricao_id AS 'Código Inscrição',
                                                     PessoaFisica.Nome AS 'Nome do Cliente',
                                                     Evento.NomeEvento AS 'Nome do Evento',
                                                     Evento.DataInicio AS 'Data de Inicio',
                                                     Evento.HoraInicio AS 'Hora de Inicio' 
                                              FROM ReservaInscricao INNER JOIN PessoaFisica ON PessoaFisica.PessoaFisicaId = ReservaInscricao.PessoaFisica_id
                                              INNER JOIN Inscricoes ON Inscricoes.InscricoesId = ReservaInscricao.Inscricao_id
                                              INNER JOIN Evento ON Evento.EventoId = Inscricoes.Evento_id
                                              WHERE Inscricoes.Ativo ='true'");
            DataTable dt = new DbUtils().Search(cmd);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            return dt;
        }
    }
}
