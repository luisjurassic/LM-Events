using LM_Events.DataObjectBase.Conexao;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LM_Events.DataObjectBase
{
    class EnderecoDAL
    {
        /// <summary>
        /// rotina para inserir um novo endereco referenciado pela pessoa fisica
        /// </summary>
        public int inserirDadosEndereco(DBEndereco instanciaEndereco)
        {
            SqlCommand comandoInserirDados = new SqlCommand(@"INSERT INTO Endereco(Rua,Bairro,Numero,Complemento,Cidade_id,Estado_id,CEP) 
                                                               VALUES(@Rua,@Bairro,@Numero,@Complemento,@Cidade_id,@Estado_id,@CEP); SELECT SCOPE_IDENTITY()");

            comandoInserirDados.Parameters.AddWithValue("@Rua", instanciaEndereco.Rua);
            comandoInserirDados.Parameters.AddWithValue("@Bairro", instanciaEndereco.Bairro);
            comandoInserirDados.Parameters.AddWithValue("@Numero", instanciaEndereco.Numero);
            comandoInserirDados.Parameters.AddWithValue("@Complemento", instanciaEndereco.Complemento);
            comandoInserirDados.Parameters.AddWithValue("@Cidade_id", instanciaEndereco.Cidade_id);
            comandoInserirDados.Parameters.AddWithValue("@Estado_id", instanciaEndereco.Estado_id);
            comandoInserirDados.Parameters.AddWithValue("@CEP", instanciaEndereco.CEP);
            return new DbUtils().ExecuteOnIdentity(comandoInserirDados);
        }
        /// <summary>
        /// rotina pesquisa pessoa fisisca e retorna dados endereco já cadastrados
        /// </summary>
        public DBEndereco pesquisaAtualizarEnderecoPessoaFisica(int atualizarEndereco)
        {
            DBEndereco atualizarEndPF = new DBEndereco();
            SqlCommand comandoSearch = new SqlCommand("SELECT *FROM Endereco WHERE EnderecoId=@EnderecoId");
            comandoSearch.Parameters.AddWithValue("@EnderecoId", atualizarEndereco);
            DataTable dt = new DbUtils().Search(comandoSearch);
            if (dt.HasErrors)
            {
                throw new Exception();
            }
            atualizarEndPF.Rua = (string)dt.Rows[0]["Rua"];
            atualizarEndPF.Bairro = (string)dt.Rows[0]["Bairro"];
            atualizarEndPF.Numero = (string)dt.Rows[0]["Numero"];
            atualizarEndPF.Complemento = (string)dt.Rows[0]["Complemento"];
            atualizarEndPF.CEP = (string)dt.Rows[0]["CEP"];
            atualizarEndPF.Cidade_id = (int)dt.Rows[0]["Cidade_id"];
            atualizarEndPF.Estado_id = (byte)dt.Rows[0]["Estado_id"];
            return atualizarEndPF;
        }
        /// <summary>
        /// rotina para pesquisar endereço de uma pessoa juridica e retorna dados endereco já cadastrados
        /// </summary>
        public DBEndereco pesquisaAtualizarEnderecoPessoaJuridica(int atualizarEnderecoPJ)
        {
            DBEndereco atualizarEndPJ = new DBEndereco();
            SqlCommand comandoSearch = new SqlCommand("SELECT *FROM Endereco WHERE EnderecoId =@EnderecoId");
            comandoSearch.Parameters.AddWithValue("@EnderecoId", atualizarEnderecoPJ);

            DataTable dtEndPJ = new DbUtils().Search(comandoSearch);
            atualizarEndPJ.Rua = (string)dtEndPJ.Rows[0]["Rua"];
            atualizarEndPJ.Bairro = (string)dtEndPJ.Rows[0]["Bairro"];
            atualizarEndPJ.Numero = (string)dtEndPJ.Rows[0]["Numero"];
            atualizarEndPJ.Complemento = (string)dtEndPJ.Rows[0]["Complemento"];
            atualizarEndPJ.CEP = (string)dtEndPJ.Rows[0]["CEP"];
            atualizarEndPJ.Cidade_id = (int)dtEndPJ.Rows[0]["Cidade_id"];
            atualizarEndPJ.Estado_id = (byte)dtEndPJ.Rows[0]["Estado_id"];
            return atualizarEndPJ;
        }
        /// <summary>
        /// rotina aguardo o retorno "ID" para exclusão do endereço referenciado
        /// </summary>
        public void ExcluirPorID(int id)
        {
            SqlCommand comandoDelete = new SqlCommand("DELETE FROM Endereco WHERE EnderecoId = @EnderecoId ");
            comandoDelete.Parameters.AddWithValue("@EnderecoId", id);
            new DbUtils().Execute(comandoDelete);
        }
        /// <summary>
        /// rotina para atualizar dados do endereço da pessoa referencia
        /// </summary>
        public void atualizarDadosEndereco(DBEndereco updateEndereco)
        {
            SqlCommand comandoInserirDados = new SqlCommand(@"UPDATE Endereco SET Rua = @Rua,
                                                                                      Bairro = @Bairro,
                                                                                      Numero =@Numero,
                                                                                      Complemento=@Complemento,
                                                                                      Cidade_id=@Cidade_id,
                                                                                      Estado_id = @Estado_id,
                                                                                      CEP = @CEP
                                                                   WHERE EnderecoId =@EnderecoId");
            comandoInserirDados.Parameters.AddWithValue("@EnderecoId", updateEndereco.EnderecoId);
            comandoInserirDados.Parameters.AddWithValue("@Rua", updateEndereco.Rua);
            comandoInserirDados.Parameters.AddWithValue("@Bairro", updateEndereco.Bairro);
            comandoInserirDados.Parameters.AddWithValue("@Numero", updateEndereco.Numero);
            comandoInserirDados.Parameters.AddWithValue("@Complemento", updateEndereco.Complemento);
            comandoInserirDados.Parameters.AddWithValue("@Cidade_id", updateEndereco.Cidade_id);
            comandoInserirDados.Parameters.AddWithValue("@Estado_id", updateEndereco.Estado_id);
            comandoInserirDados.Parameters.AddWithValue("@CEP", updateEndereco.CEP);
            new DbUtils().Execute(comandoInserirDados);
        }

        public DBEndereco GetEndereco(int id)
        {
            DBEndereco atualizarEndPJ = new DBEndereco();
            SqlCommand comandoSearch = new SqlCommand("SELECT *FROM Endereco WHERE EnderecoId =@EnderecoId");
            comandoSearch.Parameters.AddWithValue("@EnderecoId", id);

            DataTable dtEndPJ = new DbUtils().Search(comandoSearch);
            atualizarEndPJ.Rua = (string)dtEndPJ.Rows[0]["Rua"];
            atualizarEndPJ.Bairro = (string)dtEndPJ.Rows[0]["Bairro"];
            atualizarEndPJ.Numero = (string)dtEndPJ.Rows[0]["Numero"];
            atualizarEndPJ.Complemento = (string)dtEndPJ.Rows[0]["Complemento"];
            atualizarEndPJ.CEP = (string)dtEndPJ.Rows[0]["CEP"];
            atualizarEndPJ.Cidade_id = (int)dtEndPJ.Rows[0]["Cidade_id"];
            atualizarEndPJ.Estado_id = (byte)dtEndPJ.Rows[0]["Estado_id"];
            return atualizarEndPJ;
        }
    }
}
