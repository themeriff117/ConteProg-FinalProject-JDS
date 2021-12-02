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
                new NameDatabase { Id = 1, Name = "Samuel", Bday = "03/17/2000", CP = "Information Tech.", Year = 2021 },
                new NameDatabase { Id = 2, Name = "Dora", Bday = "07/03/1996", CP = "Information Tech.", Year = 2021 },
                new NameDatabase { Id = 3, Name = "Julia", Bday = "01/17/2000", CP = "Information Tech.", Year = 2021 }
            );
            
            builder.Entity<Vinyl>().HasData
            (
                  new Vinyl { Id = 1, Album = "Blue Banisters", Artist = "Lana Del Rey", Year = 2021 },
                  new Vinyl { Id = 2, Album = "The 1975", Artist = "The 1975", Year = 2013 },
                  new Vinyl { Id = 3, Album = "Fine Line", Artist = "Harry Styles", Year = 2019 }
            );
           
            builder.Entity<Anime>().HasData
            (
                  new Anime { }
            );
        
        builder.Entity<DnD>().HasData
           (
                  new DnD { }
            );
        }

        public DbSet<NameDatabase> Name { get; set; }
        public DbSet<Vinyl> VinylCollection { get; set; }
        public DbSet<Anime> Anime { get; set; } 
        public DbSet<DnD>DnD {get; set;} 
    }
}
