using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Transaction
    {
        public int ID { get; set; }
        public string VrstaRobe { get; set; }
        public decimal Kolicina { get; set; }
        public string OvlascenoLice { get; set; }
        public string KupacProizvodjac { get; set; }
        public DateTime Datum { get; set; }
        public string Vrsta { get; set; }
    }
}