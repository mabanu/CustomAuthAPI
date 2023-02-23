using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CustomAuthAPI.Models;

public class Store
{
	[JsonPropertyName("name")]
	public string Name { get; set; }
	
	[Key]
	[JsonPropertyName("uniqueStoreId")]
	public int UniqueStoreId { get; set; }
	
}