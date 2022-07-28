using ClientService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClientService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        [HttpGet(Name = "listaDeClientes")]
        public List<Client> Index()
        {
            return Client.All();
        }
    }
}
