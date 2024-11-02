namespace Unbrdn.Core.Api.Models
{
    public class UserRegistrationDto
    {
        public Guid UserId { get; set; }  // GUID as primary key
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
    }
}
