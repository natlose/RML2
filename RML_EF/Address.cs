using System;
using System.Collections.Generic;
using System.Text;

namespace RML_EF
{
    public enum AddressKind { RES, MAIL, DEL }

    public class Address
    {
        public int Id { get; set; }
        public AddressKind Kind { get; set; }
        public string Country3166 { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }

        public int FI_Person { get; set; }
        public Person Person { get; set; }
    }
}
