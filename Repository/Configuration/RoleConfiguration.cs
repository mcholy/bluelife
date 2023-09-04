using Entities.ConfigurationModels;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<TipoUsuario>
    {
        public void Configure(EntityTypeBuilder<TipoUsuario> builder)
        {
            builder.HasData(
                new TipoUsuario
                {
                    Name = "Manager",
                    NormalizedName = "MANAGER",
                    DateEntry = DateTime.UtcNow,
                    IdUserEntry = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                    Estado = Constants.Status.Actived
                },
                new TipoUsuario
                {
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR",
                    DateEntry = DateTime.UtcNow,
                    IdUserEntry = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                    Estado = Constants.Status.Actived
                }
            );
        }
    }
}
