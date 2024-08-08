using Business.Implementacion;
using Entity.Dto;
using Data.Implementation;
using Entity.Model.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    public class VistaBusiness : IVistaBusiness
    {
            private readonly IVistaData data;
            public VistaBusiness(IVistaData data)
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

            public async Task<VistaDto> GetById(int id)
            {
                Vista vista = await data.GetById(id);
                VistaDto vistaDto = new VistaDto();

                vistaDto.Id = vista.Id;
                vistaDto.Nombre = vista.nombre;
                vistaDto.Descripcion = vista.descripcion;
                vistaDto.Ruta = vista.ruta;
                vistaDto.Modulo_id = vista.modulo_id;



                return vistaDto;
            }



            public async Task<Vista> Save(VistaDto entity)
            {

            //verifica si el modulo_id existe
           /* var moduloExists = await data.ModuloExists(entity.moduleName);
            if (moduloExists)
            {
                throw new Exception("El modulo especificado no existe");
            }*/


                Vista vista = new Vista();
                vista = mapearDatos(vista, entity);

                return await data.Save(vista);
            }

            public async Task Update(int id, VistaDto entity)
            {
                Vista vista = await data.GetById(id);
                if (vista == null)
                {
                    throw new Exception("Registro no encontrado");
                }
                vista = mapearDatos(vista, entity);

                await data.Update(vista);
            }

            public async Task<IEnumerable<VistaDto>> GetAll()
            {
                return await data.GetAll();
            }

            private Vista mapearDatos(Vista vista, VistaDto entity)
            {
                vista.Id = entity.Id;
                vista.nombre = entity.Nombre;
                vista.descripcion = entity.Descripcion;
                vista.ruta = entity.Ruta;
                vista.modulo_id = entity.Modulo_id;

                return vista;
            }

    }
}
