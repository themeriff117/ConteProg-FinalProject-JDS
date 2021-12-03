using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_v1
{
    public class NameDatabase
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Bday { get; set; }

        public string CP{ get; set; }

        public int Year{ get; set; }
    }
}
