namespace Unbrdn.Core.Api.Models
{
    public class AccountDto
    {
        public Guid Id { get; set; }  // GUID as primary key
        public string? Name { get; set; }
        public AccountSettingsDto? Settings { get; set; }
    }
}
