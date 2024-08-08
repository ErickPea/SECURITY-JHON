using Entity.Dto;
using Entity.Model.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Web.Controllers.Implements
{
    public interface ICityController
    {
        Task Delete(int id);
        Task<IEnumerable<DataSelectDto>> GetAllSelect();
        Task<IEnumerable<CityDto>> GetAll();
        Task<ActionResult<CityDto>> Save([FromBody] CityDto entity);
        Task<CityDto> GetById(int id);
        Task<IActionResult> Update(int id, [FromBody] CityDto entity);
    }
}
