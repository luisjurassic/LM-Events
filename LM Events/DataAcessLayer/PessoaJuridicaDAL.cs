using LM_Events.DataObjectBase.Conexao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LM_Events.DataObjectBase
{
    class PessoaJuridicaDAL
    {
        /// <summary>
        /// rotina para inserir um novo cadastro pessoa juridica
        /// </summary>
        public void inserirDadosPessoaJuridica(DBPessoaJuridica instanciaPessoaJuridica)
        {
            SqlCommand comandoInsert = new SqlCommand(@"INSERT INTO PessoaJuridica(NomeFantasia, RazaoSocial, CNPJ, InscricaoEstadual, DataFundacao, RamoAtividade_id, Email, WebSite, EnderecoPessoaJuridica_id, Telefone, Ativo) 
                                                        VALUES(@NomeFantasia,@RazaoSocial,@CNPJ,@InscricaoEstadual,@DataFundacao,@RamoAtividade_id,@Email,@WebSite,@EnderecoPessoaJuridica_id,@Telefone,@Ativo)");

            comandoInsert.Parameters.AddWithValue("@NomeFantasia", instanciaPessoaJuridica.NomeFantasia);
            comandoInsert.Parameters.AddWithValue("@RazaoSocial", instanciaPessoaJuridica.RazaoSocial);
            comandoInsert.Parameters.AddWithValue("@CNPJ", instanciaPessoaJuridica.CNPJ);
            comandoInsert.Parameters.AddWithValue("@InscricaoEstadual", instanciaPessoaJuridica.InscricaoEstadual);
            comandoInsert.Parameters.AddWithValue("@DataFundacao", instanciaPessoaJuridica.DataFundacao);
            comandoInsert.Parameters.AddWithValue("@Email", instanciaPessoaJuridica.Email);
            comandoInsert.Parameters.AddWithValue("@WebSite", instanciaPessoaJuridica.WebSite);
            comandoInsert.Parameters.AddWithValue("@Telefone", instanciaPessoaJuridica.Telefone);
            comandoInsert.Parameters.AddWithValue("@RamoAtividade_id", instanciaPessoaJuridica.RamoAtividade_id);
            comandoInsert.Parameters.AddWithValue("@EnderecoPessoaJuridica_id", instanciaPessoaJuridica.EnderecoPessoaJuridica_id);
            comandoInsert.Parameters.AddWithValue("@Ativo", true);
            new DbUtils().Execute(comandoInsert);
        }
        /// <summary>
        ///Lista pesquisa pessoas juridica por "NOME" para verificação de dados retorna dados em uma grid
        /// </summary>
        public List<DBPessoaJuridica> GetPessoaJuridica(string nomePJ)
        {
            ConnectionHelper con = new ConnectionHelper();
            List<DBPessoaJuridica> listaPJ = new List<DBPessoaJuridica>();
            SqlCommand comandoSearch = new SqlCommand(@"SELECT *FROM PessoaJuridica WHERE NomeFantasia LIKE '%'+@NomeFantasia+'%'");
            comandoSearch.Parameters.AddWithValue("@NomeFantasia", nomePJ);

            con.AttachCommand(comandoSearch);
            SqlDataReader dr = comandoSearch.ExecuteReader();
            while (dr.Read())
            {
                DBPessoaJuridica searchPJ = new DBPessoaJuridica();
                searchPJ.PessoaJuridicaId = (int)dr["PessoaJuridicaId"];
                searchPJ.NomeFantasia = (string)dr["NomeFantasia"];
                searchPJ.RazaoSocial = (string)dr["RazaoSocial"];
                searchPJ.CNPJ = (string)dr["CNPJ"];
                searchPJ.InscricaoEstadual = (string)dr["InscricaoEstadual"];
                searchPJ.DataFundacao = (DateTime)dr["DataFundacao"];
                searchPJ.Telefone = (string)dr["Telefone"];
                searchPJ.WebSite = (string)dr["WebSite"];
                searchPJ.Email = (string)dr["Email"];
                searchPJ.RamoAtividade_id = (byte)dr["RamoAtividade_id"];
                searchPJ.EnderecoPessoaJuridica_id = (int)dr["EnderecoPessoaJuridica_id"];
                listaPJ.Add(searchPJ);
            }
            return listaPJ;
        }       
        /// <summary>
        /// apos o retorno da pesquisa faz o update dos novos dados recebidos da pessoa juridica
        /// </summary>
        public int atualizarDadosPessoaJuridica(DBPessoaJuridica upPessoaJuridica)
        {
            SqlCommand comandoUpdate = new SqlCommand(@"SELECT EnderecoPessoaJuridica_id FROM PessoaJuridica WHERE CNPJ =@CNPJ;
                                                                  UPDATE PessoaJuridica SET NomeFantasia = @NomeFantasia,
                                                                                            RazaoSocial = @RazaoSocial,
                                                                                            InscricaoEstadual = @InscricaoEstadual,
                                                                                            DataFundacao = @DataFundacao,
                                                                                            Telefone = @Telefone,
                                                                                            WebSite =@WebSite,
                                                                                            Email = @Email,
                                                                                            RamoAtividade_id = @RamoAtividade_id 
                                                                   WHERE CNPJ =@CNPJ");
            comandoUpdate.Parameters.AddWithValue("@NomeFantasia", upPessoaJuridica.NomeFantasia);
            comandoUpdate.Parameters.AddWithValue("@RazaoSocial", upPessoaJuridica.RazaoSocial);
            comandoUpdate.Parameters.AddWithValue("@CNPJ", upPessoaJuridica.CNPJ);
            comandoUpdate.Parameters.AddWithValue("@InscricaoEstadual", upPessoaJuridica.InscricaoEstadual);
            comandoUpdate.Parameters.AddWithValue("@DataFundacao", upPessoaJuridica.DataFundacao);
            comandoUpdate.Parameters.AddWithValue("@Telefone", upPessoaJuridica.Telefone);
            comandoUpdate.Parameters.AddWithValue("@WebSite", upPessoaJuridica.WebSite);
            comandoUpdate.Parameters.AddWithValue("@Email", upPessoaJuridica.Email);
            comandoUpdate.Parameters.AddWithValue("@RamoAtividade_id", upPessoaJuridica.RamoAtividade_id);

            DataTable dtUpdatePJ = new DbUtils().Search(comandoUpdate);
            upPessoaJuridica.EnderecoPessoaJuridica_id = (int)dtUpdatePJ.Rows[0]["EnderecoPessoaJuridica_id"];
            return upPessoaJuridica.EnderecoPessoaJuridica_id;
        }
        /// <summary>
        /// SELECT para buscar no banco pessoas juridicas pelo CPF e mandar para comfirmação
        /// </summary>
        public DataTable PesquisarExcluirPJ()
        {
            DBPessoaJuridica ExcluirPJ = new DBPessoaJuridica();
            SqlCommand comandoPesquisar = new SqlCommand(@"SELECT PessoaJuridica.RazaoSocial AS 'Nome da Empresa',
                                                                  PessoaJuridica.CNPJ,
                                                                  PessoaJuridica.InscricaoEstadual AS 'Inscrição Estadual',
                                                                  RamoAtividade.Atividade AS 'Ramo de Atividade'
                                                           FROM PessoaJuridica INNER JOIN RamoAtividade ON RamoAtividade.RamoAtividadeId = PessoaJuridica.RamoAtividade_id
                                                           WHERE PessoaJuridica.Ativo = 'true'");
            DataTable dtExcluirPJ = new DbUtils().Search(comandoPesquisar);
            if (dtExcluirPJ.Rows.Count == 0)
            {
                return null;
            }
            return dtExcluirPJ;
        }
        /// <summary>
        /// SELECT de comfirmação de dados pessoas juridicas para exclusao dos memos 
        /// </summary>
        public void ExcluirPessoaJuridica(DBPessoaJuridica delPessoaJuridica)
        {
            SqlCommand comandoExcluir = new SqlCommand(@"UPDATE PessoaJuridica SET Ativo = 'false' WHERE CNPJ = @CNPJ AND InscricaoEstadual = @InscricaoEstadual");
            comandoExcluir.Parameters.AddWithValue("@CNPJ", delPessoaJuridica.CNPJ);
            comandoExcluir.Parameters.AddWithValue("@InscricaoEstadual", delPessoaJuridica.InscricaoEstadual);
            new DbUtils().Execute(comandoExcluir);
        }

        public bool VerificaCNPJ(string CNPJ)
        {
            ConnectionHelper con = new ConnectionHelper();
            SqlCommand comandoVerificaDados = new SqlCommand(@"SELECT CNPJ FROM PessoaJuridica 
                                                                           WHERE CNPJ = @CNPJ");
            SqlParameter parametroCNPJ = new SqlParameter("@CNPJ", SqlDbType.VarChar, 20);
            parametroCNPJ.Value = CNPJ;
            comandoVerificaDados.Parameters.Add(parametroCNPJ);

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

        public void restaurarPessoaJuridica(int idRestaurar)
        {
            SqlCommand comandoUpdate = new SqlCommand(@"UPDATE PessoaJuridica SET Ativo = 'true' WHERE PessoaJuridicaId = @PessoaJuridicaId ");
            comandoUpdate.Parameters.AddWithValue("@PessoaJuridicaId", idRestaurar);
            new DbUtils().Execute(comandoUpdate);
        }

        public List<DBPessoaJuridica> pessoaJuridicaCanceladas()
        {
            ConnectionHelper con = new ConnectionHelper();
            List<DBPessoaJuridica> listaPJ = new List<DBPessoaJuridica>();
            SqlCommand comandoSearch = new SqlCommand(@"SELECT *FROM PessoaJuridica WHERE  Ativo = 'false'");

            con.AttachCommand(comandoSearch);
            SqlDataReader dr = comandoSearch.ExecuteReader();
            while (dr.Read())
            {
                DBPessoaJuridica searchPJ = new DBPessoaJuridica();
                searchPJ.PessoaJuridicaId = (int)dr["PessoaJuridicaId"];
                searchPJ.NomeFantasia = (string)dr["NomeFantasia"];
                searchPJ.CNPJ = (string)dr["CNPJ"];
                searchPJ.RazaoSocial = (string)dr["RazaoSocial"];
                searchPJ.DataFundacao = (DateTime)dr["DataFundacao"];
                searchPJ.InscricaoEstadual = (string)dr["InscricaoEstadual"];
                searchPJ.Telefone = (string)dr["Telefone"];
                searchPJ.WebSite = (string)dr["WebSite"];
                searchPJ.Email = (string)dr["Email"];
                searchPJ.EnderecoPessoaJuridica_id = (int)dr["EnderecoPessoaJuridica_id"];
                listaPJ.Add(searchPJ);
            }
            return listaPJ;
        }
    }
}
