﻿
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring a variable of type Employee and instantiate a new instance of Employee and assigning it to the variable
            Employee myEmployee = new Employee();
            //Use properties to assign values
            myEmployee.FirstName = "Morgan";
            myEmployee.LastName = "Boon";
            myEmployee.WeeklySalary = 298763.02m;

            //Output by property
            Console.WriteLine(myEmployee.FirstName);
            //Output the entire  employee, which will call the ToString method implicitly 
            //This would work with out overriding the TOString method but we would print the name-space and the name of the class
            Console.WriteLine(myEmployee);

            //Creates array and allocates memory for the objects
            Employee[] employees = new Employee[10];

            //Assign values to the arrayEach spot needs to contain an instance of Employee
            employees[0] = new Employee("James", "blah", 45667.01m);
            employees[1] = new Employee("Jam", "blame", 45660000007.01m);
            employees[2] = new Employee("Jes", "b", 67.01m);
            employees[3] = new Employee("Mes", "cash", 0.01m);
            employees[4] = new Employee("Sam", "lab", 7.01m);
            employees[5] = new Employee("Jack", "ah", 4563267.01m);
            employees[6] = new Employee("Ram", "bl h", 4524667.01m);

            //For each array item it goes through the loop
            foreach (Employee employee in employees)
            {
                if (employee != null)
                {
                    Console.WriteLine(employee.ToString() + " " + employee.YearlySalary());

                }

            }

            //Use the CSVProcessor method that we wrote into main to load the employees from the csv file
            ImortCsv("employees.csv", employees);




            //Instantiate a new UI class
            UserInterface ui = new UserInterface();

            //Gets input from UI class
            int choice = ui.getUserInput();

            //While the input is not 2 it continues in the loop to see what they want to do
            while (choice != 2)
            {
                //If one is chosen then it will go to the for each loop
                if (choice == 1)
                {
                    //String a made to concatenate the list in
                    string allOutput = "";

                    //loops through the employees to concatenate them.
                    foreach (Employee employee in employees)
                    {
                        if (employee != null)
                        {
                            allOutput += employee.ToString() + " " + employee.YearlySalary() + Environment.NewLine;
                        }
                    }
                    //Once the loop is done the UI class will print the results
                    ui.PrintAllOutput(allOutput);
                }
                //Gets the next choice from the user
                choice = ui.getUserInput();
            }

        }

        static bool ImortCsv(string pathToCsvFile, Employee[] employees)
        {
            //Declare variable for stream Reader. Not going to instantiate yet
            StreamReader streamReader = null;

            //Try so anything that goes wrong can be caught
            try
            {
                //Declare a sting for each line we read in
                string line;

                //Instantiate the stream reader
                streamReader = new StreamReader(pathToCsvFile);

                //Setup counter that we are not using yet
                int counter = 0;

                //while there is a line to read, processes it and input it to the 
                while ((line = streamReader.ReadLine()) != null)
                {
                    //Calls the processLine method and send over the read in line
                    //the  employee array is passed by reference
                    //counter counts
                    processLine(line, employees, counter++);
                }
                return true;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine();
                //Shows all method calls that lead to where the exception occurred
                Console.WriteLine(e.StackTrace);

                return false;
            }
            //Runs if passes or fails
            finally
            {

                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
            
        }

        static void processLine(string line, Employee[] employees, int index)
        {
            //splits items by commas
            string[] parts = line.Split(',');

            //Assign parts of array to variables
            string firstName = parts[0];
            string lastName = parts[1];
            decimal salaryDecimal = decimal.Parse(parts[2]);

            //Use the variables to instantiate a new Employee and assign it to the spot in the employees array by 
            //the index that was passed in
            employees[index] = new Employee(firstName, lastName, salaryDecimal);


        }


    }
}
