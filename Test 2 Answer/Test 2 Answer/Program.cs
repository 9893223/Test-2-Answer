using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessPayroll
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boolean for do while loop
            bool checkAgain = false;

            Console.WriteLine("This application was developed by Ben de Rijk\n" +
                "It calculates the employees weekly wage based " +
                "on either annual salary or hours worked\n");
            Console.WriteLine("******Welcome to the business payroll******\n");
            do
            {
                //Asking for user inout to decide what info to display
                Console.WriteLine("Please enter want information you want from the menu:\n\n1)Weekly wages according to annual salary\n2)Weekly wages according to hours worked");

                int choice = int.Parse(Console.ReadLine());

                //If statments to determine what user input does
                if (choice == 1)
                {
                    Salary emp1 = new Salary();//New Salary object created
                    Console.WriteLine(emp1.CalculateSalary());//Calling method
                    Console.ReadLine();
                }

                else if (choice == 2)
                {
                    Wages emp1 = new Wages();//Create new Wages object
                    Console.WriteLine("Please enter how many hours you worked:");//Asking for user input that will be used in method calculation
                    double hours = double.Parse(Console.ReadLine());
                    Console.WriteLine(emp1.DisplayWages(hours)); //calling method
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine($"{choice} is not an option.Please input either 1 or 2 only");//Incorrct user input error
                }

                Console.WriteLine("Do you want to check again? Y/N:");//Asking user if they wish to run application again
                char option = char.Parse(Console.ReadLine().ToLower());

                //If statements to determine if loop will be triggered
                if (option == 'y')
                {
                    checkAgain = true;
                }

                if (option == 'n')
                {
                    checkAgain = false;
                }

            } while (checkAgain == true);
      

            }
        }
    }
