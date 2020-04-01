using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.Swagger;

namespace Tweetbook.Options
{
    public class SwaggerOptions
    {
        public string JsonRoute { get; set; }
        public string Description { get; set; }
        public string UIEndpoint { get; set; }
        
    }
}
