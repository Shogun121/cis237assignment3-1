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
        public void CreateProtocolDroid()
        {
            string[] pDroid = new string[5];
            uI.UiHandlingCreateProtocolDroid(pDroid);
            for(int i=0;i>5;i++)
            {
                Console.WriteLine(pDroid[i]);
            }
        }
        public void CreateUtilityDroid()
        {
        }
        public void CreateJanitorDroid()
        {
        }
        public void CreateAstromechDroid()
        {
        }

        //----------
        //Properties
        //----------

    }
}
