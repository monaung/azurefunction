using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace MonAung.Function
{
    public class MyFirstFunction
    {
        private readonly ILogger<MyFirstFunction> _logger;

        public MyFirstFunction(ILogger<MyFirstFunction> logger)
        {
            _logger = logger;
        }

        [Function("MyFirstFunction")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Mon Aung's Azure Function!");
        }
    }
}
