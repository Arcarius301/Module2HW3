using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3.Models
{
    public abstract class Vegetable
    {
        public string Name { get; set; }
        public int Kilocalories { get; set; }
        public int GrowthTimeInDays { get; set; }
    }
}
