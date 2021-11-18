using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3.Models
{
    public class Artichoke : Flower
    {
        public Artichoke()
        {
            Name = "Artichoke";
            Kilocalories = 15;
            GrowthTimeInDays = 40;
            Stem = StemSize.Medium;
            FlowerColor = FlowerColor.Green;
        }
    }
}
