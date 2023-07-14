using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interface
{
    public interface IAdminBL
    {
        public AdminModel AddAdmin(AdminModel registerAdmin);
        public int LoginAdminGetAdminId(AdminModel loginAdmin);
        //public int LoginAdminGetAdminCount(AdminModel loginAdmin);
    }
}
