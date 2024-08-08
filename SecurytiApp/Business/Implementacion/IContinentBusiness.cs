using Entity.Dto;
using Entity.Model.Dto;
using Entity.Model.Security;

namespace Business.Implementacion
{
    public interface IContinentBusiness
    {
        Task Delete(int id);
        Task<IEnumerable<DataSelectDto>> GetAllSelect();
        Task<IEnumerable<ContinentDto>> GetAll();
        Task<Continent> Save(ContinentDto entity);
        Task Update(int id, ContinentDto entity);
        Task<ContinentDto> GetById(int id);
    }
}