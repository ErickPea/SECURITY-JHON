using Business.Implementacion;
using Data.Implementation;
using Data.Interface;
using Entity.Dto;
using Entity.Model.Dto;
using Entity.Model.Security;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Interface
{
    public class CityBusiness : ICityBusiness
    {
        private readonly ICityData data;

        public CityBusiness(ICityData data)
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

        public async Task<CityDto> GetById(int id)
        {
            City city = await data.GetById(id);
            CityDto cityDto = new CityDto();

            cityDto.Id = city.Id;
            cityDto.code = city.Code;
            cityDto.description = city.Description;
            cityDto.departmentId = city.DepartmentId;
         
            cityDto.State = city.State;

            return cityDto;
        }

        public async Task<City> Save(CityDto entity)
        {
            City city = new City();
            city = mapearDatos(city, entity);

            return await data.Save(city);
        }

        public async Task Update(int id, CityDto entity)
        {
            City city = await data.GetById(id);
            if (city == null)
            {
                throw new Exception("Registro no encontrado");
            }
            city = mapearDatos(city, entity);

            await data.Update(city);
        }

        public async Task<IEnumerable<CityDto>> GetAll()
        {
            return await data.GetAll();
        }

        private City mapearDatos(City city, CityDto entity)
        {
            city.Id = entity.Id;
            city.Code = entity.code;
            city.Description = entity.description;
            city.DepartmentId = entity.departmentId;
          
            city.State = entity.State;

            return city;
        }
    }
}

