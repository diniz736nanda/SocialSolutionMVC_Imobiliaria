using SocialSolutionMVC_Imobiliaria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialSolutionMVC_Imobiliaria.Repository
{
    public interface IClienteRepository
    {
        List<ClienteModel> BuscarTodos();
        ClienteModel Adicionar(ClienteModel cliente);
    }
}
