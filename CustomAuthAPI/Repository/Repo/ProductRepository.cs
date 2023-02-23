using CustomAuthAPI.Repository.Interfaces;
using CustomAuthAPI.Services;

namespace CustomAuthAPI.Repository.Repo;

public class ProductRepository : IProductRepository
{
	private readonly AppDbContext _Context;

	public ProductRepository(AppDbContext context)
	{
		_Context = context;
	}
}