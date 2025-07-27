using System;
using System.Collections.Generic;

namespace Emp_Auth_Crud.Models;

public partial class Employee
{
    public int EmpId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Role { get; set; }

    public int? Salary { get; set; }

    public long? DepartmentId { get; set; }

    public virtual Department? Department { get; set; }
}
