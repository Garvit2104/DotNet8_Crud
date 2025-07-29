using Emp_Auth_Crud.DTOs;
using Emp_Auth_Crud.Models;
using Microsoft.AspNetCore.Mvc;

namespace Emp_Auth_Crud.DAL
{
    public interface IAddEmpRecordRepo
    {
        Employee AddEmployee(Employee employee);

        Employee GetEmployeeById(int id);

        Employee UpdateEmpRecord(Employee employee);

        bool DeleteEmpRecord(int id);

        List<Employee> GetAllEmployee();

    }
}
