﻿using Business.Implementacion;
using Entity.Dto;
using Data.Implementation;
using Entity.Model.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Business.Interface
{
    public class UsuarioBusiness : IUsuarioBusiness
    {
        private readonly IUsuarioData data;

        public UsuarioBusiness(IUsuarioData data)
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

        public async Task<UsuarioDto> GetById(int id)
        {
            Usuario usuario = await data.GetById(id);
            UsuarioDto usuarioDto = new UsuarioDto();

            usuarioDto.Id = usuario.Id;
            usuarioDto.Nombre_De_Usuario = usuario.nombre_de_usuario;
            usuarioDto.Contraseña = usuario.contraseña;
            usuarioDto.Estado = usuario.estado;
            usuarioDto.Persona_id = usuario.persona_id;
            


            return usuarioDto;
        }

        public async Task<Usuario> Save(UsuarioDto entity)
        {
            Usuario usuario = new Usuario();
            usuario = mapearDatos(usuario, entity);

            return await data.Save(usuario);
        }

        public async Task Update(int id, UsuarioDto entity)
        {
            Usuario usuario = await data.GetById(id);
            if (usuario == null)
            {
                throw new Exception("Registro no encontrado");
            }
            usuario = mapearDatos(usuario, entity);

            await data.Update(usuario);
        }

        public async Task<IEnumerable<UsuarioDto>> GetAll()
        {
            return await data.GetAll();
        }

        private Usuario mapearDatos(Usuario usuario, UsuarioDto entity)
        {
            usuario.Id = entity.Id;
            usuario.nombre_de_usuario = entity.Nombre_De_Usuario;
            usuario.contraseña = entity.Contraseña;
            usuario.estado = entity.Estado;
            usuario.persona_id = entity.Persona_id;

            return usuario;
        }
    }
}

