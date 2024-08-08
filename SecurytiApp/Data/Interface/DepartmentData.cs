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
    public class DepartmentData : IDepartmentData
    {
        private readonly ApplicationDbContext context;
        protected readonly IConfiguration configuration;

        public DepartmentData(ApplicationDbContext context, IConfiguration configuration)
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
            context.Departments.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<DataSelectDto>> GetAllSelect()
        {
            var sql = @"SELECT Id, name AS name FROM dbo.Departments WHERE DeletedAt IS NULL AND State = 1 ORDER BY Id ASC";
            return await context.QueryAsync<DataSelectDto>(sql);
        }

        public async Task<Department> GetById(int id)
        {
            var sql = @"SELECT * FROM dbo.Departments WHERE Id = @Id ORDER BY Id ASC";
            return await context.QueryFirstOrDefaultAsync<Department>(sql, new { Id = id });
        }

        public async Task<IEnumerable<DepartmentDto>> GetAll()
        {
            var sql = @"SELECT Id,
             code,
              name,
               description,
                CountryId,
                 CreatedAt,
                  UpdatedAt,
                   DeletedAt,
                    state FROM dbo.Departments WHERE DeletedAt IS NULL AND State = 1 ORDER BY Id ASC";
            return await context.QueryAsync<DepartmentDto>(sql);
        }

        public async Task<Department> Save(Department entity)
        {
            context.Departments.Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task Update(Department entity)
        {
            context.Departments.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
