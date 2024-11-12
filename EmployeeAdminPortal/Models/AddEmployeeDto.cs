namespace EmployeeAdminPortal.Models;

public class AddEmployeeDto
{
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string Phone{ get; set; }
    public int Salary { get; set; }
}