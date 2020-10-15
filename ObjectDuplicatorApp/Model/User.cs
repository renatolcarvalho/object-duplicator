using System;
using System.Collections.Generic;

namespace ObjectDuplicatorApp.Model
{
    public class User : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public List<Phone> Phones { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }

    public class Address : ICloneable
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public object Clone()
        {
            return MemberwiseClone();
        }
    }

    public class Phone : ICloneable
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}