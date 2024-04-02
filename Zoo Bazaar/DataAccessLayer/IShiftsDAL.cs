using BusinessLogicLayer;
using BusinessLogicObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IShiftsDAL
    {
        public List<Shift> GetShifts();
        public int CreateShift(Shift shift);

        public void DeleteShift(Shift shift);

        public void AssignEmployee(Shift shift, Employee employee);

        public void UnAssignEmployee(Shift shift, Employee employee);

        public void LoadEmp(List<Shift> shifts, List<Employee> employees);

        public List<Shift> GetEmployeeShifts(int employeeId);
    }
}
