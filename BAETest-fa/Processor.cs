
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;
using System;

namespace BAETest
{
    public static class Processor
    {
        [FunctionName("Main")]
        public static IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "post", Route = null)]HttpRequest req, TraceWriter log)
        {
            try
            {
                log.Info("BAE Test - Main Function Called");
                return new OkObjectResult("BAE Test Process Finished - OK");
            }
            catch(Exception ex)
            {
                return new BadRequestObjectResult(ex.InnerException.ToString());
            }
        }
    }
}
