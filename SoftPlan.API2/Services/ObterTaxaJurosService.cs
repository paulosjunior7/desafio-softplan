using SoftPlan.API2.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SoftPlan.API2.Services
{
    public class ObterTaxaJurosService : IObterTaxaJurosService
    {
        decimal IObterTaxaJurosService.ObterTaxaJuros()
        {
            string URL = Environment.GetEnvironmentVariable("URL_API1");

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                CultureInfo culture = new CultureInfo("en-US");
                decimal result = Convert.ToDecimal(reader.ReadToEnd(), culture);
                return result;
            }
        }
    }
}
