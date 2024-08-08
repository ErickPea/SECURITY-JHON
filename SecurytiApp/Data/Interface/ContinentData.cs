using Entity.Dto;
using Entity.Model.Security;
using Entity.Model.Context;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Model.Dto;

namespace Data.Interface
{
    public class ContinentData
    {

        private readonly ApplicationDbContext context;
        protected readonly IConfiguration configuration;

        public ContinentData(ApplicationDbContext context, IConfiguration configuration)
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
            entity.Deleted_At = DateTime.Parse(DateTime.Today.ToString());
            context.Continent.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<DataSelectDto>> GetAllSelect()
        {
            var sql = @"SELECT Id, Name AS Name FROM dbo.Continents WHERE DeletedAt IS NULL AND State = 1 ORDER BY Id ASC";
            return await context.QueryAsync<DataSelectDto>(sql);
        }

        public async Task<Continent> GetById(int id)
        {
            var sql = @"SELECT * FROM dbo.Continents WHERE Id = @Id ORDER BY Id ASC";
            return await context.QueryFirstOrDefaultAsync<Continent>(sql, new { Id = id });
        }

        public async Task<IEnumerable<ContinentDto>> GetAll()
        {
            var sql = @"SELECT Id, code,
              name,
               description,
                CountryId,
                 CreatedAt,
                  UpdatedAt,
                   DeletedAt, State FROM dbo.Continents WHERE DeletedAt IS NULL AND State = 1 ORDER BY Id ASC";
            return await context.QueryAsync<ContinentDto>(sql);
        }

        public async Task<Continent> Save(Continent entity)
        {
            context.Continent.Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task Update(Continent entity)
        {
            context.Continent.Update(entity);
            await context.SaveChangesAsync();
        }
    
}
}
