using CustomAuthAPI.Repository.Interfaces;
using CustomAuthAPI.Services;

namespace CustomAuthAPI.Repository.Repo;

public class StoreRepository : IStoreRepository
{
	private readonly AppDbContext _context;

	public StoreRepository(AppDbContext context)
	{
		_context = context;
	}
}