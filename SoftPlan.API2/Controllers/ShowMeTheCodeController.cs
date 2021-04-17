using Microsoft.AspNetCore.Mvc;
using SoftPlan.API2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftPlan.API2.Controllers
{
    [Route("v1/showmethecode")]
    public class ShowMeTheCodeController : ControllerBase
    {
        readonly IShowMeTheCodeService _showMeTheCodeService;

        public ShowMeTheCodeController(IShowMeTheCodeService showMeTheCodeService)
        {
            _showMeTheCodeService = showMeTheCodeService;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<string>> Get()
        {

            try
            {
                return Ok(_showMeTheCodeService.ObterUrlGit());
            }
            catch (Exception ex)
            {
                return BadRequest("Falha ao obter url do código fonte");
            }

        }
    }

}
