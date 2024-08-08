using Entity.Dto;
using Entity.Model.Dto;
using Entity.Model.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementation
{
    public interface IContinentData
    {
        Task Delete(int id);
        Task<IEnumerable<DataSelectDto>> GetAllSelect();
        Task<IEnumerable<ContinentDto>> GetAll();
        Task<Continent> Save(Continent entity);
        Task Update(Continent entity);
        Task<Continent> GetById(int id);
    }
}
