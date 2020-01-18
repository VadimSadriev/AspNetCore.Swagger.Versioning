using System.Collections.Generic;

namespace AspNetCore.Swagger.Versioning.Contracts.v1.Exceptions
{
    /// <summary>
    /// Contract for all kind of <see cref="System.Exception"/> thrown in application
    /// </summary>
    public class ExceptionContract
    {
        /// <summary>
        /// List of errors of all thrown exception during request
        /// </summary>
        public List<ExceptionErrorContract> Errors { get; set; }
    }
}