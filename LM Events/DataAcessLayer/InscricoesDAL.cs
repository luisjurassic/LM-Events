using LM_Events.DataObjectBase.Conexao;
using LM_Events.DataObjectBase.Dados;
using LM_Events.ViewModel;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LM_Events.DataAcessLayer
{
    class InscricoesDAL
    {
        /// <summary>
        /// rotina para inserir uma nova Inscrição e retornar o ID gerado
        /// para fazer depois a atualização da situação da inscrição
        /// </summary>
        public int newInscricao(DBInscricoes instanciaInscricoes)
        {
            SqlCommand comandoInserir = new SqlCommand(@"INSERT INTO Inscricoes(InscritoPor, DataInscricao, Evento_id, PessoaFisica_id, Itens, Desconto_id, Pago, Ativo) 
                                                         VALUES(@InscritoPor, @DataInscricao, @Evento_id, @PessoaFisica_id, @Itens, @Desconto_id, @Pago, @Ativo); SELECT SCOPE_IDENTITY()");
            comandoInserir.Parameters.AddWithValue("@InscritoPor", instanciaInscricoes.InscritoPor);
            comandoInserir.Parameters.AddWithValue("@DataInscricao", instanciaInscricoes.DataInscricao);
            comandoInserir.Parameters.AddWithValue("@Evento_id", instanciaInscricoes.Evento_id);
            comandoInserir.Parameters.AddWithValue("@PessoaFisica_id", instanciaInscricoes.PessoaFisica_id);
            comandoInserir.Parameters.AddWithValue("@Itens", instanciaInscricoes.Itens);
            comandoInserir.Parameters.AddWithValue("@Desconto_id", instanciaInscricoes.Desconto_id);
            comandoInserir.Parameters.AddWithValue("@Pago", instanciaInscricoes.Pago);
            comandoInserir.Parameters.AddWithValue("@Ativo", true);
            return new DbUtils().ExecuteOnIdentity(comandoInserir);
        }
        /// <summary>
        /// rotina para atualizar a situação do pagamento (Pago ou Não Pago)
        /// </summary>
        public void atualizarSituacao(DBInscricoes updateSituacao)
        {
            SqlCommand comandoUpdate = new SqlCommand(@"UPDATE Inscricoes SET Pago = @Pago WHERE InscricoesId = @InscricoesId");
            comandoUpdate.Parameters.AddWithValue("@InscricoesId", updateSituacao.InscricoesId);
            comandoUpdate.Parameters.AddWithValue("@Pago", updateSituacao.Pago);
            new DbUtils().Execute(comandoUpdate);
        }
        /// <summary>
        /// rotina  para exclusão da inscrição
        /// </summary>
        public void excluirInscricao(int codInscricao, int codcliente)
        {
            SqlCommand comandoDelete = new SqlCommand(@"UPDATE Inscricoes SET Ativo = 'false' WHERE InscricoesId = @InscricoesId AND PessoaFisica_id = @PessoaFisica_id");
            comandoDelete.Parameters.AddWithValue("@InscricoesId", codInscricao);
            comandoDelete.Parameters.AddWithValue("@PessoaFisica_id", codcliente);
            new DbUtils().Execute(comandoDelete);
        }
        /// <summary>
        /// pesquisa de inscrições para pagamento
        /// </summary>
        public DataTable GetInscricoesNaoPagas()
        {
            SqlCommand comandoSearch = new SqlCommand(@"SELECT Inscricoes.InscricoesId AS 'Inscrição',
                                                               Evento.NomeEvento AS 'Nome do Evento',
                                                               PessoaFisica.Nome,
                                                               Evento.ValorEvento AS 'Valor do Evento',
                                                               Inscricoes.Itens,
                                                               Descontos.PcentDesconto AS 'Porcentagem de Desconto',
                                                               Inscricoes.Pago AS 'Pago'
                                                        FROM (((dbo.Inscricoes Inscricoes 
                                                        INNER JOIN dbo.Evento Evento ON (Evento.EventoId = Inscricoes.Evento_id))
                                                        INNER JOIN dbo.PessoaFisica PessoaFisica  ON (PessoaFisica.PessoaFisicaId = Inscricoes.PessoaFisica_id))
                                                        INNER JOIN dbo.Descontos Descontos ON (Descontos.DescontosId = Inscricoes.Desconto_id))
                                                        WHERE Inscricoes.Ativo = 'true' AND  Inscricoes.Pago = 'Não'");
            DataTable dt = new DbUtils().Search(comandoSearch);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum registro em aberto!");
                return null;
            }
            return dt;
        }
        /// <summary>
        /// pesquisa de pagamento para cliente inscrito na hora
        /// </summary>
        public DataTable InscricaoID(int id)
        {
            SqlCommand comandoSearch = new SqlCommand(@"SELECT Inscricoes.InscricoesId AS 'Inscrição',
                                                               Evento.NomeEvento AS 'Nome do Evento',
                                                               PessoaFisica.Nome,
                                                               Evento.ValorEvento AS 'Valor do Evento',
                                                               Inscricoes.Itens,
                                                               Descontos.PcentDesconto AS 'Porcentagem de Desconto',
                                                               Inscricoes.Pago AS 'Pago'
                                                        FROM Inscricoes INNER JOIN Evento ON Evento.EventoId = Inscricoes.Evento_id
                                                        INNER JOIN PessoaFisica ON PessoaFisica.PessoaFisicaId = Inscricoes.PessoaFisica_id
                                                        INNER JOIN Descontos ON Descontos.DescontosId = Inscricoes.Desconto_id
                                                        WHERE Inscricoes.InscricoesId = @InscricoesId AND Inscricoes.Ativo = 'true'");
            comandoSearch.Parameters.AddWithValue("@InscricoesId", id);
            DataTable dt = new DbUtils().Search(comandoSearch);
            return dt;
        }
        /// <summary>
        /// pesquisa para cancelamento da inscrição no load do formulário 
        /// </summary>
        public DataTable TabelaDeInscricoes()
        {
            SqlCommand comandoSearch = new SqlCommand(@"SELECT Inscricoes.InscricoesId AS 'Inscrição',
                                                               Evento.NomeEvento AS 'Nome do Evento',
                                                               PessoaFisica.Nome,PessoaFisica.PessoaFisicaId AS 'Código Cliente',
                                                               Evento.ValorEvento AS 'Valor do Evento',
                                                               Inscricoes.Pago AS 'Pago'
                                                        FROM ((dbo.Inscricoes Inscricoes 
                                                        INNER JOIN dbo.Evento Evento ON (Evento.EventoId = Inscricoes.Evento_id))
                                                        INNER JOIN dbo.PessoaFisica PessoaFisica  ON (PessoaFisica.PessoaFisicaId = Inscricoes.PessoaFisica_id)) WHERE Inscricoes.Ativo = 'true'");
            DataTable dt = new DbUtils().Search(comandoSearch);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum registro em aberto!");
                return null;
            }
            return dt;
        }
        /// <summary>
        /// pesquisa de inscrição por parametro para cancelamento
        /// </summary>
        public DataTable GetTodasInscricoes()
        {
            SqlCommand comandoSearch = new SqlCommand(@"SELECT Inscricoes.InscricoesId AS 'Inscrição',
                                                               Evento.NomeEvento AS 'Nome do Evento',
                                                               PessoaFisica.Nome,
                                                               Evento.ValorEvento AS 'Valor do Evento',
                                                               Inscricoes.Itens,
                                                               Descontos.PcentDesconto AS 'Porcentagem de Desconto',
                                                               Inscricoes.Pago AS 'Pago'
                                                        FROM Inscricoes 
                                                        INNER JOIN Evento ON  Evento.EventoId = Inscricoes.Evento_id 
                                                        INNER JOIN PessoaFisica  ON PessoaFisica.PessoaFisicaId = Inscricoes.PessoaFisica_id
                                                        INNER JOIN Descontos ON Descontos.DescontosId = Inscricoes.Desconto_id WHERE Inscricoes.Ativo = 'true'");
            DataTable dt = new DbUtils().Search(comandoSearch);
            return dt;
        }

        public DataTable InscricoesCanceladas()
        {
            SqlCommand comandoSearch = new SqlCommand(@"SELECT Inscricoes.InscricoesId AS 'Inscrição',
                                                               Evento.NomeEvento AS 'Nome do Evento',
                                                               PessoaFisica.Nome,PessoaFisica.PessoaFisicaId AS 'Código Cliente',
                                                               Evento.ValorEvento AS 'Valor do Evento',
                                                               Inscricoes.Situacao AS 'Situação'
                                                        FROM ((dbo.Inscricoes Inscricoes 
                                                        INNER JOIN dbo.Evento Evento ON (Evento.EventoId = Inscricoes.Evento_id))
                                                        INNER JOIN dbo.PessoaFisica PessoaFisica  ON (PessoaFisica.PessoaFisicaId = Inscricoes.PessoaFisica_id)) WHERE Inscricoes.Ativo = 'false'");
            DataTable dt = new DbUtils().Search(comandoSearch);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            return dt;
        }

        public void restaurarInscricao(int idRestaurar)
        {
            SqlCommand comandoUpdate = new SqlCommand(@"UPDATE Inscricoes SET Ativo = 'true' WHERE InscricoesId = @InscricoesId");

            comandoUpdate.Parameters.AddWithValue("@InscricoesId", idRestaurar);
            new DbUtils().Execute(comandoUpdate);
        }

    }
}
