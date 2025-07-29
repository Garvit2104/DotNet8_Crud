using Emp_Auth_Crud.DTOs;
using Emp_Auth_Crud.Models;
using Microsoft.AspNetCore.Mvc;
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
        public Employee UpdateEmpRecord(Employee employee)
        {
            _context.Employees.Update(employee);
            _context.SaveChanges();
            return employee;
        }

        public bool DeleteEmpRecord(int id)
        {
            var employee = _context.Employees.FirstOrDefault(e=>e.DepartmentId == id);
            if(employee == null)
            {
                return false;
            }
            _context.Employees.Remove(employee);
            _context.SaveChanges();
            return true;
        }

        public List<Employee> GetAllEmployee()
        {
            return _context.Employees.ToList<Employee>();
        }

    }
}
