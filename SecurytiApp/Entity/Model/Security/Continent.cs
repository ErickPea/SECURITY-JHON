using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Security
{
    public class Continent
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created_At { get; set; }
        public string Created_By { get; set; }
        public DateTime? Deleted_At { get; set; }
        public string Deleted_By { get; set; }
        public DateTime Updated_At { get; set; }
        public string Updated_By { get; set; }
        public bool State { get; set; }

        public virtual ICollection<Country> countries { get; set; }
    }
}
