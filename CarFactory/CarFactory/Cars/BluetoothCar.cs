using CarFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Cars
{
    class BluetoothCar : baseCar, IBluetoothCarFeature
    {
        public BluetoothCar():base()
        {
            this._type = Cartypes.bluetooth;
            this._color = Colors.red;
            this._safteyRating = SafetyRating.great;
        }
            
        public string GetBluetoothFeatures()
        {
            return "BlueTooth";
        }

        public decimal GetBlueToothPrice()
        {
            return 1000.00m;
        }

        public new string GetFeatures()
        {
            string ret = base.GetFeatures() + GetBluetoothFeatures();
            return ret;
        }

        public new decimal GetPrice()
        {
            return _price + GetBlueToothPrice();
        }
    }
}
