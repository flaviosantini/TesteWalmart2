using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Walmart.Repositorios;
using System.Data.SqlClient;
using DataAccessLayer;
using System.Data;
using Walmart.Entidades;

namespace Walmart.Repositorios
{
    public class RepositorioEstado : IRepository<Estado>
    {
        public RepositorioEstado() {}

        public bool Adiciona(Estado entity, IConexao conexao)
        {
            AdicionaParametros(entity, conexao);
            return conexao.ExecuteNonQuery("ESTADO_INSERE") == 1 ? true : false;
        }

        public bool Atualiza(Estado entity, IConexao conexao)
        {
            AdicionaParametros(entity, conexao);
            return conexao.ExecuteNonQuery("ESTADO_ATUALIZA") == 1 ? true : false;
        }

        public bool Deleta(int id, IConexao conexao)
        {
            conexao.AdicionaParametro("COD_ESTADO", id);
            return conexao.ExecuteNonQuery("ESTADO_DELETA") == 1 ? true : false;
        }

        public Estado Seleciona(int id, IConexao conexao)
        {
            conexao.AdicionaParametro("COD_ESTADO", id);
            SqlDataReader reader = conexao.ExecuteDataReader("ESTADO_SELECIONA");
            Estado entity = new Estado();
            if (reader.Read())
            {
                entity.CodEstado = Convert.ToInt32(reader["COD_ESTADO"].ToString());
                entity.Pais = reader["PAIS"].ToString();
                entity.Sigla = reader["SIGLA"].ToString();
                entity.Nome = reader["NOME"].ToString();
                entity.Regiao = reader["REGIAO"].ToString();
            }
            return entity;
        }

        public List<Estado> Lista(IConexao conexao)
        {
            SqlDataReader reader = conexao.ExecuteDataReader("ESTADO_LISTA");
            List<Estado> retorno = new List<Estado>();

            while (reader.Read())
            {
                Estado entidade = new Estado();
                entidade.CodEstado = Convert.ToInt32(reader["COD_ESTADO"].ToString());
                entidade.Nome = reader["NOME"].ToString();
                entidade.Pais = reader["PAIS"].ToString();
                entidade.Regiao = reader["REGIAO"].ToString();
                entidade.Sigla = reader["SIGLA"].ToString();
                retorno.Add(entidade);
            }
            return retorno;
        }

        private void AdicionaParametros(Estado entity, IConexao conexao)
        {
            conexao.AdicionaParametro("COD_ESTADO", entity.CodEstado);
            conexao.AdicionaParametro("PAIS", entity.Pais);
            conexao.AdicionaParametro("SIGLA", entity.Sigla);
            conexao.AdicionaParametro("NOME", entity.Nome);
            conexao.AdicionaParametro("REGIAO", entity.Regiao);
        }

    }
}