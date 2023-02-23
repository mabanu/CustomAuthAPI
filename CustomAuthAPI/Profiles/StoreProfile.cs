using AutoMapper;
using CustomAuthAPI.Models;
using CustomAuthAPI.Models.DTOs.Incoming;
using CustomAuthAPI.Models.DTOs.Outgoing;

namespace CustomAuthAPI.Profiles;

public class StoreProfile : Profile
{
	public StoreProfile()
	{
		CreateMap<StoreCreationDto, Store>()
			.ForMember(dest => dest.Name,
				opt => opt.MapFrom(src => src.Name));

		CreateMap<Store, StoreDto>()
			.ForMember(dest => dest.Name,
				opt => opt.MapFrom(src => src.Name));
	}
}