using System.Security.Claims;
using CustomAuthAPI.Repository.Interfaces;
using CustomAuthAPI.Services;

namespace CustomAuthAPI.Repository.Repo;

public class UserRepository : IUserRepository
{
	private readonly AppDbContext _context;
	private readonly IHttpContextAccessor _httpContextAccessor;

	public UserRepository(AppDbContext context, IHttpContextAccessor httpContextAccessor)
	{
		_context = context;
		_httpContextAccessor = httpContextAccessor;
	}

	public object GetMyName()
	{
		var email = string.Empty;
		var role = string.Empty;

		if (_httpContextAccessor != null)
		{
			email = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Email);
			role = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Role);
		}

		return new { email, role };
	}
}