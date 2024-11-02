using Microsoft.AspNetCore.Mvc;
using Unbrdn.Core.Api.Models;

namespace Unbrdn.Core.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpPost("register")]
        public IActionResult RegisterUser([FromBody] UserRegistrationDto registration)
        {
            if (registration == null)
            {
                return BadRequest("Registration data cannot be null.");
            }

            // Placeholder logic to register user
            var defaultSettings = new AccountSettingsDto
            {
                EnableEmailNotifications = true,
                LanguagePreference = "en-US",
                DarkModeEnabled = false
            };

            // Assign or save settings for the new user

            return CreatedAtAction(nameof(RegisterUser), new { id = registration.UserId }, registration);
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] UserLoginDto login)
        {
            // Placeholder logic for user login
            return Ok("User logged in successfully.");
        }

        [HttpPost("logout")]
        public IActionResult Logout()
        {
            // Placeholder logic for user logout
            return Ok("User logged out successfully.");
        }

        [HttpPost("verify-death")]
        public IActionResult VerifyDeath([FromBody] VerificationDto verification)
        {
            // Placeholder logic to verify user’s status for dispersal
            return Ok("Verification complete for dispersal.");
        }
    }
}
