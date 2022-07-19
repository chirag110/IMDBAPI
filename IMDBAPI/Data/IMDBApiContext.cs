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
        public IMDBApiContext()
        {

        }
        public IMDBApiContext(DbContextOptions<IMDBApiContext>options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().
                HasOne(a => a.Actor).
                WithMany(am => am.Actor_Movies).
                HasForeignKey(ai => ai.ActorId);

            modelBuilder.Entity<Actor_Movie>().
               HasOne(m => m.Movie).
               WithMany(am => am.Actor_Movies).
               HasForeignKey(mi => mi.MovieId);

        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
    }
}
