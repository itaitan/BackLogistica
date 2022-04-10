using AutoMapper;
using LogisticaLoremIpsum.Data.Dtos;
using LogisticaLoremIpsum.Models;

namespace LogisticaLoremIpsum.Profiles
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<CreateClienteDto, Cliente>();
            CreateMap<Cliente, ReadClienteDto>();
            CreateMap<UpdateClienteDto, Cliente>();
        }
    }
}
