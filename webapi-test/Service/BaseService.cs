using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi_test.Service.Contract;
using webapi_test.Dto;
using webapi_test.Repository.Contract;
using webapi_test.Service.Response;
using webapi_test.Service.Request;

namespace webapi_test.Service
{
    public abstract class BaseService<TDto, TDtoType, TRepository> : IBaseService<TDto, TDtoType>
        where TDto : BaseDto<TDtoType>
        where TRepository : IBaseRepository<TDto>
    {
        protected readonly TRepository _repository;

        protected BaseService(TRepository repository)
        {
            _repository = repository;
        }

        public virtual async Task DeleteAsync(GenericRequest<TDtoType> request)
        {
            await _repository.DeleteAsync(request.Data);
        }

        public virtual async Task<GenericResponse<TDto>> CreateAsync(GenericRequest<TDto> request)
        {
            var response = new GenericResponse<TDto>();
            var result = await _repository.CreateAsync(request.Data);

            if (result == null) {
                response.AddErrorMessage("Failed creating data");
            }

            response.Data = result;
            return response;
        }

        public virtual async Task<GenericResponse<ICollection<TDto>>> ReadAllAsync()
        {
            var response = new GenericResponse<ICollection<TDto>>();
            var result = await _repository.ReadAllAsync();
            response.Data = result;
            return response;
        }

        public virtual async Task<GenericResponse<TDto>> ReadAsync(GenericRequest<TDtoType> request)
        {
            var response = new GenericResponse<TDto>();
            var result = await _repository.ReadAsync(request.Data);
            response.Data = result;
            return response;
        }

        public virtual async Task<GenericResponse<TDto>> UpdateAsync(GenericRequest<TDto> request)
        {
            var response = new GenericResponse<TDto>();
            var result = await _repository.UpdateAsync(request.Data);
            response.Data = result;
            return response;
        }
    }
}