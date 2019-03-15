using CarFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Cars
{
    class baseCar : ICar
    {
        protected Interfaces.Cartypes _type;
        protected Interfaces.Colors _color;
        protected Interfaces.SafetyRating _safteyRating;
        protected decimal _price;

        public baseCar()
        {
            _type = Cartypes.basecar;
            _color = Colors.white;
            _safteyRating = SafetyRating.good;
            _price = 5000.00m;
        }

        public string GetColor()
        {
            string ret = String.Empty;
            switch (_color)
            {
               case  Colors.black:
                    ret = "black";break;
                case Colors.red:
                    ret = "red";break;
                case Colors.white:
                    ret = "white";break;
            }
            return ret;
        }

        public string GetFeatures()
        {
            string ret = "Base Features: Color = " + GetColor() + "Price: " + GetPrice();
            return ret;
        }

        public decimal GetPrice()
        {
            return _price;
        }

        public SafetyRating GetSafteyRating()
        {
            return _safteyRating;
        }

        Cartypes ICar.GetType()
        {
            return _type;
        }
    }
}
