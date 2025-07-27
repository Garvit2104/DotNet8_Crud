using Emp_Auth_Crud.Models;

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
    }
}
