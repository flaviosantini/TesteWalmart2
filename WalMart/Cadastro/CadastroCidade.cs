using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Walmart.Entidades;
using Walmart.Repositorios;
using Walmart.Factories;

namespace Walmart.Cadastro
{
    public class CadastroCidade : ICadastro<Cidade>
    {
        private readonly IRepository<Cidade> repositorio;

        public CadastroCidade()
        {
            IRepositoryFactory fabrica = new RepositoryFactory();
            IRepository<Cidade> repo = fabrica.FabricarRepositorio<Cidade>();
            this.repositorio = repo;
        }

        public bool Adiciona(Cidade entity)
        {
            return repositorio.Adiciona(entity, Util.ObterConexao.RetornarConexao());
        }

        public bool Atualiza(Cidade entity)
        {
            return repositorio.Atualiza(entity, Util.ObterConexao.RetornarConexao());
        }

        public bool Deleta(int id)
        {
            return repositorio.Deleta(id, Util.ObterConexao.RetornarConexao());
        }

        public Cidade Seleciona(int id)
        {
            return repositorio.Seleciona(id, Util.ObterConexao.RetornarConexao());
        }

        public List<Cidade> Lista()
        {
            return repositorio.Lista(Util.ObterConexao.RetornarConexao());
        }
    }
}