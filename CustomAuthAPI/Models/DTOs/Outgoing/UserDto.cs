namespace CustomAuthAPI.Models.DTOs.Outgoing;

public class UserDto
{
	public string Email { get; set; }
	public string Password { get; set; }
	public string Role { get; set; }
	public int StoreId { get; set; }
}