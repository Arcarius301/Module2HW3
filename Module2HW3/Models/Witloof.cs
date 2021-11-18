using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3.Models
{
    public class Witloof : Leaves
    {
        public Witloof()
        {
            Name = "Witloof";
            Kilocalories = 15;
            GrowthTimeInDays = 40;
            Stem = StemSize.Medium;
            LeavesType = LeavesType.Sharp;
        }
    }
}
