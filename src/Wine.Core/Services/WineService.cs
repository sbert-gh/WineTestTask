using AutoMapper;
using WineCatalog.Core.Exceptions;
using WineCatalog.Core.Interfaces;
using WineCatalog.Core.Models;

namespace WineCatalog.Core.Services;

public class WineService
{
    private readonly IWineRepository _repository;
    private readonly IMapper _mapper;

    public WineService(IWineRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<Wine> CreateWine(WineDto wineDto)
    {
        ArgumentNullException.ThrowIfNull(wineDto);

        var wine = _mapper.Map<Wine>(wineDto);
        return await _repository.AddWine(wine);
    }

    public async Task<List<WineDto>> GetAllWines()
    {
        var wines = await _repository.GetAllWine();
        return _mapper.Map<List<WineDto>>(wines);
    }

    public async Task<WineDto> GetWine(int id)
    {
        var wine = await _repository.GetWineByIdOrDefault(id)
            ?? throw new WineNotFoundException();
        return _mapper.Map<WineDto>(wine);
    }

    public async Task<bool> UpdateWine(int id, WineDto wineDto)
    {
        ArgumentNullException.ThrowIfNull(wineDto);

        var wine = await _repository.GetWineByIdOrDefault(id)
            ?? throw new WineNotFoundException();
        _mapper.Map(wineDto, wine);
        return await _repository.UpdateWine(wine);
    }

    public async Task<bool> DeleteWine(int id)
    {
        var wine = await _repository.GetWineByIdOrDefault(id)
            ?? throw new WineNotFoundException();
        return await _repository.DeleteWine(wine);
    }
}
