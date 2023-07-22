using AutoMapper;
using Entities.Models;
using Shared.DataTransferObjects;

namespace BlueLife
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Cliente, ClienteDto>();
            CreateMap<Producto, ProductoDto>();
            CreateMap<Persona, PersonaDto>();
        }
    }
}
