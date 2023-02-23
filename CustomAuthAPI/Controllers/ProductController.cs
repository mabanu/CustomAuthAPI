using AutoMapper;
using CustomAuthAPI.Models;
using CustomAuthAPI.Models.DTOs.Incoming;
using CustomAuthAPI.Models.DTOs.Outgoing;
using CustomAuthAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CustomAuthAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
	private readonly AppDbContext _context;
	private readonly IMapper _mapper;

	public ProductController(AppDbContext context, IMapper mapper)
	{
		_context = context;
		_mapper = mapper;
	}

	// GET: api/Product
	[HttpGet]
	public async Task<ActionResult<IEnumerable<ProductDto>>> GetProducts()
	{
		if (_context.Products == null) return NotFound();
		
		var allProduct = await _context.Products.ToListAsync();
		var _products = _mapper.Map<IEnumerable<ProductDto>>(allProduct);
		return Ok(_products);
	}

	// GET: api/Product/5
	[HttpGet("{id}")]
	public async Task<ActionResult<ProductDto>> GetProduct(int id)
	{
		if (_context.Products == null) return NotFound();
		var product = await _context.Products.FindAsync(id);

		if (product == null) return NotFound();

		var _product = _mapper.Map<ProductDto>(product);
		return Ok(_product);
	}

	// PUT: api/Product/5
	// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
	[HttpPut("{id}")]
	public async Task<IActionResult> PutProduct(int id, ProductUpdateDto product)
	{
		if (id != product.Id) return BadRequest();

		var _product = _mapper.Map<Product>(product);
		_context.Entry(_product).State = EntityState.Modified;

		try
		{
			await _context.SaveChangesAsync();
		}
		catch (DbUpdateConcurrencyException)
		{
			if (!ProductExists(id))
				return NotFound();
			throw;
		}

		return NoContent();
	}

	// POST: api/Product
	// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
	[HttpPost]
	public async Task<ActionResult<Product>> PostProduct(ProductCreationDto product)
	{
		if (_context.Products == null) return Problem("Entity set 'AppDbContext.Products'  is null.");

		var _product = _mapper.Map<Product>(product);
		_context.Products.Add(_product);
		await _context.SaveChangesAsync();

		return CreatedAtAction("GetProduct", new { id = _product.Id }, _product);
	}

	// DELETE: api/Product/5
	[HttpDelete("{id}")]
	public async Task<IActionResult> DeleteProduct(int id)
	{
		if (_context.Products == null) return NotFound();
		var product = await _context.Products.FindAsync(id);
		if (product == null) return NotFound();

		_context.Products.Remove(product);
		await _context.SaveChangesAsync();

		return NoContent();
	}

	private bool ProductExists(int id)
	{
		return (_context.Products?.Any(e => e.Id == id)).GetValueOrDefault();
	}
}