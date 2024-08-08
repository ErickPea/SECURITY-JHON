using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Security
{
    public class City
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int DepartmentId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string DeletedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public bool State { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<Persona> Personas { get; set; }
    }
}
