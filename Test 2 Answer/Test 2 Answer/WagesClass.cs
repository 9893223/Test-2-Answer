using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessPayroll
{
    class Wages
    {
        //Private properties with hourly rate value initialised
        private double hourlyRate = 33.75;
        private int numHours;
        private double weeklyWages;

        //Get and set for number of hours
        public int NumHours { get { return numHours; } set { numHours = value; } }

        //Public Constructor to display message reagrding wages
        public Wages()
        {
            Console.WriteLine("I will calculate your wages");
        }
        //Method to calculate weekly wage
        public string DisplayWages(double hours)
        {
            return $"Your wages paid to you each week: {hours * hourlyRate:C}";
        }

    }
}
