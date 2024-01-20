using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.User;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;
using Api.Domain.Dtos;
using Microsoft.AspNetCore.Authorization;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class LoginController : ControllerBase
    {
        [AllowAnonymous]
        [HttpPost]
        public async Task<object> Login([FromBody] LoginDto userEntity, [FromServices] ILoginService service)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (userEntity == null) return BadRequest();

            try
            {
                var result = await service.GetByLogin(userEntity);
                if (result != null) return Ok(result);
                else return NotFound();
            }
            catch (Exception erro)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, erro.Message);
            }
        }



    }
}
