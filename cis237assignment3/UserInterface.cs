/**
 * Robert Cooley
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//class used to handle the UI.
namespace cis237assignment3
{
    class UserInterface
    {   
        //-----------------------
        //Backing Fields
        //-----------------------
        string userInput;
        //-----------------------
        //Methods
        //-----------------------
        /// <summary>
        /// A method used to print the main menu in the console window.
        /// </summary>
        public void PrintMain()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("| Droid Management System v1.1 |");
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            Console.WriteLine("Please select an option.");
            Console.WriteLine();
            Console.WriteLine("1. Print Droid List");
            Console.WriteLine("-------------------");
            Console.WriteLine("2. Add Droid");
            Console.WriteLine("------------");
            Console.WriteLine("3. Exit DMS");
            Console.WriteLine();
        }
        /// <summary>
        /// A method taking in the user input and switches into the choice.
        /// </summary>
        public void MenuChoice()
        {   
            //if the menu option isn't '3' then continue until 3 is selected.
            while(userInput!="3")
            {
                switch (userInput)
                {
                    case "1": //Print the droid list.
                        break;
                    case "2": //Add a Droid to the list.
                        break;
                    case "3": //Exit the system.
                        Console.WriteLine("Thank you for using the Droid Management System.");
                        break;
                }
            }    
        }
        /// <summary>
        /// A method used to acquire User Input and validates it.
        /// </summary>
        public void GetInput()
        {
            userInput = Console.ReadLine();

            if(userInput!="1" && userInput!="2" && userInput!="3")
            {
                //If input does not match criteria, print the contingency message.
                InvalidMainInput();
                //Then reprint menu so user knows what their options are.
                PrintMain();
            }
            //If input is valid, proceed with menu.
            MenuChoice();
            
        }
        /// <summary>
        /// Method for catching bad input at main menu.
        /// </summary>
        public void InvalidMainInput()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Invalid Input, please enter a number for an option.");
            Console.WriteLine();
        }
    }
}
