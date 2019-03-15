using CarFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Cars
{
    class NavigationCar : baseCar, INavifationCarFeature
    {

        public NavigationCar() : base()
        {
            this._type = Cartypes.navigation;
            this._color = Colors.red;
            this._safteyRating = SafetyRating.fantastic;
            this._price = 5000.00m;
        }

        public new string GetFeatures()
        {
            string ret = base.GetFeatures() + GetNavigationFeatures();
            return ret;
        }

        public string GetNavigationFeatures()
        {
            return " Navigation System."; 
        }

        public decimal GetNavigationPrice()
        {
            return 2000.00m;
        }

        public decimal GetPrice()
        {
            return _price + GetNavigationPrice();
        }
    }
}
