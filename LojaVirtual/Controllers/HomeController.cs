using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaVirtual.DataBase;
using LojaVirtual.Libraries.Email;
using LojaVirtual.Models;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Controllers
{
    public class HomeController : Controller
    {

        private LojaVirtualContext _ctx;
        public HomeController(LojaVirtualContext ctx)
        {
            _ctx = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index([FromForm] NewsletterEmail newsletter)
        {
            if (ModelState.IsValid )
            {
                _ctx.NewsletterEmails.Add(newsletter);
                _ctx.SaveChanges();

                ViewData["MSG_S"] = "E-mail cadastrado, agora você vai receber promoções especiais no seu e-mail. Fique atento as novidades";

                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();

            }

        }

        public IActionResult Contato()
        {
            return View();
        }
      

        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CadastroCliente()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroCliente([FromForm] Cliente cliente)
        {

            if (ModelState.IsValid)
            {
                _ctx.Add(cliente);
                _ctx.SaveChanges();


                TempData["MSG_S"] = "Cadastro realizado com sucesso!";

                // TODO: Implementar redirecionamentos diferentes (Painel, Carrinho de Compras, etc)

                return RedirectToAction(nameof(CadastroCliente));
            }
            return View();

        }

        public IActionResult CarrinhoCompras()
        {
            return View();
        }
    }
}