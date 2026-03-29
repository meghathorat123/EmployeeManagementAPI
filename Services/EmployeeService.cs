using EmpManagement.Repos;
using EmpManagement.Models;

namespace EmpManagement.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepo _repo;

        public EmployeeService(IEmployeeRepo repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await _repo.GetAllAsync();
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await _repo.GetByIDAsync(id);
        }

        public async Task<bool> AddEmployee(Employee employee)
        {
            await _repo.AddAsync(employee);
            return true;
        }

        public async Task<bool> UpdateEmployee(Employee employee)
        {
             await _repo.UpdateAsync(employee);
             return true;
        }

        public async Task<bool> DeleteEmployee(int id)
        {
             await _repo.DeleteAsync(id);
            return true;
        }
    }


}
