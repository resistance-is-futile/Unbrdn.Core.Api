namespace Unbrdn.Core.Api.Models
{
    public class AssetDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Value { get; set; }
        public string? Category { get; set; }  // e.g., "Real Estate", "Financial", "Personal"
        public string? Description { get; set; }
    }
}
