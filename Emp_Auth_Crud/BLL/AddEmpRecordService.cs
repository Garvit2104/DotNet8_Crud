using Emp_Auth_Crud.DAL;
using Emp_Auth_Crud.DTOs;
using Emp_Auth_Crud.Models;
using Microsoft.AspNetCore.Mvc;

namespace Emp_Auth_Crud.BLL
{
    public class AddEmpRecordService : IAddEmpRecordService
    {
        private readonly IAddEmpRecordRepo _addEmpRepo;
        public AddEmpRecordService(IAddEmpRecordRepo addEmpRepo)
        {
            _addEmpRepo = addEmpRepo;
        }
        public IActionResult AddEmployeeRecords(AddEmpRecordDTO empRecordDto)
        {  // Here we are accepting DTO and convert it into Entity
            var employeeEntity = new Employee           // Employee is the model class
            {
                FirstName = empRecordDto.FirstName,
                LastName = empRecordDto.LastName,
                Email = empRecordDto.Email,
                Password = empRecordDto.Password,
                Role = empRecordDto.Role,
                Salary = empRecordDto.Salary,
                DepartmentId = empRecordDto.DepartmentId

            };
           var result =  _addEmpRepo.AddEmployee(employeeEntity);
            return new OkObjectResult(result);
        }
        public EmployeeResponseDTO GetEmployeeById(int id)
        {
            var employee = _addEmpRepo.GetEmployeeById(id);

            if(employee == null)
            {
                return null;
            }
            return new EmployeeResponseDTO
            {
                EmpId = employee.EmpId,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email = employee.Email,
                Role = employee.Role,
                Salary = employee.Salary
            };
        }
    }
}
