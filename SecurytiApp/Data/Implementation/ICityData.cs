using Entity.Dto;
using Entity.Model.Dto;
using Entity.Model.Security;


namespace Data.Interface
{
    public interface ICityData
    {
        Task Delete(int id);
        Task<IEnumerable<DataSelectDto>> GetAllSelect();
        Task<IEnumerable<CityDto>> GetAll();
        Task<City> Save(City entity);
        Task Update(City entity);
        Task<City> GetById(int id);
    }
}
