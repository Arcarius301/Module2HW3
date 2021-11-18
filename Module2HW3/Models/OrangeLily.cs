using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3.Models
{
    public class OrangeLily : Bulb
    {
        public OrangeLily()
        {
            Name = "OrangeLily";
            Kilocalories = 10;
            GrowthTimeInDays = 90;
            RootSizeInCentimeters = 10;
            IsBulbOverTheGround = true;
        }
    }
}
