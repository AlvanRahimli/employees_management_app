using System.ComponentModel.DataAnnotations;

namespace employee_management_app.Models
{
    public class EmployeeAddDto
    {

        public string Name { get; set; }
        public string Password { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Range(18, 120)]
        public int Age { get; set; }
        public int DepartmentId { get; set; }
    }
}