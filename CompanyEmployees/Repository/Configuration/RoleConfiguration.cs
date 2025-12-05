using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData
        (
            new IdentityRole
            {
                Id = "8f6f3c89-4e7e-4f63-9b1d-4c5658c1a001", // sabit, əl ilə yazılmış GUID
                Name = "Manager",
                NormalizedName = "MANAGER",
                ConcurrencyStamp = "c4a8e6a5-2b1d-4e7c-9b32-1f0b7a2f1001" // sabit
            },
            new IdentityRole
            {
                Id = "c3a2c4d1-9b5a-4a96-8b8c-985fa3a2b002", // sabit
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR",
                ConcurrencyStamp = "e2b4a7c3-8d2f-4f61-8c1e-7a9db5f21002" // sabit
            },
            new IdentityRole
            {
                Id = "56952643-b959-41bd-99ee-f9916d6fc6d7",
                Name = "Software-Engineer",
                NormalizedName = "SOFTWARE-ENGINEER",
                ConcurrencyStamp = "4bb50b8c-2eef-4eef-91b8-4b88780cb139"
            }
         );
    }
}
