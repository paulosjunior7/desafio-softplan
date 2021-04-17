using SoftPlan.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftPlan.Services
{
    public class TaxaJurosService : ITaxaJurosService
    {
        const decimal TAXA_JUROS = 0.01M;
        public decimal ObterTaxaJuros()
        {
            decimal valor = TAXA_JUROS;

            return valor;
        }
    }
}
