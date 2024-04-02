using BusinessLogicManagerLayer;
using BusinessLogicObjectLayer;
using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WEBSITE.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Phone is required")]
        public string Phone { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required]
        [BindProperty]
        public string DateOfBirth { get; set; }


        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (Password == ConfirmPassword)
            {
                CustomerManager customerManager = new CustomerManager(new CustomerDAL());

                DateOnly dateOnly = DateOnly.ParseExact(DateOfBirth, "yyyy-MM-dd", null);


                foreach (Customer custMail in customerManager.GetAllCustomers())
                {
                    if (Email == custMail.Email)
                    {

                        TempData["Message"] = "This email is already registered!";

                        return Page();
                    }
                }

                bool isChecked = Request.Form["MyCheckbox"] == "on";

                Customer cust = new Customer(FirstName, LastName, Password, dateOnly, Email, Phone, Address);
                string message = customerManager.SaveCustomer(cust);

                string fullName = cust.FirstName + " " + cust.LastName;
                HttpContext.Session.SetString("CustomerID", cust.CustomerID.ToString());
                HttpContext.Session.SetString("FullName", fullName);


                if (isChecked)
                {
                    string message2 = customerManager.SaveSubscriberEmail(Email);
                }
                TempData["Message"] = message;
                return RedirectToPage("/Index");
            }
            else
            {
                return Page();
            }
        }
      
    }
}
