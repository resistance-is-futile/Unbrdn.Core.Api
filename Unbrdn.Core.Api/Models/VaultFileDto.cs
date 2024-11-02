namespace Unbrdn.Core.Api.Models
{
    public class VaultFileDto
    {
        public int FileId { get; set; }
        public string? FileName { get; set; }
        public DateTime UploadDate { get; set; }
        public DateTime? LastAccessed { get; set; }
        public string? FileType { get; set; }  // e.g., "pdf", "jpg", "docx"
        public long FileSize { get; set; }
    }
}
