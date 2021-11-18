using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW3.Models;
using Module2HW3.Helpers;
using Module2HW3.Services.Abstractions;

namespace Module2HW3.Services
{
    public class SaladService : ISaladService
    {
        private Vegetable[] _ingredients;
        public SaladService()
        {
        }

        public string Name { get; set; }

        public bool Add(Vegetable item)
        {
            if (_ingredients == null)
            {
                _ingredients = new Vegetable[1];
                _ingredients[0] = item;
            }
            else
            {
                Array.Resize(ref _ingredients, _ingredients.Length + 1);
                _ingredients[_ingredients.Length - 1] = item;
            }

            return true;
        }

        public bool Sort()
        {
            if (_ingredients.Length <= 1)
            {
                return false;
            }

            Array.Sort(_ingredients, new VegetableComparer());

            return true;
        }

        public Vegetable[] Get()
        {
            var ingredients = new Vegetable[_ingredients.Length];

            for (var i = 0; i < _ingredients.Length; i++)
            {
                ingredients[i] = _ingredients[i];
            }

            return ingredients;
        }

        public int GetKilocalories()
        {
            var sum = 0;

            for (var i = 0; i < _ingredients.Length; i++)
            {
                sum += _ingredients[i].Kilocalories;
            }

            return sum;
        }

        public void Clean()
        {
            _ingredients = new Vegetable[0];
        }
    }
}
