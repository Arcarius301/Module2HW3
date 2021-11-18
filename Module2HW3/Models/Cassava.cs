using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3.Models
{
    public class Cassava : Tuber
    {
        public Cassava()
        {
            Name = "Cassava";
            Kilocalories = 57;
            GrowthTimeInDays = 120;
            RootSizeInCentimeters = 6;
            HasLateralBud = false;
        }
    }
}
