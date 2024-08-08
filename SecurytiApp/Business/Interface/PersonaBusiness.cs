using Business.Implementacion;
using Data.Implementation;
using Entity.Dto;
using Entity.Model.Security;


namespace Business.Interface
{
    public class PersonaBusiness : IPersonaBusiness
    {
        private readonly IPersonaData data;

        public PersonaBusiness(IPersonaData data)
        {
            this.data = data;
        }

        public async Task Delete(int id)
        {
            await data.Delete(id);
        }

        public async Task<IEnumerable<DataSelectDto>> GetAllSelect()
        {
            return await data.GetAllSelect();
        }

        public async Task<PersonaDto> GetById(int id)
        {
            Persona persona = await data.GetById(id);
            PersonaDto personaDto = new PersonaDto();

            personaDto.Id = persona.Id;
            personaDto.Primer_Nombre = persona.primer_nombre;
            personaDto.Segundo_Nombre = persona.segundo_nombre;
            personaDto.Primer_Apellido = persona.primer_apellido;
            personaDto.Segundo_Apellido = persona.segundo_apellido;
            personaDto.Correo = persona.correo;
            personaDto.Fecha_De_Nacimiento = persona.fecha_de_nacimiento;
            personaDto.Genero = persona.genero;
            personaDto.Documento = persona.documento;
            personaDto.Tipo_De_Documento = persona.tipo_de_documento;
            personaDto.Direccion = persona.direccion;
            personaDto.Numero = persona.numero;
            personaDto.Estado= persona.estado;


            return personaDto;
        }

        public async Task<Persona> Save(PersonaDto entity)
        {
            Persona persona = new Persona();
            persona = mapearDatos(persona, entity);

            return await data.Save(persona);
        }

        public async Task Update(int id, PersonaDto entity)
        {
            Persona persona = await data.GetById(id);
            if (persona == null)
            {
                throw new Exception("Registro no encontrado");
            }
            persona = mapearDatos(persona, entity);

            await data.Update(persona);
        }

        public async Task<IEnumerable<PersonaDto>> GetAll()
        {
            return await data.GetAll();
        }

        private Persona mapearDatos(Persona persona, PersonaDto entity)
        {
            persona.Id = entity.Id;
            persona.primer_nombre = entity.Primer_Nombre;
            persona.segundo_nombre = entity.Segundo_Nombre;
            persona.primer_apellido = entity.Primer_Apellido;
            persona.segundo_apellido = entity.Segundo_Apellido;

            persona.correo = entity.Correo;
            persona.numero = entity.Numero;
            persona.fecha_de_nacimiento = entity.Fecha_De_Nacimiento;
            persona.genero = entity.Genero;
            persona.direccion = entity.Direccion;
            persona.tipo_de_documento = entity.Tipo_De_Documento;
            persona.documento = entity.Documento;
            persona.estado = entity.Estado;


            return persona;
        }


    }
}
