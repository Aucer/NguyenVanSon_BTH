using System.Security.AccessControl;
namespace NguyenVanSon_BTH.Models;

public class Employee
{
    public int EmployeeID { get; set; }

    public string? EmployeeName { get; set; }

    public int EmployeePhone { get; set; }

    public string? EmployeeAddress { get; set; }
    
    public int EmployeeAge { get; set; }
      
}