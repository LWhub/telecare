using CarFactory.Cars;
using CarFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{

    /// <summary>
    ///    Design a factory that makes cars. All cars may have common features like price, color
    ///    and safety rating but they may also have some specific features only applicable to certain cars
    ///    e.g.Navigation system and Bluetooth support.Show with examples how to make some cars and
    ///    how to check if they have a specific feature.
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            factory factory = new factory();
            ICar basecar;
            ICar navacar;
            ICar bluetoothcar;

            basecar = factory.MakeCar(Interfaces.Cartypes.basecar);
            navacar = factory.MakeCar(Interfaces.Cartypes.navigation);
            bluetoothcar = factory.MakeCar(Interfaces.Cartypes.bluetooth);

            Console.WriteLine(basecar.GetFeatures());
            Console.WriteLine(navacar.GetFeatures());
            Console.WriteLine(bluetoothcar.GetFeatures());
        }
    }
}
