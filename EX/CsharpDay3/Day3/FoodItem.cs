using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDay3.Day3
{
    public class FoodItem: InventoryItem
    {
        public string Brand {  get; set; }
        public FoodType food;
        public AnimalType animal;
    }

    public enum FoodType
    {
        Dry,
        Wet
    }

    public enum AnimalType
    {
        Dog,
        Cat
    }
}
