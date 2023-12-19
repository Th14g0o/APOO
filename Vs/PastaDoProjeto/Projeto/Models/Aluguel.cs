using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.Models
{
    public class Aluguel
    {
        public long AluguelId { get; set; }
        public double Valor { get; set; }
        public DateTime DataFesta { get; set; }
        public TimeSpan HorarioInicio { get; set; }
        public TimeSpan HorarioTermino { get; set; }

        public double ValorFinal(double v, DateTime d, int? descontoCliente)
        {
            int desconto = 0;
            if (descontoCliente != null)
                desconto = (int)descontoCliente;
            switch (d.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    desconto += 40; break;
                case DayOfWeek.Tuesday:
                    desconto += 40; break;
                case DayOfWeek.Wednesday:
                    desconto += 40; break;
                case DayOfWeek.Thursday:
                    desconto += 40; break;
                default:
                    break;
            }
            if (desconto != 0)
                v = v - (v * (desconto / 100.00));

            return v;
        }
    }
}