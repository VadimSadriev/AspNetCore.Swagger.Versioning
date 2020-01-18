namespace AspNetCore.Swagger.Versioning.Routes.v1
{
    /// <summary>
    /// Contains very base route part for v1
    /// </summary>
    public static class AppRoutes
    {
        public const string Root = "api";

        public const string Version = "v1";

        public const string Base = Root + "/" + Version;

        /// <summary>
        /// Contains routes for v1 account
        /// </summary>
        public static class Account
        {
            public const string AccountRoot = Base + "/" + "account";

            public const string GetAccountById = "{accountId}";
        }
    }
}
