using Entity.Dto;
using Entity.Model.Dto;
using Entity.Model.Security;

namespace Business.Implementacion
{
    public interface IDepartmentBusiness
    {
        Task Delete(int id);
        Task<IEnumerable<DataSelectDto>> GetAllSelect();
        Task<IEnumerable<DepartmentDto>> GetAll();
        Task<Department> Save(DepartmentDto entity);
        Task Update(int id, DepartmentDto entity);
        Task<DepartmentDto> GetById(int id);
    }
}