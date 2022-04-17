using SocialSolutionMVC_Imobiliaria.Data;
using SocialSolutionMVC_Imobiliaria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialSolutionMVC_Imobiliaria.Repository
{
    public class ImovelRepository : IImovelRepository
    {
        private readonly BancoContext _bancoContext;
        public ImovelRepository(BancoContext bancocontext)
        {
            _bancoContext = bancocontext;
        }
        public ImovelModel Adicionar(ImovelModel imovel)
        {
            _bancoContext.Imoveis.Add(imovel);                 //gravar no banco de dados
            _bancoContext.SaveChanges();
            return imovel;
        }

        public List<ImovelModel> BuscarTodos()
        {
            return _bancoContext.Imoveis.ToList();
        }

    }
}
