using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Interfaces
{
    public interface ICar
    {
        decimal GetPrice();
        string GetFeatures();
        string GetColor();
        Interfaces.SafetyRatings GetSafteyRating();
        Interfaces.Cartypes GetType();
    }

}
