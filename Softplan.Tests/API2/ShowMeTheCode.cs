using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftPlan.API2.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Softplan.Tests.API2
{
    [TestClass]
    public class ShowMeTheCode
    {
        [TestMethod]
        public void ObterStringGitHub()
        {
            string URL = new ShowMeTheCodeService().ObterUrlGit();
            Assert.IsNotNull(URL);
        }

        [TestMethod]
        public void valida_retorno_url()
        {
            string URL = new ShowMeTheCodeService().ObterUrlGit();
            bool result = Uri.IsWellFormedUriString(URL, UriKind.Absolute);
            Assert.IsTrue(result);
        }
    }
}


