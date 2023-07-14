using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Interface
{
    public interface IEmployeeRepo
    {
        public EmployeeModel AddEmployee(EmployeeModel registerEmployee);
        public int LoginEmployee(EmployeeModel loginEmployee);
        public IEnumerable<EmployeeModel> GetAllEmployees();
        public EmployeeModel GetEmployeeById(int id);
        public EmployeeModel EditEmployee(EmployeeModel employee);
        public EmployeeModel DeleteEmployee(int id);
    }
}
