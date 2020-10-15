using System.Collections.Generic;
using ObjectDuplicatorApp.Model;

namespace ObjectDuplicatorApp.Service
{
    public static class UserMock
    {
        public static User GetUserFilled()
        {
            return new User
            {
                Id = Faker.NumberFaker.Number(),
                Name = Faker.NameFaker.Name(),
                LastName = Faker.NameFaker.LastName(),
                Address = new Address
                {
                    Id = Faker.NumberFaker.Number(),
                    City = Faker.LocationFaker.City(),
                    Street = Faker.LocationFaker.Street(),
                    Country = Faker.LocationFaker.Country(),
                    Number = Faker.NumberFaker.Number()
                },
                Phones = new List<Phone>
                {
                    new Phone
                    {
                        Id = Faker.NumberFaker.Number(),
                        Number = Faker.PhoneFaker.Phone()
                    },
                    new Phone
                    {
                        Id = Faker.NumberFaker.Number(),
                        Number = Faker.PhoneFaker.Phone()
                    }
                }
            };
        }
    }
}