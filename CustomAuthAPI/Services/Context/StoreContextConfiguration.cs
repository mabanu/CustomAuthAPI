using System.Text.Json;
using CustomAuthAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CustomAuthAPI.Services.Context;

public class StoreContextConfiguration : IEntityTypeConfiguration<Store>
{
	public void Configure(EntityTypeBuilder<Store> builder)
	{
		builder.HasData(
			SeedStoreData()
		);
	}

	public List<Store> SeedStoreData()
	{
		var stores = new List<Store>();
		using (var reader = new StreamReader(@"Services/Data/StoreData.json"))
		{
			var json = reader.ReadToEnd();
			stores = JsonSerializer.Deserialize<List<Store>>(json);
		}

		return stores;
	}
}