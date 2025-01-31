﻿using Entity.Dto;
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
    public class RolVistaData
    {
        private readonly ApplicationDbContext context;
        protected readonly IConfiguration configuration;

        public RolVistaData(ApplicationDbContext context, IConfiguration configuration)
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
            context.rol_vista.Remove(entity);
            await context.SaveChangesAsync();
        }
        public async Task<IEnumerable<DataSelectDto>> GetAllSelect()
        {
            var sql = @"SELECT 
                        Id,
                        nombre AS Nombre 
                    FROM 
                        dbo.usuario
                    WHERE deleted_at IS NULL AND Estado = 1
                    ORDER BY Id ASC";
            return await context.QueryAsync<DataSelectDto>(sql);
        }
        public async Task<Rol_Vista> GetById(int id)
        {
            var sql = @"SELECT * FROM dbo.rol_vista WHERE Id = @Id ORDER BY Id ASC";
            return await context.QueryFirstOrDefaultAsync<Rol_Vista>(sql, new { Id = id });
        }

        public async Task<IEnumerable<RolVistaDto>> GetAll()
        {
            var sql = @"SELECT 
                            Id,
                            RolId,
                            VistaId
                        FROM 
                            dbo.rol_vista
                        WHERE deleted_at IS NULL AND State = 1
                        ORDER BY Id ASC";
            return await context.QueryAsync<RolVistaDto>(sql);
        }
        public async Task<Rol_Vista> Save(Rol_Vista entity)
        {
            context.rol_vista.Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task Update(Rol_Vista entity)
        {
            context.rol_vista.Update(entity);
            await context.SaveChangesAsync();
        }

    }
}

