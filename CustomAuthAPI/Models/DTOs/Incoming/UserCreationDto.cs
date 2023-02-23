namespace CustomAuthAPI.Models.DTOs.Incoming;

public class UserCreationDto
{
	public string Email { get; set; }
	public string Password { get; set; }
	public string Role { get; set; }
	public int StoreId { get; set; }
}