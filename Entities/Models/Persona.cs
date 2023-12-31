﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Persona
    {
        public Guid Id { get; set; }
        [ForeignKey(nameof(Empresa))]
        public Guid? EmpresaId { get; set; }
        public string? Nombre { get; set; }
        public string? ApPaterno { get; set; }
        public string? ApMaterno { get; set; }
        public string? Documento { get; set; }
        public string? Email { get; set; }
        public string? Celular { get; set; }
        public string? Direccion { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public DateTime DateEntry { get; set; }
        public DateTime? DateModify { get; set; }
        public Guid? IdUserEntry { get; set; }
        public Guid? IdUserModify { get; set; }
        public string? Estado { get; set; }
        public Cliente? Cliente { get; set; }
        public Usuario? Usuario { get; set; }
        public Trabajador? Trabajador { get; set; }
        public Empresa? Empresa { get; set; }
    }
}
