using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW3.Models;

namespace Module2HW3.Services
{
    public class VegetableComparer : IComparer<Vegetable>
    {
        public int Compare(Vegetable x, Vegetable y)
        {
            if (x.Kilocalories > y.Kilocalories)
            {
                return 1;
            }
            else if (x.Kilocalories < y.Kilocalories)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
