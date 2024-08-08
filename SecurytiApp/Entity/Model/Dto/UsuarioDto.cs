using Entity.Model.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dto
{
    public class UsuarioDto
    {
        public int Id { get; set; }
        public string Nombre_De_Usuario { get; set; }
        public string Contraseña { get; set; }
        public int Persona_id { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
        public DateTime Deleted_at { get; set; }
        public Boolean Estado { get; set; }
    }

}
