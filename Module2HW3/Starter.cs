using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW3.Services;
using Module2HW3.Models;
using Module2HW3.Helpers;

namespace Module2HW3
{
    public class Starter
    {
        private readonly SaladService _saladService;
        public Starter()
        {
            _saladService = new SaladService() { Name = "Vegetable salad" };
        }

        public void Run()
        {
            _saladService.Add(new Artichoke());
            _saladService.Add(new Cabbage());
            _saladService.Add(new Cassava());
            _saladService.Add(new Cauliflower());
            _saladService.Add(new Garlic());
            _saladService.Add(new OrangeLily());
            _saladService.Add(new Potato());
            _saladService.Add(new Cabbage());
            _saladService.Add(new Potato());
            _saladService.Add(new Witloof());

            Console.WriteLine($"{_saladService.Name} contains {_saladService.GetKilocalories()} kcal");

            _saladService.Sort();

            Vegetable[] vegetables1 = _saladService.Get().Find(100);
            Vegetable[] vegetables2 = _saladService.Get().Find(LeavesType.Blant);
        }
    }
}
