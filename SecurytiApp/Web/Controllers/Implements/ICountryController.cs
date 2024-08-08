using Entity.Dto;
using Entity.Model.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Web.Controllers.Implements
{
    public interface ICountryController
    {
        Task Delete(int id);
        Task<IEnumerable<DataSelectDto>> GetAllSelect();
        Task<IEnumerable<CountryDto>> GetAll();
        Task<ActionResult<CountryDto>> Save([FromBody] CountryDto entity);
        Task<CountryDto> GetById(int id);
        Task<IActionResult> Update(int id, [FromBody] CountryDto entity);
    }
}
