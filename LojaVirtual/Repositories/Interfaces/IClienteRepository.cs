﻿using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Repositories.Interfaces
{
    interface IClienteRepository
    {
        Cliente Login(string email, string senha);
        void Cadastrar(Cliente cliente);
        void Atualizar(Cliente cliente);
        void Excluir(int id);
        Cliente ObterCliente(int id);
        List<Cliente> ObterTodosClientes();
    }
}
