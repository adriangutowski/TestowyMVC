using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestowaMVC.Models;

namespace TestowaMVC.Data
{
    public class DbInitializer
    {
        public static void Initialize(TestowyContext context)
        {
            context.Database.EnsureCreated();

            // nie robi nic jesli baza jest juz zapelniona
            //if (context.Przedmiot.Any())
            //    return;


            var przedmioty = new Przedmiot[]
            {
                new Przedmiot{ID=1, DlaF2P=true},
                new Przedmiot{ID=2, DlaF2P=true}
            };

            foreach (var p in przedmioty)
            {
                context.Przedmiot.Add(p);
            }

            context.SaveChanges();
        }
    }
}
