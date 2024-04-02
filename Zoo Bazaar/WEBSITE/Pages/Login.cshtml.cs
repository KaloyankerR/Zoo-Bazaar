using BusinessLogicLayer;
using BusinessLogicManagerLayer;
using BusinessLogicObjectLayer;
using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WEBSITE.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string ErrorMessage { get; set; }

        public string FullName;

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                CustomerManager customerManager = new CustomerManager(new CustomerDAL());
                EmployeeManager employeeManager = new EmployeeManager(new EmployeeDAL());

                if (customerManager.Login(Email, Password))
                {
                    Customer cust = customerManager.GetCustomerByEmail(Email);
                    string fullName = cust.FirstName + " " + cust.LastName;
                    HttpContext.Session.SetString("CustomerID", cust.CustomerID.ToString());
                    HttpContext.Session.SetString("FullName", fullName);
                    return RedirectToPage("/Index");
                }
                else if (employeeManager.Login(Email, Password) is Employee emp)
                {
                    string fullName = emp.FirstName + " " + emp.LastName;
                    HttpContext.Session.SetString("EmployeeID", emp.ID.ToString());
                    HttpContext.Session.SetString("FullName", fullName);
                    return RedirectToPage("/Schedule");
                }
                else
                {
                    ErrorMessage = "Invalid login attempt.";
                    return Page();
                }
            }
            else
            {
                return Page();
            }
        }
        
    }
}
