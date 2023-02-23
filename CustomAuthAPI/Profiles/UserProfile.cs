using AutoMapper;
using CustomAuthAPI.Models;
using CustomAuthAPI.Models.DTOs.Incoming;
using CustomAuthAPI.Models.DTOs.Outgoing;

namespace CustomAuthAPI.Profiles;

public class UserProfile : Profile
{
	public UserProfile()
	{
		CreateMap<UserCreationDto, User>()
			.ForMember(dest => dest.Email,
				opt => opt.MapFrom(src => src.Email))
			.ForMember(dest => dest.Password,
				opt => opt.MapFrom(src => src.Password))
			.ForMember(dest => dest.Role,
				opt => opt.MapFrom(src => src.Role))
			.ForMember(dest => dest.StoreId,
				opt => opt.MapFrom(src => src.StoreId));
		
		CreateMap<User, UserDto>()
			.ForMember(dest => dest.Email,
				opt => opt.MapFrom(src => src.Email))
			.ForMember(dest => dest.Password,
				opt => opt.MapFrom(src => src.Password))
			.ForMember(dest => dest.Role,
				opt => opt.MapFrom(src => src.Role))
			.ForMember(dest => dest.StoreId,
				opt => opt.MapFrom(src => src.StoreId));
	}
}