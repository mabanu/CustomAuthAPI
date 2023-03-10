using AutoMapper;
using CustomAuthAPI.Models;
using CustomAuthAPI.Models.DTOs.Incoming;
using CustomAuthAPI.Models.DTOs.Outgoing;
using CustomAuthAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CustomAuthAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize(Roles = "super-admin")]
public class UserController : ControllerBase
{
	private readonly AppDbContext _context;
	private readonly IMapper _mapper;

	public UserController(AppDbContext context, IMapper mapper)
	{
		_context = context;
		_mapper = mapper;
	}

	// GET: api/User
	[HttpGet]
	[Authorize(Roles = "super-admin")]
	public async Task<ActionResult<IEnumerable<UserDto>>> GetUsers()
	{
		if (_context.Users == null) return NotFound();
		var allUsers = await _context.Users.ToListAsync();
		var _users = _mapper.Map<IEnumerable<UserDto>>(allUsers);

		return Ok(_users);
	}

	// GET: api/User/5
	[HttpGet("{id}")]
	[Authorize(Roles = "user")]
	public async Task<ActionResult<UserDto>> GetUser(int id)
	{
		if (_context.Users == null) return NotFound();
		var user = await _context.Users.FindAsync(id);

		if (user == null) return NotFound();

		var _user = _mapper.Map<UserDto>(user);

		return _user;
	}

	// PUT: api/User/5
	// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
	[HttpPut("{id}")]
	[Authorize(Roles = "user")]
	public async Task<IActionResult> PutUser(int id, User user)
	{
		if (id != user.Id) return BadRequest();

		_context.Entry(user).State = EntityState.Modified;

		try
		{
			await _context.SaveChangesAsync();
		}
		catch (DbUpdateConcurrencyException)
		{
			if (!UserExists(id))
				return NotFound();
			throw;
		}

		return NoContent();
	}

	// POST: api/User
	// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
	[HttpPost]
	[Authorize(Roles = "user")]
	public async Task<ActionResult<User>> PostUser(UserCreationDto user)
	{
		if (_context.Users == null) return Problem("Entity set 'AppDbContext.Users'  is null.");

		var _user = _mapper.Map<User>(user);
		_context.Users.Add(_user);
		await _context.SaveChangesAsync();

		return CreatedAtAction("GetUser", new { id = _user.Id }, user);
	}

	// DELETE: api/User/5
	[HttpDelete("{id}")]
	[Authorize(Roles = "user")]
	public async Task<IActionResult> DeleteUser(int id)
	{
		if (_context.Users == null) return NotFound();
		var user = await _context.Users.FindAsync(id);
		if (user == null) return NotFound();

		_context.Users.Remove(user);
		await _context.SaveChangesAsync();

		return NoContent();
	}

	private bool UserExists(int id)
	{
		return (_context.Users?.Any(e => e.Id == id)).GetValueOrDefault();
	}
}