using Emp_Auth_Crud.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Emp_Auth_Crud.BLL
{
    public interface IAddEmpRecordService
    {
        public IActionResult AddEmployeeRecords(AddEmpRecordDTO empRecordDto);
    }
}
