using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TestApp.Application;
using TestApp.DataAccess.Dto;

namespace TestApp.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotesController : ControllerBase
    {
        private readonly ITodoService todoService;

        public NotesController(ITodoService todoService)
        {
            this.todoService = todoService;
        }

        [HttpGet()]
        public async Task<IActionResult> Get()
        {
            var result = await todoService.GetDataAsync();
            return Ok(result);
        }
    }
}
