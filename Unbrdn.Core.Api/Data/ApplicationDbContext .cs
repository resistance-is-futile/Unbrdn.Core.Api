using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Unbrdn.Core.Api.Models;

namespace Unbrdn.Core.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<AccountDto> Accounts { get; set; }
        public DbSet<AssetDto> Assets { get; set; }
        public DbSet<VaultFileDto> VaultFiles { get; set; }
        public DbSet<UserRegistrationDto> Users { get; set; }
    }
}
