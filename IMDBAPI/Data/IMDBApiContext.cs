using IMDBAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IMDBAPI.Data
{
    public class IMDBApiContext : DbContext
    {
        public IMDBApiContext(DbContextOptions<IMDBApiContext>options):base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Producer> Producers { get; set; }
    }
}
