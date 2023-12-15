using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Projeto.Context;
using Projeto.Models;

namespace Projeto.DAL
{
    public class ItemDAL
    {
        public EFContext Banco = new EFContext();
        public List<ItemTema> Listar()
        {
            return Banco.Itens.OrderBy(c => c.nome).ToList();
        }
        public ItemTema Achar(long id)
        {
            return Banco.Itens.Find(id);
        }
        public bool Gravar(ItemTema i)
        {
            try
            {
                Banco.Itens.Add(i);
                Banco.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Editar(ItemTema i)
        {
            try
            {
                Banco.Entry(i).State = EntityState.Modified;
                Banco.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Excluir(ItemTema i)
        {
            try
            {
                Banco.Itens.Remove(i);
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