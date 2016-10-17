/**
 * Robert Cooley
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{   //class used to store the droid array and perform various tasks on it.
    class DroidCollection
    {
        //class instantiation.
        UserInterface uI= new UserInterface();
        //----------
        //Backing Fields
        //----------

        //----------
        //Constructor
        //----------
        //public DroidCollection(UserInterface uI)
        //{
        //    uI = this.uI;
        //}
        //----------
        //Methods
        //----------
        public string[] CreateProtocolDroid()
        {
            string[] pDroid = new string[5];
            uI.UiHandlingCreateProtocolDroid(pDroid);
            foreach (string i in pDroid)
            {
                Console.WriteLine(i);
            }
            return pDroid;
        }
        public void CreateUtilityDroid()
        {
            Console.WriteLine("You chose to create a '{0}'","Utility Droid");
        }
        public void CreateJanitorDroid()
        {
            Console.WriteLine("You chose to create a '{0}'", "Janitor Droid");
        }
        public void CreateAstromechDroid()
        {
            Console.WriteLine("You chose to create a '{0}'", "Astromech Droid");
        }

        //----------
        //Properties
        //----------

    }
}
