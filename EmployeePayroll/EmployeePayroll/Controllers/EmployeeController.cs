using BusinessLayer.Interface;
using BusinessLayer.Service;
using CommonLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeePayroll.Controllers
{
    public class EmployeeController : Controller
    {
       
            private readonly IEmployeeBL employeeBL;

            public EmployeeController(IEmployeeBL employeeBL)
            {
                this.employeeBL = employeeBL;
            }

            public IActionResult Index()
            {
                return View();
            }

            [HttpGet]
            public IActionResult AddEmployee()
            {

                return View();
            }

            [HttpPost]
            public IActionResult AddEmployee(EmployeeModel employeeModel)
            {
                try
                {
                    employeeBL.AddEmployee(employeeModel);
                   //return View(employeeModel);
                
                    return RedirectToAction("GetAllEmployees");
                }
                catch (Exception ex)
                {
                    throw;
                }
            }

        [HttpGet]
        public IActionResult LoginEmployee()
        {

            return View();
        }

        [HttpPost]
        public IActionResult LoginEmployee(EmployeeModel loginEmployee)
        {
            try
            {
                int result = employeeBL.LoginEmployee(loginEmployee);

                if(result > 0)
                {
                    return RedirectToAction("GetEmployeeById", new { id = loginEmployee.EmployeeID });
                }
                else
                {
                    ModelState.AddModelError("", "Invalid Employee ID or Name");
                }

                return View(loginEmployee);
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            try
            {
                string adminName = HttpContext.Session.GetString("Name");
                ViewBag.Name = adminName;
                List<EmployeeModel> employeeList = new List<EmployeeModel>();
                int adminId = (int)HttpContext.Session.GetInt32("AdminID");
                if(adminId != null)
                {
                    employeeList = employeeBL.GetAllEmployees().ToList();

                    return View(employeeList);
                }
                else
                {
                    return RedirectToAction("LoginAdmin", "Admin");
                }
                
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpGet]
        public IActionResult GetEmployeeById(int id)
        {
            try
            {
                
                EmployeeModel employee = employeeBL.GetEmployeeById(id);

                return View(employee);
                // return RedirectToAction("AddEmployee");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        

        [HttpGet]
        public IActionResult EditEmployee(int id)
        {
            EmployeeModel employee = employeeBL.GetEmployeeById(id); 
            HttpContext.Session.SetInt32("EmployeeID", employee.EmployeeID);
            return View(employee);
        }

        [HttpPost]
        public IActionResult EditEmployee(EmployeeModel employee)
        {
            try
            {
                
                employeeBL.EditEmployee(employee);
                
                //return View(employee);
                return RedirectToAction("GetAllEmployees");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpGet]
        public IActionResult DeleteEmployee(int id)
        {
            EmployeeModel employee = employeeBL.GetEmployeeById(id);
            return View(employee);
            
        }

        [HttpPost]
        public IActionResult DeleteEmployee(EmployeeModel employee, int id)
        {
            try
            {
                employeeBL.DeleteEmployee(id);
               // return View(employee);
                return RedirectToAction("GetAllEmployees");
            }
            catch (Exception ex)
            {
                throw;
            }
        }


    }
}
