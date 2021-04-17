using Microsoft.AspNetCore.Mvc;
using SoftPlan.API2.Interfaces;
using SoftPlan.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoftPlan.Controllers

{
    [Route("v1/calculajuros")]
    public class CalculaJurosController : ControllerBase
    {
        readonly ICalculoJurosService _calculoJurosService;
        readonly IObterTaxaJurosService _obterTaxaJurosService;

        public CalculaJurosController(ICalculoJurosService calculoJurosService, IObterTaxaJurosService obterTaxaJurosService)
        {
            _calculoJurosService = calculoJurosService;
            _obterTaxaJurosService = obterTaxaJurosService;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<decimal>> Get(decimal valorinicial, int meses)
        {

            decimal taxaJuros = 0;

            try
            {
                taxaJuros = _obterTaxaJurosService.ObterTaxaJuros();
            }
            catch (Exception ex)
            {
                return BadRequest("Falha ao obter taxa de juros");
            }

            try
            {
                return Ok(_calculoJurosService.CalcularJuros(valorinicial, meses, taxaJuros));
            }
            catch(Exception ex)
            {
                return BadRequest("Falha ao calcular Juros");
            }
        }

    }
}
