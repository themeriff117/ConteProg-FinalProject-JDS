using Final_v1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_v1.Data
{
    public class Finalcontext : DbContext
    {
        public Finalcontext(DbContextOptions<Finalcontext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<NameDatabase>().HasData
           (
                new NameDatabase { Name = "Samuel", Bday = "03/17/2000", CP = "Information Tech.", Year = 2021 },
                new NameDatabase { Name = "Dora", Bday = "07/03/1996", CP = "Information Tech.", Year = 2021 },
                new NameDatabase { Name = "Julia", Bday = "01/17/2000", CP = "Information Tech.", Year = 2021 }
            );
            
            builder.Entity<Vinyl>().HasData
            (
                  new Vinyl { Album = "Blue Banisters", Artist = "Lana Del Rey", Year = 2021 },
                  new Vinyl { Album = "The 1975", Artist = "The 1975", Year = 2013 },
                  new Vinyl { Album = "Fine Line", Artist = "Harry Styles", Year = 2019 }
            );
           
            builder.Entity<Anime>().HasData
            (
                  new Anime { }
            );
        }

        public DbSet<NameDatabase> Name { get; set; }
        public DbSet<Vinyl> VinylCollection { get; set; }
        public DbSet<Anime> Anime { get; set; } //just setting it up for Sam

        // public DbSet<> {get; set;} placeholder for Julia's table
    }
}
