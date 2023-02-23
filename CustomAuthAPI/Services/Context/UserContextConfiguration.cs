using System.Text.Json;
using CustomAuthAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CustomAuthAPI.Services.Context;

public class UserContextConfiguration : IEntityTypeConfiguration<User>
{
	public void Configure(EntityTypeBuilder<User> builder)
	{
		builder.HasData(
			SeedUserData()
		);
	}

	public List<User> SeedUserData()
	{
		var users = new List<User>();
		using (var reader = new StreamReader(@"Services/Data/UsersData.json"))
		{
			var json = reader.ReadToEnd();
			users = JsonSerializer.Deserialize<List<User>>(json);
		}

		return users;
	}
}