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
        //class instantiation.
        DroidCollection myDroidCollection;
        //-----------------------
        //Backing Fields
        //-----------------------

        string userInput;                             //used to access Input property for User Input
        bool droidTypeValidation;                     //Bool used for data validation test.
        //-----------------------
        //Constructor
        //-----------------------
        public UserInterface()
        {
           new DroidCollection(this);
        }
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
                    case "1": 
                        //Print the droid list.
                        Console.WriteLine("You have selected 'Print the Droid List'");
                        GetMainInput();
                        break;
                    case "2": 
                        //Add a Droid to the list.
                        Console.WriteLine("You have selected 'Add a Droid'");
                        GetDroidType();

                        //Allow the user to continue making deicisions.
                        ClearConsole();            
                        Console.WriteLine("What would you like to do now?");
                        PrintMain();
                        GetMainInput();
                        break;
                    case "3": 
                        //Exit the system.
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
                //Use input to select a menu option, and continue until "3" is choosen to exit.
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
        /// <summary>
        /// Method used to acquire user input to determine what droid type to create.
        /// </summary>
        public void GetDroidType()
        {   //delcare bool as false to validate.
            droidTypeValidation = false;

            //loop while bool remains false.
            while(droidTypeValidation==false)
            {
                //Stores a line of input in the 'Input' property.
                Input = Console.ReadLine();
                try
                {
                    //Compares 'Input' to the droid types.
                    if (Input.ToLower() == "protocol" && Input.ToLower() == "utility"
                        && Input.ToLower() == "janitor" && Input.ToLower() == "astromech")
                    {
                        //If 'Input' matches one of the droid types the switcher is called.
                        CreateDroid();
                    }
                    //Data has been validated, bool is set to true.
                    droidTypeValidation = true;
                }
                catch
                {
                    //Method call to inform the user that the input is invalid.
                    InvalidDroidType();
                }
            }            
        }
        /// <summary>
        /// method used to switch through the droid types to 
        /// correctly prompt the user to create a droid.
        /// </summary>
        public void CreateDroid()
        {
            switch(Input)
            {
                case "protocol":
                //call CreateProtocolDroid()
                    myDroidCollection.CreateProtocolDroid();
                    break;
                case "utility":
                //call CreateUtilityDroid()
                    myDroidCollection.CreateUtilityDroid();
                    break;
                case "janitor":
                //call CreateJanitorDroid()
                    myDroidCollection.CreateJanitorDroid();
                    break;
                case "astromech":
                //call CreateAstromechDroid()
                    myDroidCollection.CreateAstromechDroid();
                    break;
            }
        }
        /// <summary>
        /// method used to report incorrect droid types.
        /// </summary>
        public void InvalidDroidType()
        {
            Console.WriteLine();
            Console.WriteLine("The droid type '{0}' is not valid.",Input);
            Console.WriteLine("Please enter a valid droid type.");
        }
        /// <summary>
        /// Method used to report incorrect droid material.
        /// </summary>
        public void InvalidDroidMaterial()
        {
            Console.WriteLine();
            Console.WriteLine("The droid material '{0}' is not valid.", Input);
            Console.WriteLine("Please enter a valid droid {0}.","material");
        }
        /// <summary>
        /// Method used to report incorrect droid color.
        /// </summary>
        public void InvalidDroidColor()
        {
            Console.WriteLine();
            Console.WriteLine("The droid color '{0}' is not valid.", Input);
            Console.WriteLine("Please enter a valid droid {0}.", "color");
        }
        /// <summary>
        /// Method used to report incorrect droid number of languages.
        /// </summary>
        public void InvalidDroidNumberOfLanguages()
        {
            Console.WriteLine();
            Console.WriteLine("The droid Number of Languages '{0}' is not valid.", Input);
            Console.WriteLine("Please enter a valid number for {0}.", "Number of Languages");
        }
        public void UiHandlingCreateProtocolDroid()
        {
            bool ValidProtocolInput = false;
            while(!ValidProtocolInput)
            {
                try
                {
                    Console.WriteLine("What material will the protocol Droid be made of?");
                    Console.WriteLine("1) Fragillium--------200");
                    Console.WriteLine("2) Okium--------300");
                    Console.WriteLine("3) Durium--------500");
                    Console.WriteLine("4) Cosmosium--------1,000");

                    //Read Line to variable to store it, and price
                    //if(input==1 &&input==2 &&input==3 &&input==4)
                    //{
                        //return the cost of the material.
                    //}
                    try
                    {
                        Console.WriteLine("What color will the protocol Droid be?");
                        Console.WriteLine("1) White--------250");
                        Console.WriteLine("2) Black--------250");

                        //Read Line to variable to store it, and price
                        //if(input==1 &&input==2)
                        //{
                        //return the cost of the color..
                        //}
                        try
                        {
                            Console.WriteLine("How many languages do you want the Protocol Droid to have?");

                            //Read Line to variable to store it, and price
                            //if(input==aNumber)
                            //{
                            //  if(input>1 )
                            //{
                            //      return the number.
                            //}
                            //return the cost of the color..
                            //}
                        }
                        catch
                        {
                            InvalidDroidNumberOfLanguages();
                        }
                    }
                    catch
                    {
                        InvalidDroidColor();
                    }
                }
                catch
                {
                    InvalidDroidMaterial();
                }
                ValidProtocolInput = true;
            }
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
