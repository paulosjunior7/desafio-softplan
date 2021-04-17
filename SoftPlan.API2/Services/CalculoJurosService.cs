using SoftPlan.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftPlan.Services
{
    public class CalculoJurosService : ICalculoJurosService
    {
        public decimal CalcularJuros(decimal valorInicial, int meses, decimal taxaJuros)
        {
            if(taxaJuros > 0 )
            {
                return Math.Round(valorInicial * Convert.ToDecimal(Math.Pow(1 + Convert.ToDouble(taxaJuros), meses)),2);
            } else
            {
                return 0;
            }
        }
    }
}
