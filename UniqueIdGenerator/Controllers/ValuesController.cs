using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using UniqueIdGenerator.Contacts;
using UniqueIdGenerator.Models;

namespace UniqueIdGenerator.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IGuIdService _guIdService;
        private readonly IXIdService _xIdService;

        public ValuesController(IGuIdService guIdService, IXIdService xIdService)
        {
            _guIdService = guIdService;
            _xIdService = xIdService;

        }


        [HttpGet]
        public IActionResult GenerateGuid()
        {
            var response = new ResponseData();
            response.guid = _guIdService.GetGuIdValue();

            return Ok(response);
        }

        [HttpGet]
        public IActionResult ParsedGuid(string guid)
        {
            var response = new ResponseData();
            response.parsedGuid = _guIdService.GetGuIdValue(guid);

            return Ok(response);
        }

        [HttpGet]
        public IActionResult GenerateXid()
        {
            var response = new ResponseData();
            response.guid = _xIdService.GetXIdValue();

            return Ok(response);
        }

        [HttpGet]
        public IActionResult ParsedXid(string guid)
        {
            var response = new ResponseData();
            response.parsedGuid = _xIdService.GetXIdValue(guid);

            return Ok(response);
        }
        
    }
}
