using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessPayroll
{
    class Salary
    {
        //Private properties inclding annual salary initialised with value
        private double annualSalary = 80000;
        private double weeklySalary;

        //Public Constructor to display message indicating salary amount
        public Salary()
        {
            Console.WriteLine($"Your annual salary is set at {annualSalary:C}");
        }
        //Method to calculate weekely wage
        public string CalculateSalary()
        {
            return $"Therefore, your wages per week is: {annualSalary / 52:C}";
        }

    }
}
