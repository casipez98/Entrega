using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Prod.Models
{
    public class Proyecto : DbContext
    {
        public Proyecto(DbContextOptions<Proyecto> options)
            : base(options)
        { }

        public DbSet<Categoria> Categoria{ get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Cliente> Cliente {get; set;}
    }
    

 
 public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nombre { get; set; }
       
    }
    public class Producto
    {
        public int ProductoId { get; set; }
        public string Title { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
    }
    public class Cliente
    {
        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public string UserName {get; set;}
        public string Email {get; set;}
    }
}
 
       

    
