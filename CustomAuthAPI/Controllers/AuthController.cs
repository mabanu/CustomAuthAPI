using AutoMapper;
using CustomAuthAPI.Models;
using CustomAuthAPI.Models.DTOs.Incoming;
using CustomAuthAPI.Models.DTOs.Outgoing;
using CustomAuthAPI.Repository.Interfaces;
using CustomAuthAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CustomAuthAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
	private readonly IConfiguration _configuration;
	private readonly IUserRepository _userRepository;
	private readonly ITokenRepository _tokenRepository;
	private readonly AppDbContext _context;
	private readonly IMapper _mapper;

	public AuthController(IConfiguration configuration, IUserRepository userRepository, ITokenRepository tokenRepository, AppDbContext context, IMapper mapper)
	{
		_configuration = configuration;
		_userRepository = userRepository;
		_tokenRepository = tokenRepository;
		_context = context;
		_mapper = mapper;
	}
	
	[HttpGet("{id}")]
	public async Task<ActionResult<UserDto>> GetUser(int id)
	{
		if (_context.Users == null) return NotFound();
		var user = await _context.Users.FindAsync(id);

		if (user == null) return NotFound();

		var _user = _mapper.Map<UserDto>(user);

		return _user;
	}

	[HttpGet]
	[Authorize]
	public ActionResult<object> GetMe()
	{
		var userData = _userRepository.GetMyName();

		return Ok(new { userData });
	}

	[HttpPost("register")]
	public async Task<ActionResult<User>> Register(UserCreationDto request)
	{
		if (_context.Users == null) return Problem("Entity set 'AppDbContext.Users'  is null.");
		
		_tokenRepository.CreatePasswordHash(request.Password, out var passwordHash, out var passwordSalt);

		var user = _mapper.Map<User>(request);
		
		var token = _tokenRepository.CreateToken(user, request.Role, _configuration);

		user.RefreshToken = token;
		user.PasswordHash = passwordHash;
		user.PasswordSalt = passwordSalt;
		user.TokenCreated = DateTime.Now;
		user.TokenExpires = DateTime.Now.AddDays(7);

		_context.Users.Add(user);
		await _context.SaveChangesAsync();

		return CreatedAtAction("GetUser", new { id = user.Id }, user);
	}

	[HttpPost("login")]
	public async Task<ActionResult<string>> Login(UserCreationDto request)
	{
		var user = await _context.Users.FirstOrDefaultAsync(value => value.Email == request.Email);

		if (user == null) return BadRequest("Email not found.");
		
		if (user.Password != request.Password)
			return BadRequest("Wrong password.");

		var token = _tokenRepository.CreateToken(user, request.Role, _configuration);

		user.RefreshToken = token;
		
		var refreshToken = _tokenRepository.GenerateRefreshToken();
		_tokenRepository.SetRefreshToken(refreshToken, user, Response);

		_context.Entry(user).State = EntityState.Modified;

		refreshToken.UserId = user.Id;
		
		_context.Tokens.Add(refreshToken);
		await _context.SaveChangesAsync();

		return Ok(token);
	}
	
	[HttpPost("refresh-token")]
	public async Task<ActionResult<string>> RefreshToken()
	{
		var refreshToken = Request.Cookies["refreshToken"];
		var dataToken = await _context.Tokens.FirstOrDefaultAsync(src => src.Token == refreshToken);
		

		if (dataToken == null) return Unauthorized("Invalid Refresh Token.");

		if (dataToken.Expires < DateTime.Now) return Unauthorized("Token expired.");
		
		var user = await _context.Users.FindAsync(dataToken.UserId);

		var token = _tokenRepository.CreateToken(user, "admin", _configuration);
		var newRefreshToken = _tokenRepository.GenerateRefreshToken();
		_tokenRepository.SetRefreshToken(newRefreshToken, user, Response);
		_context.Entry(user).State = EntityState.Modified;
		_context.Tokens.Add(newRefreshToken);
		await _context.SaveChangesAsync();

		return Ok(token);
	}
}