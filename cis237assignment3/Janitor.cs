/**
 * Robert Cooley
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Janitor : Utility
    {
        //------------------
        //Backing Fields
        //------------------
        bool _trashCompactor;
        bool _vacuum;

        const decimal costPerShip = 600m;
        const decimal compactorCost = 350m;
        const decimal vacuumCost = 150m;
        int numberOfShips=1;

        decimal janitorAccum;
        //------------------
        //Constructor
        //------------------
        public Janitor():base()
        {

        }
        public Janitor(string Model, string Material, string Color, bool TrashCompactor, bool Vacuum,
            bool ToolBox,bool ComputerConnection, bool Arm)
            : base(Model, Material, Color, ToolBox, ComputerConnection, Arm)
        {
            _trashCompactor = TrashCompactor;
            _vacuum = Vacuum;
        }
        //------------------
        //Methods
        //------------------
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
                "Trash Compactor: " + _trashCompactor + Environment.NewLine +
                "Vacuum: " + _vacuum;
        }
        public override void CalculateTotalCost()
        {
            if(_trashCompactor==true)
            {
                janitorAccum += compactorCost;
            }
            if(_vacuum==true)
            {
                janitorAccum += vacuumCost;
            }
            //number of ships HAS to be at least 1.
            janitorAccum += costPerShip * numberOfShips;

            TotalCost += _baseCost;
            //return base.CalculateTotalCost()+janitorAccum;
        }
        //------------------
        //Properties
        //------------------
    }
}
