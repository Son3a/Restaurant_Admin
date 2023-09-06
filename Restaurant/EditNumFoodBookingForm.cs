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
    public partial class EditNumFoodBookingForm : Form
    {
        private int numOfFood;
        public EditNumFoodBookingForm()
        {
            InitializeComponent();
        }

        private void EditFoodBookingForm_Load(object sender, EventArgs e)
        {
            numOfFood = Int32.Parse(BookingFoodForm.numOfFood);
            labelNumOfFood.Text = BookingFoodForm.numOfFood;
            labelFoodName.Text = BookingFoodForm.nameFood;
            pbFood.ImageLocation = BookingFoodForm.urlImageFood;
            pbFood.SizeMode=PictureBoxSizeMode.StretchImage;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if(Int32.Parse(labelNumOfFood.Text) == numOfFood) {
                MessageBox.Show("Bạn chưa thay đổi số lượng");
                return;
            }
            String url_api = Constants.URL_API + "/booking/update-num-of-food";
            var client = new HttpClient();

            try
            {
                
                var obj = new
                {
                    idBooking = Program.ID_BOOKING,
                    idFood = BookingFoodForm.idFood,
                    numOfFood = labelNumOfFood.Text

                };
                JsonContent jsonContent = JsonContent.Create(obj);
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Program.TOKEN);
                var result = client.PutAsync(url_api, jsonContent);
                var response = JObject.Parse(result.Result.Content.ReadAsStringAsync().Result);

                numOfFood = Int32.Parse(labelNumOfFood.Text);

                MessageBox.Show("Success");

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            int num = Int32.Parse(labelNumOfFood.Text);
            labelNumOfFood.Text = (num+=1).ToString();
        }

        private void pbMinus_Click(object sender, EventArgs e)
        {
            int num = Int32.Parse(labelNumOfFood.Text);
            num -= 1;
            if(num >= 1)
            {
                labelNumOfFood.Text = (num).ToString();
            }
            
        }
    }
    
}
