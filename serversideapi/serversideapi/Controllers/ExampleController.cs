using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace serversideapi.Controllers
{
    
    public class ExampleController : Controller
    {
        [Route("/testroute")]
        public async Task<string> TestRoute()
        {
            return "test";
        }

    }
}
