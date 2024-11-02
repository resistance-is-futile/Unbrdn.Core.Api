namespace Unbrdn.Core.Api.Models
{
    public class VerificationDto
    {
        public int UserId { get; set; }       // Identifier of the user to verify
        public string? VerificationCode { get; set; }  // Code for verification (e.g., unique token)
        public DateTime VerificationDate { get; set; }  // Optional date for verification context
    }
}
