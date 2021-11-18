using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3.Models
{
    public class Cauliflower : Flower
    {
        public Cauliflower()
        {
            Name = "Cauliflower";
            Kilocalories = 35;
            GrowthTimeInDays = 80;
            Stem = StemSize.Small;
            FlowerColor = FlowerColor.White;
        }
    }
}
