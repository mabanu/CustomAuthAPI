using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CustomAuthAPI.Models;

public class User
{
	[Key] [JsonPropertyName("id")] public int Id { get; set; }

	[JsonPropertyName("email")] public string Email { get; set; }

	[JsonPropertyName("password")] public string Password { get; set; }

	[JsonPropertyName("role")] public string Role { get; set; }

	public Store Store { get; set; }

	[ForeignKey("Store")]
	[JsonPropertyName("uniqueStoreId")]
	public int StoreId { get; set; }
}