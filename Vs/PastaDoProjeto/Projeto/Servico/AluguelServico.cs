using Projeto.DAL;
using Projeto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace Projeto.Servico
{
    public class AluguelServico
    {
        public AluguelDAL Dal = new AluguelDAL();
        public ClienteServico ServicoCliente = new ClienteServico();

        public List<Aluguel> Listar()
        {
            return Dal.Listar();
        }
        public Aluguel AcharPorId(long id)
        {
            return Dal.Achar(id);
        }
        public bool Gravar(Aluguel aluguel, DateTime d, long ClienteId)
        {
            
            int? descontoC = null;
            //Cliente c = ServicoCliente.AcharPorId(ClienteId);
            //foreach (Aluguel a in Listar())
            //{
            //    if (c.ClienteId == a.ClienteId)
            //    {
            //        descontoC = 10;
            //        break;
            //    }
            //}
            //Pensamentos quando for associar, acho qeu vai ser algo assim
            aluguel.Valor = aluguel.ValorFinal(aluguel.Valor, d, descontoC);
            return Dal.Gravar(aluguel);
        }
        public bool Editar(Aluguel a)
        {
            return Dal.Editar(a);
        }
        public bool Excluir(Aluguel a)
        {
            return Dal.Excluir(a);
        }
    }
}