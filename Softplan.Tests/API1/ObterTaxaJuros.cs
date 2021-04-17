using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftPlan.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.Tests.TaxaJuros
{
    [TestClass]
    public class ObterTaxaJuros
    {
        [TestMethod]
        public void BuscarTaxaJuros()
        {
            decimal value = Convert.ToDecimal(new TaxaJurosService().ObterTaxaJuros());
            Assert.AreEqual(value , 0.01M);
        }
    }
}
