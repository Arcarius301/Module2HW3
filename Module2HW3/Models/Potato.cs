using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3.Models
{
    public class Potato : Tuber
    {
        public Potato()
        {
            Name = "Potato";
            Kilocalories = 100;
            GrowthTimeInDays = 95;
            RootSizeInCentimeters = 7;
            HasLateralBud = true;
        }
    }
}
