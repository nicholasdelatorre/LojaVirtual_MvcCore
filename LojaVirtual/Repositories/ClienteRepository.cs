using LojaVirtual.DataBase;
using LojaVirtual.Models;
using LojaVirtual.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Repositories
{
    public class ClienteRepository : IClienteRepository
    {

        private LojaVirtualContext _banco;
        public ClienteRepository(LojaVirtualContext banco)
        {
            _banco = banco;
        }

        public void Atualizar(Cliente cliente)
        {
            _banco.Update(cliente);
            _banco.SaveChanges();
        }

        public void Cadastrar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            Cliente cliente = ObterCliente(id);
            _banco.Remove(cliente);
            _banco.SaveChanges();
        }

        public Cliente Login(string email, string senha)
        {
            Cliente cliente  = _banco.Clientes.Where(c => c.Email.Equals(email) && c.Senha.Equals(senha)).FirstOrDefault();
            return cliente;
        }

        public Cliente ObterCliente(int id)
        {
            return _banco.Clientes.Find(id);
        }

        public List<Cliente> ObterTodosClientes()
        {
            List<Cliente> clientes = _banco.Clientes.ToList();
            return clientes;
        }
    }
}
