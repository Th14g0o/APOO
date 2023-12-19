using Projeto.Context;
using Projeto.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Projeto.DAL
{
    public class ClienteDAL
    {
        public EFContext Banco = new EFContext();
        public List<Cliente> Listar()
        {
            return Banco.Clientes.OrderBy(c => c.ClienteId).ToList();
        }
        public Cliente Achar(long id)
        {
            return Banco.Clientes.Find(id);
        }
        public bool Gravar(Cliente c)
        {
            try
            {
                Banco.Clientes.Add(c);
                Banco.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Editar(Cliente c)
        {
            try
            {
                Banco.Entry(c).State = EntityState.Modified;
                Banco.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Excluir(Cliente c)
        {
            try
            {
                Banco.Clientes.Remove(c);
                Banco.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}