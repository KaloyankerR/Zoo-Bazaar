using BusinessLogicLayer;
using BusinessLogicObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IEmployeeDAL
    {
        void CreateEmployee(Employee employee);

        List<Employee> GetAllEmployees();

        string DeleteEmployeeByID(int employeeID);
        Employee GetEmployeeByID(int employeeID);
        List<Employee> GetAllEmployeesByName(string name);
        Employee Login(string email, string password);
        void SaveRegionToEmployee(Employee emp, ZooRegion region);
        List<string> GetAssignedRegionsByEmployeeID(int employeeID);

        string DeleteRegionAssignment(Employee emp, ZooRegion region);
    }
}
