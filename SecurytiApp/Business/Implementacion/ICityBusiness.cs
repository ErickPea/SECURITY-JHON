
using Entity.Dto;
using Entity.Model.Dto;
using Entity.Model.Security;

namespace Business.Implementacion
{
    public interface ICityBusiness
    {
        Task Delete(int id);
        Task<IEnumerable<DataSelectDto>> GetAllSelect();
        Task<IEnumerable<CityDto>> GetAll();
        Task<City> Save(CityDto entity);
        Task Update(int id, CityDto entity);
        Task<CityDto> GetById(int id);
    }

   
}