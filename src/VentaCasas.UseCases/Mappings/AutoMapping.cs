using AutoMapper;
using VentaCasas.DTOs;
using VentaCasas.Entities.POCOs;

namespace VentaCasas.UseCases.Mappings
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<CreatePropertyDTO, Property>().ReverseMap();
            CreateMap<Property, PropertyDTO>().ReverseMap();
            CreateMap<UpdatePropertyDTO, Property>().ReverseMap();
            CreateMap<CreateOwnerDTO, Owner>().ReverseMap();
            CreateMap<Owner, OwnerDTO>().ReverseMap();
            CreateMap<CreatePropertyImageDTO, PropertyImage>().ReverseMap();
            CreateMap<PropertyImage, PropertyImageDTO>().ReverseMap();
        }
    }
}
