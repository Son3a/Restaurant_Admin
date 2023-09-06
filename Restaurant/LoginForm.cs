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
    public partial class LoginForm : Form
    {
        string password;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            roundImage(pictureBox1);
            textPassword.UseSystemPasswordChar = true;
        }

        private void roundImage(PictureBox pb)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pb.Width - 3, pb.Height - 3);
            Region rg = new Region(gp);
            pb.Region = rg;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (isEmpty())
            {
                MessageBox.Show("Bạn cần điền đủ email và password!");
                return;
            }
            
            login();
        }

        private void login()
        {
            String url_api = Constants.URL_API + "/auth/login";
            var client = new HttpClient();

            try
            {
                //client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwOi8vYXBpLnRhbmNhLmlvL2FwaS92NC9hdXRoL3NpZ25pbi9waG9uZSIsImlhdCI6MTY3Mjg0NzIwNiwibmJmIjoxNjcyODQ3MjA2LCJqdGkiOiJRR3V5b2puTTNsWFZNNzgwIiwic3ViIjoiTml0SnBlSnV2QXgzWmNhd0oiLCJwcnYiOiIxYzU1MjBmNzBiYWE2NTVkZGM1NzQ2YTY3NjRmMzcyYTFiNjU1YWE2Iiwic2hvcF9pZCI6IjVjMjBhMTljMGIwODg4MGY1OTRmYzQ2OCIsInNob3BfdXNlcm5hbWUiOiJ0YW5jYXhheWR1bmciLCJzaG9wX3ByZWZpeCI6InQiLCJ0eXBlIjoiYXBpIn0.qFWIs4VU3h3I-DAojuDg5mtuv0EOUN37g10eYRzbKBU");
                var obj = new
                {
                    email = textEmail.Text.Trim(),
                    password = textPassword.Text.Trim(),
                    role = "2"
                };
                JsonContent jsonContent = JsonContent.Create(obj);
                var result = client.PostAsync(url_api, jsonContent);
                var response = JObject.Parse(result.Result.Content.ReadAsStringAsync().Result);

                Program.TOKEN = response["token"].ToString();
                Program.NAME_USER = response["data"][0]["USERNAME"].ToString();

                MainForm mainForm = new MainForm();
                mainForm.FormClosed += new FormClosedEventHandler(mainForm_FormClosed);
                mainForm.Show();
                this.Hide();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Email hoặc password không đúng!");
            }
        }

        void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // here you can do anything

            // we will close the application
            Application.Exit();
        }

        private Boolean isEmpty()
        {
            if(textEmail.Text.Equals("") || textPassword.Text.Equals(""))
            {
                return true;
            }
            return false;
        }

        private void labelSignUp_Click(object sender, EventArgs e)
        {
            new SignUpForm().ShowDialog();
        }
    }
}
