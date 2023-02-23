using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CustomAuthAPI.Models;

public class Product
{
	[Key] [JsonPropertyName("id")] public int Id { get; set; }

	[JsonPropertyName("title")] public string Title { get; set; }

	[JsonPropertyName("description")] public string Description { get; set; }

	[JsonPropertyName("imageUrl")] public string ImageUrl { get; set; }

	public Store Store { get; set; }

	[ForeignKey("Store")]
	[JsonPropertyName("storeId")]
	public int StoreId { get; set; }

	[JsonPropertyName("price")] public string Price { get; set; }

	[JsonPropertyName("quantity")] public int Quantity { get; set; }

	[JsonPropertyName("category")] public string Category { get; set; }
}