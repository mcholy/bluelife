using Microsoft.AspNetCore.Identity;

namespace Entities.Models
{
    public class TipoUsuario : IdentityRole
    {
        public DateTime DateEntry { get; set; }
        public DateTime? DateModify { get; set; }
        public Guid IdUserEntry { get; set; }
        public Guid? IdUserModify { get; set; }
        public string? Estado { get; set; }
    }
}
