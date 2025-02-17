using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WineCatalog.Core.Models;
using WineCatalog.Core.Services;

namespace WineCatalog.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WinesController : ControllerBase
{
    private readonly ILogger<WinesController> _logger;
    private readonly WineService _wineService;

    public WinesController(ILogger<WinesController> logger, WineService wineService)
    {
        _logger = logger;
        _wineService = wineService;
    }

    [HttpPost]
    public async Task<IActionResult> Create(WineDto dto)
    {
        _logger.LogInformation("Creating new Wine");
        var wine = await _wineService.CreateWine(dto);
        _logger.LogInformation("New Wine created, ID: {0}", wine.Id);
        return CreatedAtAction(nameof(Create), wine);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        _logger.LogInformation("Getting all Wines");
        var result = await _wineService.GetAllWines();
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        _logger.LogInformation("Getting Wine by ID: {0}", id);
        var result = await _wineService.GetWine(id);
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, WineDto dto)
    {
        _logger.LogInformation("Updating Wine with ID: {0}", id);
        await _wineService.UpdateWine(id, dto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    [Authorize]
    public async Task<IActionResult> Delete(int id)
    {
        _logger.LogInformation("Deleting Wine with ID: {0}", id);
        await _wineService.DeleteWine(id);
        return NoContent();
    }
}
