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
        {                    // calling the repo to get the details of {id}
            var employee = _addEmpRepo.GetEmployeeById(id);

            if(employee == null)
            {
                return null;
            }
            // {id} employee exist fetch the details and convert the entity details to responseDTO
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
        public AddEmpRecordDTO UpdateEmployeeRecord(AddEmpRecordDTO updateRecordDTO, int id)
        {
            var employee = _addEmpRepo.GetEmployeeById(id);

            if(employee == null)
            {
                return null;
            }

            employee.FirstName = updateRecordDTO.FirstName;
            employee.LastName = updateRecordDTO.LastName;
            employee.Email = updateRecordDTO.Email;
            employee.Password = updateRecordDTO.Password;
            employee.Role = updateRecordDTO.Role;
            employee.Salary = updateRecordDTO.Salary;
            employee.DepartmentId = updateRecordDTO.DepartmentId;

            var updatedEmployee = _addEmpRepo.UpdateEmpRecord(employee);


            return new AddEmpRecordDTO
            {

                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email = employee.Email,
                Role = employee.Role,
                Salary = employee.Salary
            }; 
            
        }
        public bool DeleteEmpRecord(int id)
        {
            return _addEmpRepo.DeleteEmpRecord(id);
            
        }
        public List<EmployeeResponseDTO> GetAllEmployee()
        {
           List<Employee> employees  =  _addEmpRepo.GetAllEmployee();
           List<EmployeeResponseDTO> responsesDTO = new();

            foreach (Employee emp in employees)
            {
                EmployeeResponseDTO responseDTO = new EmployeeResponseDTO();
                responseDTO.EmpId = emp.EmpId;
                responseDTO.FirstName = emp.FirstName;
                responseDTO.LastName = emp.LastName;
                responseDTO.Email = emp.Email;
                responseDTO.Role = emp.Role;
                responseDTO.Salary = emp.Salary;

                responsesDTO.Add(responseDTO); // Add the mapped DTO to the list


            }
            return responsesDTO;

        }
    }
}
