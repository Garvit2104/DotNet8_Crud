namespace Emp_Auth_Crud.DTOs
{
    public class EmployeeResponseDTO
    {
        public int EmpId { get; set; }
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string? Role { get; set; }

        public int? Salary { get; set; }

    }
}
