using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Interface
{
    public interface IAdminRepo
    {
        public AdminModel AddAdmin(AdminModel registerAdmin);
        public int LoginAdminGetAdminId(AdminModel loginAdmin);
        //public int LoginAdminGetAdminCount(AdminModel loginAdmin);
    }
}
