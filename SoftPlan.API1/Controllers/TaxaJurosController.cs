using Microsoft.AspNetCore.Mvc;
using SoftPlan.Interfaces;
using System.Threading.Tasks;

namespace SoftPlan.Controllers

{
    [Route("v1/taxajuros")]
    public class TaxaJurosController : ControllerBase
    {
        readonly ITaxaJurosService _taxaJurosService;

        public TaxaJurosController(ITaxaJurosService taxaJurosService)
        {
            _taxaJurosService = taxaJurosService;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<decimal>> Get()
        {
            try
            {
                return Ok(_taxaJurosService.ObterTaxaJuros());
            }
            catch
            {
                return BadRequest("Falha ao obter taxa de juros");
            }
        }

    }
}
