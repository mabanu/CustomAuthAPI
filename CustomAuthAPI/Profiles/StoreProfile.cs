using AutoMapper;
using CustomAuthAPI.Models;
using CustomAuthAPI.Models.DTOs.Incoming;

namespace CustomAuthAPI.Profiles;

public class StoreProfile : Profile
{
	public StoreProfile()
	{
		CreateMap<StoreCreationDto, Store>()
			.ForMember(dest => dest.Name,
				opt => opt.MapFrom(src => src.Name));
	}
}