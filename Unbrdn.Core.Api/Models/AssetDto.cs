namespace Unbrdn.Core.Api.Models
{
    public class AssetDto
    {
        public Guid Id { get; set; }  // GUID as primary key
        public string? Name { get; set; }
        public decimal Value { get; set; }
        public string? Category { get; set; }
        public string? Description { get; set; }
    }
}
