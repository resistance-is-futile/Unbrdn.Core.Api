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

        [HttpGet("{id}")]
        public IActionResult GetAssetById(int id)
        {
            // Placeholder logic to retrieve asset by id
            return Ok(new AssetDto { Id = id });
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAsset(int id, [FromBody] AssetDto asset)
        {
            if (string.IsNullOrEmpty(asset.Category))
            {
                return BadRequest("Asset category is required.");
            }
            // Placeholder logic to update asset
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAsset(int id)
        {
            // Placeholder logic to delete asset
            return NoContent();
        }
    }
}
