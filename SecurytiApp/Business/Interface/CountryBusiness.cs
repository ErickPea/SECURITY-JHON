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
    public class CountryBusiness : ICountryBusiness
    {
        private readonly ICountryData data;

        public CountryBusiness(ICountryData data)
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

        public async Task<CountryDto> GetById(int id)
        {
            Country country = await data.GetById(id);
            CountryDto countryDto = new CountryDto();

            countryDto.Id = country.Id;
            countryDto.code = country.Code;
            countryDto.name = country.Name;
            countryDto.description = country.Description;
            countryDto.continentId = country.ContinentId;
            
            countryDto.State = country.State;

            return countryDto;
        }

        public async Task<Country> Save(CountryDto entity)
        {
            Country country = new Country();
            country = mapearDatos(country, entity);

            return await data.Save(country);
        }

        public async Task Update(int id, CountryDto entity)
        {
            Country country = await data.GetById(id);
            if (country == null)
            {
                throw new Exception("Registro no encontrado");
            }
            country = mapearDatos(country, entity);

            await data.Update(country);
        }

        public async Task<IEnumerable<CountryDto>> GetAll()
        {
            return await data.GetAll();
        }

        private Country mapearDatos(Country country, CountryDto entity)
        {
            country.Id = entity.Id;
            country.Code = entity.code;
            country.Name = entity.name;
            country.Description = entity.description;
            country.ContinentId = entity.continentId;
            
            country.State = entity.State;

            return country;
        }
    }
}


