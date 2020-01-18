using System;

namespace AspNetCore.Swagger.Versioning.Contracts.v1.Account
{
    /// <summary>
    /// Response contract for <see cref="Account"/>
    /// </summary>
    public class AccountResponseContract : AccountContract
    {
        /// <summary>
        /// Account identifier
        /// </summary>
        public long Id { get; set; }

        /// <summary> User birthday </summary>
        public DateTimeOffset Birthday { get; set; }
    }
}