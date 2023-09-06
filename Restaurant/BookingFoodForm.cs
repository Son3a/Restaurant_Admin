using Newtonsoft.Json.Linq;
using RestaurantAdmin;
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
using Newtonsoft.Json;

namespace Restaurant
{
    public partial class BookingFoodForm : Form
    {

        public static String numOfFood;
        public static String urlImageFood;
        public static String nameFood;
        public static String idFood;

        private List<string> listImageFoods;
        
        public static string idTable;
        public BookingFoodForm()
        {
            InitializeComponent();
        }
        private void BookingFoodForm_Load(object sender, EventArgs e)
        {
            setDataGridViewFoods();

            getFoodByBooking();
        }

        private void setDataGridViewFoods()
        {
            dgvFoods.ColumnCount = 4;
            dgvFoods.Columns[0].Name = "Mã món ăn";
            dgvFoods.Columns[1].Name = "Tên món ăn";
            dgvFoods.Columns[2].Name = "Số lượng";
            dgvFoods.Columns[3].Name = "Giá";

            DataGridViewButtonColumn startbtn = new DataGridViewButtonColumn();
            startbtn.Name = "";
            startbtn.Text = "Sửa số lượng";
            startbtn.UseColumnTextForButtonValue = true;
            int columnIndex = 4;
            dgvFoods.Columns.Insert(columnIndex, startbtn);

            DataGridViewButtonColumn startbtn1 = new DataGridViewButtonColumn();
            startbtn1.Name = "";
            startbtn1.Text = "Xóa";
            startbtn1.UseColumnTextForButtonValue = true;
            columnIndex = 5;
            dgvFoods.Columns.Insert(columnIndex, startbtn1);
        }

        private void getFoodByBooking()
        {
            listImageFoods = new List<string>();

            String url_api = Constants.URL_API + "/food/get-booking-and-food/" + Program.ID_BOOKING;
            var client = new HttpClient();

            try
            {
                //client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwOi8vYXBpLnRhbmNhLmlvL2FwaS92NC9hdXRoL3NpZ25pbi9waG9uZSIsImlhdCI6MTY3Mjg0NzIwNiwibmJmIjoxNjcyODQ3MjA2LCJqdGkiOiJRR3V5b2puTTNsWFZNNzgwIiwic3ViIjoiTml0SnBlSnV2QXgzWmNhd0oiLCJwcnYiOiIxYzU1MjBmNzBiYWE2NTVkZGM1NzQ2YTY3NjRmMzcyYTFiNjU1YWE2Iiwic2hvcF9pZCI6IjVjMjBhMTljMGIwODg4MGY1OTRmYzQ2OCIsInNob3BfdXNlcm5hbWUiOiJ0YW5jYXhheWR1bmciLCJzaG9wX3ByZWZpeCI6InQiLCJ0eXBlIjoiYXBpIn0.qFWIs4VU3h3I-DAojuDg5mtuv0EOUN37g10eYRzbKBU");
                var result = client.GetAsync(url_api);
                var response = JObject.Parse(result.Result.Content.ReadAsStringAsync().Result);
                dgvFoods.Rows.Clear();
                dgvFoods.Refresh();
                string[] row;

                idTable = response["data"][0][0]["MABAN"].ToString().Trim();

                foreach (var t in response["data"][1])
                {
                    row = new String[] {
                        t["MAMA"].ToString().Trim(),
                        t["TEN"].ToString().Trim(),
                        t["SO_LUONG"].ToString().Trim(),
                        t["GIA"].ToString().Trim()
                    };
                    dgvFoods.Rows.Add(row);

                    listImageFoods.Add(t["HINH_ANH"].ToString());
                }
                // 
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void dgvFoods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4) //Sửa số lượng
            {
                int rowIndex = e.RowIndex;
                urlImageFood = listImageFoods[rowIndex];
                numOfFood = dgvFoods.Rows[e.RowIndex].Cells[2].Value.ToString();
                nameFood = dgvFoods.Rows[e.RowIndex].Cells[1].Value.ToString();
                idFood = dgvFoods.Rows[e.RowIndex].Cells[0].Value.ToString();
                new EditNumFoodBookingForm().ShowDialog(this);

            } else if(e.ColumnIndex == 5) // Xóa món ăn
            {
                String nameFood = dgvFoods.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (MessageBox.Show("Bạn muốn xóa " + nameFood, "", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    DataGridViewRow row = dgvFoods.Rows[e.RowIndex];
                    deleteFood(row.Cells[0].Value.ToString());
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            getFoodByBooking();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            new AddFoodBookingForm().ShowDialog();
        }

        private async void deleteFood(String idFoodString)
        {
            try
            {
                String url_api = Constants.URL_API + "/booking/delete-food-in-booking";

                var httpClient = new HttpClient();
                var deleteObject = new
                {
                    idBooking = Program.ID_BOOKING,
                    idFood = idFoodString,
                };
                var stringContent = new StringContent(
                   JsonConvert.SerializeObject(deleteObject), Encoding.UTF8,
                   "application/json");
                var request = new HttpRequestMessage(HttpMethod.Delete,
                   url_api);
                request.Content = stringContent;
                var response = await httpClient.SendAsync(request);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
           

           /* try
            {
                //client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwOi8vYXBpLnRhbmNhLmlvL2FwaS92NC9hdXRoL3NpZ25pbi9waG9uZSIsImlhdCI6MTY3Mjg0NzIwNiwibmJmIjoxNjcyODQ3MjA2LCJqdGkiOiJRR3V5b2puTTNsWFZNNzgwIiwic3ViIjoiTml0SnBlSnV2QXgzWmNhd0oiLCJwcnYiOiIxYzU1MjBmNzBiYWE2NTVkZGM1NzQ2YTY3NjRmMzcyYTFiNjU1YWE2Iiwic2hvcF9pZCI6IjVjMjBhMTljMGIwODg4MGY1OTRmYzQ2OCIsInNob3BfdXNlcm5hbWUiOiJ0YW5jYXhheWR1bmciLCJzaG9wX3ByZWZpeCI6InQiLCJ0eXBlIjoiYXBpIn0.qFWIs4VU3h3I-DAojuDg5mtuv0EOUN37g10eYRzbKBU");
                
                JsonContent jsonContent = JsonContent.Create(obj);

                var result = client.DeleteAsync(url_api, jsonContent);
                var response = JObject.Parse(result.Result.Content.ReadAsStringAsync().Result);

                MessageBox.Show("Thêm món thành công!");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }*/
        }
    }
}
