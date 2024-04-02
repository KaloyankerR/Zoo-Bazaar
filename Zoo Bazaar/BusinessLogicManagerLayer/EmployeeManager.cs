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
    public class EmployeeManager
    {
        RegionManager regionManager = new RegionManager(new RegionDAL());

        private IEmployeeDAL employeeCRUD;


        public EmployeeManager(IEmployeeDAL emp)
        {
            this.employeeCRUD = emp;
        }

        public void CreateEmployee(Employee employee)
        {
            employeeCRUD.CreateEmployee(employee);
        }

        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = employeeCRUD.GetAllEmployees();
            return employees;
        }

        public string DeleteEmployeeByID(int employeeID)
        {
            string message = employeeCRUD.DeleteEmployeeByID(employeeID);
            return message;

        }

        public Employee GetEmployeeByID(int employeeID)
        {
            Employee emp = employeeCRUD.GetEmployeeByID(employeeID);
            return emp;
        }

        public List<Employee> GetAllEmployeesByName(string name)
        {
            List<Employee> employees = employeeCRUD.GetAllEmployeesByName(name);
            return employees;
        }

        public Employee Login(string email, string password)
        {
            Employee emp = employeeCRUD.Login(email, password);
            return emp;
        }

        public void SaveRegionToEmployee(Employee emp, ZooRegion region)
        {
            employeeCRUD.SaveRegionToEmployee(emp, region);
        }

        public List<ZooRegion> GetAssignedRegionsByEmployeeID(int employeeID)
        {
            List<string> regionsNames = employeeCRUD.GetAssignedRegionsByEmployeeID(employeeID);


            List<ZooRegion> allAssignedRegions = new List<ZooRegion>();
            foreach (string regionName in regionsNames)
            {
                ZooRegion region = regionManager.GetRegionByName(regionName);
                allAssignedRegions.Add(region);
            }


            return allAssignedRegions;
        }

        public string DeleteRegionAssignment(Employee emp, ZooRegion region)
        {
            string message = employeeCRUD.DeleteRegionAssignment(emp, region);
            return message;
        }
    }
}
