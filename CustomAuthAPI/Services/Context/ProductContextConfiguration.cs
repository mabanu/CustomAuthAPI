using System.Text.Json;
using CustomAuthAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CustomAuthAPI.Services.Context;

public class ProductContextConfiguration : IEntityTypeConfiguration<Product>
{
	public void Configure(EntityTypeBuilder<Product> builder)
	{
		builder.HasData(SeedProductData());
	}

	public List<Product> SeedProductData()
	{ 
		var products = new List<Product>();
		using (var reader = new StreamReader(@"Services/Data/ProductData.json"))
		{
			var json = reader.ReadToEnd();
			products = JsonSerializer.Deserialize<List<Product>>(json);
		}

		return products;
	}
}