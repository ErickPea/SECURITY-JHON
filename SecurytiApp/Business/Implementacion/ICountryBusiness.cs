using Entity.Dto;
using Entity.Model.Dto;
using Entity.Model.Security;

namespace Business.Implementacion
{
    public interface ICountryBusiness
    {
        Task Delete(int id);
        Task<IEnumerable<DataSelectDto>> GetAllSelect();
        Task<IEnumerable<CountryDto>> GetAll();
        Task<Country> Save(CountryDto entity);
        Task Update(int id, CountryDto entity);
        Task<CountryDto> GetById(int id);
    }
}