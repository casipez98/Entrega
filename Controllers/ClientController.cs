using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prod.Models;
namespace api27.controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase 
    {
         
            
        public ClientController( Proyecto Parametros){
            Context = Parametros;

        }
        private Proyecto Context;
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> Get()
        {
            return Context.Cliente.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Cliente> Get(int id)
        {
            return Context.Cliente.Find();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Cliente value)
        {
            Context.Cliente.Add(value);
            Context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Cliente value)
        {
            var post = Context.Cliente.Find(id);
            if (post != null ){
            post.Id= value.Id;
            post.Nombre= value.Nombre;
            post.Apellido= value.Apellido;
            post.Email= value.Email;
            post.UserName= value.UserName;
            Context.SaveChanges();
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
             var Client = Context.Cliente.Find(id);
             if (Client != null )
             {
                 Context.Cliente.Remove (Client);
                 Context.SaveChanges();
             }
            
        }
    }
}