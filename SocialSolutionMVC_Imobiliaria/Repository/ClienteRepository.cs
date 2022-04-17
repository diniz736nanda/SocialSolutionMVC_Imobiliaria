using SocialSolutionMVC_Imobiliaria.Data;
using SocialSolutionMVC_Imobiliaria.Models;
using System.Collections.Generic;
using System.Linq;

namespace SocialSolutionMVC_Imobiliaria.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly BancoContext _bancoContext;
        public ClienteRepository(BancoContext bancocontext)
        {
            _bancoContext = bancocontext;
        }
        public ClienteModel Adicionar(ClienteModel cliente)
        {
            _bancoContext.Clientes.Add(cliente);                 //gravar no banco de dados
            _bancoContext.SaveChanges();
            return cliente;   
        }

        public List<ClienteModel> BuscarTodos()
        {
            return _bancoContext.Clientes.ToList();
        }
    }
}
