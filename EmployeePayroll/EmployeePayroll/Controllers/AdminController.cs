using BusinessLayer.Interface;
using BusinessLayer.Service;
using CommonLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using System;
using System.Reactive;

namespace EmployeePayroll.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminBL adminBL;

        public AdminController(IAdminBL adminBL)
        {
            this.adminBL = adminBL;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddAdmin()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddAdmin(AdminModel adminModel)
        {
            try
            {
                adminBL.AddAdmin(adminModel);
                return View(adminModel);

               // return RedirectToAction("GetAllEmployees");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpGet]
        public IActionResult LoginAdmin()
        {
          
            return View();
        }

        [HttpPost]
        public IActionResult LoginAdmin(AdminModel loginAdmin)
        {
            try
            {
                
                int adminId = adminBL.LoginAdminGetAdminId(loginAdmin);

                    if (adminId==1)
                    {
                        HttpContext.Session.SetInt32("AdminID", adminId);
                        HttpContext.Session.SetString("Name", loginAdmin.Name);
                        return RedirectToAction("GetAllEmployees", "Employee");
                    }
                    
                    else if(adminId==2)
                    {
                        //ViewBag.msg = "You are not authorized to login yet";
                        ViewData["ErrorMessage"] = "You are not authorized to login yet";
                        //TempData["ErrorMessage"] = "You are not authorized to login yet";

                        //return RedirectToAction("LoginAdmin", "Admin");
                    }
                
                    else
                    {
                        ModelState.AddModelError("", "Invalid Admin Name or Password");
                    }

                
                return View(loginAdmin);
                
            }
            catch (Exception ex)
            {
                throw;
            }
        }



    }
}
