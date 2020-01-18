namespace AspNetCore.Swagger.Versioning.Routes.v2
{
    /// <summary>
    /// Contains very base route part for v2
    /// </summary>
    public static class AppRoutes
    {
        public const string Root = "api";

        public const string Version = "v2";

        public const string Base = Root + "/" + Version;

        /// <summary>
        /// Contains routes for v2 account
        /// </summary>
        public static class Account
        {
            public const string AccountRoot = Base + "/" + "account";

            public const string GetAccountByName = "{name}";
        }
    }
}