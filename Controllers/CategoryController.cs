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
    public class CategoryController : ControllerBase 
    {
         
            
        public CategoryController( Proyecto Parametros){
            Context = Parametros;

        }
        private Proyecto Context;
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Categoria>> Get()
        {
            return Context.Categoria.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Categoria> Get(int id)
        {
            return Context.Categoria.Find();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Categoria value)
        {
            Context.Categoria.Add(value);
            Context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Categoria value)
        {
            var post = Context.Categoria.Find(id);
            post.Nombre= value.Nombre;
            post.CategoriaId= value.CategoriaId;
           
            Context.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
             var Category = Context.Categoria.Find(id);
             if (Category != null )
             {
                 Context.Categoria.Remove (Category);
                 Context.SaveChanges();
             }
            
        }
    }
}