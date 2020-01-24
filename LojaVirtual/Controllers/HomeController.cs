using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaVirtual.DataBase;
using LojaVirtual.Libraries.Email;
using LojaVirtual.Libraries.Login;
using LojaVirtual.Models;
using LojaVirtual.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Controllers
{
    public class HomeController : Controller
    {

        private IClienteRepository _repCliente;
        private INewsletterRepository _repNewsletter;
        private LoginSessaoCliente _loginCliente;
        public HomeController(IClienteRepository repCliente, INewsletterRepository repNewsletter, LoginSessaoCliente loginCliente)
        {
            _repCliente = repCliente;
            _repNewsletter = repNewsletter;
            _loginCliente = loginCliente;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index([FromForm] NewsletterEmail newsletter)
        {
            if (ModelState.IsValid)
            {

                _repNewsletter.Cadastrar(newsletter);

                TempData["MSG_S"] = "E-mail cadastrado, agora você vai receber promoções especiais no seu e-mail. Fique atento as novidades";

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



        [HttpGet]
        public IActionResult Painel()
        {
            //var hasEmail = HttpContext.Session.GetString("Email");

            Cliente cliente = _loginCliente.ObterCliente();

            if (cliente != null)
                return new ContentResult
                {
                    Content = string.Format("Usuário {0}, logado! \r\n Nome: {1} \r\n Idade: {2} anos",
                    cliente.Id, cliente.Email, (DateTime.Now.Year - cliente.Nascimento.Year))
                };
            else
                return new ContentResult
                {
                    Content = "Acesso Negado!"
                };
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([FromForm] Cliente cliente)
        {

            Cliente clienteDB = _repCliente.Login(cliente.Email, cliente.Senha);

            if (clienteDB != null)
            {
                _loginCliente.Login(clienteDB);
                return new RedirectResult(Url.Action(nameof(Painel)));
            }
            else
            {
                ViewData["MSG_E"] = "E-mail e/ou senha inválidos.";
                return View();
            }
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
                _repCliente.Cadastrar(cliente);

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