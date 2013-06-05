using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccessLayer;
using System.Configuration;

namespace Walmart.Util
{
    public static class ObterConexao
    {
        public static IConexao RetornarConexao()
        {
            string connString = ConfigurationManager.ConnectionStrings["Walmart"].ToString();
            IConexao conexao = new Conexao(connString);
            return conexao;
        }
    }


}