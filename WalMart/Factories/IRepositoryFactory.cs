using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Walmart.Repositorios;

namespace Walmart.Factories
{
    public interface IRepositoryFactory
    {
        IRepository<T> FabricarRepositorio<T>() where T : class;
    }
}