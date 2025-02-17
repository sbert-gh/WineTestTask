using Microsoft.EntityFrameworkCore;
using WineCatalog.Core.Interfaces;
using WineCatalog.Core.Models;

namespace WineCatalog.Infrastructure.Repositories;

public class WineRepository : IWineRepository
{
    private readonly WineDbContext _context;
    public WineRepository(WineDbContext context)
    {
        _context = context;
    }

    public async Task<Wine?> GetWineByIdOrDefault(int id)
    {
        return await _context.Wines
            .FirstOrDefaultAsync(w => w.Id == id);
    }

    public async Task<List<Wine>> GetAllWine()
    {
        return await _context.Wines.ToListAsync();
    }

    public async Task<Wine> AddWine(Wine wine)
    {
        await _context.AddAsync(wine);
        await _context.SaveChangesAsync();
        return wine;
    }

    public async Task<bool> UpdateWine(Wine wine)
    {
        _context.Update(wine);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteWine(Wine wine)
    {
        _context.Remove(wine);
        return await _context.SaveChangesAsync() > 0;
    }
}
