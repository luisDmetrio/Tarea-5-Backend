using loginBackend5.Backend;
using loginBackend5.Modelos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apiUsuarioLog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccesoController : ControllerBase
    {
        // GET: api/<AccesoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AccesoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AccesoController>
        [HttpPost]
        public IActionResult Post([FromBody] autenticarUsuario autenticarUser)
        {
            
            
            if(new UsuariosSC().autenticacion(autenticarUser) == true)
            {
                return Ok("datos correctos");
            }
            else
            {
                return Ok("datos incorrectos");
            }
            
                
        }

        private IActionResult OkResult()
        {
            throw new NotImplementedException();
        }

        // PUT api/<AccesoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AccesoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
