using AutoMapper;
using CustomAuthAPI.Models;
using CustomAuthAPI.Models.DTOs.Incoming;
using CustomAuthAPI.Models.DTOs.Outgoing;

namespace CustomAuthAPI.Profiles;

public class ProductProfile : Profile
{
	public ProductProfile()
	{
		CreateMap<ProductCreationDto, Product>()
			.ForMember(dest => dest.Title,
				opt => opt.MapFrom(src => src.Title))
			.ForMember(dest => dest.Description,
				opt => opt.MapFrom(src => src.Description))
			.ForMember(dest => dest.ImageUrl,
				opt => opt.MapFrom(src => src.ImageUrl))
			.ForMember(opt => opt.StoreId,
				opt => opt.MapFrom(src => src.StoreId))
			.ForMember(dest => dest.Price,
				opt => opt.MapFrom(src => src.Price))
			.ForMember(dest => dest.Quantity,
				opt => opt.MapFrom(src => src.Quantity))
			.ForMember(dest => dest.Category,
				opt => opt.MapFrom(src => src.Category));
		
		CreateMap<ProductUpdateDto, Product>()
			.ForMember(dest => dest.Title,
				opt => opt.MapFrom(src => src.Title))
			.ForMember(dest => dest.Description,
				opt => opt.MapFrom(src => src.Description))
			.ForMember(dest => dest.ImageUrl,
				opt => opt.MapFrom(src => src.ImageUrl))
			.ForMember(opt => opt.StoreId,
				opt => opt.MapFrom(src => src.StoreId))
			.ForMember(dest => dest.Price,
				opt => opt.MapFrom(src => src.Price))
			.ForMember(dest => dest.Quantity,
				opt => opt.MapFrom(src => src.Quantity))
			.ForMember(dest => dest.Category,
				opt => opt.MapFrom(src => src.Category));

		CreateMap<Product, ProductDto>()
			.ForMember(dest => dest.Title,
				opt => opt.MapFrom(src => src.Title))
			.ForMember(dest => dest.Description,
				opt => opt.MapFrom(src => src.Description))
			.ForMember(dest => dest.ImageUrl,
				opt => opt.MapFrom(src => src.ImageUrl))
			.ForMember(opt => opt.StoreId,
				opt => opt.MapFrom(src => src.StoreId))
			.ForMember(dest => dest.Price,
				opt => opt.MapFrom(src => src.Price))
			.ForMember(dest => dest.Quantity,
				opt => opt.MapFrom(src => src.Quantity))
			.ForMember(dest => dest.Category,
				opt => opt.MapFrom(src => src.Category));
	}
}