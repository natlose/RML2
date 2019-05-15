using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace RML_EF
{
    class Program
    {
        static void Main(string[] args)
        {
            int ArankaId;
            
            // Lépésenkénti végrehajtással!
            using (Entities entities = new Entities())
            {
                Person person = new Person { FirstName = "Aranka", LastName = "Soproni" };
                person.Addresses.Add(new Address { Kind = AddressKind.DEL, Country3166 = "HU", Zip = "8000", City = "Székesfehérvár", Line1 = "Budai út 6." });
                entities.Persons.Add(person);
                entities.SaveChanges();
                ArankaId = person.Id;
            }
            // Itt nézd meg az adatbázist!
            using (Entities entities = new Entities())
            {
                Person aranka = entities.Persons.Include(p => p.Addresses).Single(p => p.Id == ArankaId);
                aranka.Phone = "+363011223344";
                aranka.Addresses.Single(a => a.Kind == AddressKind.DEL).Kind = AddressKind.MAIL;
                entities.SaveChanges();
            }
            // Itt nézd meg az adatbázist!
            using (Entities entities = new Entities())
            {
                Person aranka = entities.Persons.Include(p => p.Addresses).Single(p => p.Id == ArankaId);
                entities.Addresses.RemoveRange(aranka.Addresses);
                entities.Persons.Remove(aranka);
                // Lehetne cascade-delete politikát is felparaméterezni: https://docs.microsoft.com/en-us/ef/core/saving/cascade-delete
                entities.SaveChanges();
            }
            // Itt nézd meg az adatbázist!
        }
    }
}
