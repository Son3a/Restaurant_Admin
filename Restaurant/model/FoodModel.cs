using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.model
{
    internal class FoodModel
    {
        public FoodModel() { }

        public string idFood { get; set; }
        public string nameFood { get; set; }
        public string price { get; set; }
        public int numOfFood { get; set;}
        public string image { get; set; }
    }
}
