using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Swagger.Versioning.Swagger
{
    public class SwaggerOptions
    {
        public string JsonRoute { get; set; }

        public SwagerVersionOptions[] Versions { get; set; }
    }

    public class SwagerVersionOptions
    {
        public string Description { get; set; }
        public string UiEndpoint { get; set; }
    }
}
