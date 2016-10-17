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
    class Protocol : Droid
    {
        //-------------------
        //Backing Fields
        //-------------------
        protected int _numberLanguages;
        protected const decimal costPerLangauge=100m;

        //-------------------
        //Constructor
        //-------------------
        public Protocol(string Model,string Material, string Color,int NumberLanguages)
            :base(Model,Material,Color)
        {
            _numberLanguages = NumberLanguages;
        }
        public Protocol():base()
        {

        }
        //-------------------
        //Methods
        //-------------------
        /// <summary>
        /// Method used to calculate total cost for droid(s).
        /// </summary>
        public override void CalculateTotalCost()
        {
            _totalCost = _numberLanguages * costPerLangauge;
            TotalCost += _baseCost;
            //return base.CalculateTotalCost() + _totalCost;
        }
        public override decimal CalculateBaseCost(string Model, string Material, string Color)
        {
            return base.CalculateBaseCost(Model, Material, Color);   
        }
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
                    "Number of Languages: " + _numberLanguages;
        }
        //-------------------
        //Properties
        //-------------------
    }
}
