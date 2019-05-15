using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace RML_EF
{
    class Program
    {
        static void Main(string[] args)
        {
            #region INSERT
            //using (Entities entites = new Entities())
            //{
            //    Person person = new Person { FirstName = "Jenő", LastName = "Nagylaki" };
            //    person.Addresses.Add(new Address { Kind = AddressKind.MAIL, Country3166 = "HU", Zip = "1043", City = "Budapest", Line1 = "Váci út 103." });
            //    entites.Persons.Add(person);

            //    entites.SaveChanges();
            //}
            #endregion

            #region SELECT
            using (Entities entities = new Entities())
            {
                // Ezekhez kell a using System.Linq
                Console.WriteLine("LINQ Expressions:");
                var result = from p in entities.Persons
                             where p.FirstName == "Ferenc"
                             select new { Telefon = p.Phone, Nev = p.LastName + " " + p.FirstName };
                // Lépésenkénti Debug módban a Locals ablakban ezen a ponton látszik, hány lépésből építette fel a fenti Expression objektumgráfot!
                foreach (var item in result.ToArray()) Console.WriteLine("{0,-60} {1,-30}", item.Nev, item.Telefon);

                // Ez ugyanaz, mint a fenti, csak nem LINQ Expressions, hanem LINQ Extensions technikával
                Console.WriteLine("\nLINQ Extensions:");
                foreach (var item in entities.Persons.Where(p => p.FirstName == "Ferenc").Select(p => new { Telefon = p.Phone, Nev = p.LastName + " " + p.FirstName }).ToArray())
                    Console.WriteLine("{0,-60} {1,-30}", item.Nev, item.Telefon);

                // Alapból nem tölti be a függő egyedeket, az Addresses üres marad!
                Console.WriteLine("\nLazy loading:");
                var result2 = from p in entities.Persons select p;
                foreach (var item in result2.ToArray()) Console.WriteLine("{0,-30} {1,-30} {2,2}", item.FirstName, item.LastName, item.Addresses.Count);

                Console.WriteLine("\nEager loading:");
                // Lehet kérni a függő egyedek betöltését
                var result3 = from p in entities.Persons.Include(p => p.Addresses) select p;
                foreach (var item in result3.ToArray()) Console.WriteLine("{0,-30} {1,-30} {2,2} {3,-20}", item.FirstName, item.LastName, item.Addresses.Count, item.Addresses.FirstOrDefault()?.City);
            }
            #endregion


        }
    }
}
