using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula01Exercicio01.DAO;
using Aula01Exercicio01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aula01Exercicio01.Controllers
{
    //Meice Silva de Jesus
    public class PedidoController : Controller
    {
        private readonly PedidoDAO _pedidoDAO;
        public PedidoController(PedidoDAO pedidoDAO)
        {
            _pedidoDAO = pedidoDAO;
        }

        public IActionResult Index()
        {
            ViewBag.Data = DateTime.Now;
            return View(_pedidoDAO.Listar());
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(Pedido pedido)
        {
            _pedidoDAO.Cadastrar(pedido);
            return RedirectToAction("Index");
        }
    }
}