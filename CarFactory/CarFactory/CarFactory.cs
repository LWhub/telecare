using CarFactory.Interfaces;
using CarFactory.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    abstract class CarFactory
    {
        public abstract ICar MakeCar(Cartypes type);
    }

    class factory : CarFactory
    {
        public override ICar MakeCar(Cartypes type)
        {
            switch (type)
            {
                case Cartypes.basecar:
                    return new baseCar();
                case Cartypes.navigation:
                    return new NavigationCar();
                case Cartypes.bluetooth:
                    return new BluetoothCar();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
