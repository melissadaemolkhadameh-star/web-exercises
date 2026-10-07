using System;

namespace Employees
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalID { get; set; }
        public string Job { get; set; }
        public DateTime EmployedDate { get; set; }

        public double CalculateWorkHours(double hoursPerDay, int workingDays)
        {
            return hoursPerDay * workingDays;
        }

        public double CalculateSalary(double hourlySalary, double workHours)
        {
            return hourlySalary * workHours;
        }
    }
}
