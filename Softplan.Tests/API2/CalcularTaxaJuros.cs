using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftPlan.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.Tests.CalcularTaxaJuros
{
    [TestClass]
    public class CalcularTaxaJuros
    {
        [TestMethod]
        public void CalcularTaxa_retorno()
        {
            const decimal VALORTAXA = 0.01M;
            double value = Convert.ToDouble(new CalculoJurosService().CalcularJuros(100, 5, VALORTAXA));
            Assert.AreEqual(value, Convert.ToDouble(105.10));
        }

        [TestMethod]
        public void CalcularTaxa_Sem_Passar_ValorTaxa_zerada_retorna_zero()
        {
            double value = Convert.ToDouble(new CalculoJurosService().CalcularJuros(100, 5 , 0));
            Assert.AreEqual(value, 0);
        }
    }
}
