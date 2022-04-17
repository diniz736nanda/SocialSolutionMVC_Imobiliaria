using SocialSolutionMVC_Imobiliaria.Models;
using System.Collections.Generic;

namespace SocialSolutionMVC_Imobiliaria.Repository
{
    public interface IImovelRepository
    {
        List<ImovelModel> BuscarTodos();
        ImovelModel Adicionar(ImovelModel cliente);
    }
}
