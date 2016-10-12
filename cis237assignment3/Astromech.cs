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
    class Astromech : Utility
    {
        //-----------------
        //Backing Fields
        //-----------------
        protected bool _fireExtinguisher;
        protected int _numberOfShips;

        protected decimal astromechAccum;

        protected const decimal costOfExtinguisher = 200m;
        protected const decimal costPerShip = 120m;
        //-----------------
        //Constructor
        //-----------------
        public Astromech():base()
        {

        }
        public Astromech(string Model, string Material, string Color,bool ToolBox, 
            bool ComputerConnection, bool Arm, bool FireExtinguisher, int NumberOfShips )
            : base(Model,Material,Color,ToolBox,ComputerConnection,Arm)
        {
            _fireExtinguisher = FireExtinguisher;
            _numberOfShips = NumberOfShips;
        }
        //-----------------
        //Methods
        //-----------------
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
                "Fire Extinguisher: " + _fireExtinguisher + Environment.NewLine +
                "Number of Ships: " + _numberOfShips;
        }
        public override void CalculateTotalCost()
        {
            if(_fireExtinguisher==true)
            {
                astromechAccum += costOfExtinguisher;
            }
            if (_numberOfShips > 1)
            {
                astromechAccum += (_numberOfShips * costPerShip) ;
            }
            TotalCost += _baseCost;
            //return base.CalculateTotalCost()+astromechAccum;
        }
        //-----------------
        //Properties
        //-----------------
    }
}
