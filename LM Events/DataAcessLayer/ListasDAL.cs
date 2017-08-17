using LM_Events.DataObjectBase;
using LM_Events.DataObjectBase.Conexao;
using LM_Events.DataObjectBase.Dados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LM_Events
{
    class ListasDAL
    {
        /// <summary>
        /// lista de dados obtidos do dbo.TipoCadastro pessoa fisica
        /// </summary>
        public static List<DBTipoCadastro> ObterTipoCadastro()
        {
            List<DBTipoCadastro> listaTipoCadastro = new List<DBTipoCadastro>();
            DataTable tableTipoCadastro = new DbUtils().Search(new SqlCommand("SELECT * FROM TipoCadastro"));

            foreach (DataRow rowTipoCadastro in tableTipoCadastro.Rows)
            {
                listaTipoCadastro.Add(new DBTipoCadastro { TipoCadastroId = Convert.ToInt32(rowTipoCadastro["TipoCadastroId"]), Descricao = rowTipoCadastro["Descricao"].ToString() });
            }
            return listaTipoCadastro;
        }
        /// <summary>
        /// lista de dados obtidos do dbo.EstadoCivil pessoa fisica
        /// </summary>
        public static List<DBEstadoCivil> ObterEstadoCivil()
        {
            List<DBEstadoCivil> listaEstadoCivil = new List<DBEstadoCivil>();
            DataTable tableEstadoCivil = new DbUtils().Search(new SqlCommand("SELECT *FROM EstadoCivil"));

            foreach (DataRow rowEstadoCivil in tableEstadoCivil.Rows)
            {

                listaEstadoCivil.Add(new DBEstadoCivil { EstadoCivilId = Convert.ToInt32(rowEstadoCivil["EstadoCivilId"]), Descricao = rowEstadoCivil["Descricao"].ToString() });
            }
            return listaEstadoCivil;

        }
        /// <summary>
        /// lista de dados obtidos do dbo.Cidade
        /// </summary>
        public static List<DBCidade> ObterCidade()
        {
            List<DBCidade> listaCidade = new List<DBCidade>();
            DataTable tableCidade = new DbUtils().Search(new SqlCommand("SELECT * FROM Cidade"));

            foreach (DataRow rowCidade in tableCidade.Rows)
            {

                listaCidade.Add(new DBCidade { CidadeId = Convert.ToInt32(rowCidade["CidadeId"]), Nome = rowCidade["Nome"].ToString() });
            }
            return listaCidade;

        }
        /// <summary>
        /// lista de dados obtidos do dbo.Estado
        /// </summary>
        public static List<DBEstado> ObterEstado()
        {
            List<DBEstado> listaEstado = new List<DBEstado>();
            DataTable tableEstado = new DbUtils().Search(new SqlCommand("SELECT * FROM Estado"));

            foreach (DataRow rowEstado in tableEstado.Rows)
            {

                listaEstado.Add(new DBEstado { EstadoId = Convert.ToInt32(rowEstado["EstadoId"]), Sigla = rowEstado["Sigla"].ToString() });
            }
            return listaEstado;

        }
        /// <summary>
        /// lista de dados obtidos do dbo.RamoAtividade pessoa juridica
        /// </summary>
        public static List<DBRamoAtividade> ObterRamoAtividade()
        {
            List<DBRamoAtividade> listaRamoAtividade = new List<DBRamoAtividade>();
            DataTable tableRamoAtividade = new DbUtils().Search(new SqlCommand("SELECT * FROM RamoAtividade"));

            foreach (DataRow rowRamoAtividade in tableRamoAtividade.Rows)
            {

                listaRamoAtividade.Add(new DBRamoAtividade { RamoAtividadeId = Convert.ToInt32(rowRamoAtividade["RamoAtividadeId"]), Atividade = rowRamoAtividade["Atividade"].ToString() });
            }
            return listaRamoAtividade;
        }
        /// <summary>
        /// lista de dados obtidos do dbo.TipoPagamento
        /// </summary>
        public static List<DBTipoPagamento> ObterTipoPagamento()
        {
            List<DBTipoPagamento> listaTipoPagamento = new List<DBTipoPagamento>();
            DataTable tableTipoPagamento = new DbUtils().Search(new SqlCommand("SELECT * FROM TipoPagamento"));

            foreach (DataRow rowTipoPagamento in tableTipoPagamento.Rows)
            {

                listaTipoPagamento.Add(new DBTipoPagamento { TipoPagamentoId = Convert.ToInt32(rowTipoPagamento["TipoPagamentoId"]), Descricao = rowTipoPagamento["Descricao"].ToString() });
            }
            return listaTipoPagamento;
        }
        /// <summary>
        /// lista de dados obtidos do dbo.Descontos
        /// </summary>
        public static List<DBDescontos> ObterDescontos()
        {
            ConnectionHelper con = new ConnectionHelper();
            List<DBDescontos> listaDescontos = new List<DBDescontos>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Descontos");

            con.AttachCommand(cmd);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DBDescontos desc = new DBDescontos();
                desc.DescontosId = Convert.ToInt32(dr["DescontosId"]);
                desc.Descricao = dr["Descricao"].ToString();
                desc.PcentDesconto = Convert.ToDecimal(dr["PcentDesconto"]);
                listaDescontos.Add(desc);
            }
            return listaDescontos;
        }
        /// <summary>
        /// lista de dados obtidos do dbo.Permissao de usuario
        /// </summary>
        public static List<DBPermissao> ObterPermissao()
        {
            List<DBPermissao> listaPermissao = new List<DBPermissao>();
            DataTable tablePermissao = new DbUtils().Search(new SqlCommand("SELECT * FROM Permissao"));

            foreach (DataRow rowPermissao in tablePermissao.Rows)
            {
                listaPermissao.Add(new DBPermissao { PermissaoId = Convert.ToInt32(rowPermissao["PermissaoId"]), Descricao = rowPermissao["Descricao"].ToString() });
            }
            return listaPermissao;
        }
        /// <summary>
        /// lista de dados obtidos do dbo.TipoEventos
        /// </summary>
        public static List<DBTipoEvento> ObterTipoEvento()
        {
            List<DBTipoEvento> listaTipoEvento = new List<DBTipoEvento>();
            DataTable tableTipoEvento = new DbUtils().Search(new SqlCommand("SELECT * FROM TipoEvento"));

            foreach (DataRow rowTipoEvento in tableTipoEvento.Rows)
            {
                listaTipoEvento.Add(new DBTipoEvento { TipoEventoId = Convert.ToInt32(rowTipoEvento["TipoEventoId"]), Descricao = rowTipoEvento["Descricao"].ToString() });
            }
            return listaTipoEvento;
        }
    }
}
