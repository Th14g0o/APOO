using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projeto.DAL;
using Projeto.Models;

namespace Projeto.Servico
{
    public class ItemServico
    {
        public ItemDAL Dal = new ItemDAL();
        public List<ItemTema> Listar()
        {
            return Dal.Listar();
        }
        public bool Gravar(ItemTema i)
        {
            return Dal.Gravar(i);
        }
    }
}