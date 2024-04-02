using BusinessLogicLayer;
using BusinessLogicObjectLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicManagerLayer
{
    public class ShiftManager
    {

        private IShiftsDAL shiftsDAL;

        public List<Shift> shifts;
        public ShiftManager(IShiftsDAL shiftsDAL) 
        {
            this.shiftsDAL = shiftsDAL;
            shifts = new List<Shift>();
        }

        public void AddShift(Shift shift) 
        {
           
           int id = shiftsDAL.CreateShift(shift);
            shift.ID = id;
            shifts.Add(shift);
        }

        public List<Shift> GetEmployeeShifts(int employeeId) 
        {
            List<Shift> shifts = shiftsDAL.GetEmployeeShifts(employeeId);

            return shifts;
        }

    }
}
