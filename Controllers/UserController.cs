using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using TradeQuickWinsAPI.WebModel.Request;

namespace TradeQuickWinsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet("~/get-current-user")]
        public async Task<IActionResult> GetCurrentUser() 
        {
            try
            {
                return Ok("");
            }
            catch (Exception ex)
            {
                return Unauthorized("Session expired.");
            }
        }

        //[Authorize(Roles = "Administrator")]
        [HttpDelete("~/delete-user/{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            try
            {
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("~/get-users")]
        public async Task<IActionResult> GetUsers()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("~/get-user/{username}", Name = "get-user")]
        public async Task<IActionResult> GetUser(string username)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("~/login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            try
            {
                return Ok(new
                {
                    user = "",
                    token = ""
                });
            }
            catch (Exception ex)
            {
                throw new Exception($"Internal server error: {ex.Message}");
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost("~/register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserRequest user)
        {
            try
            {
                return StatusCode(201, "");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


    }
}