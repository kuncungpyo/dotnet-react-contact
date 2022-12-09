namespace webapi_test.Repository.Contract
{
    public interface IBaseRepository<TDto>
    {
        Task<TDto> CreateAsync(TDto dto);
        Task<ICollection<TDto>> ReadAllAsync();
        Task<TDto> ReadAsync(object primaryKey);
        Task<TDto> UpdateAsync(TDto dto);
        Task DeleteAsync(object primaryKey);
    }
}