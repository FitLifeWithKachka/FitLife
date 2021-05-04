using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloryCalculator
{
    public class DishInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }

        private List<Product> _products;

        public List<Product> Products { get => _products; set => _products = value; }

        public DishInfo(Dish dish)
        {
            Id = dish.Id;
            Name = dish.Name;
            Calories = dish.Calories;

            _products = new List<Product>();
            var tmpDB = new FitLifeDataContent().Products.ToList();

            foreach (var item in dish.ProductsIds.ToString().Split())
            {
                _products.Add(tmpDB.Find(p => p.Id.ToString() == item));
            }
        }

        public override string ToString()
        {
            return $"{Name}    {Calories}";
        }
    }
}
