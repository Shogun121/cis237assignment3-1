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
        //public UserInterface()
        //{
        //   new DroidCollection(this);
        //}
        ////-----------------------
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
        /// A method used to acquire User Input and validates it.
        /// </summary>
        public string GetMainInput()
        {
            Input = Console.ReadLine();

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
            return Input;          
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
        /// A method used to clear the console.
        /// </summary>
        public void ClearConsole()
        {
            Console.Clear();
        }
        /// <summary>
        /// Method used to acquire user input to determine what droid type to create.
        /// </summary>
        public string GetDroidType()
        {   //declare bool as false to validate.
            droidTypeValidation = false;

            //loop while bool remains false.
            while(droidTypeValidation==false)
            {
                Console.WriteLine("Input the type of Droid you wish to create.");
                Console.WriteLine("Your options are '{0}','{1}','{2}' or '{3}' ",
                                  "Protocol","Utility","Janitor","Astromech");
                Console.WriteLine();

                //Stores a line of input in the 'Input' property.
                Input = Console.ReadLine();
                
                //Compares 'Input' to the droid types.
                while(Input.ToLower() != "protocol" && Input.ToLower() != "utility"
                   && Input.ToLower() != "janitor" && Input.ToLower() != "astromech")
                {
                   //Method call to inform the user that the input is invalid.
                   InvalidDroidType();
                   Input = Console.ReadLine();
                }
                //Stores the input in lower case to be returned.
                userInput = Input.ToLower();

                Console.WriteLine("Your input '{0}' passed", userInput);
                Console.WriteLine();

                //Data has been validated, bool is set to true. 
                droidTypeValidation = true; 
                                           
            }
            //If 'Input' matches one of the droid types the switcher is called.
            return userInput;
        }
        /// <summary>
        /// method used to report incorrect droid types.
        /// </summary>
        public void InvalidDroidType()
        {
            Console.WriteLine();
            Console.WriteLine("The droid type '{0}' is not valid.",Input);
            Console.WriteLine("Please enter a valid droid type.");
            Console.WriteLine();
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
        /// <summary>
        /// Method used to gather the information nneccessary to create a droid.
        /// </summary>
        /// <param name="PDroid"></param>
        /// <returns></returns>
        public string[] UiHandlingCreateProtocolDroid(string [] PDroid)
        {
            //Declare local array
            string[] pDroid = PDroid;
            //Data validation bool
            bool ValidProtocolInput = false;
            while (!ValidProtocolInput)
            {
                try
                {
                    //Print the user's choices for material
                    Console.WriteLine("What material will the protocol Droid be made of?");
                    Console.WriteLine("1) Fragillium--------200");
                    Console.WriteLine("2) Okium--------300");
                    Console.WriteLine("3) Durium--------500");
                    Console.WriteLine("4) Cosmosium--------1,000");

                    //Store user's input
                    userInput = Console.ReadLine();

                    //write the input to the array
                    if (userInput == "1")
                    {
                        pDroid[0] = "Fragillium";
                        pDroid[1] = "200";
                    }
                    if (userInput == "2")
                    {
                        pDroid[0] = "Okium";
                        pDroid[1] = "300";
                    }
                    if (userInput == "3")
                    {
                        pDroid[0] = "Durium";
                        pDroid[1] = "500";
                    }
                    if (userInput == "4")
                    {
                        pDroid[0] = "Cosmosium";
                        pDroid[1] = "1000";
                    }
                    try
                    {
                        //Display user's choices for droid color.
                        Console.WriteLine("What color will the protocol Droid be?");
                        Console.WriteLine("1) White--------250");
                        Console.WriteLine("2) Black--------250");

                        //store user's input
                        userInput = Console.ReadLine();                        
                        if (userInput == "1")
                        {
                            pDroid[2] = "White";
                            pDroid[3] = "250";
                        }
                        if (userInput == "2")
                        {
                            pDroid[2] = "Black";
                            pDroid[3] = "250";
                        }
                        try
                        {
                            Console.WriteLine("How many languages do you want the Protocol Droid to have?");

                            userInput = Console.ReadLine();
                            //If the number of languages is an integer and is greater than 0...
                            if (int.Parse(userInput) > 0)
                            {
                                //...store in the array.
                                pDroid[4] = userInput;
                            }  
                        }
                        catch
                        {
                            //Error message for incorrect language.
                            InvalidDroidNumberOfLanguages();
                        }
                    }
                    catch
                    {
                        //Error message for incorrect Droid color.
                        InvalidDroidColor();
                    }
                }
                catch
                {
                    //Error message for incorrect Droid material.
                    InvalidDroidMaterial();
                }
                ValidProtocolInput = true;
            }
            //return the array of input
            return pDroid;
        }
        //-----------------------
        //Properties
        //-----------------------
         string Input
        {
            get { return userInput; }
            set { userInput = value; }
        }
    }
}
