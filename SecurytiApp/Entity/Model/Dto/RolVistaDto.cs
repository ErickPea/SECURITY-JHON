using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dto
{
    public class RolVistaDto
    {
        public int Id { get; set; }
        public int rolId { get; set; } 
        public int vistaId { get; set; }


        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
        public DateTime Deleted_at { get; set; }
    

        public Boolean State { get; set; }
    }
}
