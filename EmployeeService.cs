using EmployeeManagementSystem_Advanced.Models;
using EmployeeManagementSystem_Advanced.Data;

namespace EmployeeManagementSystem_Advanced.Services;

public class EmployeeService
{
    private readonly EmployeeRepository _repo;

    public EmployeeService(EmployeeRepository repo)
    {
        _repo = repo;
    }

    public List<Employee> GetEmployees()
    {
        return _repo.GetAll();
    }

    public void AddEmployee(string name, decimal salary, string dept)
    {
        var emp = new Employee
        {
            Name = name,
            Salary = salary,
            Department = dept
        };

        _repo.Add(emp);
    }

    public void DeleteEmployee(int id)
    {
        _repo.Delete(id);
    }

    public void UpdateEmployee(Employee emp)
    {
        _repo.Update(emp);
    }
}