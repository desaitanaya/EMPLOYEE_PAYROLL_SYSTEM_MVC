using CommonLayer.Model;
using Microsoft.Extensions.Configuration;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace RepositoryLayer.Service
{
    public class AdminRepo : IAdminRepo
    {
        private readonly IConfiguration iconfig;
        readonly SqlConnection connection = new SqlConnection();
        readonly string connectionString;

        public AdminRepo(IConfiguration iconfig)
        {
            this.iconfig = iconfig;
            connectionString = iconfig.GetConnectionString("DBConnection");
            connection.ConnectionString = connectionString;
        }


        public AdminModel AddAdmin(AdminModel registerAdmin)
        {
            connection.Open();
            try
            {
                SqlCommand insertCommand = new SqlCommand("AdminRegisteration", connection);
                insertCommand.CommandType = System.Data.CommandType.StoredProcedure;

                insertCommand.Parameters.AddWithValue("admin_name", registerAdmin.Name);
                insertCommand.Parameters.AddWithValue("admin_password", registerAdmin.Password);

                
                SqlDataReader reader = insertCommand.ExecuteReader();

                AdminModel admin = new AdminModel();

                if (reader.Read())
                {
                    admin.AdminID = (int)reader["AdminID"];
                    admin.Name = (string)reader["Name"];
                    admin.Password = (string)reader["Password"];
                   
                }
                return admin;

            }

            catch (Exception ex)
            {
                throw;
            }
            connection.Close();

        }

        public int LoginAdminGetAdminId(AdminModel loginAdminId)
        {

            connection.Open();
            try
            {
                SqlCommand loginIdCommand = new SqlCommand("AdminLoginGetAdminId", connection);
                loginIdCommand.CommandType = System.Data.CommandType.StoredProcedure;

                loginIdCommand.Parameters.AddWithValue("admin_name", loginAdminId.Name);
                loginIdCommand.Parameters.AddWithValue("admin_password", loginAdminId.Password);


                SqlDataReader reader = loginIdCommand.ExecuteReader();

                AdminModel admin = new AdminModel();

                if (reader.Read())
                {
                    admin.AdminID = (int)reader["AdminID"];
                   
                }
                return admin.AdminID;

            }

            catch (Exception ex)
            {
                throw;
            }
            connection.Close();

        }



        //public int LoginAdminGetAdminCount(AdminModel loginAdmin)
        //{
        //    connection.Open();

        //    try
        //    {

        //        SqlCommand loginCommand = new SqlCommand("AdminLoginGetAdminCount", connection);
        //        loginCommand.CommandType = System.Data.CommandType.StoredProcedure;

        //        loginCommand.Parameters.AddWithValue("admin_name", loginAdmin.Name);
        //        loginCommand.Parameters.AddWithValue("admin_password", loginAdmin.Password);

        //        int adminCount= (int)loginCommand.ExecuteScalar();

        //        return adminCount;

        //    }


        //    catch (Exception ex)
        //    {
        //        throw;
        //    }


        //    connection.Close();

        //}



    }
}
