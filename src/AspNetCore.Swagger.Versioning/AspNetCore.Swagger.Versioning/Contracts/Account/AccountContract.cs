﻿using AspNetCore.Swagger.Versioning.Contracts.Enums;
using System;

namespace AspNetCore.Swagger.Versioning.Contracts.Account
{
    /// <summary> Contract used for account creation </summary>
    public class AccountContract
    {
        /// <summary> Account name </summary>
        public string Name { get; set; }

        /// <summary> Age of user </summary>
        public int Age { get; set; }

        /// <summary> Account permission </summary>
        public AccountPermission[] Permissions { get; set; }
    }
}
