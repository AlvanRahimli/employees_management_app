using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using employee_management_app.Data;
using employee_management_app.Models;
using employee_management_app.Util;
using Microsoft.EntityFrameworkCore;

namespace employee_management_app.Repositories.EmployeesRepos
{
    public class EmployeesRepo : IEmployeesRepo
    {
        private readonly AppDbContext _context;
        public EmployeesRepo(AppDbContext context)
        {
            this._context = context;

        }

        public async Task<bool> Add(EmployeeAddDto newEmployee)
        {
            var emp = new Employee()
            {
                Name = newEmployee.Name,
                RegistrationDate = DateTime.Today,
                Age = newEmployee.Age,
                DepartmentId = newEmployee.DepartmentId,
                Email = newEmployee.Email,
                PasswordHash = Helper.ComputeHash(newEmployee.Password)
            };

            await _context.Employees.AddAsync(emp);
            var res = await _context.SaveChangesAsync();

            return res > 0;
        }

        public Task<Employee> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Employee>> GetAll()
        {
            var employees = _context.Employees
                .AsNoTracking()
                .ToList();
        }
    }
}