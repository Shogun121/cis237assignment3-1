/**
 * Robert Cooley
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace cis237assignment3
{   //interface used for the droid class and all child classes.
    interface IDroid
    {   //method that must be created in all lower derived classes.
        decimal CalculateTotalCost();

        //property that must be used in derived classses.
         decimal TotalCost { get; set; }
    }
}
