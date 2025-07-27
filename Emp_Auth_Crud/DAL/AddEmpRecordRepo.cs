using Emp_Auth_Crud.Models;
using Microsoft.EntityFrameworkCore;

namespace Emp_Auth_Crud.DAL
{
    public class AddEmpRecordRepo : IAddEmpRecordRepo
    {
        private readonly EmpDbContext _context;
        public AddEmpRecordRepo(EmpDbContext context)
        {
            _context = context;
        }
        public Employee AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }
        public Employee GetEmployeeById(int id)
        {
            var result = _context.Employees.Find(id);
            if(result == null)
            {
                return null;
            }
        
            return result;
        }
    }
}
