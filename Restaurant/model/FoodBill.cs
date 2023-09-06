using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.model
{
    internal class FoodBill
    {
        public FoodBill(string stt, string nameFood, string price, string numOfFood, string total) {
            this.stt = stt;
            this.nameFood = nameFood;
            this.price = price;
            this.numOfFood = numOfFood;
            this.total = total;
        }

        public string stt { get; set; }
        public string nameFood { get; set; }
        public string price { get; set; }
        public string numOfFood { get; set; }
        public string total { get; set; }
    }
}
