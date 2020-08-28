using System;

namespace employee_management_app.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] PasswordHash { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public int DepartmentId { get; set; }
        public DateTime RegistrationDate { get; set; }

        public Department Department { get; set; }
    }
}