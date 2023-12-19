using Projeto.Context;
using Projeto.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Projeto.DAL
{
    public class AluguelDAL
    {
        public EFContext Banco = new EFContext();
        public List<Aluguel> Listar()
        {
            return Banco.Alugueis.OrderBy(c => c.AluguelId).ToList();
        }
        public Aluguel Achar(long id)
        {
            return Banco.Alugueis.Find(id);
        }
        public bool Gravar(Aluguel a)
        {
            try
            {
                Banco.Alugueis.Add(a);
                Banco.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Editar(Aluguel a)
        {
            try
            {
                Banco.Entry(a).State = EntityState.Modified;
                Banco.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Excluir(Aluguel a)
        {
            try
            {
                Banco.Alugueis.Remove(a);
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