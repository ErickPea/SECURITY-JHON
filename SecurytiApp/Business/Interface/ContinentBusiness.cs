using Business.Implementacion;
using Data.Implementation;
using Entity.Dto;
using Entity.Model.Dto;

using Entity.Model.Security;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Interface
{
    public class ContinentBusiness : IContinentBusiness
    {
        private readonly IContinentData data;

        public ContinentBusiness(IContinentData data)
        {
            this.data = data;
        }

        public async Task Delete(int id)
        {
            await data.Delete(id);
        }

        public async Task<IEnumerable<DataSelectDto>> GetAllSelect()
        {
            return await data.GetAllSelect();
        }

        public async Task<ContinentDto> GetById(int id)
        {
            Continent continent = await data.GetById(id);
            ContinentDto continentDto = new ContinentDto();

            continentDto.Id = continent.Id;
            continentDto.Code = continent.Code;
            continentDto.Name = continent.Name;
            continentDto.Description = continent.Description;
            continentDto.CreatedAt = continent.Created_At;
            continentDto.UpdatedAt = continent.Updated_At;
            continentDto.DeletedAt = continent.Deleted_At;
            continentDto.State = continent.State;

            return continentDto;
        }

        public async Task<Continent> Save(ContinentDto entity)
        {
            Continent continent = new Continent();
            continent = mapearDatos(continent, entity);

            return await data.Save(continent);
        }

        public async Task Update(int id, ContinentDto entity)
        {
            Continent continent = await data.GetById(id);
            if (continent == null)
            {
                throw new Exception("Registro no encontrado");
            }
            continent = mapearDatos(continent, entity);

            await data.Update(continent);
        }

        public async Task<IEnumerable<ContinentDto>> GetAll()
        {
            return await data.GetAll();
        }

        private Continent mapearDatos(Continent continent, ContinentDto entity)
        {
            continent.Id = entity.Id;
            continent.Code = entity.Code;
            continent.Name = entity.Name;
            continent.Description = entity.Description;
            continent.Created_At = entity.CreatedAt;
            continent.Updated_At = entity.UpdatedAt;
            continent.Deleted_At = entity.DeletedAt;
            continent.State = entity.State;

            return continent;
        }
    }
}


