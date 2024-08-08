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
    public class CountryData : ICountryData
    {
        private readonly ApplicationDbContext context;
        protected readonly IConfiguration configuration;

        public CountryData(ApplicationDbContext context, IConfiguration configuration)
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
            entity.DeletedAt = DateTime.Parse(DateTime.Today.ToString());
            context.country.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<DataSelectDto>> GetAllSelect()
        {
            var sql = @"SELECT Id, Name AS Name FROM dbo.Countries WHERE DeletedAt IS NULL AND State = 1 ORDER BY Id ASC";
            return await context.QueryAsync<DataSelectDto>(sql);
        }

        public async Task<Country> GetById(int id)
        {
            var sql = @"SELECT * FROM dbo.Countries WHERE Id = @Id ORDER BY Id ASC";
            return await context.QueryFirstOrDefaultAsync<Country>(sql, new { Id = id });
        }

        public async Task<IEnumerable<CountryDto>> GetAll()
        {
            var sql = @"SELECT Id, code,
              name,
               description,
                CountryId,
                 CreatedAt,
                  UpdatedAt,
                   DeletedAt, State FROM dbo.Countries WHERE DeletedAt IS NULL AND State = 1 ORDER BY Id ASC";
            return await context.QueryAsync<CountryDto>(sql);
        }

        public async Task<Country> Save(Country entity)
        {
            context.country.Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task Update(Country entity)
        {
            context.country.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
