using FluentDate;
using Newtonsoft.Json.Linq;
using RestaurantAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Restaurant
{
    public partial class BookingDetail : Form
    {
        string idClientParam;
        string idTableParam;
        public BookingDetail()
        {
            InitializeComponent();
        }

        private void BookingDetail_Load(object sender, EventArgs e)
        {

            setDataGridViewFoods();

            getDataBookingDetail();

            getFoodByBooking();
        }

        private String convertTime(String time)
        {
            return DateTime.Parse(time).ToString();
        }


        private void getDataBookingDetail()
        {
            String url_api = Constants.URL_API + "/booking/get-booking-detail/" + Program.ID_BOOKING;
            var client = new HttpClient();

            try
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Program.TOKEN);
                var result = client.GetAsync(url_api);
                var response = JObject.Parse(result.Result.Content.ReadAsStringAsync().Result);
                var booking = response["data"][0][0];
                var tables = response["data"][1];

                textIdBooking.Text = booking["MAPD"].ToString().Trim();
                textNameClient.Text = booking["HOTEN"].ToString().Trim();
                textPhoneNum.Text = booking["SDT"].ToString().Trim();
                textEmail.Text = booking["EMAIL"].ToString().Trim();
                textNumOfPeople.Text = booking["SONGUOI"].ToString().Trim();
                textTimeComing.Text = convertTime(booking["NGAYDAT"].ToString().Trim());
                textStatus.Text = booking["TRANGTHAI"].ToString().Trim();
                idClientParam = booking["MAKH"].ToString().Trim();

                if (!booking["MABAN"].ToString().Trim().Equals(""))
                {
                    idTableParam = booking["MABAN"].ToString().Trim();
                } else
                {
                    idTableParam = tables[0]["MABAN"].ToString().Trim();
                }


                string status = booking["TRANGTHAI"].ToString().Trim();

                if (String.Equals(status, Constants.STATUS_CONFIRMED, StringComparison.OrdinalIgnoreCase))
                {
                    btnConfirm.Text = "Giao bàn";
                }
                else if (String.Equals(status, Constants.STATUS_CANCELED, StringComparison.OrdinalIgnoreCase))
                {
                    btnConfirm.Visible = false;
                    btnCancel.Text = "Đã hủy";
                    btnCancel.Enabled = false;
                    buttonEditFood.Enabled = false;
                }
                else if (String.Equals(status, Constants.STATUS_RECEPTION, StringComparison.OrdinalIgnoreCase))
                {
                    btnConfirm.Text = "Thanh toán";
                    btnCancel.Enabled = false;
                    buttonEditFood.Enabled = false;

                }
                else if (String.Equals(status, Constants.STATUS_END, StringComparison.OrdinalIgnoreCase))
                {
                    btnConfirm.Text = "Đã thanh toán";
                    btnConfirm.Enabled = false;
                    btnCancel.Enabled = false;
                    buttonEditFood.Enabled = false;
                    pbBill.Visible = true;
                }

                checkStatus(booking["NGAYDAT"].ToString().Trim());

                string nameTable = "";
                foreach (var t in tables)
                {
                    nameTable = nameTable + t["TENBAN"].ToString().Trim() + " ";
                }

                textNameTable.Text = nameTable.Trim();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void getFoodByBooking()
        {

            String url_api = Constants.URL_API + "/food/get-food-booking";
            var client = new HttpClient();

            try
            {
                //client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwOi8vYXBpLnRhbmNhLmlvL2FwaS92NC9hdXRoL3NpZ25pbi9waG9uZSIsImlhdCI6MTY3Mjg0NzIwNiwibmJmIjoxNjcyODQ3MjA2LCJqdGkiOiJRR3V5b2puTTNsWFZNNzgwIiwic3ViIjoiTml0SnBlSnV2QXgzWmNhd0oiLCJwcnYiOiIxYzU1MjBmNzBiYWE2NTVkZGM1NzQ2YTY3NjRmMzcyYTFiNjU1YWE2Iiwic2hvcF9pZCI6IjVjMjBhMTljMGIwODg4MGY1OTRmYzQ2OCIsInNob3BfdXNlcm5hbWUiOiJ0YW5jYXhheWR1bmciLCJzaG9wX3ByZWZpeCI6InQiLCJ0eXBlIjoiYXBpIn0.qFWIs4VU3h3I-DAojuDg5mtuv0EOUN37g10eYRzbKBU");
                var obj = new
                {
                    idBooking = Program.ID_BOOKING
                };
                JsonContent jsonContent = JsonContent.Create(obj);
                var result = client.PostAsync(url_api, jsonContent);
                var response = JObject.Parse(result.Result.Content.ReadAsStringAsync().Result);
                dvgFoods.Rows.Clear();
                dvgFoods.Refresh();
                string[] row;

                foreach (var t in response["data"])
                {
                    row = new String[] {
                        t["TEN"].ToString(),
                        t["SO_LUONG"].ToString(),
                        t["GIA"].ToString()
                    };
                    dvgFoods.Rows.Add(row);
                }
                // 
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void setDataGridViewFoods()
        {
            dvgFoods.ColumnCount = 3;

            dvgFoods.Columns[0].Name = "Tên món ăn";
            dvgFoods.Columns[1].Name = "Số lượng";
            dvgFoods.Columns[2].Name = "Giá";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (BookingDetail.ActiveForm != null)
            {
                BookingDetail.ActiveForm.Close();
            }
        }

        private void checkStatus(String time)
        {
            DateTime now = DateTime.Now + 1.Days();
            DateTime enteredDate = DateTime.Parse(time);
            if (DateTime.Compare(enteredDate, now) < 0)
            {
                btnCancel.Enabled = false;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            if (String.Equals(textStatus.Text.Trim(), Constants.STATUS_WAITING, StringComparison.OrdinalIgnoreCase))
            {
                confirmBooking();
            }
            else if (String.Equals(textStatus.Text.Trim(), Constants.STATUS_CONFIRMED, StringComparison.OrdinalIgnoreCase))
            {
                takeTable(Program.ID_BOOKING);

            }
            else if (String.Equals(textStatus.Text.Trim(), Constants.STATUS_RECEPTION, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Create bill");
                createBill();
            }
        }

        private void createBill()
        {
            String url_api = Constants.URL_API + "/bill/create-bill";
            var client = new HttpClient();

            try
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Program.TOKEN);
                var obj = new
                {
                    idClient = idClientParam,
                    idBooking = Program.ID_BOOKING,
                    idTable = idTableParam,
                    status = Constants.STATUS_END

                };
                JsonContent jsonContent = JsonContent.Create(obj);
                var result = client.PostAsync(url_api, jsonContent);
                var response = JObject.Parse(result.Result.Content.ReadAsStringAsync().Result);

                btnConfirm.Text = "Đã thanh toán";
                btnConfirm.Enabled = false;
                btnCancel.Enabled = false;
                buttonEditFood.Enabled = false;
                pbBill.Visible = true;
                textStatus.Text = Constants.STATUS_END;
                MessageBox.Show("Giao bàn cho khách thành công");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void confirmBooking()
        {
            String url_api = Constants.URL_API + "/booking/confirm-booking";
            var client = new HttpClient();

            try
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Program.TOKEN);
                var obj = new
                {
                    idBooking = Program.ID_BOOKING,
                    status = Constants.STATUS_CONFIRMED,

                };
                JsonContent jsonContent = JsonContent.Create(obj);
                var result = client.PutAsync(url_api, jsonContent);
                var response = JObject.Parse(result.Result.Content.ReadAsStringAsync().Result);

                MessageBox.Show("Duyệt thành công");

                btnConfirm.Text = "Giao bàn";
                textStatus.Text = Constants.STATUS_CONFIRMED;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void buttonEditFood_Click(object sender, EventArgs e)
        {
            new BookingFoodForm().ShowDialog();
        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            ListDepositForm listDepositForm = new ListDepositForm();
            listDepositForm.ShowDialog();
        }



        private void pbBill_Click(object sender, EventArgs e)
        {
            new BillForm().ShowDialog(this);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            String url_api = Constants.URL_API + "/booking/cancel-booking";
            var client = new HttpClient();

            try
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Program.TOKEN);
                var obj = new
                {
                    idBooking = Program.ID_BOOKING,

                };
                JsonContent jsonContent = JsonContent.Create(obj);
                var result = client.PutAsync(url_api, jsonContent);
                var response = JObject.Parse(result.Result.Content.ReadAsStringAsync().Result);

                MessageBox.Show("Success");

                btnCancel.Text = "Đã hủy";
                btnCancel.Enabled = false;
                btnConfirm.Enabled = false;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void takeTable(String idBooking)
        {
            String url_api = Constants.URL_API + "/booking/confirm-booking";
            var client = new HttpClient();

            try
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Program.TOKEN);
                var obj = new
                {
                    idBooking = idBooking,
                    status = Constants.STATUS_RECEPTION,

                };
                JsonContent jsonContent = JsonContent.Create(obj);
                var result = client.PutAsync(url_api, jsonContent);
                var response = JObject.Parse(result.Result.Content.ReadAsStringAsync().Result);

                btnConfirm.Text = "Thanh toán";
                textStatus.Text = Constants.STATUS_RECEPTION;

                MessageBox.Show("Giao bàn cho khách thành công");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            getDataBookingDetail();
            getFoodByBooking();
        }
    }
}
