using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.model
{
    internal class StatisticalModel
    {
        public StatisticalModel() { }

        public StatisticalModel(string stt, string date, string totalMoney)
        {
            this.stt = stt;
            this.date = date;
            this.totalMoney = totalMoney;
        }

        public string stt { get; set; }
        public string date { get; set; }
        public string totalMoney { get; set; }
    }
}
