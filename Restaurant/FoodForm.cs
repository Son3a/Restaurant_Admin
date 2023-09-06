using Newtonsoft.Json.Linq;
using RestaurantAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FoodForm : Form
    {
        public static String idFood, priceFood, nameFood;

        private List<String> listId= new List<String>();
        public FoodForm()
        {
            InitializeComponent();
        }

        private void FoodForm_Load(object sender, EventArgs e)
        {

            setDataGridViewFood();
            getCategory();
            getAllFood();
            
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
                
                foreach(var t in response["data"][0])
                {
                    listId.Add(t["MALOAI"].ToString().Trim());
                    cbxCategory.Items.Add(t["TEN"].ToString().Trim());
                }
                            
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi mạng! Xin hãy kiểm tra lại kết nối");
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
                dgvFood.Rows.Clear();
                dgvFood.Refresh();
                string[] row;
                foreach (var t in response["data"])
                {
                    row = new String[] {
                        t["MAMA"].ToString(),
                        t["TEN"].ToString(),
                        Constants.formatMoney(t["GIA"].ToString()),
                        "Chi tiết"
                    };
                    dgvFood.Rows.Add(row);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi mạng! Xin hãy kiểm tra lại kết nối");
            }
        }
        private void getFoodByCategory(String idCategory)
        {
            String url_api = Constants.URL_API + "/food/get-food-by-category/"+idCategory;
            var client = new HttpClient();

            try
            {
                //client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwOi8vYXBpLnRhbmNhLmlvL2FwaS92NC9hdXRoL3NpZ25pbi9waG9uZSIsImlhdCI6MTY3Mjg0NzIwNiwibmJmIjoxNjcyODQ3MjA2LCJqdGkiOiJRR3V5b2puTTNsWFZNNzgwIiwic3ViIjoiTml0SnBlSnV2QXgzWmNhd0oiLCJwcnYiOiIxYzU1MjBmNzBiYWE2NTVkZGM1NzQ2YTY3NjRmMzcyYTFiNjU1YWE2Iiwic2hvcF9pZCI6IjVjMjBhMTljMGIwODg4MGY1OTRmYzQ2OCIsInNob3BfdXNlcm5hbWUiOiJ0YW5jYXhheWR1bmciLCJzaG9wX3ByZWZpeCI6InQiLCJ0eXBlIjoiYXBpIn0.qFWIs4VU3h3I-DAojuDg5mtuv0EOUN37g10eYRzbKBU");
                var result = client.GetAsync(url_api);
                var response = JObject.Parse(result.Result.Content.ReadAsStringAsync().Result);
                dgvFood.Rows.Clear();
                dgvFood.Refresh();
                string[] row;
                foreach (var t in response["data"][0])
                {
                    row = new String[] {
                        t["MAMA"].ToString(),
                        t["TEN"].ToString(),
                        Constants.formatMoney(t["GIA"].ToString()),
                        "Chi tiết"
                    };
                    dgvFood.Rows.Add(row);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi mạng! Xin hãy kiểm tra lại kết nối");
            }
        }

        private void setDataGridViewFood()
        {
            dgvFood.ColumnCount = 4;
            dgvFood.Columns[0].Name = "Mã món";
            dgvFood.Columns[1].Name = "Tên món";
            dgvFood.Columns[2].Name = "Giá";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (cbxCategory.SelectedIndex == 0)
            {
                getAllFood();
            } else
            {
                int index = cbxCategory.SelectedIndex;
                getFoodByCategory(listId[index]);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbxCategory.SelectedIndex == 0)
            {
                getAllFood();
            } else
            {
                int index = cbxCategory.SelectedIndex;
                getFoodByCategory(listId[index]);
            }
        }

        private void dvgFood_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvFood.Rows[e.RowIndex];
            idFood = row.Cells[0].Value.ToString();
            nameFood = row.Cells[1].Value.ToString();
            priceFood = row.Cells[2].Value.ToString();
            new ChangePriceFoodForm().ShowDialog();
        }
    }
}
