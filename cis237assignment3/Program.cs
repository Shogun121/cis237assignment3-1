/**
 * Robert Cooley
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//where the magic happens.
namespace cis237assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //class instantiations
            UserInterface uI = new UserInterface();
            DroidCollection DCollection = new DroidCollection();
            Utility UDroid = new Utility();
            Janitor JDroid = new Janitor();
            Protocol PDroid = new Protocol();
            Astromech ADroid = new Astromech();

            string choice;
            

            //Prints main menu
            uI.PrintMain();
            //Acquires input for main menu.
            choice = uI.GetMainInput();
            //Switch statement for menu choices.
            while(choice!="3")
            {
                switch (choice)
                {
                    case "1":
                        //Print the droid list.
                        Console.WriteLine("You have selected 'Print the Droid List'");
                        uI.GetMainInput();
                        break;
                    case "2":
                        //Add a Droid to the list.
                        Console.WriteLine("You have selected 'Add a Droid'");
                        choice = uI.GetDroidType().ToLower();
                        switch (choice)
                        {
                            case "protocol":
                                DCollection.CreateProtocolDroid();
                                break;
                            case "utility":
                                //call CreateUtilityDroid()
                                DCollection.CreateUtilityDroid();
                                break;
                            case "janitor":
                                //call CreateJanitorDroid()
                                DCollection.CreateJanitorDroid();
                                break;
                            case "astromech":
                                //call CreateAstromechDroid()
                                DCollection.CreateAstromechDroid();
                                break;
                        }
                        //Allow the user to continue making deicisions.
                        Console.WriteLine("What would you like to do now?");
                        //uI.PrintMain();
                        //uI.GetMainInput();
                        break;
                    case "3":
                        //Exit the system.
                        Console.WriteLine("Thank you for using the Droid Management System.");
                        break;
                }
            }
            
            
        }
    }
}
