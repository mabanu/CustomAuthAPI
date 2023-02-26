using CustomAuthAPI.Models;
using CustomAuthAPI.Services.Context;
using Microsoft.EntityFrameworkCore;

namespace CustomAuthAPI.Services;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions options) : base(options)
	{
	}

	public DbSet<Product> Products { get; set; }
	public DbSet<Store> Stores { get; set; }
	public DbSet<User> Users { get; set; }
	
	public DbSet<RefreshToken> Tokens { get; set; }

	protected override void OnModelCreating(ModelBuilder builder)
	{
		builder.ApplyConfiguration(new ProductContextConfiguration());
		builder.ApplyConfiguration(new StoreContextConfiguration());
		builder.ApplyConfiguration(new UserContextConfiguration());
	}
}