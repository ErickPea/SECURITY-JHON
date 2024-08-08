using Entity.Dto;
using Entity.Model.Dto;
using Entity.Model.Security;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Interface
{
    public interface IDepartmentData
    {
        Task Delete(int id);
        Task<IEnumerable<DataSelectDto>> GetAllSelect();
        Task<IEnumerable<DepartmentDto>> GetAll();
        Task<Department> Save(Department entity);
        Task Update(Department entity);
        Task<Department> GetById(int id);
    }
}
