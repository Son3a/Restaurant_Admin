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

namespace Restaurant
{
    public partial class AddFoodBookingForm : Form
    {
        private List<string> listId = new List<string>();
        public AddFoodBookingForm()
        {
            InitializeComponent();
        }

        private void AddFoodBookingForm_Load(object sender, EventArgs e)
        {
            setDataGridViewFood();
            getAllFood();
            getCategory();
        }

        private void getCategory()
        {
            cbxCategory.Items.Add("Tất cả");
            listId.Add("0");
            cbxCategory.SelectedIndex = 0;
            String url_api = Constants.URL_API + "/category/get-categories";
            var client = new HttpClient();

            try
            {
                //client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwOi8vYXBpLnRhbmNhLmlvL2FwaS92NC9hdXRoL3NpZ25pbi9waG9uZSIsImlhdCI6MTY3Mjg0NzIwNiwibmJmIjoxNjcyODQ3MjA2LCJqdGkiOiJRR3V5b2puTTNsWFZNNzgwIiwic3ViIjoiTml0SnBlSnV2QXgzWmNhd0oiLCJwcnYiOiIxYzU1MjBmNzBiYWE2NTVkZGM1NzQ2YTY3NjRmMzcyYTFiNjU1YWE2Iiwic2hvcF9pZCI6IjVjMjBhMTljMGIwODg4MGY1OTRmYzQ2OCIsInNob3BfdXNlcm5hbWUiOiJ0YW5jYXhheWR1bmciLCJzaG9wX3ByZWZpeCI6InQiLCJ0eXBlIjoiYXBpIn0.qFWIs4VU3h3I-DAojuDg5mtuv0EOUN37g10eYRzbKBU");
                var result = client.GetAsync(url_api);
                var response = JObject.Parse(result.Result.Content.ReadAsStringAsync().Result);

                foreach (var t in response["data"][0])
                {
                    listId.Add(t["MALOAI"].ToString().Trim());
                    cbxCategory.Items.Add(t["TEN"].ToString().Trim());
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void getFoodByCategory(String idCategory)
        {
            String url_api = Constants.URL_API + "/food/get-food-by-category/" + idCategory;
            var client = new HttpClient();

            try
            {
                //client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwOi8vYXBpLnRhbmNhLmlvL2FwaS92NC9hdXRoL3NpZ25pbi9waG9uZSIsImlhdCI6MTY3Mjg0NzIwNiwibmJmIjoxNjcyODQ3MjA2LCJqdGkiOiJRR3V5b2puTTNsWFZNNzgwIiwic3ViIjoiTml0SnBlSnV2QXgzWmNhd0oiLCJwcnYiOiIxYzU1MjBmNzBiYWE2NTVkZGM1NzQ2YTY3NjRmMzcyYTFiNjU1YWE2Iiwic2hvcF9pZCI6IjVjMjBhMTljMGIwODg4MGY1OTRmYzQ2OCIsInNob3BfdXNlcm5hbWUiOiJ0YW5jYXhheWR1bmciLCJzaG9wX3ByZWZpeCI6InQiLCJ0eXBlIjoiYXBpIn0.qFWIs4VU3h3I-DAojuDg5mtuv0EOUN37g10eYRzbKBU");
                var result = client.GetAsync(url_api);
                var response = JObject.Parse(result.Result.Content.ReadAsStringAsync().Result);
                dgvFoods.Rows.Clear();
                dgvFoods.Refresh();
                string[] row;
                foreach (var t in response["data"][0])
                {
                    string gia = t["GIA"].ToString();
                    if (!t["GIA_KM"].ToString().Equals(""))
                    {
                        gia = t["GIA_KM"].ToString();
                    }
                    row = new String[] {
                        t["MAMA"].ToString(),
                        t["TEN"].ToString(),
                        Constants.formatMoney(gia),
                        "Chi tiết"
                    };
                    dgvFoods.Rows.Add(row);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void getAllFood()
        {
            String url_api = Constants.URL_API + "/food/get-price-food-with-sale-off";
            var client = new HttpClient();

            try
            {
                //client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwOi8vYXBpLnRhbmNhLmlvL2FwaS92NC9hdXRoL3NpZ25pbi9waG9uZSIsImlhdCI6MTY3Mjg0NzIwNiwibmJmIjoxNjcyODQ3MjA2LCJqdGkiOiJRR3V5b2puTTNsWFZNNzgwIiwic3ViIjoiTml0SnBlSnV2QXgzWmNhd0oiLCJwcnYiOiIxYzU1MjBmNzBiYWE2NTVkZGM1NzQ2YTY3NjRmMzcyYTFiNjU1YWE2Iiwic2hvcF9pZCI6IjVjMjBhMTljMGIwODg4MGY1OTRmYzQ2OCIsInNob3BfdXNlcm5hbWUiOiJ0YW5jYXhheWR1bmciLCJzaG9wX3ByZWZpeCI6InQiLCJ0eXBlIjoiYXBpIn0.qFWIs4VU3h3I-DAojuDg5mtuv0EOUN37g10eYRzbKBU");
                var result = client.GetAsync(url_api);
                var response = JObject.Parse(result.Result.Content.ReadAsStringAsync().Result);
                dgvFoods.Rows.Clear();
                dgvFoods.Refresh();
                string[] row;
                int index = 0;
                foreach (var t in response["data"])
                {
                    String gia = t["GIA"].ToString();
                    if (!t["GIA_KM"].ToString().Equals(""))
                    {
                        gia = t["GIA_KM"].ToString();
                    }
                    row = new String[] {
                        t["MAMA"].ToString(),
                        t["TEN"].ToString(),
                        Constants.formatMoney(gia)
                    };
                    dgvFoods.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void setDataGridViewFood()
        {
            dgvFoods.ColumnCount = 3;
            dgvFoods.Columns[0].Name = "Mã món";
            dgvFoods.Columns[1].Name = "Tên món";
            dgvFoods.Columns[2].Name = "Giá";

            DataGridViewButtonColumn startbtn = new DataGridViewButtonColumn();
            startbtn.Name = "Action";
            startbtn.Text = "Thêm";
            startbtn.UseColumnTextForButtonValue = true;
            int columnIndex = 3;
            dgvFoods.Columns.Insert(columnIndex, startbtn);
        }

        private void dgvFoods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                String nameFood = dgvFoods.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (MessageBox.Show("Bạn muốn thêm " + nameFood, "", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    DataGridViewRow row = dgvFoods.Rows[e.RowIndex];
                    addFood(row.Cells[0].Value.ToString(), row.Cells[2].Value.ToString());
                }
            }
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCategory.SelectedIndex == 0)
            {
                getAllFood();
            }
            else
            {
                int index = cbxCategory.SelectedIndex;
                getFoodByCategory(listId[index]);
            }
        }

        private void addFood(String idFoodString, String priceString)
        {
            String url_api = Constants.URL_API + "/booking/add-food-to-booking";
            var client = new HttpClient();

            try
            {
                //client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwOi8vYXBpLnRhbmNhLmlvL2FwaS92NC9hdXRoL3NpZ25pbi9waG9uZSIsImlhdCI6MTY3Mjg0NzIwNiwibmJmIjoxNjcyODQ3MjA2LCJqdGkiOiJRR3V5b2puTTNsWFZNNzgwIiwic3ViIjoiTml0SnBlSnV2QXgzWmNhd0oiLCJwcnYiOiIxYzU1MjBmNzBiYWE2NTVkZGM1NzQ2YTY3NjRmMzcyYTFiNjU1YWE2Iiwic2hvcF9pZCI6IjVjMjBhMTljMGIwODg4MGY1OTRmYzQ2OCIsInNob3BfdXNlcm5hbWUiOiJ0YW5jYXhheWR1bmciLCJzaG9wX3ByZWZpeCI6InQiLCJ0eXBlIjoiYXBpIn0.qFWIs4VU3h3I-DAojuDg5mtuv0EOUN37g10eYRzbKBU");
                var obj = new
                {
                    idBooking = Program.ID_BOOKING,
                    idFood = idFoodString,
                    idTable = BookingFoodForm.idTable,
                    price = convertToInt(priceString),
                    numOfFood = 1
                };
                JsonContent jsonContent = JsonContent.Create(obj);

                var result = client.PutAsync(url_api, jsonContent);
                var response = JObject.Parse(result.Result.Content.ReadAsStringAsync().Result);

                MessageBox.Show("Thêm món thành công!");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private int convertToInt(String price)
        {
            string subPrice = price.Substring(1);
            return Int32.Parse(subPrice.Replace(",", ""));
        }

        private void dgvFoods_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            //DataGridViewRow row = dvgBookings.Rows[e.RowIndex];

        }
    }
}