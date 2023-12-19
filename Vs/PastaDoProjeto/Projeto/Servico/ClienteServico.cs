using Projeto.DAL;
using Projeto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.Servico
{
    public class ClienteServico
    {
        public ClienteDAL Dal = new ClienteDAL();
        public List<Cliente> Listar()
        {
            return Dal.Listar();
        }
        public Cliente AcharPorId(long c)
        {
            return Dal.Achar(c);
        }
        public bool Gravar(Cliente c)
        {
            return Dal.Gravar(c);
        }
        public bool Editar(Cliente c)
        {
            return Dal.Editar(c);
        }
        public bool Excluir(Cliente c)
        {
            return Dal.Excluir(c);
        }
    }
}