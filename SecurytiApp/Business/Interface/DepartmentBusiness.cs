using Business.Implementacion;
using Data.Implementation;
using Data.Interface;
using Entity.Dto;
using Entity.Model.Dto;

using Entity.Model.Security;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Interface
{
    public class DepartmentBusiness : IDepartmentBusiness
    {
        private readonly IDepartmentData data;

        public DepartmentBusiness(IDepartmentData data)
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

        public async Task<DepartmentDto> GetById(int id)
        {
            Department department = await data.GetById(id);
            DepartmentDto departmentDto = new DepartmentDto();

            departmentDto.Id = department.Id;
            departmentDto.code = department.Code;
            departmentDto.name = department.Name;
            departmentDto.description = department.Description;
            departmentDto.countryId = department.CountryId;
            
            departmentDto.state = department.State;

            return departmentDto;
        }

        public async Task<Department> Save(DepartmentDto entity)
        {
            Department department = new Department();
            department = mapearDatos(department, entity);

            return await data.Save(department);
        }

        public async Task Update(int id, DepartmentDto entity)
        {
            Department department = await data.GetById(id);
            if (department == null)
            {
                throw new Exception("Registro no encontrado");
            }
            department = mapearDatos(department, entity);

            await data.Update(department);
        }

        public async Task<IEnumerable<DepartmentDto>> GetAll()
        {
            return await data.GetAll();
        }

        private Department mapearDatos(Department department, DepartmentDto entity)
        {
            department.Id = entity.Id;
            department.Code = entity.code;
            department.Name = entity.name;
            department.Description = entity.description;
            department.CountryId = entity.countryId;
         
            department.State = entity.state;

            return department;
        }
    }
}


