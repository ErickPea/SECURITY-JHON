using Entity.Dto;
using Entity.Model.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Web.Controllers.Implements
{
    public interface IContinentController
    {
        Task Delete(int id);
        Task<IEnumerable<DataSelectDto>> GetAllSelect();
        Task<IEnumerable<ContinentDto>> GetAll();
        Task<ActionResult<ContinentDto>> Save([FromBody] ContinentDto entity);
        Task<ContinentDto> GetById(int id);
        Task<IActionResult> Update(int id, [FromBody] ContinentDto entity);
    }
}
