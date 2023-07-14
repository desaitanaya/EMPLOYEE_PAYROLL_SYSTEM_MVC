using BusinessLayer.Interface;
using CommonLayer.Model;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Service
{
    public class AdminBL : IAdminBL
    {
        private readonly IAdminRepo adminRepository;

        public AdminBL(IAdminRepo adminRepository)
        {
            this.adminRepository = adminRepository;
        }

        public AdminModel AddAdmin(AdminModel adminModel)
        {
            try
            {
                return adminRepository.AddAdmin(adminModel);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public int LoginAdminGetAdminId(AdminModel adminModel)
        {
            try
            {
                return adminRepository.LoginAdminGetAdminId(adminModel);
            }
            catch (Exception)
            {
                throw;
            }

        }

        //public int LoginAdminGetAdminCount(AdminModel adminModel)
        //{
        //    try
        //    {
        //        return adminRepository.LoginAdminGetAdminCount(adminModel);
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }

        //}

    }
}
