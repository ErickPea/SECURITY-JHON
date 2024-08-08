using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Dto
{
    public class CountryDto
    {
        public int Id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    public int continentId { get; set; }
        public bool State { get; set; }
    }
}
