using LM_Events.DataObjectBase.Conexao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LM_Events.DataObjectBase
{
    public class PessoaFisicaDAL
    {
        /// <summary>
        /// rotina para inserir um novo cadastro pessoa fisica
        /// </summary>
        public void inserirDadosPessoaFisica(DBPessoaFisica instanciaPessoaFisica)
        {
            SqlCommand comandoInsert = new SqlCommand(@"INSERT INTO PessoaFisica(Nome,CPF,RG,Sexo,DataNascimento,TelefoneResidencial,TelefoneCelular,TipoCadastro_id,EstadoCivil_id,EnderecoPessoaFisica_id,Ativo)
                                                        VALUES(@Nome,@CPF,@RG,@Sexo,@DataNascimento,@TelefoneResidencial,@TelefoneCelular,@TipoCadastro_id,@EstadoCivil_id,@EnderecoPessoaFisica_id,@Ativo)");
            comandoInsert.Parameters.AddWithValue("@Nome", instanciaPessoaFisica.Nome);
            comandoInsert.Parameters.AddWithValue("@CPF", instanciaPessoaFisica.CPF);
            comandoInsert.Parameters.AddWithValue("@RG", instanciaPessoaFisica.RG);
            comandoInsert.Parameters.AddWithValue("@Sexo", instanciaPessoaFisica.Sexo);
            comandoInsert.Parameters.AddWithValue("@DataNascimento", instanciaPessoaFisica.DataNascimento);
            comandoInsert.Parameters.AddWithValue("@TelefoneResidencial", instanciaPessoaFisica.TelefoneResidencial);
            comandoInsert.Parameters.AddWithValue("@TelefoneCelular", instanciaPessoaFisica.TelefoneCelular);
            comandoInsert.Parameters.AddWithValue("@TipoCadastro_id", instanciaPessoaFisica.TipoCadastro_id);
            comandoInsert.Parameters.AddWithValue("@EstadoCivil_id", instanciaPessoaFisica.EstadoCivil_id);
            comandoInsert.Parameters.AddWithValue("@EnderecoPessoaFisica_id", instanciaPessoaFisica.EnderecoPessoaFisica_id);
            comandoInsert.Parameters.AddWithValue("@Ativo", true);
            new DbUtils().Execute(comandoInsert);
        }
        /// <summary>
        ///Lista pesquisa pessoas fisicas por "NOME" para verificação de dados retorna dados em uma grid
        /// </summary>
        public List<DBPessoaFisica> GetPessoaFisica(string nomePF)
        {
            ConnectionHelper con = new ConnectionHelper();
            List<DBPessoaFisica> listaPF = new List<DBPessoaFisica>();
            SqlCommand comandoSearch = new SqlCommand(@"SELECT *FROM PessoaFisica WHERE Nome LIKE '%'+@Nome+'%' AND ATIVO = 'TRUE'");
            comandoSearch.Parameters.AddWithValue("@Nome", nomePF);

            con.AttachCommand(comandoSearch);
            SqlDataReader dr = comandoSearch.ExecuteReader();
            while (dr.Read())
            {
                DBPessoaFisica searchPF = new DBPessoaFisica();
                searchPF.PessoaFisicaId = (int)dr["PessoaFisicaId"];
                searchPF.Nome = (string)dr["Nome"];
                searchPF.CPF = (string)dr["CPF"];
                searchPF.RG = (string)dr["RG"];
                searchPF.DataNascimento = (DateTime)dr["DataNascimento"];
                searchPF.Sexo = (string)dr["Sexo"];
                searchPF.TelefoneResidencial = (string)dr["TelefoneResidencial"];
                searchPF.TelefoneCelular = (string)dr["TelefoneCelular"];
                searchPF.EstadoCivil_id = (int)dr["EstadoCivil_id"];
                searchPF.TipoCadastro_id = (int)dr["TipoCadastro_id"];
                searchPF.EnderecoPessoaFisica_id = (int)dr["EnderecoPessoaFisica_id"];
                listaPF.Add(searchPF);
            }
            return listaPF;
        }       
        /// <summary>
        /// apos o retorno da pesquisa faz o update dos novos dados recebidos da pessoa fisisca
        /// </summary>
        public int atualizarDadosPessoaFisica(DBPessoaFisica upPessoaFisica)
        {
            SqlCommand comandoUpdate = new SqlCommand(@"SELECT EnderecoPessoaFisica_id FROM PessoaFisica WHERE CPF =@CPF;
            UPDATE PessoaFisica SET  Nome = @Nome, DataNascimento = @DataNascimento, TelefoneResidencial =@TelefoneResidencial, 
            TelefoneCelular=@TelefoneCelular, TipoCadastro_id=@TipoCadastro_id, EstadoCivil_id = @EstadoCivil_id WHERE CPF =@CPF");

            comandoUpdate.Parameters.AddWithValue("@Nome", upPessoaFisica.Nome);
            comandoUpdate.Parameters.AddWithValue("@CPF", upPessoaFisica.CPF);
            comandoUpdate.Parameters.AddWithValue("@DataNascimento", upPessoaFisica.DataNascimento);
            comandoUpdate.Parameters.AddWithValue("@TelefoneResidencial", upPessoaFisica.TelefoneResidencial);
            comandoUpdate.Parameters.AddWithValue("@TelefoneCelular", upPessoaFisica.TelefoneCelular);
            comandoUpdate.Parameters.AddWithValue("@TipoCadastro_id", upPessoaFisica.TipoCadastro_id);
            comandoUpdate.Parameters.AddWithValue("@EstadoCivil_id", upPessoaFisica.EstadoCivil_id);

            DataTable dt = new DbUtils().Search(comandoUpdate);
            upPessoaFisica.EnderecoPessoaFisica_id = (int)dt.Rows[0]["EnderecoPessoaFisica_id"];
            return upPessoaFisica.EnderecoPessoaFisica_id;

        }
        /// <summary>
        /// SELECT para buscar no banco pessoa fisica pelo CPF e mandar para comfirmação
        /// </summary>
        public DataTable PesquisarExcluirPF()
        {
            DBPessoaFisica pessoaExcluir = new DBPessoaFisica();
            SqlCommand comandoPesquisar = new SqlCommand(@"SELECT PessoaFisica.Nome,
                                                                  PessoaFisica.CPF,
                                                                  PessoaFisica.RG,
                                                                  PessoaFisica.DataNascimento AS 'Data de Nascimento',
                                                                  TipoCadastro.Descricao AS 'Tipo de Cadastro'
                                                           FROM PessoaFisica INNER JOIN TipoCadastro ON TipoCadastro.TipoCadastroId = PessoaFisica.TipoCadastro_id
                                                           WHERE PessoaFisica.Ativo = 'true'");
            DataTable ExcluirPF = new DbUtils().Search(comandoPesquisar);
            if (ExcluirPF.Rows.Count == 0)
            {
                return null;
            }
            return ExcluirPF;
        }
        /// <summary>
        /// SELECT de comfirmação de dados pessoas fisicas para exclusao dos memos 
        /// </summary>
        public void ExcluirPessoaFisica(DBPessoaFisica delPessoaFisica)
        {
            SqlCommand comandoExcluir = new SqlCommand(@"UPDATE PessoaFisica SET Ativo = 'false' WHERE CPF = @CPF AND RG = @RG");
            comandoExcluir.Parameters.AddWithValue("@CPF", delPessoaFisica.CPF);
            comandoExcluir.Parameters.AddWithValue("@RG", delPessoaFisica.RG);
            new DbUtils().Execute(comandoExcluir);
        }
        /// <summary>
        ///Lista pesquisa pessoas fisicas para restaurar atividade
        /// </summary>
        public List<DBPessoaFisica> pessoaFisicaCanceladas()
        {
            ConnectionHelper con = new ConnectionHelper();
            List<DBPessoaFisica> listaPF = new List<DBPessoaFisica>();
            SqlCommand comandoSearch = new SqlCommand(@"SELECT *FROM PessoaFisica WHERE  Ativo = 'false'");

            con.AttachCommand(comandoSearch);
            SqlDataReader dr = comandoSearch.ExecuteReader();
            while (dr.Read())
            {
                DBPessoaFisica searchPF = new DBPessoaFisica();
                searchPF.PessoaFisicaId = (int)dr["PessoaFisicaId"];
                searchPF.Nome = (string)dr["Nome"];
                searchPF.CPF = (string)dr["CPF"];
                searchPF.RG = (string)dr["RG"];
                searchPF.DataNascimento = (DateTime)dr["DataNascimento"];
                searchPF.Sexo = (string)dr["Sexo"];
                searchPF.TelefoneResidencial = (string)dr["TelefoneResidencial"];
                searchPF.TelefoneCelular = (string)dr["TelefoneCelular"];
                searchPF.EstadoCivil_id = (int)dr["EstadoCivil_id"];
                searchPF.TipoCadastro_id = (int)dr["TipoCadastro_id"];
                searchPF.EnderecoPessoaFisica_id = (int)dr["EnderecoPessoaFisica_id"];
                listaPF.Add(searchPF);
            }
            return listaPF;
        }
        /// <summary>
        /// atualizar atividade da pessoa fisaca para true
        /// </summary>
        public void restaurarPessoaFisica(int idRestaurar)
        {
            SqlCommand comandoUpdate = new SqlCommand(@"UPDATE PessoaFisica SET Ativo = 'true' WHERE PessoaFisicaId = @PessoaFisicaId ");
            comandoUpdate.Parameters.AddWithValue("@PessoaFisicaId", idRestaurar);
            new DbUtils().Execute(comandoUpdate);
        }

        public bool VerificaCPF(string cpf)
        {
            ConnectionHelper con = new ConnectionHelper();
            SqlCommand comandoVerificaDados = new SqlCommand(@"SELECT CPF FROM PessoaFisica 
                                                                           WHERE CPF = @CPF");
            SqlParameter parametroCPF = new SqlParameter("@CPF", SqlDbType.NVarChar, 15);
            parametroCPF.Value = cpf;
            comandoVerificaDados.Parameters.Add(parametroCPF);

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

    }
}
