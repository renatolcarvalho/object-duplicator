using AutoMapper;
using ObjectDuplicatorApp.Model;

namespace ObjectDuplicatorApp.Duplicators.AutoMapperApproach
{
    public static class AutoMapperDuplicator
    {
        public static User Duplicate(User user)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, User>()
                    .ForMember(x => x.Phones, opt => opt.Ignore());
            });

            var mapper = new Mapper(config);
            return mapper.Map<User>(user);
        }
    }
}
