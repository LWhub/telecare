using CarFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Cars
{

    public class baseCar : Car 
    {

        public baseCar()
        {
            this.CarType = Cartypes.basecar;
            this.SafteyRating  = SafetyRatings.good;
            this._price = 5000.00m;
            _color = Colors.white;
        }       
    }
}
