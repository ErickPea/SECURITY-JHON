using Entity.Dto;
using Entity.Model.Dto;
using Entity.Model.Security;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Interface
{
    public interface ICountryData
    {
        Task Delete(int id);
        Task<IEnumerable<DataSelectDto>> GetAllSelect();
        Task<IEnumerable<CountryDto>> GetAll();
        Task<Country> Save(Country entity);
        Task Update(Country entity);
        Task<Country> GetById(int id);
    }
}
