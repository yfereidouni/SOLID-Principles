using System;

namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeDetailsModified = new EmployeeDetailsModified(new SalaryCalculatorModified());
            employeeDetailsModified.HourlyRate = 50;
            employeeDetailsModified.HoursWorked = 150;
            Console.WriteLine($"The Total Pay is {employeeDetailsModified.GetSalary()}");
        }
    }
}
