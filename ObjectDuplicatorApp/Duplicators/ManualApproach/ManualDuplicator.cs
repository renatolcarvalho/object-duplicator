using System.Linq;
using ObjectDuplicatorApp.Model;

namespace ObjectDuplicatorApp.Duplicators.ManualApproach
{
    public static class ManualDuplicator
    {
        public static User Duplicate(User user)
        {
            return new User
            {
                Id = Faker.NumberFaker.Number(),
                Name = user.Name,
                LastName = user.LastName,
                Address = user.Address != null
                    ? new Address
                    {
                        Id = Faker.NumberFaker.Number(),
                        City = user.Address.City,
                        Country = user.Address.Country,
                        Number = user.Address.Number,
                        Street = user.Address.Street
                    }
                    : null,
                Phones = user.Phones?.Select(x => new Phone
                {
                    Id = Faker.NumberFaker.Number(),
                    Number = x.Number
                }).ToList()
            };
        }
    }
}
