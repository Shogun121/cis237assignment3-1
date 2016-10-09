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
            Console.WriteLine("| Droid Management System v1.2 |");
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
                switch (userInput)
                {
                    case "1": //Print the droid list.
                        Console.WriteLine("You have selected Option 1");
                        GetMainInput();
                        break;
                    case "2": //Add a Droid to the list.
                        Console.WriteLine("You have selected Option 2");
                        GetMainInput();
                        break;
                    default: //Exit the system.
                        Console.WriteLine("Thank you for using the Droid Management System.");
                        break;
                }   
        }
        /// <summary>
        /// A method used to acquire User Input and validates it.
        /// </summary>
        public void GetMainInput()
        {
            userInput = Console.ReadLine();

            while(userInput!="1" && userInput!="2" && userInput!="3")
            {
                //If input does not match criteria, print the contingency message.
                InvalidMainInput();

                //Then reprint menu so user knows what their options are.
                PrintMain();

                //reaquire input
                userInput = Console.ReadLine();
                
                //clear console of error message.
                ClearConsole();

                //Reprint menu.
                PrintMain(); 
            }
            
        }
        /// <summary>
        /// Method for catching bad input at main menu.
        /// </summary>
        public void InvalidMainInput()
        {
            ClearConsole();

            Console.WriteLine();
            Console.WriteLine("Invalid Input, please enter a number '1' through '3' for an option.");
            Console.WriteLine("The input you gave was "+ "'"+userInput+"'");
            Console.WriteLine();

            
        }
        /// <summary>
        /// A method used to run the UI cleanly.
        /// </summary>
        public void MainMenuRun()
        {
            //Prints main menu
            PrintMain();
            //Acquires input for main menu.
            GetMainInput();
            while(userInput!="3")
            {               
                //Use input to select a menu option, and continue until "3" is chose to exit.
                MenuChoice();
            }
            
        }
        /// <summary>
        /// A method used to clear the console.
        /// </summary>
        public void ClearConsole()
        {
            Console.Clear();
        }
        //-----------------------
        //Properties
        //-----------------------
        public string Input
        {
            get { return userInput; }
            set { userInput = value; }
        }
    }
}
