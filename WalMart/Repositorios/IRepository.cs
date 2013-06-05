using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace Walmart.Repositorios
{
    public interface IRepository<T> where T : class
    {
        bool Adiciona(T entity, IConexao conexao);
        bool Atualiza(T entity, IConexao conexao);
        bool Deleta(int id, IConexao conexao);
        T Seleciona(int id, IConexao conexao);
        List<T> Lista(IConexao conexao);
    }
}
