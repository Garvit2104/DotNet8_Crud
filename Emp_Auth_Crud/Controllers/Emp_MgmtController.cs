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
        [HttpGet("GetEmployeeById/{id}")]
        public IActionResult GetEmployeeById(int id)
        {                                       // calling service to fetch {id} result and store
            var employee = _addEmpServices.GetEmployeeById(id);
            if(employee is null)
            {
                return NotFound($"Employee with EmpId {id} is not found. ");
            }
            return Ok(employee);
        }

        [HttpPut("UpdateEmpRecord/{id}")]

        public IActionResult UpdateEmployeeRecord(AddEmpRecordDTO updateRecordDTO, int id)
        {
            var result = _addEmpServices.UpdateEmployeeRecord(updateRecordDTO, id);
            if(result == null)
            {
                return NotFound($"Employee with EmpId {id} is not exist");
            }
                return Ok(result);

           
        }
        [HttpDelete("DeleteEmpRecord/{id}")]
        public IActionResult DeleteEmployeeRecord(int id)
        {
            var result = _addEmpServices.DeleteEmpRecord(id);
            if(!result)
            {
                return NotFound($"Employee with id {id} not found");
            }
            return Ok($"Employee Record with id {id} sucessfully Deleted");
        }
        [HttpPost("GetAllEmpRecord")]
        public IActionResult GetAllEmployeeRecord()
        {
            var result = _addEmpServices.GetAllEmployee();
            return Ok(result);
        }
    }
}
