using AspNetCore.Swagger.Versioning.Contracts.v2.Account;
using AspNetCore.Swagger.Versioning.Models;
using AutoMapper;
using System;

namespace AspNetCore.Swagger.Versioning.Mapping.v2.Profiles
{
    public class AccountMappingProfile : Profile
    {
        public AccountMappingProfile()
        {
            CreateMap<AccountContract, Account>()
                .ForMember(x => x.Id, o => o.Ignore())
                .ForMember(x => x.Birthday, o => o.MapFrom((src, dst, destMember, context) => DateTime.UtcNow));

            CreateMap<Account, AccountResponseContract>();
        }
    }
}
