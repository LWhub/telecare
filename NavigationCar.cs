using CarFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Cars
{
    public class NavigationCar : Car, INavifationCarFeature
    {

        public NavigationCar() : base()
        {
            this.CarType = Cartypes.navigation;
            this.SafteyRating = SafetyRatings.fantastic;
            this._price = 5000.00m; 
            this._color = Colors.red;
        }

        public override string GetFeatures()
        {
            string ret =  base.GetFeatures() + GetNavigationFeatures();
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

        public override decimal GetPrice()
        {
            return base.GetPrice() + GetNavigationPrice();
        }

    }
}
