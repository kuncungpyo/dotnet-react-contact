using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi_test.Repository.Contract;
using webapi_test.Dto;

namespace webapi_test.Repository
{
    public abstract class BaseRepository<TDto, TDtoType> : IBaseRepository<TDto>
        where TDto : BaseDto<TDtoType>, new()
    {
        // This should be a db context in real project if using EF
        // For prototyping purposes, I use static list to store entities and reused in every child repo
        protected static List<TDto> Entities = new List<TDto>();

        public virtual async Task<TDto> CreateAsync(TDto dto)
        {
            Entities.Add(dto);
            return dto;
        }

        public virtual async Task DeleteAsync(object primaryKey)
        {
            var dto = Entities.FirstOrDefault(e => EqualityComparer<TDtoType>.Default.Equals(e.Id,(TDtoType)primaryKey));
            if (dto != null) {
                Entities.Remove(dto);
            }       
        }

        public virtual async Task<ICollection<TDto>> ReadAllAsync()
        {
            return Entities.ToList();
        }

        public virtual async Task<TDto> ReadAsync(object primaryKey)
        {
            var dto = Entities.FirstOrDefault(e => EqualityComparer<TDtoType>.Default.Equals(e.Id,(TDtoType)primaryKey));
            return dto;
        }

        public virtual async Task<TDto> UpdateAsync(TDto dto)
        {
            var d = Entities.FirstOrDefault(e => EqualityComparer<TDtoType>.Default.Equals(e.Id, dto.Id));
            if (d != null) {
                Entities.Remove(d);
                Entities.Add(dto);
            }
            return dto;
        }
    }
}