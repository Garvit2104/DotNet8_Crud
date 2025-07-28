using Emp_Auth_Crud.DTOs;
using Emp_Auth_Crud.Models;

namespace Emp_Auth_Crud.DAL
{
    public interface IAddEmpRecordRepo
    {
        Employee AddEmployee(Employee employee);

        Employee GetEmployeeById(int id);

        Employee UpdateEmpRecord(Employee employee);

    }
}
