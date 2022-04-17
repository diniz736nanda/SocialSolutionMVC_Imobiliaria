using Microsoft.AspNetCore.Mvc;
using SocialSolutionMVC_Imobiliaria.Models;
using SocialSolutionMVC_Imobiliaria.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialSolutionMVC_Imobiliaria.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClienteRepository _clienteRepository;
        public ClientesController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public IActionResult Index()
        {
            List<ClienteModel> clientes = _clienteRepository.BuscarTodos();
            return View(clientes);
        }

        public IActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(ClienteModel cliente)
        {
            _clienteRepository.Adicionar(cliente);
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
