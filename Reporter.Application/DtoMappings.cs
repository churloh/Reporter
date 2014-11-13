using AutoMapper;
using Reporter.Users;
using Reporter.Users.Dtos;

namespace Reporter
{
    internal static class DtoMappings
    {
        public static void Map()
        {
            // This code configures AutoMapper to auto map between Entities and DTOs.

            // I specified mapping for AssignedPersonId since NHibernate does not fill SitRep.ReporterId
            // If you will just use EF, then you can remove ForMember definition.
            Mapper.CreateMap<User, UserDto>();
        }
    }
}
