using Microsoft.AspNetCore.Mvc;
using PropertyAPI.Models;
using PropertyAPI.Data;
using Microsoft.EntityFrameworkCore;


namespace PropertyAPI.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class PropertyController : ControllerBase
{
    private readonly PropertyDbContext _context;

    public PropertyController(PropertyDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Property>>> GetProperties()
    {
        try
        {
            var properties = await _context.Properties.ToListAsync();
            if (properties == null || !properties.Any())
            {
                return NotFound("No property found");
            }
            return Ok(properties);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"An error occurred: {ex.Message}");
        }
    }

    // Other CRUD operations (POST, PUT, DELETE) go here

    //[HttpGet("testdbconnection")]
    //public async Task<IActionResult> TestDbConnection()
    //{
    //    var conn = _context.Database.GetDbConnection();
    //    try
    //    {
    //        await conn.OpenAsync();
    //        await conn.CloseAsync();
    //        return Ok("Connected successfully.");
    //    }
    //    catch (Exception ex)
    //    {
    //        return StatusCode(500, $"An error occurred: {ex.Message}");
    //    }
    //}


    //[HttpGet("testdb")]
    //public async Task<IActionResult> TestDatabaseConnection()
    //{
    //    try
    //    {
    //        var newProperty = new Property { PropertyID = 14, PropertyName = "Test", Price = 1000 };
    //        _context.Properties.Add(newProperty);
    //        await _context.SaveChangesAsync();

    //        var property = await _context.Properties.FindAsync(newProperty.PropertyID);
    //        if (property != null)
    //        {
    //            return Ok("Database connection is fine!");
    //        }
    //        return NotFound("Test property not found");
    //    }
    //    catch (Exception ex)
    //    {
    //        // Log exception
    //        return StatusCode(500, $"An error occurred: {ex.Message}");
    //    }
    //}
}

