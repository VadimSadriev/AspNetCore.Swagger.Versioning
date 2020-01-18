using AspNetCore.Swagger.Versioning.Contracts.Enums;
using System;

namespace AspNetCore.Swagger.Versioning.Models
{
    /// <summary>
    /// User account
    /// </summary>
    public class Account
    {
        public long Id { get; set; }
        /// <summary> Account name </summary>
        public string Name { get; set; }

        /// <summary> Age of user </summary>
        public int Age { get; set; }

        /// <summary> User birthday </summary>
        public DateTimeOffset Birthday { get; set; }

        /// <summary> Account permission </summary>
        public AccountPermission[] Permissions { get; set; }
    }
}
