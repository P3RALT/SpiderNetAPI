using Microsoft.AspNetCore.Mvc;
using SpiderNetApi.Models;

namespace SpiderNetApi.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Missoescontroller : ControllerBase
    {
        private static List<MissaoAranha> missaos = new List<MissaoAranha>();

        // GET
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(missaos);
        }

        // POST
        [HttpPost]
        public IActionResult Post([FromBody] MissaoAranha novaMissao)
        {
            // VALIDAR
        if (novaMissao.NivelPerigo < 1 || novaMissao.NivelPerigo > 10)
            {
                return BadRequest("Nivel de Perigo deve ser entre 1 a 10");
            }

            missaos.Add(novaMissao);
            return Created("", novaMissao);
        }
    }
}