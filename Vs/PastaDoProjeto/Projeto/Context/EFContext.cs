using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Projeto.Models;
namespace Projeto.Context
{
    public class EFContext : DbContext
    {
        public EFContext() : base("Asp_Net_MVC_CS")
        {

        }
        public DbSet<ItemTema> Itens { get; set; }
    }
}