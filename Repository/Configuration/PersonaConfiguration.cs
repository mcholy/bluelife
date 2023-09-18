using Entities.ConfigurationModels;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.HasData(
                new Persona
                {
                    //Id = Guid.NewGuid(),
                    Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                    Nombre = "Administrator",
                    Documento = "00000000",
                    Celular = "999999999",
                    Direccion = "Internet",
                    DateEntry = DateTime.UtcNow,
                    IdUserEntry = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                    Estado = Constants.Status.Actived
                }
            );
        }
    }
}
