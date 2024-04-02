using BusinessLogicManagerLayer;
using BusinessLogicObjectLayer;
using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using System;

namespace WEBSITE.Pages
{
    public class ScheduleModel : PageModel
    {
        [BindProperty]
        public List<Shift> EmployeeShifts { get; set; } = new ();

        private ShiftManager _shiftManager = new(new ShiftsDAL());

        public string GetMonthName(int month)
        {
            string[] monthNames = {"January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December" };
        
            if (month >= 1 && month <= 12)
            {
                return monthNames[month - 1];
            }

            return string.Empty;
        }

        public string GetShiftType(DateTime shiftStart)
        {
            if (shiftStart.TimeOfDay >= new TimeSpan(12, 0, 0)) 
            {
                return "Afternoon Shift";
            }
            else
            {
                return "Morning Shift";
            }
        }

        public IActionResult OnGet()
        {
            try
            {
                string employeeId = HttpContext.Session.GetString("EmployeeID").ToString();

                if (employeeId == null)
                {
                    return RedirectToPage("/Error");
                }
                else
                {
                    int id = Convert.ToInt32(employeeId);
                    EmployeeShifts = _shiftManager.GetEmployeeShifts(id);

                    return Page();
                }
            }
            catch
            {
                return RedirectToPage("/Error");
            }

        }
    }
}
