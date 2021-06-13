using ClientGrpcService.Protos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClientWebApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientApiController : ControllerBase
    {
        private readonly ClientProtoService.ClientProtoServiceClient _clientProtoService;

        public ClientApiController(ClientProtoService.ClientProtoServiceClient clientProtoService)
        {
            _clientProtoService = clientProtoService;
        }

        // GET: api/<ClientApiController>
        [HttpGet]
        public async Task<IActionResult> Get(int clientId)
        {
            var response = await this._clientProtoService.GetClientAsync(new GetClientRequest() { ClientId = clientId });

            return Ok(response);
        }

      
    }
}
