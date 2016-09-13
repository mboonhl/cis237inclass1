using System;

namespace cis237Inclass1
{
    public class UserInterface
    {
        public int getUserInput()
        {
            this.printMenu();

            string input = Console.ReadLine();

            while (input != "1" && input != "2")
            {
                Console.WriteLine("That is not a valid entry");
                Console.WriteLine("Please make a valid choice");
                Console.WriteLine();

                this.printMenu();
                input = Console.ReadLine();

            }
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