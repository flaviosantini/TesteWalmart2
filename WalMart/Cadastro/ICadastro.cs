using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Walmart.Repositorios;
using Walmart.Factories;

namespace Walmart.Cadastro
{
    public interface ICadastro<T> where T : class
    {
        bool Adiciona(T entity);
        bool Atualiza(T entity);
        bool Deleta(int id);
        T Seleciona(int id);
        List<T> Lista();
    }
}