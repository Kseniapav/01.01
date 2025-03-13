using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.Models
{
    public class Dishes
    {
        public string DishName { get; set; }  
        public string Price { get; set; } 
        public string Description { get; set; } 
        public string Ingredients { get; set; } 
        public string PortionWeight { get; set; }

        // Конструктор для удобного создания объекта
        public Dishes(string dishName, string price, string description, string ingredients, string portionWeight)
        {
            DishName = dishName;
            Price = price;

            Description = description;
            Ingredients = ingredients;
            PortionWeight = portionWeight;
        }
    }
}
