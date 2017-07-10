using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestowaMVC.Models
{
    [Table("Przedmiot")]
    public class Przedmiot
    {
        public int ID { get; set; }
        public bool DlaF2P { get; set; }

        public Kupno Kupno { get; set; }
        public Sprzedaz Sprzedaz { get; set; }
    }

    [Table("Kupno")]
    public class Kupno
    {
        public int KupnoID { get; set; }
        public int KupnoIlosc { get; set; }
        public int KupnoCena { get; set; }

        public int PrzedmiotID { get; set; }
        public Przedmiot Przedmiot { get; set; }
    }

    [Table("Sprzedaz")]
    public class Sprzedaz
    {
        public int SprzedazID { get; set; }
        public int SprzedazIlosc { get; set; }
        public int SprzedazCena { get; set; }

        public int PrzedmiotID { get; set; }
        public Przedmiot Przedmiot { get; set; }
    }
} // el el lololololo
