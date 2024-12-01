using Microsoft.AspNetCore.Mvc;
using Wpm.Managment.Api.Application.Command;

namespace Wpm.Managment.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ManagmentController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult> Post(CreatePetCommand command)
        {

        }

    }
}
