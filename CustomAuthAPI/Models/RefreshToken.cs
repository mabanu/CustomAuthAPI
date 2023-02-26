using System.ComponentModel.DataAnnotations.Schema;

namespace CustomAuthAPI.Models;

public class RefreshToken
{
	public Guid Id { get; set; }
	public string Token { get; set; }
	public DateTime Created { get; set; }
	public DateTime Expires { get; set; }
	public User User { get; set; }
	[ForeignKey("User")]
	public int UserId { get; set; }
}