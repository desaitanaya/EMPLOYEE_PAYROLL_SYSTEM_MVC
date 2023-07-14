using BusinessLayer.Interface;
using CommonLayer.Model;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Service
{
    public class EmployeeBL : IEmployeeBL
    {
        private readonly IEmployeeRepo employeeRepository;

        public EmployeeBL(IEmployeeRepo employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public EmployeeModel AddEmployee(EmployeeModel employeeModel)
        {
            try
            {
                return employeeRepository.AddEmployee(employeeModel);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public int LoginEmployee(EmployeeModel employeeModel)
        {
            try
            {
                return employeeRepository.LoginEmployee(employeeModel);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
            try
            {
                return employeeRepository.GetAllEmployees();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public EmployeeModel GetEmployeeById(int id)
        {
            try
            {
                return employeeRepository.GetEmployeeById(id);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public EmployeeModel EditEmployee(EmployeeModel employeeModel)
        {
            try
            {
                return employeeRepository.EditEmployee(employeeModel);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public EmployeeModel DeleteEmployee(int id)
        {
            try
            {
                return employeeRepository.DeleteEmployee(id);
            }
            catch (Exception)
            {
                throw;
            }

        }



    }
}
