using AspNetCore.Swagger.Versioning.Contracts.Account;
using AspNetCore.Swagger.Versioning.Models;
using AutoMapper;
using System;

namespace AspNetCore.Swagger.Versioning.Mapping.Profiles
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
