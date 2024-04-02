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
    public class EmployeeScheduleManager
    {
        private IShiftsDAL shiftsDAL;

        private List<Shift> shifts;
        public List<Shift> Shifts { get { return shifts; } private set {  shifts = value; } }

        private List<Employee> employees;
        public List<Employee> Employees { get { return employees; } private set { employees = value; } }
        public EmployeeScheduleManager(List<Employee> employee,ShiftsDAL shiftsDAL) 
        {
            this.shiftsDAL = shiftsDAL;
            //shifts = new List<Shift> { new Shift(1, Position.HR, new DateTime(2023, 12, 11, 12, 0, 0), new DateTime(2023, 12, 11, 12, 0, 0), 10, new List<Employee>()),
            //                            new Shift(2, Position.HR, new DateTime(2023, 12, 12, 12, 0, 0), new DateTime(2023, 12, 12, 12, 0, 0), 10, new List<Employee>())
            //                            };
            this.employees = employee;
        }

        public EmployeeScheduleManager(List<Shift> shifts, List<Employee> employees,IShiftsDAL shiftsDAL)
        {
            this.shifts = shifts;
            this.shiftsDAL = shiftsDAL;
            this.employees = employees;
      
        }

        public List<Shift> NeededShifts(DateTime start, DateTime end)
        {
            List<Shift> shifts = new List<Shift>();
            foreach(Shift shift in this.shifts)
            {
                if(shift.ShiftStart > start && shift.ShiftStart < end)
                { shifts.Add(shift); }
            }
            return shifts;
        }

        public void LoadShifts()
        {
            this.shifts = this.shiftsDAL.GetShifts();
        }

        public void AddShift(Shift shift)
        {
            DateTime start = new DateTime(shift.ShiftStart.Year, shift.ShiftStart.Month, shift.ShiftStart.Day, shift.ShiftStart.Hour, shift.ShiftStart.Minute, 0);

            if (shift.ShiftStart > shift.ShiftEnd)
            {
                throw new Exception("Start time cannot be after end time.");
            }
            else if (start.AddHours(8) < shift.ShiftEnd)
            {
                throw new Exception("Shift cannot be longer than 8 hours.");
            }
            if (shift.EmployeesAssigned.Count < 1)
            {
                throw new Exception("Please assgin at least one employee.");
            }
            if (shift.EmployeesAssigned.Count > shift.Capacity)
            {
                throw new Exception("Too many employees assigned.");
            }
            int id = shiftsDAL.CreateShift(shift);
            shift.ID = id;
            shifts.Add(shift);
        }



        public void LoadEmp()
        {
            this.shiftsDAL.LoadEmp(this.Shifts,this.employees);
        }

        public void CopyWeek(int day, int year)
        {
            List<Shift> newS = new List<Shift>(this.shifts);
            foreach(Shift shift in newS)
            {
                if (shift.ShiftStart.Year == year)
                {
                    if (shift.ShiftStart.DayOfYear >= day + 7 && shift.ShiftStart.DayOfYear <= day + 14)
                    {
                        this.RemoveShit(shift);
                    }
                }
            }
            foreach (Shift shift in newS)
            {
                if (shift.ShiftStart.Year == year)
                {
                    if (shift.ShiftStart.DayOfYear >= day && shift.ShiftStart.DayOfYear <= day + 7)
                    {
                       this.AddShift(new Shift(shift.Position, shift.ShiftStart.AddDays(7), shift.ShiftEnd.AddDays(7), shift.Capacity, shift.EmployeesAssigned));
                    }
                }
            }
        }

        public void RemoveShit(Shift shift)
        {
            this.shifts.Remove(shift);
            // this.shiftsDAL.DeleteShift(shift);
        }

        public void AssignEmployee(Shift shift, Employee employee)
        {
            shift.EmployeesAssigned.Add(employee);
            shiftsDAL.AssignEmployee(shift, employee);
        }

        public void UnAssignEmployee(Shift shift, Employee employee)
        {
            shift.EmployeesAssigned.Remove(employee);
            shiftsDAL.UnAssignEmployee(shift, employee);
        }

        public List<Shift> FilterShifts(List<Shift> shifts, Dictionary<string, object?> filters)
        {
            List<Shift> filteredShifts = new List<Shift>(shifts);

            try
            {
                foreach (var filter in filters)
                {
                    string filterKey = filter.Key;
                    object? filterValue = filter.Value;

                    switch (filterKey)
                    {
                        case "position":
                            if (filterValue != null)
                            {
                                if (filterValue is Position positionFilter)
                                {
                                    filteredShifts = filteredShifts.Where(s => s.Position == positionFilter).ToList();
                                }
                            }
                            break;
                        case "startTime":
                            if (filterValue is DateTime startTimeFilter)
                            {
                                filteredShifts = filteredShifts.Where(s => s.ShiftStart >= startTimeFilter).ToList();
                            }
                            break;
                        case "endTime":
                            if (filterValue is DateTime endTimeFilter)
                            {
                                filteredShifts = filteredShifts.Where(s => s.ShiftEnd <= endTimeFilter).ToList();
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            catch
            {
                return shifts;
            }

            return filteredShifts;
        }

    }
}
