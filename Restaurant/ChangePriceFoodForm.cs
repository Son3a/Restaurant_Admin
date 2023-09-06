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

namespace Restaurant
{
    public partial class ChangePriceFoodForm : Form
    {
        public ChangePriceFoodForm()
        {
            InitializeComponent();
        }

        private void ChangePriceFoodForm_Load(object sender, EventArgs e)
        {
            lbIdFood.Text = FoodForm.idFood;
            lbNameFood.Text = FoodForm.nameFood;
            lbPriceCurrent.Text = FoodForm.priceFood;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ChangePriceFoodForm.ActiveForm.Close();
        }

        private void updatePrice()
        {
            String url_api = Constants.URL_API + "/food/update-price-food";
            var client = new HttpClient();

            try
            {
                //client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwOi8vYXBpLnRhbmNhLmlvL2FwaS92NC9hdXRoL3NpZ25pbi9waG9uZSIsImlhdCI6MTY3Mjg0NzIwNiwibmJmIjoxNjcyODQ3MjA2LCJqdGkiOiJRR3V5b2puTTNsWFZNNzgwIiwic3ViIjoiTml0SnBlSnV2QXgzWmNhd0oiLCJwcnYiOiIxYzU1MjBmNzBiYWE2NTVkZGM1NzQ2YTY3NjRmMzcyYTFiNjU1YWE2Iiwic2hvcF9pZCI6IjVjMjBhMTljMGIwODg4MGY1OTRmYzQ2OCIsInNob3BfdXNlcm5hbWUiOiJ0YW5jYXhheWR1bmciLCJzaG9wX3ByZWZpeCI6InQiLCJ0eXBlIjoiYXBpIn0.qFWIs4VU3h3I-DAojuDg5mtuv0EOUN37g10eYRzbKBU");
                var obj = new
                {
                    idEmployer = "NV01",
                    idFood = FoodForm.idFood,
                    price = textNewPrice.Text,

                };
                JsonContent jsonContent = JsonContent.Create(obj);
                var result = client.PostAsync(url_api, jsonContent);
                var response = JObject.Parse(result.Result.Content.ReadAsStringAsync().Result);

                MessageBox.Show("Success");

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (textNewPrice.Text != null && !textNewPrice.Text.Equals(""))
            {
                updatePrice();
            }
        }
    }
}
