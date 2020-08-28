using System.Collections.Generic;
using System.Threading.Tasks;
using employee_management_app.Models;

namespace employee_management_app.Repositories.EmployeesRepos
{
    public interface IEmployeesRepo
    {
        Task<List<Employee>> GetAll();
        Task<Employee> Get(int id);
        Task<bool> Add(Employee newEmployee);
    }
}