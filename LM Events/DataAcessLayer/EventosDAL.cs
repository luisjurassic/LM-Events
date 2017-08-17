using LM_Events.DataObjectBase.Conexao;
using LM_Events.DataObjectBase.Dados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LM_Events.DataAcessLayer
{
    class EventosDAL
    {
        /// <summary>
        /// rotina para inserir um novo evento
        /// </summary>
        public void inserirDadosPessoaFisica(DBEvento instanciaEvento)
        {
            SqlCommand comandoInsert = new SqlCommand(@"INSERT INTO Evento(TipoEvento_id, NomeEvento, DataInicio, DataFim, HoraInicio, HoraFim, ValorEvento, EnderecoEvento_id, Ativo)
                                                        VALUES(@TipoEvento_id, @NomeEvento, @DataInicio, @DataFim, @HoraInicio, @HoraFim, @ValorEvento, @EnderecoEvento_id, @Ativo)");
            comandoInsert.Parameters.AddWithValue("@TipoEvento_id", instanciaEvento.TipoEvento_id);
            comandoInsert.Parameters.AddWithValue("@NomeEvento", instanciaEvento.NomeEvento);
            comandoInsert.Parameters.AddWithValue("@DataInicio", instanciaEvento.DataInicio);
            comandoInsert.Parameters.AddWithValue("@DataFim", instanciaEvento.DataFim);
            comandoInsert.Parameters.AddWithValue("@HoraInicio", instanciaEvento.HoraInicio);
            comandoInsert.Parameters.AddWithValue("@HoraFim", instanciaEvento.HoraFim);
            comandoInsert.Parameters.AddWithValue("@ValorEvento", instanciaEvento.ValorEvento);
            comandoInsert.Parameters.AddWithValue("@EnderecoEvento_id", instanciaEvento.EnderecoEvento_id);
            comandoInsert.Parameters.AddWithValue("@Ativo", true);
            new DbUtils().Execute(comandoInsert);
        }
        /// <summary>
        ///Lista de evento pelo nome e retorna dados em uma grid
        /// </summary>
        public List<DBEvento> GetEventosLike(string nomeEvento)
        {
            ConnectionHelper con = new ConnectionHelper();
            List<DBEvento> listaEventos = new List<DBEvento>();
            SqlCommand comandoSearch = new SqlCommand(@"SELECT *FROM Evento WHERE Ativo = 'true' AND NomeEvento LIKE '%'+@NomeEvento+'%'");
            comandoSearch.Parameters.AddWithValue("@NomeEvento", nomeEvento);

            con.AttachCommand(comandoSearch);
            SqlDataReader dr = comandoSearch.ExecuteReader();
            if (!dr.Read())
            {
                return null;
            }
            while (dr.Read())
            {
                DBEvento searchEventos = new DBEvento();
                searchEventos.EventoId = (int)dr["EventoId"];
                searchEventos.TipoEvento_id = (int)dr["TipoEvento_id"];
                searchEventos.NomeEvento = (string)dr["NomeEvento"];
                searchEventos.DataInicio = (DateTime)dr["DataInicio"];
                searchEventos.DataFim = (DateTime)dr["DataFim"];
                searchEventos.HoraInicio = (string)dr["HoraInicio"];
                searchEventos.HoraFim = (string)dr["HoraFim"];
                searchEventos.ValorEvento = (Decimal)dr["ValorEvento"];
                searchEventos.EnderecoEvento_id = (int)dr["EnderecoEvento_id"];

                listaEventos.Add(searchEventos);
            }
            return listaEventos;
        }
        /// <summary>
        ///Lista de evento para adicionar aos stands e retorna dados em uma grid
        /// </summary>
        public DataTable GetEventosStands()
        {
            SqlCommand comandoSearch = new SqlCommand(@"SELECT EventoId AS 'Código do Evento', 
                                                               NomeEvento AS 'Nome do Evento',
                                                               ValorEvento AS 'Valor do Evento'
                                                       FROM Evento  WHERE Ativo = 'true'");
            DataTable dr = new DbUtils().Search(comandoSearch);
            if (dr.Rows.Count == 0)
            {
                return null;
            }
            return dr;
        }
        /// <summary>
        ///Lista de evento pelo dia  retorna dados em uma grid
        /// </summary>
        public List<DBEvento> GetEventosPorDia(DateTime dia)
        {
            ConnectionHelper con = new ConnectionHelper();
            List<DBEvento> listaEventos = new List<DBEvento>();
            SqlCommand comandoSearch = new SqlCommand(@"SELECT * FROM Evento WHERE Ativo = 'true' AND DataInicio = @DataInicio");
            comandoSearch.Parameters.AddWithValue("@DataInicio", dia);

            con.AttachCommand(comandoSearch);
            SqlDataReader dr = comandoSearch.ExecuteReader();
            while (dr.Read())
            {
                DBEvento searchEventos = new DBEvento();
                searchEventos.EventoId = (int)dr["EventoId"];
                searchEventos.NomeEvento = (string)dr["NomeEvento"];
                searchEventos.DataInicio = (DateTime)dr["DataInicio"];
                searchEventos.DataFim = (DateTime)dr["DataFim"];
                searchEventos.HoraInicio = (string)dr["HoraInicio"];
                searchEventos.HoraFim = (string)dr["HoraFim"];
                searchEventos.ValorEvento = (Decimal)dr["ValorEvento"];
                searchEventos.EnderecoEvento_id = (int)dr["EnderecoEvento_id"];

                listaEventos.Add(searchEventos);
            }
            return listaEventos;
        }
        /// <summary>
        ///Lista de evento do mes retorna dados em uma grid
        /// </summary>
        public List<DBEvento> GetEventosPorMes(int mes, int ano)
        {
            DateTime dataInicioPesquisa = new DateTime(ano, mes, 1);
            DateTime dataFimPesquisa = new DateTime(ano, mes, DateTime.DaysInMonth(ano, mes));

            ConnectionHelper con = new ConnectionHelper();
            List<DBEvento> listaEventos = new List<DBEvento>();
            SqlCommand comandoSearch = new SqlCommand(@"SELECT * FROM Evento WHERE Ativo = 'true' AND DataInicio BETWEEN @INICIO AND @FIM");
            comandoSearch.Parameters.AddWithValue("@INICIO", dataInicioPesquisa);
            comandoSearch.Parameters.AddWithValue("@FIM", dataFimPesquisa);


            con.AttachCommand(comandoSearch);
            SqlDataReader dr = comandoSearch.ExecuteReader();
            while (dr.Read())
            {
                DBEvento searchEventos = new DBEvento();
                searchEventos.EventoId = (int)dr["EventoId"];
                searchEventos.NomeEvento = (string)dr["NomeEvento"];
                searchEventos.DataInicio = (DateTime)dr["DataInicio"];
                searchEventos.DataFim = (DateTime)dr["DataFim"];
                searchEventos.HoraInicio = (string)dr["HoraInicio"];
                searchEventos.HoraFim = (string)dr["HoraFim"];
                searchEventos.ValorEvento = (Decimal)dr["ValorEvento"];
                searchEventos.EnderecoEvento_id = (int)dr["EnderecoEvento_id"];
                listaEventos.Add(searchEventos);
            }
            return listaEventos;
        }
     
        public int atualizardadoseventosUPA(DBEvento UPAevento)
        {
            SqlCommand comandoUpdate = new SqlCommand(@"SELECT EnderecoEvento_id FROM Evento WHERE EventoId =@EventoId;
            UPDATE Evento SET  NomeEvento = @NomeEvento, DataInicio = @DataInicio, DataFim =@DataFim, HoraInicio = @HoraInicio,
            HoraFim=@HoraFim, ValorEvento=@ValorEvento WHERE EventoId =@EventoId");

            comandoUpdate.Parameters.AddWithValue("@EventoId", UPAevento.EventoId);
            comandoUpdate.Parameters.AddWithValue("@TipoEvento_id", UPAevento.TipoEvento_id);
            comandoUpdate.Parameters.AddWithValue("@NomeEvento", UPAevento.NomeEvento);
            comandoUpdate.Parameters.AddWithValue("@DataInicio", UPAevento.DataInicio);
            comandoUpdate.Parameters.AddWithValue("@DataFim", UPAevento.DataFim);
            comandoUpdate.Parameters.AddWithValue("@HoraInicio", UPAevento.HoraInicio);
            comandoUpdate.Parameters.AddWithValue("@HoraFim", UPAevento.HoraFim);
            comandoUpdate.Parameters.AddWithValue("@ValorEvento", UPAevento.ValorEvento);

            DataTable dt = new DbUtils().Search(comandoUpdate);
            UPAevento.EnderecoEvento_id = (int)dt.Rows[0]["EnderecoEvento_id"];
            return UPAevento.EnderecoEvento_id;
        }
        /// <summary>
        /// rotina  para cancelamento de evento
        /// </summary>
        public void excluirEvento(int codEvento)
        {
            SqlCommand comandoDelete = new SqlCommand(@"UPDATE Evento SET Ativo = 'false' WHERE EventoId = @EventoId");
            comandoDelete.Parameters.AddWithValue("@EventoId", codEvento);
            new DbUtils().Execute(comandoDelete);
        }
        
        public DataTable GetEventosCancelados()
        {
            SqlCommand comandoSearch = new SqlCommand(@"SELECT EventoId AS 'Código do Evento', NomeEvento AS 'Nome do Evento',DataInicio AS 'Data de Inicio',DataFim AS 'Data do Fim',
                                                               HoraInicio AS 'Hora de Inicio',HoraFim AS 'Hora do Fim', ValorEvento AS 'Valor do Evento' 
                                                        FROM Evento WHERE Ativo = 'false'");
            DataTable dr = new DbUtils().Search(comandoSearch);
            if (dr.Rows.Count == 0)
            {
                return null;
            }
            return dr;
        }

        public void restaurarEvento(int idRestaurar)
        {
            SqlCommand comandoUpdate = new SqlCommand(@"UPDATE Evento SET Ativo = 'true' WHERE EventoId = @EventoId");

            comandoUpdate.Parameters.AddWithValue("@EventoId", idRestaurar);
            new DbUtils().Execute(comandoUpdate);
        }


    }
}
