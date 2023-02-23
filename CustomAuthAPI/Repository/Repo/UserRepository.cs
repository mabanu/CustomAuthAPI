using CustomAuthAPI.Repository.Interfaces;
using CustomAuthAPI.Services;

namespace CustomAuthAPI.Repository.Repo;

public class UserRepository : IUserRepository
{
	private readonly AppDbContext _context;

	public UserRepository(AppDbContext context)
	{
		_context = context;
	}
}