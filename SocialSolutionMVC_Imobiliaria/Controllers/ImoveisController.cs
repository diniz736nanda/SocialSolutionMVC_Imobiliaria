using Microsoft.AspNetCore.Mvc;
using SocialSolutionMVC_Imobiliaria.Models;
using SocialSolutionMVC_Imobiliaria.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialSolutionMVC_Imobiliaria.Controllers
{
    public class ImoveisController : Controller
    {
        private readonly IImovelRepository _imovelRepository;
        public ImoveisController(IImovelRepository imovelRepository)
        {
            _imovelRepository = imovelRepository;
        }

        public IActionResult Index()
        {
            List<ImovelModel> imovel = _imovelRepository.BuscarTodos();
            return View(imovel);
        }
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(ImovelModel imovel)
        {
            _imovelRepository.Adicionar(imovel);
            return RedirectToAction("Index");
        }



        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult DeletarConfirmacao()
        {
            return View();
        }


    }
}
