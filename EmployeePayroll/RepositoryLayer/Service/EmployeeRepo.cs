using CommonLayer.Model;
using Microsoft.Extensions.Configuration;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace RepositoryLayer.Service
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly IConfiguration iconfig;
        readonly SqlConnection connection = new SqlConnection();
        readonly string connectionString;

        public EmployeeRepo(IConfiguration iconfig)
        {
            this.iconfig = iconfig;
            connectionString = iconfig.GetConnectionString("DBConnection");
            connection.ConnectionString = connectionString;
        }


        public EmployeeModel AddEmployee(EmployeeModel registerEmployee)
        {
            connection.Open();
            try
            {
                SqlCommand insertCommand = new SqlCommand("EmployeeRegisteration", connection);
                insertCommand.CommandType = System.Data.CommandType.StoredProcedure;

                insertCommand.Parameters.AddWithValue("emp_name", registerEmployee.Name);
                insertCommand.Parameters.AddWithValue("emp_profile_img", registerEmployee.ProfileImage);
                insertCommand.Parameters.AddWithValue("emp_gender", registerEmployee.Gender);
                insertCommand.Parameters.AddWithValue("emp_start_date", registerEmployee.StartDate);
                insertCommand.Parameters.AddWithValue("department", registerEmployee.Department);
                insertCommand.Parameters.AddWithValue("emp_salary", registerEmployee.Salary);
                insertCommand.Parameters.AddWithValue("notes", registerEmployee.Notes);
                insertCommand.Parameters.AddWithValue("createdAt", registerEmployee.CreatedAt);
                insertCommand.Parameters.AddWithValue("updatedAt", registerEmployee.UpdatedAt);

                SqlDataReader reader = insertCommand.ExecuteReader();

                EmployeeModel employee = new EmployeeModel();

                if (reader.Read())
                {
                    employee.EmployeeID = (int)reader["EmployeeID"];
                    employee.Name = (string)reader["Name"];
                    employee.ProfileImage = (string)reader["ProfileImage"];
                    employee.Gender = (string)reader["Gender"];
                    employee.StartDate = (DateTime)reader["StartDate"];
                    employee.Department = (string)reader["Department"];
                    employee.Salary = (decimal)reader["Salary"];
                    employee.Notes = (string)reader["Notes"];
                    employee.CreatedAt = (DateTime)reader["CreatedAt"];
                    employee.UpdatedAt = (DateTime)reader["UpdatedAt"];
                }
                return employee;

            }

            catch (Exception ex)
            {
                throw;
            }
            connection.Close();

        }


        public int LoginEmployee(EmployeeModel loginEmployee)
        {
            connection.Open();
            
            try
            {
                int count = 0;
                SqlCommand loginCommand = new SqlCommand("EmployeeLogin", connection);
                loginCommand.CommandType = System.Data.CommandType.StoredProcedure;

                loginCommand.Parameters.AddWithValue("emp_id", loginEmployee.EmployeeID);
                loginCommand.Parameters.AddWithValue("emp_name", loginEmployee.Name);

                 count = (int)loginCommand.ExecuteScalar();
                
                //SqlDataReader reader = loginCommand.ExecuteReader();

                //EmployeeModel employee = new EmployeeModel();

                //if (reader.Read())
                //{
                //    employee.EmployeeID = (int)reader["EmployeeID"];
                //    employee.Name = (string)reader["Name"];
                //    employee.ProfileImage = (string)reader["ProfileImage"];
                //    employee.Gender = (string)reader["Gender"];
                //    employee.StartDate = (DateTime)reader["StartDate"];
                //    employee.Department = (string)reader["Department"];
                //    employee.Salary = (decimal)reader["Salary"];
                //    employee.Notes = (string)reader["Notes"];
                //    //employee.CreatedAt = (DateTime)reader["CreatedAt"];
                //    //employee.UpdatedAt = (DateTime)reader["UpdatedAt"];
                //}

                return count;

            }

            catch (Exception ex)
            {
                throw;
            }
            connection.Close();

        }

        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
            List<EmployeeModel> employeeList = new List<EmployeeModel>();
            connection.Open();
            
            SqlCommand displayCommand = new SqlCommand("GetAllEmployees", connection);
            displayCommand.CommandType = System.Data.CommandType.StoredProcedure;


            SqlDataReader reader = displayCommand.ExecuteReader();

            while (reader.Read())
            {
                EmployeeModel employee = new EmployeeModel();
                employee.EmployeeID = (int)reader["EmployeeID"];
                employee.Name = (string)reader["Name"];
                employee.ProfileImage = (string)reader["ProfileImage"];
                employee.Department = (string)reader["Department"];
                
                employeeList.Add(employee);
            }
            
                connection.Close();
            
            return employeeList;

          
        }

        public EmployeeModel GetEmployeeById(int id)
        {
            connection.Open();
            try
            {
                //Console.WriteLine("Enter Id");
                //id = int.Parse(Console.ReadLine());
                SqlCommand displayCommand = new SqlCommand("GetEmployeeById", connection);
                displayCommand.CommandType = System.Data.CommandType.StoredProcedure;

                displayCommand.Parameters.AddWithValue("emp_id", id);

                displayCommand.ExecuteNonQuery();

                SqlDataReader reader = displayCommand.ExecuteReader();

                EmployeeModel employee = new EmployeeModel();

                if (reader.Read())
                {
                    employee.EmployeeID = (int)reader["EmployeeID"];
                    employee.Name = (string)reader["Name"];
                    employee.ProfileImage = (string)reader["ProfileImage"];
                    employee.Gender = (string)reader["Gender"];
                    employee.StartDate = (DateTime)reader["StartDate"];
                    employee.Department = (string)reader["Department"];
                    employee.Salary = (decimal)reader["Salary"];
                    employee.Notes = (string)reader["Notes"];
                    //employee.CreatedAt = (DateTime)reader["CreatedAt"];
                    //employee.UpdatedAt = (DateTime)reader["UpdatedAt"];
                }
                return employee;

            }
            catch (Exception ex)
            {
                throw;
            }

            connection.Close();

        }


        public EmployeeModel EditEmployee(EmployeeModel editEmployee)
        {
            connection.Open();
            try
            {

                SqlCommand updateCommand = new SqlCommand("EditEmployee", connection);
                updateCommand.CommandType = System.Data.CommandType.StoredProcedure;

                updateCommand.Parameters.AddWithValue("emp_id", editEmployee.EmployeeID);
                updateCommand.Parameters.AddWithValue("emp_name", editEmployee.Name);
                updateCommand.Parameters.AddWithValue("emp_profile_img", editEmployee.ProfileImage);
                updateCommand.Parameters.AddWithValue("emp_gender", editEmployee.Gender);
                updateCommand.Parameters.AddWithValue("emp_start_date", editEmployee.StartDate);
                updateCommand.Parameters.AddWithValue("department", editEmployee.Department);
                updateCommand.Parameters.AddWithValue("emp_salary", editEmployee.Salary);
                updateCommand.Parameters.AddWithValue("notes", editEmployee.Notes);
                

                updateCommand.ExecuteNonQuery();

                SqlDataReader reader = updateCommand.ExecuteReader();
                EmployeeModel employee = new EmployeeModel();
                

                if (reader.Read())
                {
                    
                    employee.EmployeeID = (int)reader["EmployeeID"];
                    employee.Name = (string)reader["Name"];
                    employee.ProfileImage = (string)reader["ProfileImage"];
                    employee.Gender = (string)reader["Gender"];
                    employee.StartDate = (DateTime)reader["StartDate"];
                    employee.Department = (string)reader["Department"];
                    employee.Salary = (decimal)reader["Salary"];
                    employee.Notes = (string)reader["Notes"];
                    
                }
                return employee;
            }
            catch (Exception ex)
            {
                throw;
            }

            connection.Close();

        }


        public EmployeeModel DeleteEmployee(int id)
        {
            try
            {
                connection.Open();
                
                SqlCommand deleteCommand = new SqlCommand("DeleteEmployee", connection);
                deleteCommand.CommandType = System.Data.CommandType.StoredProcedure;

                deleteCommand.Parameters.AddWithValue("emp_id", id);

                deleteCommand.ExecuteNonQuery();
                SqlDataReader reader = deleteCommand.ExecuteReader();

                EmployeeModel employee = new EmployeeModel();

                if (reader.Read())
                {
                    employee.EmployeeID = (int)reader["EmployeeID"];
                    employee.Name = (string)reader["Name"];
                    employee.ProfileImage = (string)reader["ProfileImage"];
                    employee.Gender = (string)reader["Gender"];
                    employee.StartDate = (DateTime)reader["StartDate"];
                    employee.Department = (string)reader["Department"];
                    employee.Salary = (decimal)reader["Salary"];
                    employee.Notes = (string)reader["Notes"];
                    employee.CreatedAt = (DateTime)reader["CreatedAt"];
                    employee.UpdatedAt = (DateTime)reader["UpdatedAt"];
                }
                return employee;

            }
            catch (Exception ex)
            {
                throw;
            }

            connection.Close();

        }

    }
}
