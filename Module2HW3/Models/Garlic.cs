using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3.Models
{
    public class Garlic : Bulb
    {
        public Garlic()
        {
            Name = "Garlic";
            Kilocalories = 20;
            GrowthTimeInDays = 100;
            RootSizeInCentimeters = 3;
            IsBulbOverTheGround = false;
        }
    }
}
