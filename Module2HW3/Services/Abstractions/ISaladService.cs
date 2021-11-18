using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW3.Models;

namespace Module2HW3.Services.Abstractions
{
    public interface ISaladService
    {
        bool Add(Vegetable item);
        bool Sort();
        Vegetable[] Get();
        int GetKilocalories();
        void Clean();
    }
}
