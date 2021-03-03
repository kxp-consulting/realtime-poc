using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RealTimePoC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestChatController : ControllerBase
    {

        private readonly ILogger<RestChatController> _logger;

        private static List<string> messages = new List<string>();
        public RestChatController(ILogger<RestChatController> logger)
        {
            _logger = logger;
            
        }


        [HttpGet]
        public async Task<ActionResult<List<string>>> Get()
        {
            return messages;
        }

        [HttpPost]
        public async Task<ActionResult<List<string>>> Post(string message)
        {
            messages.Add(message);
            return messages;
        }
    }
}