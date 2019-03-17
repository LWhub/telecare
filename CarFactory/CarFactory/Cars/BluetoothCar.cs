using CarFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Cars
{
    public class BluetoothCar : Car, IBluetoothCarFeature
    {
        public BluetoothCar():base()
        {
            this.CarType = Cartypes.bluetooth;
            this.SafteyRating = SafetyRatings.great;
            this._price = 5000.0m;
            this._color = Colors.black;
        }
            
        public string GetBluetoothFeatures()
        {
            return " BlueTooth";
        }

        public decimal GetBlueToothPrice()
        {
            return 1000.00m;
        }

        public override string GetFeatures()
        {
            string ret = base.GetFeatures() + GetBluetoothFeatures();
            return ret;
        }

        public override decimal GetPrice()
        {
            return base.GetPrice() + GetBlueToothPrice();
        }
    }
}
