using Microsoft.AspNetCore.Mvc;
using ProcessService;

namespace RestAPI.Controllers
{
    [ApiController]
    [Route("api/processes")]
    public class ProcessController : Controller
    {
        private readonly IProcessService _processService;
        public ProcessController(IProcessService processService)
        {
            _processService = processService;
        }

        [HttpGet]
        public IActionResult GetProcesses()
        {
            var result = _processService.GetProcesses();
            return Ok(result);
        }

        [Route("{id}")]
        public IActionResult GetProcessById(int Id)
        {
            var result = _processService.GetProcessById(Id);
            return Ok(result);
        }
    }
}
