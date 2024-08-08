using Data.Interface;
using Entity.Dto;
using Entity.Model.Context;
using Entity.Model.Dto;
using Entity.Model.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Implementation
{
    public class CityData : ICityData
    {
        private readonly ApplicationDbContext context;
        protected readonly IConfiguration configuration;

        public CityData(ApplicationDbContext context, IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);
            if (entity == null)
            {
                throw new Exception("Registro no encontrado");
            }
            entity.DeletedAt = DateTime.UtcNow;
            context.city.Update(entity);  // Cambié Remove por Update para la eliminación lógica
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<DataSelectDto>> GetAllSelect()
        {
            var sql = @"SELECT Id, Description AS Name FROM dbo.Cities WHERE Deleted_At IS NULL";
            var result = await context.Set<DataSelectDto>().FromSqlRaw(sql).ToListAsync();
            return result;
        }

        public async Task<IEnumerable<CityDto>> GetAll()
        {
            var cities = await context.city
                .Where(c => c.DeletedAt == null)
                .ToListAsync();

            var cityDtos = new List<CityDto>();
            foreach (var city in cities)
            {
                var dto = new CityDto
                {
                    Id = city.Id,
                    code = city.Code,
                    description = city.Description,
                    departmentId = city.DepartmentId,
                    createdAt = city.CreatedAt,
                    updatedAt = city.UpdatedAt,
                    deletedAt = city.DeletedAt,
                    State = city.State
                };
                cityDtos.Add(dto);
            }

            return cityDtos;
        }

        public async Task<City> GetById(int id)
        {
            return await context.city
                .FirstOrDefaultAsync(c => c.Id == id && c.DeletedAt == null);
        }

        public async Task<City> Save(City entity)
        {
            entity.CreatedAt = DateTime.UtcNow;
            context.city.Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task Update(City entity)
        {
            var existingEntity = await GetById(entity.Id);
            if (existingEntity == null)
            {
                throw new Exception("Registro no encontrado");
            }

            existingEntity.Code = entity.Code;
            existingEntity.Description = entity.Description;
            existingEntity.DepartmentId = entity.DepartmentId;
            existingEntity.UpdatedAt = DateTime.UtcNow;
            existingEntity.State = entity.State;

            context.city.Update(existingEntity);
            await context.SaveChangesAsync();
        }
    }
}
