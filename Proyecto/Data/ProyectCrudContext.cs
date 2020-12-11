using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proyecto.Models;

namespace Proyecto.Data
{
    public class ProyectCrudContext : DbContext
    {
        public ProyectCrudContext (DbContextOptions<ProyectCrudContext> options)
            : base(options)
        {
        }

        public DbSet<Proyecto.Models.Movie> Movie { get; set; }
    }
}
