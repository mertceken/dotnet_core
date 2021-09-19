using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCrudApp.Data
{
    public class EmployeeService : IEmployeeService
    {
        private List<Employee> employeeList = new List<Employee>()
        {
            new Employee{
            Id =Guid.NewGuid(),
            Name="John Doe"
            },
            new Employee
            {
            Id= Guid.NewGuid(),
            Name="Christian"
            }

        };

        public void AddEmployee(Employee model)
        {
            var id = Guid.NewGuid();
            model.Id = id;
            employeeList.Add(model);
        }

        public void DeleteEmployee(Guid id)
        {
            var employee = GetEmployee(id);
            employeeList.Remove(employee);

        }

        public Employee GetEmployee(Guid id)
        {
            return employeeList.SingleOrDefault(x => x.Id == id);
        }

        public List<Employee> GetEmployees()
        {
            return employeeList;
        }

        public void UpdateEmployee(Employee model)
        {
            var getOldEmpName = GetEmployee(model.Id);
            getOldEmpName.Name = model.Name;
        }
    }
}
