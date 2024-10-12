using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using UniqueIdGenerator.Contacts;
using UniqueIdGenerator.Models;
using UniqueIdGenerator.Services;

namespace UniqueIdGenerator.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UniqIdController : ControllerBase
    {
        private readonly INanoIDService _nanoIDService;

        public UniqIdController(INanoIDService nanoIDService)
        {
            _nanoIDService = nanoIDService;

        }


        [HttpGet]
        public IActionResult GenerateGuid()
        {
            var response = new ResponseData();
            response.guid = _nanoIDService.GetNanoIDValue();

            return Ok(response);
        }

        [HttpGet]
        public IActionResult AlphabateGuid()
        {
            var response = new ResponseData();
            response.parsedGuid = _nanoIDService.GetNanoIDAlphabateValue();

            return Ok(response);
        }
                
    }
}
