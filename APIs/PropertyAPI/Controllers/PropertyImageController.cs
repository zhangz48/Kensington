using Microsoft.AspNetCore.Mvc;
using PropertyAPI.Models;
using PropertyAPI.Data;
using Microsoft.EntityFrameworkCore;


namespace PropertyAPI.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class PropertyImageController : ControllerBase
{
    private readonly PropertyDbContext _context;

    public PropertyImageController(PropertyDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<PropertyImage>>> GetPropertyImages()
    {
        try
        {
            var propertyImages = await _context.PropertyImages.ToListAsync();
            if (propertyImages == null || !propertyImages.Any())
            {
                return NotFound("No property image found");
            }
            return Ok(propertyImages);
        }
        catch (Exception ex)
        {
            // Log the exception as needed
            return StatusCode(500, $"An error occurred: {ex.Message}");
        }
    }

    // Other CRUD operations (POST, PUT, DELETE) go here
}

