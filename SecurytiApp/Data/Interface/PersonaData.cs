using Entity.Dto;
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
    public class PersonaData : IPersonaData
    {

        private readonly ApplicationDbContext context;
        protected readonly IConfiguration configuration;

        public PersonaData(ApplicationDbContext context, IConfiguration configuration)
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
            context.personas.Remove(entity);
            await context.SaveChangesAsync();
        }
        public async Task<IEnumerable<DataSelectDto>> GetAllSelect()
        {
            var sql = @"SELECT 
                        Id,
                        nombre_de_usuario AS nombre_de_usuario 
                    FROM 
                        dbo.usuario
                    WHERE deleted_at IS NULL AND estado = 1
                    ORDER BY Id ASC";
            return await context.QueryAsync<DataSelectDto>(sql);
        }
        public async Task<Persona> GetById(int id)
        {
            var sql = @"SELECT * FROM dbo.personas WHERE Id = @Id ORDER BY Id ASC";
            return await context.QueryFirstOrDefaultAsync<Persona>(sql, new { Id = id });
        }

        public async Task<IEnumerable<PersonaDto>> GetAll()
        {
             var sql = @"SELECT 
                            Id,
                            primer_nombre,
                            segundo_nombre,
                            primer_apellido,
                            segundo_apellido,
                            correo,
                            genero,
                            documento,
                            tipo_de_documento,
                            direccion,
                            numero,
                            fecha_de_nacimiento,
                             created_at,
                            updated_at,
                            deleted_at,
                            estado 
                        FROM 
                            dbo.personas
                        WHERE deleted_at IS NULL AND estado = 1
                        ORDER BY Id ASC";
           return await context.QueryAsync<PersonaDto>(sql);
        }
        public async Task<Persona> Save(Persona entity)
        {
            context.personas.Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task Update(Persona entity)
        {//se cambio esto:context.Entry(entity).State = EntityState.Modified;
            context.personas.Update(entity);
            await context.SaveChangesAsync();
        }

    }
}
