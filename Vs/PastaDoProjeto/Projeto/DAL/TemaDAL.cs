using Projeto.Context;
using Projeto.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Projeto.DAL
{
    public class TemaDAL
    {
        public EFContext Banco = new EFContext();
        public List<Tema> Listar()
        {
            return Banco.Temas.OrderBy(c => c.TemaId).ToList();
        }
        public Tema Achar(long id)
        {
            return Banco.Temas.Find(id);
        }
        public bool Gravar(Tema t)
        {
            try
            {
                Banco.Temas.Add(t);
                Banco.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Editar(Tema t)
        {
            try
            {
                Banco.Entry(t).State = EntityState.Modified;
                Banco.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Excluir(Tema t)
        {
            try
            {
                Banco.Temas.Remove(t);
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