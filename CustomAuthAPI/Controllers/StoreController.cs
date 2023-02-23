using AutoMapper;
using CustomAuthAPI.Models;
using CustomAuthAPI.Models.DTOs.Incoming;
using CustomAuthAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CustomAuthAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StoreController : ControllerBase
{
	private readonly AppDbContext _context;
	private readonly IMapper _mapper;

	public StoreController(AppDbContext context, IMapper mapper)
	{
		_context = context;
		_mapper = mapper;
	}

	// GET: api/Store
	[HttpGet]
	public async Task<ActionResult<IEnumerable<Store>>> GetStores()
	{
		if (_context.Stores == null) return NotFound();
		return await _context.Stores.ToListAsync();
	}

	// GET: api/Store/5
	[HttpGet("{id}")]
	public async Task<ActionResult<Store>> GetStore(int id)
	{
		if (_context.Stores == null) return NotFound();
		var store = await _context.Stores.FindAsync(id);

		if (store == null) return NotFound();

		return store;
	}

	// PUT: api/Store/5
	// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
	[HttpPut("{id}")]
	public async Task<IActionResult> PutStore(int id, Store store)
	{
		if (id != store.UniqueStoreId) return BadRequest();

		_context.Entry(store).State = EntityState.Modified;

		try
		{
			await _context.SaveChangesAsync();
		}
		catch (DbUpdateConcurrencyException)
		{
			if (!StoreExists(id))
				return NotFound();
			throw;
		}

		return NoContent();
	}

	// POST: api/Store
	// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
	[HttpPost]
	public async Task<ActionResult<Store>> PostStore(StoreCreationDto store)
	{
		if (_context.Stores == null) return Problem("Entity set 'AppDbContext.Stores'  is null.");

		var _store = _mapper.Map<Store>(store);
		_context.Stores.Add(_store);
		await _context.SaveChangesAsync();

		return CreatedAtAction("GetStore", new { id = _store.UniqueStoreId }, store);
	}

	// DELETE: api/Store/5
	[HttpDelete("{id}")]
	public async Task<IActionResult> DeleteStore(int id)
	{
		if (_context.Stores == null) return NotFound();
		var store = await _context.Stores.FindAsync(id);
		if (store == null) return NotFound();

		_context.Stores.Remove(store);
		await _context.SaveChangesAsync();

		return NoContent();
	}

	private bool StoreExists(int id)
	{
		return (_context.Stores?.Any(e => e.UniqueStoreId == id)).GetValueOrDefault();
	}
}