using System;
using System.Collections.Generic;
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
    }
}