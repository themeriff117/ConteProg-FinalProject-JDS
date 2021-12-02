using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_v1
{
    public class NameDatabase
    {
        private Guid _Name;
        [Key]
        public Guid Name 
        {
        get { return _Name; }
        }

        public string Bday { get; set; }

        public string CP{ get; set; }

        public int Year{ get; set; }
    }
}
