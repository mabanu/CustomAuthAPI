using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using CustomAuthAPI.Models;
using CustomAuthAPI.Repository.Interfaces;
using CustomAuthAPI.Services;
using Microsoft.IdentityModel.Tokens;

namespace CustomAuthAPI.Repository.Repo;

public class TokenRepository : ITokenRepository
{
	private readonly AppDbContext _context;

	public TokenRepository(AppDbContext context)
	{
		_context = context;
	}
	public void SetRefreshToken(RefreshToken newRefreshToken, User user, HttpResponse response)
	{
		var cookieOptions = new CookieOptions
		{
			HttpOnly = true,
			Expires = newRefreshToken.Expires
		};
		response.Cookies.Append("refreshToken", newRefreshToken.Token, cookieOptions);

		user.RefreshToken = newRefreshToken.Token;
		user.TokenCreated = newRefreshToken.Created;
		user.TokenExpires = newRefreshToken.Expires;
	}

	public RefreshToken GenerateRefreshToken()
	{
		var refreshToken = new RefreshToken
		{
			Token = Convert.ToBase64String(RandomNumberGenerator.GetBytes(64)),
			Expires = DateTime.Now.AddDays(7),
			Created = DateTime.Now
		};

		return refreshToken;
	}

	public string CreateToken(User user, string role, IConfiguration _configuration)
	{
		var claims = new List<Claim>
		{
			new(ClaimTypes.Email, user.Email),
			new(ClaimTypes.Role, role)
		};

		var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
			_configuration.GetSection("AppSettings:Token").Value));

		var credential = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

		var token = new JwtSecurityToken(
			claims: claims,
			expires: DateTime.Now.AddDays(1),
			signingCredentials: credential);

		var jwt = new JwtSecurityTokenHandler().WriteToken(token);

		return jwt;
	}

	public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
	{
		using (var hmac = new HMACSHA512())
		{
			passwordSalt = hmac.Key;
			passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
		}
	}

	public bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
	{
		if (passwordSalt == null) return false;
		
			using (var hmac = new HMACSHA512(passwordSalt))
		{
			var computeHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
			return computeHash.SequenceEqual(passwordHash);
		}
	}
}