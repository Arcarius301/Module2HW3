using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3.Models
{
    public class Cabbage : Leaves
    {
        public Cabbage()
        {
            Name = "Cabbage";
            Kilocalories = 27;
            GrowthTimeInDays = 99;
            Stem = StemSize.Small;
            LeavesType = LeavesType.Blant;
        }
    }
}
