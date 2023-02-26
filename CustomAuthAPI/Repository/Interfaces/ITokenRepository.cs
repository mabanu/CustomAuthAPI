using CustomAuthAPI.Models;

namespace CustomAuthAPI.Repository.Interfaces;

public interface ITokenRepository
{
	void SetRefreshToken(RefreshToken newRefreshToken, User user, HttpResponse response);

	RefreshToken GenerateRefreshToken();

	string CreateToken(User user, string role, IConfiguration _configuration);

	void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt);

	bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt);

}