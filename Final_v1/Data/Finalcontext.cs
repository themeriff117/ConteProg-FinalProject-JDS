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
                new NameDatabase { Name = "Samuel", Bday = 3 - 17 - 2000, CP = "Information Tech.", Year = 2021 },
                new NameDatabase { Name = "Dora", Bday = 6-03-1996, CP = "Information Tech.", Year = 2021 },
                new NameDatabase { Name = "Julia", Bday = 1-17-2000, CP = "Information Tech.", Year = 2021 }
            );
        }

        public DbSet <NameDatabase> Name { get; set; }
    }
}
