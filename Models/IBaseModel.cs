using Microsoft.EntityFrameworkCore;
using StarFitApi.Models.Dto;

namespace StarFitApi.Models;

public interface IBaseModel<T, in TCreateDto, in TUpdateDto>
where T : class
where TCreateDto : IDataTransferObject
where TUpdateDto : IDataTransferObject
{
    public static abstract DbSet<T> GetDbSet(DataContext context);

    public static abstract T Create(TCreateDto createDto);
    public T Update(TUpdateDto updateDto);
}