namespace AspNetCore.Swagger.Versioning.Contracts.v1.Exceptions
{
    /// <summary> Contains information about thrown exception </summary>
    public class ExceptionErrorContract
    {
        /// <summary> Exception messages </summary>
        public string Message { get; set; }

        /// <summary> Type of exception </summary>
        public string Type { get; set; }
    }
}