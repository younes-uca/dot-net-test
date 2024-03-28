using AutoMapper;
using DotnetGenerator.Bean.Core;
using DotnetGenerator.Ws.Dto;

namespace DotnetGenerator;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        
        // tag mapper
        CreateMap<TagDto, Tag>();
        CreateMap<Tag, TagDto>();

        // purchaseState mapper
        CreateMap<PurchaseStateDto, PurchaseState>();
        CreateMap<PurchaseState, PurchaseStateDto>();
        // purchaseItem mapper
        CreateMap<PurchaseItemDto, PurchaseItem>()
            .ForMember(dest => dest.Product, opt => opt.MapFrom(src => src.Product))
            .ForMember(dest => dest.Purchase, opt => opt.MapFrom(src => src.Purchase))
                ;
        CreateMap<PurchaseItem, PurchaseItemDto>()
            .ForMember(dest => dest.Product, opt => opt.MapFrom(src => src.Product))
            .ForMember(dest => dest.Purchase, opt => opt.MapFrom(src => src.Purchase))
        ;
        // purchaseTag mapper
        CreateMap<PurchaseTagDto, PurchaseTag>()
            .ForMember(dest => dest.Purchase, opt => opt.MapFrom(src => src.Purchase))
            .ForMember(dest => dest.Tag, opt => opt.MapFrom(src => src.Tag))
                ;
        CreateMap<PurchaseTag, PurchaseTagDto>()
            .ForMember(dest => dest.Purchase, opt => opt.MapFrom(src => src.Purchase))
            .ForMember(dest => dest.Tag, opt => opt.MapFrom(src => src.Tag))
        ;
        // purchase mapper
        CreateMap<PurchaseDto, Purchase>()
            .ForMember(dest => dest.Client, opt => opt.MapFrom(src => src.Client))
            .ForMember(dest => dest.PurchaseState, opt => opt.MapFrom(src => src.PurchaseState))
            .ForMember(dest => dest.PurchaseItems, opt => opt.MapFrom(src => src.PurchaseItems))
            .ForMember(dest => dest.PurchaseTags, opt => opt.MapFrom(src => src.PurchaseTags))
                ;
        CreateMap<Purchase, PurchaseDto>()
            .ForMember(dest => dest.Client, opt => opt.MapFrom(src => src.Client))
            .ForMember(dest => dest.PurchaseState, opt => opt.MapFrom(src => src.PurchaseState))
            .ForMember(dest => dest.PurchaseItems, opt => opt.MapFrom(src => src.PurchaseItems))
            .ForMember(dest => dest.PurchaseTags, opt => opt.MapFrom(src => src.PurchaseTags))
        ;

        // product mapper
        CreateMap<ProductDto, Product>();
        CreateMap<Product, ProductDto>();
        // client mapper
        CreateMap<ClientDto, Client>()
            .ForMember(dest => dest.ClientCategory, opt => opt.MapFrom(src => src.ClientCategory))
                ;
        CreateMap<Client, ClientDto>()
            .ForMember(dest => dest.ClientCategory, opt => opt.MapFrom(src => src.ClientCategory))
        ;

        // clientCategory mapper
        CreateMap<ClientCategoryDto, ClientCategory>();
        CreateMap<ClientCategory, ClientCategoryDto>();
    }
}

