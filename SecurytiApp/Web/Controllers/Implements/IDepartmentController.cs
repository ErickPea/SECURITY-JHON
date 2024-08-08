using Entity.Dto;
using Entity.Model.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Web.Controllers.Implements
{
    public interface IDepartmentController
    {
        Task Delete(int id);
        Task<IEnumerable<DataSelectDto>> GetAllSelect();
        Task<IEnumerable<DepartmentDto>> GetAll();
        Task<ActionResult<DepartmentDto>> Save([FromBody] DepartmentDto entity);
        Task<DepartmentDto> GetById(int id);
        Task<IActionResult> Update(int id, [FromBody] DepartmentDto entity);
    }
}
