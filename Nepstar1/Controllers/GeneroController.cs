using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entidades;
using Microsoft.AspNetCore.Mvc;
using Repositorios.services;

namespace Nepstar1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneroController : ControllerBase
    {
        private readonly IGenero generoRepo;
        public GeneroController(IGenero generoRepositorio)
        {
            generoRepo = generoRepositorio;
        }
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> GetGeneros()
        {
            var gener =await generoRepo.GetGenerosAsyc();
            return Ok(gener);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Genero genero)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);

            }
            await generoRepo.Create(genero);
           
            return Ok();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
