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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }
        private void roundImage(PictureBox pb)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pb.Width - 3, pb.Height - 3);
            Region rg = new Region(gp);
            pb.Region = rg;
        }
        private void SignUpForm_Load(object sender, EventArgs e)
        {
            roundImage(pictureBox1);
            textPassword.UseSystemPasswordChar = true;
            textConfirmPassword.UseSystemPasswordChar = true;
        }

        private Boolean isEmpty()
        {
            if (textEmail.Text.Equals("") || textPassword.Text.Equals("") || textFName.Text.Equals("") || textPhone.Text.Equals("")
                || textConfirmPassword.Text.Equals("") ||textLName.Text.Equals(""))
            {
                return true;
            }
            return false;
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Bạn cần điền đủ thông tin!");
                return;
            }
            if(!textPassword.Text.Equals(textConfirmPassword.Text))
            {
                MessageBox.Show("Mật khẩu không khớp!");
                return;

            }

            signUp();
        }

        private async void signUp()
        {
            String url_api = Constants.URL_API + "/auth/register";
            var client = new HttpClient();

            try
            {
                //client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwOi8vYXBpLnRhbmNhLmlvL2FwaS92NC9hdXRoL3NpZ25pbi9waG9uZSIsImlhdCI6MTY3Mjg0NzIwNiwibmJmIjoxNjcyODQ3MjA2LCJqdGkiOiJRR3V5b2puTTNsWFZNNzgwIiwic3ViIjoiTml0SnBlSnV2QXgzWmNhd0oiLCJwcnYiOiIxYzU1MjBmNzBiYWE2NTVkZGM1NzQ2YTY3NjRmMzcyYTFiNjU1YWE2Iiwic2hvcF9pZCI6IjVjMjBhMTljMGIwODg4MGY1OTRmYzQ2OCIsInNob3BfdXNlcm5hbWUiOiJ0YW5jYXhheWR1bmciLCJzaG9wX3ByZWZpeCI6InQiLCJ0eXBlIjoiYXBpIn0.qFWIs4VU3h3I-DAojuDg5mtuv0EOUN37g10eYRzbKBU");
                var obj = new
                {
                    email = textEmail.Text.Trim(),
                    password = textPassword.Text.Trim(),
                    phoneNum = textPhone.Text.Trim(),
                    avatar = "",
                    idRole = "Q02",
                    fName = textFName.Text.Trim(),
                    lName = textLName.Text.Trim(),
                    role = "2"
                };
                JsonContent jsonContent = JsonContent.Create(obj);
                var result =  await client.PostAsync(url_api, jsonContent);

                var response = JObject.Parse(result.Content.ReadAsStringAsync().Result);
                if (result.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show(response["message"].ToString());
                    return;
                }


                /* if (Int32.Parse(response["statusCode"].ToString()) == Int32.Parse(System.Net.HttpStatusCode.Conflict.ToString()))
                 {

                 }*/


                MessageBox.Show("Tạo tài khoản thành công!");
                this.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
