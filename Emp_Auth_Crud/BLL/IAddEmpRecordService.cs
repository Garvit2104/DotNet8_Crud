using Emp_Auth_Crud.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Emp_Auth_Crud.BLL
{
    public interface IAddEmpRecordService
    {
        IActionResult AddEmployeeRecords(AddEmpRecordDTO empRecordDto);

        EmployeeResponseDTO GetEmployeeById(int id);
    }
}
