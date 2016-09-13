﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee myEmployee = new Employee();
            myEmployee.FirstName = "Morgan";
            myEmployee.LastName = "Boon";
            myEmployee.WeeklySalary = 298763.02m;

            Console.WriteLine(myEmployee.FirstName);
            Console.WriteLine(myEmployee);

            Employee[] employees = new Employee[10];

            employees[0] = new Employee("James", "blah", 45667.01m);
            employees[1] = new Employee("Jam", "blam", 45660000007.01m);
            employees[2] = new Employee("Js", "b", 67.01m);
            employees[3] = new Employee("Mes", "cah", 0.01m);
            employees[4] = new Employee("Sam", "lah", 7.01m);
            employees[5] = new Employee("Jack", "ah", 4563267.01m);
            employees[6] = new Employee("Ram", "blh", 4524667.01m);

            foreach (Employee employee in employees)
            {
                if (employee != null)
                {
                    Console.WriteLine(employee.ToString() + " " + employee.YearlySalary());

                }

            }

            UserInterface ui = new UserInterface();

            int choice = ui.getUserInput();

            while (choice != 2)
            {
                if (choice == 1)
                {
                    string allOutput = "";

                    foreach (Employee employee in employees)
                    {
                        if (employee != null)
                        {
                            allOutput += employee.ToString() + " " + employee.YearlySalary() + Environment.NewLine;
                        }
                    }

                    ui.PrintAllOutput(allOutput);
                }
                choice = ui.getUserInput();
            }
            
        }
    }
}
