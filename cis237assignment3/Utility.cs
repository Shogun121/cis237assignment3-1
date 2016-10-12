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
    class Utility : Droid
    {
        //-------------------
        //Backing Fields
        //-------------------
        //utility droid features
        protected bool _toolBox;
        protected bool _computerConnection;
        protected bool _arm;

        //feature prices
        protected const decimal toolboxCost=150m;
        protected const decimal computerConnectionCost = 300m;
        protected const decimal armCost = 400m;

        //utility droid feature accumulator
        protected decimal utilityAccum;
        //-------------------
        //Constructors
        //-------------------
        public Utility(string Model, string Material, string Color,bool Toolbox, bool ComputerConnection, bool Arm)
            : base(Model,Material,Color)
        {
            _toolBox = Toolbox;
            _computerConnection = ComputerConnection;
            _arm = Arm;
        }
        public Utility():base()
        {

        }
        //-------------------
        //Methods
        //-------------------
        /// <summary>
        /// Method inherited from object, override from Droid, and class info is rolled in.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
                "ToolBox: " + _toolBox + Environment.NewLine +
                "Computer Connection: " + Environment.NewLine +
                "Arm: " + _arm;
        }
        /// <summary>
        /// Method used to calc tot cost of utility droid features and rolls it into the total.
        /// </summary>
        /// <returns></returns>
        public override void CalculateTotalCost()
        {
            if(_toolBox==true)
            {
                utilityAccum += toolboxCost;
            }
            if (_computerConnection == true)
            {
                utilityAccum += computerConnectionCost;
            }
            if (_arm == true)
            {
                utilityAccum += armCost;
            }
            TotalCost += _baseCost;
            //return base.CalculateTotalCost()+utilityAccum;
        }
        //-------------------
        //Properties
        //-------------------
    }
}
