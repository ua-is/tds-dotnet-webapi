using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCovid.Entities;

namespace WebApiCovid.Contexts
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
        }
        // Defino la relacion entre tabla y entity
        public DbSet<Medico> Medicos { get; set; }
    }
}
