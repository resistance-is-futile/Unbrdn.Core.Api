namespace Unbrdn.Core.Api.Models
{
    public class VaultFileDto
    {
        public Guid FileId { get; set; }  // GUID as primary key
        public string? FileName { get; set; }
        public DateTime UploadDate { get; set; }
        public DateTime? LastAccessed { get; set; }
        public string? FileType { get; set; }
        public long FileSize { get; set; }
    }
}
