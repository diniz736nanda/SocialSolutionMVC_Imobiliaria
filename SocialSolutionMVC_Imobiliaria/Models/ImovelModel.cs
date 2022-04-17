using SocialSolutionMVC_Imobiliaria.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialSolutionMVC_Imobiliaria.Models
{
    public class ImovelModel
    {
        public int Id { get; set; }
        public TipNegocio TipoNegocio { get; set; }
        public double VlrImovel { get; set; }
        public string Desc { get; set; }
        public StatusImovel StatusImovel { get; set; }
        public ClienteModel Cliente { get; set; }
    }
}

