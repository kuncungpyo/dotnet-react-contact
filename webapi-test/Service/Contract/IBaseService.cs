using webapi_test.Service.Request;
using webapi_test.Service.Response;

namespace webapi_test.Service.Contract
{
    public interface IBaseService<TDto, TDtoType>
    {
        Task<GenericResponse<TDto>> CreateAsync(GenericRequest<TDto> request);

        Task<GenericResponse<TDto>> ReadAsync(GenericRequest<TDtoType> request);

        Task<GenericResponse<ICollection<TDto>>> ReadAllAsync();

        Task<GenericResponse<TDto>> UpdateAsync(GenericRequest<TDto> request);

        Task DeleteAsync(GenericRequest<TDtoType> request);
    }
}