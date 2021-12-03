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
            _ = builder.Entity<NameDatabase>().HasData
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
                  new Anime { Id = 1, MainChara = "Rimuru Tempest", Name = "Recarnated as a slime", Genre = "Isekai", Description = "Man gets stabed and recarnates as a slime" },
                  new Anime { Id = 2, MainChara = "Izuku Midoryia", Name = "My Hero Acadamia", Genre = "Fansty", Description = "A world where everyone has a power called a qurik" },
                  new Anime { Id = 3, MainChara = "Naruto Urzmaki", Name = "Naruto", Genre = "Fantsy", Description = "A world of ninja's" },
                  new Anime { Id = 4 , MainChara = "Ash Ketchum", Name = "Pokemon", Genre = "Fantsy", Description = "Got to catch them all pokemon" }
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
