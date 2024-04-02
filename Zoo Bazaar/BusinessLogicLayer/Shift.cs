using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicObjectLayer
{
    public class Shift
    {
        public int ID { get; set; }
        //public ZooRegion Region { get; set; }
        public Position Position { get; set; }
        public DateTime ShiftStart { get; set; }
        public DateTime ShiftEnd { get; set; }
        public int Capacity { get; set; }
        public List<Employee> EmployeesAssigned { get; set; }

        public Shift(int id,/*, ZooRegion region*/Position position, DateTime shiftStart, DateTime shiftEnd, int capacity, List<Employee> employeesAssigned)
        {
            ID = id;
            // Region = region;
            Position = position;
            ShiftStart = shiftStart;
            ShiftEnd = shiftEnd;
            Capacity = capacity;
            EmployeesAssigned = employeesAssigned;
        }

        public Shift(/*, ZooRegion region*/Position position, DateTime shiftStart, DateTime shiftEnd, int capacity, List<Employee> employeesAssigned)
        {
           // ID = id;
           // Region = region;
            Position = position;
            ShiftStart = shiftStart;
            ShiftEnd = shiftEnd;
            Capacity = capacity;
            EmployeesAssigned = employeesAssigned;
        }
    }
}
