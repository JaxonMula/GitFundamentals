using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



//properties

//gives the developer the ability to have read/write methods on variable containers within the class 
//public Type VariableName {get;set;}

//*{get;set;} this is shorthand for read/write methods

//use Pascal-Casing EveryFirstLetterIsCapitalized

namespace _08_Properties
{

    public class Donut
    {

        #region Private Backing Field
        private string _donutType;
        private string _Filling;
        #endregion

        #region Properties... these are the attributes of a class
        //prop
        public string Filling
        {
            get
            {
                //read only
                return _Filling.ToUpper();
            }
            set
            {
                _Filling = value;
            }
        }

        public string Topping { get; set; }

        public decimal price { get; set; } = .25m;

        public bool IsSpecial { get; set; } = false;


        #endregion

        #region Get/Set Methods that will be used for reading and writing purposes
        //This is our getter (read-only) method
        public string GetDonutType()
        {
            return _donutType;
        }

        //this is our setter (write-only) method
        public void setDonutType(string donutType)
        {
            _donutType = donutType;
        }



        #endregion

        #region Constructors. what we use to make an object class on the fly
        public Donut()
        {
            _donutType = "Plain Jane";
        }
        //lets create some method overloads...
        public Donut(string donutType)
        {
            _donutType = donutType;
        }

        //full-constructor 
        public Donut(string donutType, string filling, string topping, bool isSpecial)
        {
            _donutType = donutType;
            Filling = filling;
            Topping = topping;
            isSpecial = IsSpecial;
            price = Price;
        }
        #endregion

        #region Special Price Calculation
        private decimal CalculateSpecialPrice(bool isSpecial)
        {
            if (isSpecial)
            {
                return price * 2;
            }
            else
            {
                return price;
            }
        }
        #endregion

        #region overriding ToString()
        public ovveride string ToString()
        {
            return $"This donut is {this.GetDonutType()}\n full of {this.Filling}\n and topped with {this.Topping\n} for {CalculateSpecialPrice(this.IsSpecial)}";
        }
        #endregion
    }
}