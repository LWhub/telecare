using CarFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Cars
{
    public class Car: ICar  
    {
        public Interfaces.Cartypes CarType { get; set; }
        public Interfaces.SafetyRatings SafteyRating { get; set; }
        public decimal _price;
        protected Interfaces.Colors _color;

        virtual public decimal GetPrice()
        {
            return _price;
        }

        public string GetColor()
        {
            string ret = String.Empty;
            switch (_color)
            {
                case Colors.black:
                    ret = "black"; break;
                case Colors.red:
                    ret = "red"; break;
                case Colors.white:
                    ret = "white"; break;
            }
            return ret;
        }

        virtual public string GetFeatures()
        {
            string ret = "Base Features: Color = " + GetColor() + " Price: " + GetPrice();
            return ret;
        }

        virtual public SafetyRatings GetSafteyRating()
        {
            return this.SafteyRating;
        }

        Cartypes ICar.GetType()
        {
            return this.CarType;
        }
    }
}
