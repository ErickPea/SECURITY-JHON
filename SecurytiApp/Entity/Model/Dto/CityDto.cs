using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Dto
{
    public class CityDto
    {

        public int Id { get; set; }
        public string code { get; set; }
        public string description { get; set; }
        public int departmentId { get; set; }
         public DateTime createdAt { get; set; }
        public DateTime? deletedAt { get; set; }
        public DateTime updatedAt { get; set; }

        public bool State { get; set; }
    }
}
