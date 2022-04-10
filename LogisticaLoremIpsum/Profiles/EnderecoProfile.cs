using AutoMapper;
using LogisticaLoremIpsum.Data.Dtos.Enderecos;
using LogisticaLoremIpsum.Models;

namespace LogisticaLoremIpsum.Profiles
{
    public class EnderecoProfile : Profile
    {
        public EnderecoProfile()
        {
            CreateMap<CreateEnderecoDto, Endereco>();
            CreateMap<Endereco, ReadEnderecoDto>();
            CreateMap<UpdateEnderecoDto, Endereco>();
        }
    }
}
