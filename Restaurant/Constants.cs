using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class Constants
    {
        public static String URL_API = "http://localhost:5000/api/v1";
        public static String STATUS_CONFIRMED = "Đã duyệt";
        public static String STATUS_CANCELED = "Đã hủy";
        public static String STATUS_WAITING = "Chờ duyệt";
        public static String STATUS_RECEPTION = "Tiếp khách";
        public static String STATUS_END = "Kết thúc";

        public static String formatMoney(String money)
        {
            decimal value = 0M;
            value = Convert.ToDecimal(Int32.Parse(money));
            return (value).ToString("C0"); ;
        }
    }
}
