using Microsoft.AspNetCore.Mvc;

namespace exampleapi.Controllers
{
    public class ExampleController : Controller
    {
        [Route("testget")]
        public string TestGET()
        {
            return "test result";
        }


        [Route("testpost")]
        public string TestPOST([FromBody]DataToSend data)
        {
            return data.val1 + data.val2;
        }


        public  class DataToSend
        {
            public string val1 { get; set; }
            public bool val2 { get; set; }
        }
    }
}
