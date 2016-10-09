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
    class Droid :IDroid
    {
        //------------------------------------
        //Backing Fields
        //------------------------------------    
        //Constructor variables
        protected string _material;
        protected string _model;
        protected string _color;

        protected decimal _baseCost;
        protected decimal _totalCost;
        //------------------------------------
        //Constructor
        //------------------------------------
        /// <summary>
        /// 3 parameter constructor taking in model,color, and baseCost of a Droid.
        /// </summary>
        /// <param name="Model"></param>
        /// <param name="Color"></param>
        /// <param name="Material"></param>
        public Droid(string Model, string Color, string Material)
        {
            _model = Model;
            _color = Color;
            _material = Material;
        }
        //------------------------------------
        //Methods
        //------------------------------------
        /// <summary>
        /// method used to Calculate Total Cost of the Droid(s).
        /// </summary>
        override void CalculateTotalCost()
        {

        }
        /// <summary>
        /// Method used to print the total cost to the console of the droid.
        /// </summary>
        /// <returns></returns>
        protected override string ToString()
        {
            return base.ToString();
        }
        //------------------------------------
        //Properties
        //------------------------------------
        protected decimal TotalCost
        {
            get { return _totalCost; }
            set { _totalCost = value; }
        }
    }
}
