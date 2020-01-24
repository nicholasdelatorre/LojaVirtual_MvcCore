using LojaVirtual.Libraries.Session;
using LojaVirtual.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Login
{
    public class LoginSessaoCliente
    {
        private const string KEY = "Login.Cliente";
        private Sessao _sessao;
        public LoginSessaoCliente(Sessao sessao)
        {
            _sessao = sessao;
        }

        public void Login(Cliente cliente)
        {
            string clienteJson = JsonConvert.SerializeObject(cliente);
            _sessao.Cadastrar(KEY, clienteJson);
        }

        public Cliente ObterCliente()
        {
            if (_sessao.Existe(KEY))
            {
                string clienteJson = _sessao.Consultar(KEY);
                Cliente cliente = JsonConvert.DeserializeObject<Cliente>(clienteJson);
                return cliente;
            }
            else
            {
                return null;
            }

          
        }


        public void Logout()
        {
            _sessao.RemoverTodos();
        }
    }
}
