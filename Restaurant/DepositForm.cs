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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Restaurant
{
    public partial class DepositForm : Form
    {
        private int total = 0;
        private int deposit = 0;
        public DepositForm()
        {
            InitializeComponent();
        }

        private void DepositForm_Load(object sender, EventArgs e)
        {
            getDepositDetail();
        }



        private void confirmDeposit()
        {
            String url_api = Constants.URL_API + "/deposit/confirm-deposit";
            var client = new HttpClient();

            try
            {

                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Program.TOKEN);
                var obj = new
                {
                    idDeposit = ListDepositForm.idDeposit
                };
                JsonContent jsonContent = JsonContent.Create(obj);
                var result = client.PutAsync(url_api, jsonContent);
                var response = JObject.Parse(result.Result.Content.ReadAsStringAsync().Result);

                MessageBox.Show("Success");
                btnConfirm.Enabled = false;
                btnConfirm.Text = "Đã duyệt";
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void getDepositDetail()
        {
            String url_api = Constants.URL_API + "/deposit/get-deposit-detail/" + ListDepositForm.idDeposit;
            var client = new HttpClient();

            try
            {
                //client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwOi8vYXBpLnRhbmNhLmlvL2FwaS92NC9hdXRoL3NpZ25pbi9waG9uZSIsImlhdCI6MTY3Mjg0NzIwNiwibmJmIjoxNjcyODQ3MjA2LCJqdGkiOiJRR3V5b2puTTNsWFZNNzgwIiwic3ViIjoiTml0SnBlSnV2QXgzWmNhd0oiLCJwcnYiOiIxYzU1MjBmNzBiYWE2NTVkZGM1NzQ2YTY3NjRmMzcyYTFiNjU1YWE2Iiwic2hvcF9pZCI6IjVjMjBhMTljMGIwODg4MGY1OTRmYzQ2OCIsInNob3BfdXNlcm5hbWUiOiJ0YW5jYXhheWR1bmciLCJzaG9wX3ByZWZpeCI6InQiLCJ0eXBlIjoiYXBpIn0.qFWIs4VU3h3I-DAojuDg5mtuv0EOUN37g10eYRzbKBU");

                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Program.TOKEN);
                var result = client.GetAsync(url_api);
                var response = JObject.Parse(result.Result.Content.ReadAsStringAsync().Result);
                String depositString = response["data"][0]["GIACOC"].ToString();

                lbDeposited.Text = Constants.formatMoney(depositString);

                String time = response["data"][0]["NGAYCOC"].ToString();
                DateTime dateTime= DateTime.Parse(time);
                labelDatePay.Text = dateTime.ToString("HH:mm dd/MM/yyyy");

                labelIdDeposit.Text = response["data"][0]["MAPC"].ToString();

                labelTypePay.Text = response["data"][0]["HT_THANHTOAN"].ToString();



                if (!response["data"][0]["MANV"].ToString().Trim().Equals(""))
                {
                    btnConfirm.Enabled = false;
                    btnConfirm.Text = "Đã duyệt";
                    btnConfirm.ForeColor= Color.White;
                }
                else if (String.Equals(response["data"][0]["MANV"].ToString().Trim(), 
                    Constants.STATUS_CANCELED, StringComparison.OrdinalIgnoreCase))
                {
                    btnConfirm.Enabled = false;
                    btnConfirm.Text = "Đã hủy";
                    btnConfirm.ForeColor = Color.White;
                }


                // 
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            confirmDeposit();
        }
    }
}
