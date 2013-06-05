using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Walmart.Entidades;
using Walmart.Repositorios;
using Walmart.Factories;
using System.Reflection;
using Walmart;
using System.Diagnostics;

namespace Walmart.Cadastro
{
    public class CadastroEstado : ICadastro<Estado>
    {
        private readonly IRepository<Estado> repositorio;

        public CadastroEstado()
        {
            IRepositoryFactory fabrica = new RepositoryFactory();
            IRepository<Estado> repo = fabrica.FabricarRepositorio<Estado>();
            this.repositorio = repo;
        }

        public bool Adiciona(Estado entity)
        {
            return repositorio.Adiciona(entity, Util.ObterConexao.RetornarConexao());
        }

        public bool Atualiza(Estado entity)
        {
            return repositorio.Atualiza(entity, Util.ObterConexao.RetornarConexao());
        }

        public bool Deleta(int id)
        {
            return repositorio.Deleta(id, Util.ObterConexao.RetornarConexao());
        }

        public Estado Seleciona(int id)
        {
            return repositorio.Seleciona(id, Util.ObterConexao.RetornarConexao());
        }

        public List<Estado> Lista()
        {
            return repositorio.Lista(Util.ObterConexao.RetornarConexao());
        }
    }
}