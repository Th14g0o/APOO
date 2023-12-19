using Projeto.DAL;
using Projeto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.Servico
{
    public class TemaServico
    {
        public TemaDAL Dal = new TemaDAL();
        public List<Tema> Listar()
        {
            return Dal.Listar();
        }
        public Tema AcharPorId(long id)
        {
            return Dal.Achar(id);
        }
        public bool Gravar(Tema t)
        {
            return Dal.Gravar(t);
        }
        public bool Editar(Tema t)
        {
            return Dal.Editar(t);
        }
        public bool Excluir(Tema t)
        {
            return Dal.Excluir(t);
        }
    }
}