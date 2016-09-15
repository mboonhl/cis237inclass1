using System;

namespace cis237Inclass1
{
    public class UserInterface
    {
        //There are no backing fields variables because we do not require any
        //There are no properties because we do not have backing fields
        //There are no constructors because the default will suffice 
        //This class is a collection of methods that do work


        //Get user input.
        public int getUserInput()
        {
            //Call printMenu method
            this.printMenu();

            //Get input form the console
            string input = Console.ReadLine();

            //Continues to loop while the input is not a valid choice
            while (input != "1" && input != "2")
            {
                Console.WriteLine("That is not a valid entry");
                Console.WriteLine("Please make a valid choice");
                Console.WriteLine();

                this.printMenu();
                input = Console.ReadLine();

            }
            //when the input is valid we can then parse the input
            return Int32.Parse(input);
        }

        public void PrintAllOutput(string allOutput)
        {
            Console.WriteLine(allOutput);
        }

        private void printMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Print List");
            Console.WriteLine("2. Exit");




        }




    }
}