﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Dto
{
    public class DepartmentDto
    {
        public int Id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int countryId { get; set; }
    
        
        public bool state { get; set; }
    }
}
