using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW3.Models;

namespace Module2HW3.Helpers
{
    public static class VegetableExtension
    {
        public static Vegetable[] Find(this Vegetable[] items, int kilocalories)
        {
            Vegetable[] vegetables = new Vegetable[0];

            for (var i = 0; i < items.Length; i++)
            {
                if (items[i].Kilocalories == kilocalories)
                {
                    if (vegetables.Length == 0)
                    {
                        vegetables = new Vegetable[1];
                        vegetables[0] = items[i];
                    }
                    else
                    {
                        Array.Resize(ref vegetables, vegetables.Length + 1);
                        vegetables[vegetables.Length - 1] = items[i];
                    }
                }
            }

            return vegetables;
        }

        public static Vegetable[] Find(this Vegetable[] items, LeavesType leavesType)
        {
            Vegetable[] vegetables = new Vegetable[0];

            for (var i = 0; i < items.Length; i++)
            {
                var vegetable = items[i] as Leaves;

                if (vegetable != null && vegetable.LeavesType == leavesType)
                {
                    if (vegetables.Length == 0)
                    {
                        vegetables = new Vegetable[1];
                        vegetables[0] = items[i];
                    }
                    else
                    {
                        Array.Resize(ref vegetables, vegetables.Length + 1);
                        vegetables[vegetables.Length - 1] = items[i];
                    }
                }
            }

            return vegetables;
        }
    }
}
