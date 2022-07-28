using ClientService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClientService.Controllers
{
    [Route("minhaapiteste/[controller]")]
    [ApiController]
    public class MyTestController : ControllerBase
    {
        [HttpGet(Name = "/testete")]
        public string Get()
        {
            return ModelTest.Print();
        }
    }
}
