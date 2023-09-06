using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class AddBooking : Form
    {
        public AddBooking()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (textNumOfPeople.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập số lượng!");
                return;
            }
      
            getTable();
        }

        private void AddBooking_Load(object sender, EventArgs e)
        {
            pickerTime.ShowUpDown = true;
        }

        private void getTable()
        {
            String url_api = Constants.URL_API + "/booking/get-tables-to-booking";
            var client = new HttpClient();

            try
            {
                //client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwOi8vYXBpLnRhbmNhLmlvL2FwaS92NC9hdXRoL3NpZ25pbi9waG9uZSIsImlhdCI6MTY3Mjg0NzIwNiwibmJmIjoxNjcyODQ3MjA2LCJqdGkiOiJRR3V5b2puTTNsWFZNNzgwIiwic3ViIjoiTml0SnBlSnV2QXgzWmNhd0oiLCJwcnYiOiIxYzU1MjBmNzBiYWE2NTVkZGM1NzQ2YTY3NjRmMzcyYTFiNjU1YWE2Iiwic2hvcF9pZCI6IjVjMjBhMTljMGIwODg4MGY1OTRmYzQ2OCIsInNob3BfdXNlcm5hbWUiOiJ0YW5jYXhheWR1bmciLCJzaG9wX3ByZWZpeCI6InQiLCJ0eXBlIjoiYXBpIn0.qFWIs4VU3h3I-DAojuDg5mtuv0EOUN37g10eYRzbKBU");
                var obj = new
                {
                    time = (pickerDate.Value).ToString("yyyy/MM/dd") + " " + pickerTime.Text.ToString(),
                    amountPeople = textNumOfPeople.Text
                };
                JsonContent jsonContent = JsonContent.Create(obj);

                var result = client.PostAsync(url_api, jsonContent);
                var response = JObject.Parse(result.Result.Content.ReadAsStringAsync().Result);

                string[] pidTables = new string[5];

                int index = 0;
                foreach (var t in response["data"])
                {
                    pidTables[index] = (t["maban"].ToString().Trim());
                    index++;
                }

                bookingTable(pidTables);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Close();
            }
        }

        private void bookingTable(string[] pIdTable)
        {
            String url_api = Constants.URL_API + "/booking/booking-table";
            var client = new HttpClient();

            try
            {
                var obj = new
                {
                    amountPeople = textNumOfPeople.Text,
                    timeBooking = (pickerDate.Value).ToString("yyyy/MM/dd") + " " + pickerTime.Text.ToString(),
                    note ="",
                    idTables= pIdTable
                };
                JsonContent jsonContent = JsonContent.Create(obj);

                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Program.TOKEN);
                var result = client.PostAsync(url_api, jsonContent);
                var response = JObject.Parse(result.Result.Content.ReadAsStringAsync().Result);

                MessageBox.Show("Đặt bàn thành công!");

                Program.ID_BOOKING = response["data"]["mapd"].ToString();
                this.Close();
                new BookingDetail().ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Close();
            }
        }

        private void textNumOfPeople_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textNumOfPeople_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
