using SoftPlan.API2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftPlan.API2.Services
{
    public class ShowMeTheCodeService : IShowMeTheCodeService
    {
        public string ObterUrlGit()
        {
            string URL = Environment.GetEnvironmentVariable("URL_GITHUB");
            if (URL == null)
            {
                URL = @"https://github.com/paulosjunior7/desafio-softplan";
            }
            return URL;
        }
    }
}
