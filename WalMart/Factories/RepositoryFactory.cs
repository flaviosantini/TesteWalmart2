using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Walmart.Repositorios;
using Walmart.Entidades;
using System.Reflection;
using Walmart.Util;

namespace Walmart.Factories
{
    public class RepositoryFactory : IRepositoryFactory
    {

        public IRepository<T> FabricarRepositorio<T>() where T : class
        {
            var mType = typeof(IRepository<T>);

            var instances = from t in Assembly.GetExecutingAssembly().GetTypes()
                            where t.GetInterfaces().Contains(mType)
                                     && t.GetConstructor(Type.EmptyTypes) != null
                            select Activator.CreateInstance(t) as IRepository<T>;


            return instances.ElementAt(0);

        }
    }
}