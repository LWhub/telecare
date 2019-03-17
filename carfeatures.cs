using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Interfaces
{

    public enum Cartypes
    {
        basecar,
        navigation,
        bluetooth
    }
    public enum Colors
    {
        red,
        black,
        white
    }

    public enum SafetyRatings
    {
        fair = 1,
        moderate = 2,
        good = 3,
        great = 4,
        fantastic = 5
    }



    public interface INavifationCarFeature
    {
        decimal GetNavigationPrice();
        string GetNavigationFeatures();
    }

    public interface IBluetoothCarFeature
    {
        decimal GetBlueToothPrice();
        string GetBluetoothFeatures();
    }

}
