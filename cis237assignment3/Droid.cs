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
    abstract class  Droid : IDroid
    {
        //------------------------------------
        //Backing Fields
        //------------------------------------    
        //Constructor variables
        protected string _model;
        protected string _material;       
        protected string _color;

        //local variables for total cost.
        protected decimal _colorCost;
        protected decimal _materialCost;

        //accumulators
        protected decimal _baseCost;
        protected decimal _totalCost;

        //constants for material prices
        protected const decimal FragilliumCost = 200m;
        protected const decimal OkiumCost = 300m;
        protected const decimal DuriumCost = 500m;
        protected const decimal CosmosiumCost = 1000m;

        //constants for color prices
        protected const decimal WhiteCost = 250m;
        protected const decimal BlackCost = 250m;

        //------------------------------------
        //Constructor
        //------------------------------------
        /// <summary>
        /// 3 parameter constructor taking in model,color, and baseCost of a Droid.
        /// </summary>
        /// <param name="Model"></param>
        /// <param name="Color"></param>
        /// <param name="Material"></param>
        public Droid(string Model, string Material,string Color)
        {
            _model = Model;        
            _material = Material;
            _color = Color;
        }
        public Droid()
        {

        }
        //------------------------------------
        //Methods
        //------------------------------------
        /// <summary>
        /// method used to Calculate Total Cost of the Droid(s).
        /// </summary>
        public virtual  void CalculateTotalCost(decimal MaterialCost,decimal ColorCost)
        {
            _materialCost = MaterialCost;
            _colorCost = ColorCost;
            TotalCost = (_materialCost + _colorCost);
        }
        /// <summary>
        /// A method to calculate the lowest possible cost of a droid.
        /// </summary>
        /// <param name="Model"></param>
        /// <param name="Material"></param>
        /// <param name="Color"></param>
        public virtual decimal CalculateBaseCost(string Model,string Material,string Color)
        {   //cannot account for droid type cost in Droid class.
            _baseCost = FragilliumCost + WhiteCost;
            Console.WriteLine("The base cost for a droid is '{0}'",_baseCost);
            return TotalCost = _baseCost;
        }
        /// <summary>
        /// Method used to print the total cost to the console of the droid.
        /// </summary>
        /// <returns>A formatted string of Model, Material, and Color.</returns>
        public override string ToString()
        {
            return "Model: " + this._model + Environment.NewLine +
                    "Material: " + this._material + Environment.NewLine +
                    "Color: " + this._color;
        }
        //------------------------------------
        //Properties
        //------------------------------------
        public decimal TotalCost
        {
            get { return _totalCost; }
            set { _totalCost = value; }
        }
    }
}
