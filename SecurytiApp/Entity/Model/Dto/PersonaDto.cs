using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dto
{
    public class PersonaDto
    {
        public int Id { get; set; }
        public string Primer_Nombre { get; set; }
        public string Segundo_Nombre { get; set; }
        public string Primer_Apellido { get; set; }
        public string Segundo_Apellido { get; set; }
        public string Correo { get; set; }
        public DateTime Fecha_De_Nacimiento { get; set; }
        public string Genero { get; set; }
        public string Direccion { get; set; }
        public string Tipo_De_Documento { get; set; }
        public string Documento { get; set; }
        public string Numero { get; set; }



        public Boolean Estado { get; set; }

    }
}
