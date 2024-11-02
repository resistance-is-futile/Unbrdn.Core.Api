using Microsoft.AspNetCore.Mvc;
using Unbrdn.Core.Api.Models;

namespace Unbrdn.Core.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AssetController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateAsset([FromBody] AssetDto asset)
        {
            if (string.IsNullOrEmpty(asset.Category))
            {
                return BadRequest("Asset category is required.");
            }
            // Placeholder logic for asset creation
            return CreatedAtAction(nameof(GetAssetById), new { id = asset.Id }, asset);
        }

        [HttpGet]
        public IActionResult GetAllAssets()
        {
            // Placeholder logic to retrieve all assets
            return Ok(new List<AssetDto>());
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetAssetById(Guid id)
        {
            // Logic to retrieve asset by GUID
            return Ok(new AssetDto { Id = id });
        }

        [HttpPut("{id:guid}")]
        public IActionResult UpdateAsset(Guid id, [FromBody] AssetDto asset)
        {
            // Logic to update asset by GUID
            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteAsset(Guid id)
        {
            // Logic to delete asset by GUID
            return NoContent();
        }

    }
}
