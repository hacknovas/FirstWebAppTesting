namespace WebApplication2.Models;

public class Employee
{
    public int EmployeeID { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Position { get; set; }
    public DateTime HireDate { get; set; }
    public decimal? Salary { get; set; }  // Nullable Salary in case it's missing
}