﻿using Entity.Dto;
using Data.Implementation;
using Entity.Model.Context;
using Entity.Model.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interface
{
    public class RolData : IRolData
    {


        private readonly ApplicationDbContext context;
        protected readonly IConfiguration configuration;

        public RolData(ApplicationDbContext context, IConfiguration configuration)
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
            entity.deleted_at = DateTime.Parse(DateTime.Today.ToString());
            context.rol.Remove(entity);
            await context.SaveChangesAsync();
        }
        public async Task<IEnumerable<DataSelectDto>> GetAllSelect()
        {
            var sql = @"SELECT 
                        Id,
                        nombre AS nombre 
                    FROM 
                        dbo.rol
                    WHERE deleted_at IS NULL AND Estado = 1
                    ORDER BY Id ASC";
            return await context.QueryAsync<DataSelectDto>(sql);
        }

        public async Task<Rol> GetById(int id)
        {
            var sql = @"SELECT * FROM dbo.rol WHERE Id = @Id ORDER BY Id ASC";
            return await context.QueryFirstOrDefaultAsync<Rol>(sql, new { Id = id });
        }

        public async Task<Rol> Save(Rol entity)
        {
            context.rol.Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task Update(Rol entity)
        {
            context.rol.Update(entity);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<RolDto>> GetAll()
        {
            var sql = @"SELECT 
                            Id,
                            nombre,
                            descripcion,
                            created_at,
                            updated_at,
                            deleted_at,
                            State 
                        FROM 
                            dbo.rol
                        WHERE deleted_at IS NULL AND State = 1
                        ORDER BY Id ASC";
            return await context.QueryAsync<RolDto>(sql);
        }
    }
}
