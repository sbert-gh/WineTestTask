using WineCatalog.Core.Models;

namespace WineCatalog.Core.Interfaces;

public interface IWineRepository
{
    /// <summary>
    /// Gets a wine by its ID or returns null if not found.
    /// </summary>
    /// <param name="id">The ID of the wine.</param>
    /// <returns>The wine with the specified ID or null.</returns>
    Task<Wine?> GetWineByIdOrDefault(int id);

    /// <summary>
    /// Gets all wines.
    /// </summary>
    /// <returns>A list of all wines.</returns>
    Task<List<Wine>> GetAllWine();

    /// <summary>
    /// Adds a new wine.
    /// </summary>
    /// <param name="wine">The wine to add.</param>
    /// <returns>The added wine.</returns>
    Task<Wine> AddWine(Wine wine);

    /// <summary>
    /// Updates an existing wine.
    /// </summary>
    /// <param name="wine">The wine to update.</param>
    Task<bool> UpdateWine(Wine wine);

    /// <summary>
    /// Deletes an wine.
    /// </summary>
    /// <param name="wine">The wine to delete.</param>
    Task<bool> DeleteWine(Wine wine);
}
