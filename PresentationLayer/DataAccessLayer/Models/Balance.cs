using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Balance
    {
        public int ID { get; set; }
        public string VrstaRobe { get; set; }
        public string JedinicaMere { get; set; }
        public decimal Kolicina { get; set; }
    }
}