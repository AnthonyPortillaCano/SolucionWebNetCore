using Microsoft.EntityFrameworkCore;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC
{
    public class BDInventarioContext:DbContext
    {
        public BDInventarioContext()
        {

        }
        public BDInventarioContext(DbContextOptions options)
         : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //En caso de que el contexto no este configurado, lo configuramos mediante la cadena de conexion
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("data source = .; initial catalog = BDInventarioProduct; user id = sa; password = 12345;");
            }
        }
        public virtual DbSet<Producto> Productos { get; set; }
    }
}
