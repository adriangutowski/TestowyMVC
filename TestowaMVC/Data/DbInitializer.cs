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

            // nie rob nic jesli w bazie sa juz dane
            if (context.Przedmiot.Any())
                return;

            //var przedmioty = new Przedmiot[]
          
        }
    }
}
