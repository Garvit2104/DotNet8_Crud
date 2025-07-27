using Emp_Auth_Crud.BLL;
using Emp_Auth_Crud.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Emp_Auth_Crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Emp_MgmtController : ControllerBase
    {
        private readonly IAddEmpRecordService _addEmpServices;
        public Emp_MgmtController(IAddEmpRecordService addEmpServices)
        {
            _addEmpServices = addEmpServices;
        }

        [HttpPost("AddEmpRecord")]
        public IActionResult AddEmployeeRecords(AddEmpRecordDTO empRecordDto)
        {
            return _addEmpServices.AddEmployeeRecords(empRecordDto);
        }
        
    }
}
