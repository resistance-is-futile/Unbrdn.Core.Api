using Microsoft.AspNetCore.Mvc;
using Unbrdn.Core.Api.Models;

namespace Unbrdn.Core.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAccountInfo()
        {
            // Placeholder logic to retrieve account info
            var accountInfo = new AccountDto
            {
                // Populate with sample or retrieved data
            };
            return Ok(accountInfo);
        }

        [HttpDelete]
        public IActionResult DeleteAccount()
        {
            // Placeholder logic for account deletion
            return NoContent();
        }

        [HttpPut("settings")]
        public IActionResult UpdateAccountSettings([FromBody] AccountSettingsDto settings)
        {
            if (settings == null)
            {
                return BadRequest("Settings cannot be null.");
            }

            // Placeholder logic to apply settings (e.g., save to database)
            return NoContent();
        }
    }
}
