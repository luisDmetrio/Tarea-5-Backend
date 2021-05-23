using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using loginBackend5.Backend;
using loginBackend5.Modelos;
using loginBackend5.DataAcces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apiUsuarioLog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        // GET: api/<UsuarioController>
        [HttpGet]
        public List<UsuarioLog> Get()
        {
            var usuarios = new UsuariosSC().GetUsuarios().ToList();
            return usuarios;
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public UsuarioLog Get(int id)
        {
            return new UsuariosSC().GetUsuarioByID(id);
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public void Post([FromBody] UsuarioLoginModel newUsuario)
        {
            new UsuariosSC().agregarUsuario(newUsuario);
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
