using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCrudApp.Data
{
    interface IEmployeeService
    {
        List<Employee> GetEmployees();

        Employee GetEmployee(Guid id);

        void UpdateEmployee(Employee model);

        void AddEmployee(Employee model);

        void DeleteEmployee(Guid id);
    }
}
