using LM_Events.DataObjectBase.Conexao;
using LM_Events.DataObjectBase.Dados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LM_Events.DataAcessLayer
{
    class StandDAL
    {
        public void inserirStand(DBStands newStand)
        {
            SqlCommand cmdDados = new SqlCommand(@"INSERT INTO Stands(NomeStand, TamanhoStand, ValorStand, Evento_id, Disponivel, Pago, Ativo) 
                                                   VALUES(@NomeStand, @TamanhoStand, @ValorStand, @Evento_id, @Disponivel,@Pago, @Ativo)");
            cmdDados.Parameters.AddWithValue("@NomeStand", newStand.NomeStand);
            cmdDados.Parameters.AddWithValue("@TamanhoStand", newStand.TamanhoStand);
            cmdDados.Parameters.AddWithValue("@ValorStand", newStand.ValorStand);
            cmdDados.Parameters.AddWithValue("@Evento_id", newStand.Evento_id);
            cmdDados.Parameters.AddWithValue("@Disponivel", newStand.Disponivel);
            cmdDados.Parameters.AddWithValue("@Pago", newStand.Pago);
            cmdDados.Parameters.AddWithValue("@Ativo", newStand.Ativo);
            new DbUtils().Execute(cmdDados);
        }
        public void atualizarStands(DBStands upStand)
        {
            SqlCommand comandoUpdate = new SqlCommand(@"UPDATE Stands SET  NomeStand = @NomeStand, TamanhoStand = @TamanhoStand, ValorStand = @ValorStand
                                                        WHERE StandsId = @StandsId");
            comandoUpdate.Parameters.AddWithValue("@StandsId", upStand.StandsId);
            comandoUpdate.Parameters.AddWithValue("@NomeStand", upStand.NomeStand);
            comandoUpdate.Parameters.AddWithValue("@TamanhoStand", upStand.TamanhoStand);
            comandoUpdate.Parameters.AddWithValue("@ValorStand", upStand.ValorStand);
            new DbUtils().Execute(comandoUpdate);
        }
        public void deletarStand(int delStands)
        {
            SqlCommand comandoDelete = new SqlCommand(@"UPDATE Stands SET Ativo = 'false' WHERE StandsId = @StandsId");
            comandoDelete.Parameters.AddWithValue("@StandsId", delStands);
            new DbUtils().Execute(comandoDelete);
        }
        public void deletarTodosStands()
        {
            SqlCommand comandoDelete = new SqlCommand(@"UPDATE Stands SET Ativo = 'false'");
            new DbUtils().Execute(comandoDelete);
        }
        public List<DBStands> listaStandParaReserva()
        {
            ConnectionHelper con = new ConnectionHelper();
            List<DBStands> listStand = new List<DBStands>();
            SqlCommand cmd = new SqlCommand(@"SELECT Stands.StandsId, Stands.NomeStand, Stands.TamanhoStand, Stands.ValorStand, Evento.NomeEvento
                                              FROM Stands LEFT JOIN Evento ON Evento.EventoId = Stands.Evento_id WHERE Disponivel = 'true' AND Stands.Ativo = 'true'");
            con.AttachCommand(cmd);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DBStands st = new DBStands();
                st.StandsId = Convert.ToInt32(dr["StandsId"]);
                st.NomeStand = dr["NomeStand"].ToString();
                st.TamanhoStand = dr["TamanhoStand"].ToString();
                st.ValorStand = Convert.ToDouble(dr["ValorStand"]);
                st.Evento_id = dr["NomeEvento"].ToString();

                listStand.Add(st);
            }
            return listStand;
        }
        public List<DBStands> listaStandAdm()
        {
            ConnectionHelper con = new ConnectionHelper();
            List<DBStands> listStand = new List<DBStands>();
            SqlCommand cmd = new SqlCommand(@"SELECT Stands.StandsId, Stands.NomeStand, Stands.TamanhoStand, Stands.ValorStand, Evento.NomeEvento
                                              FROM Stands LEFT JOIN Evento ON Evento.EventoId = Stands.Evento_id WHERE Stands.Ativo = 'true'");

            con.AttachCommand(cmd);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DBStands st = new DBStands();
                st.StandsId = Convert.ToInt32(dr["StandsId"]);
                st.NomeStand = dr["NomeStand"].ToString();
                st.TamanhoStand = dr["TamanhoStand"].ToString();
                st.ValorStand = Convert.ToDouble(dr["ValorStand"]);
                st.Evento_id = dr["NomeEvento"].ToString();

                listStand.Add(st);
            }
            return listStand;
        }
        public void Reserva(DBStands upStand)
        {
            SqlCommand comandoUpdate = new SqlCommand(@"UPDATE Stands SET Disponivel = @Disponivel WHERE StandsId = @StandsId");
            comandoUpdate.Parameters.AddWithValue("@StandsId", upStand.StandsId);
            comandoUpdate.Parameters.AddWithValue("@Disponivel", upStand.Disponivel);
            new DbUtils().Execute(comandoUpdate);
        }
        public void excluirReserva(int id , string situacao)
        {
            SqlCommand comandoUpdate = new SqlCommand(@"UPDATE Stands SET Disponivel = @Disponivel, Pago = @Pago WHERE StandsId = @StandsId");
            comandoUpdate.Parameters.AddWithValue("@StandsId", id);
            comandoUpdate.Parameters.AddWithValue("@Pago", situacao);
            comandoUpdate.Parameters.AddWithValue("@Disponivel", true);
            new DbUtils().Execute(comandoUpdate);
        }
        public void atualizarSituacaoReserva(DBStands upStand)
        {
            SqlCommand comandoUpdate = new SqlCommand(@"UPDATE Stands SET Pago = @Pago WHERE StandsId = @StandsId");
            comandoUpdate.Parameters.AddWithValue("@StandsId", upStand.StandsId);
            comandoUpdate.Parameters.AddWithValue("@Pago", upStand.Pago);
            new DbUtils().Execute(comandoUpdate);
        }
        public DataTable PagamentoReserva()
        {
            SqlCommand comandoSearch = new SqlCommand(@"SELECT Stands.StandsId AS 'Código Stand', 
                                                               Stands.NomeStand AS 'Nome do Stand',
                                                               Stands.ValorStand AS 'Valor do Stand',
                                                               PessoaJuridica.RazaoSocial AS 'Resercado Para',
                                                               Stands.Pago AS 'Pago'
                                                        FROM ReservaStands INNER JOIN Stands ON Stands.StandsId = ReservaStands.Stand_id
                                                        INNER JOIN  PessoaJuridica ON PessoaJuridica.PessoaJuridicaId = ReservaStands.PessoaJuridica_id WHERE Stands.Ativo = 'true'");
            DataTable dt = new DbUtils().Search(comandoSearch);
            return dt;
        }
        public DataTable PagamentoReservaID(int id)
        {
            SqlCommand comandoSearch = new SqlCommand(@"SELECT Stands.StandsId AS 'Código Stand', 
                                                               Stands.NomeStand AS 'Nome do Stand',
                                                               Stands.ValorStand AS 'Valor do Stand',
                                                               PessoaJuridica.RazaoSocial AS 'Resercado Para',
                                                               Stands.Pago AS 'Pago'
                                                        FROM ReservaStands INNER JOIN Stands ON Stands.StandsId = ReservaStands.Stand_id
                                                        INNER JOIN  PessoaJuridica ON PessoaJuridica.PessoaJuridicaId = ReservaStands.PessoaJuridica_id
                                                        WHERE Stands.StandsId = @StandsId AND Stands.Ativo = 'true'");
            comandoSearch.Parameters.AddWithValue("@StandsId", id);
            DataTable dt = new DbUtils().Search(comandoSearch);
            return dt;
        }
       
    }
}
