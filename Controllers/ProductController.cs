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
    public class ProductController : ControllerBase 
    {
         
            
        public ProductController( Proyecto Parametros){
            Context = Parametros;

        }
        private Proyecto Context;
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Producto>> Get()
        {
            return Context.Producto.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Producto> Get(int id)
        {
            return Context.Producto.Find();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Producto value)
        {
            Context.Producto.Add(value);
            Context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Producto value)
        {
            var post = Context.Producto.Find(id);
            post.ProductoId= value.ProductoId;
            post.Title= value.Title;
            post.Categoria= value.Categoria;
            post.Descripcion= value.Descripcion;
            post.Precio= value.Precio;
            Context.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
             var producto = Context.Producto.Find(id);
             if (producto != null )
             {
                 Context.Producto.Remove (producto);
                 Context.SaveChanges();
             }
            
        }
    }
}
