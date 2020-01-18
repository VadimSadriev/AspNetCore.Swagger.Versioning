using AspNetCore.Swagger.Versioning.Contracts.Exceptions;
using AutoMapper;
using System;
using System.Collections.Generic;

namespace AspNetCore.Swagger.Versioning.Mapping.Profiles
{
    /// <summary>
    /// Mapping for all kind of exceptions <see cref="Exception"/>
    /// </summary>
    public class ExceptionMappingProfile : Profile
    {
        /// <summary>
        /// Mapping for all kind of exceptions <see cref="Exception"/>
        /// </summary>
        public ExceptionMappingProfile()
        {
            CreateMap<Exception, ExceptionContract>()
                .ForMember(x => x.Errors, o => o.MapFrom(x => MapError(x)));
        }

        private IEnumerable<ExceptionErrorContract> MapError(Exception ex)
        {
            var srcExc = ex;

            while (srcExc != null)
            {
                yield return new ExceptionErrorContract { Type = srcExc.GetType().Name, Message = srcExc.Message };
                srcExc = srcExc.InnerException;
            }
        }
    }
}
