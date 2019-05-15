using System;

namespace RML_EF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Entities entites = new Entities())
            {
                Person person = new Person { FirstName = "Jenő", LastName = "Nagylaki" };
                person.Addresses.Add(new Address { Kind = AddressKind.MAIL, Country3166 = "HU", Zip = "1043", City = "Budapest", Line1 = "Váci út 103." });
                entites.Persons.Add(person);

                entites.SaveChanges();
            }
        }
    }
}
