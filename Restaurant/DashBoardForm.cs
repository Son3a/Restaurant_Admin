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
    public partial class DashBoardForm : Form
    {
        public DashBoardForm()
        {
            InitializeComponent();
        }

        private void DashBoardForm_Load(object sender, EventArgs e)
        {
            cbxStatus.SelectedIndex = 0;
            setDataGridViewBooking();
            getDataBooking("all");
        }

        private void setDataGridViewBooking()
        {
            dvgBookings.ColumnCount = 6;

            dvgBookings.Columns[0].Name = "Mã phiếu đặt";
            dvgBookings.Columns[1].Name = "Khách hàng";
            dvgBookings.Columns[2].Name = "Sdt";
            dvgBookings.Columns[3].Name = "Số người";
            dvgBookings.Columns[4].Name = "Giờ đặt";
            dvgBookings.Columns[5].Name = "Trạng thái";
        }

        private String convertTime(String time)
        {
            return DateTime.Parse(time).ToString("HH:mm");
        }

        private void getDataBooking(String status)
        {
            String url_api = Constants.URL_API + "/booking/update-booking-in-current-day";
            var client = new HttpClient();

            try
            {
                //client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwOi8vYXBpLnRhbmNhLmlvL2FwaS92NC9hdXRoL3NpZ25pbi9waG9uZSIsImlhdCI6MTY3Mjg0NzIwNiwibmJmIjoxNjcyODQ3MjA2LCJqdGkiOiJRR3V5b2puTTNsWFZNNzgwIiwic3ViIjoiTml0SnBlSnV2QXgzWmNhd0oiLCJwcnYiOiIxYzU1MjBmNzBiYWE2NTVkZGM1NzQ2YTY3NjRmMzcyYTFiNjU1YWE2Iiwic2hvcF9pZCI6IjVjMjBhMTljMGIwODg4MGY1OTRmYzQ2OCIsInNob3BfdXNlcm5hbWUiOiJ0YW5jYXhheWR1bmciLCJzaG9wX3ByZWZpeCI6InQiLCJ0eXBlIjoiYXBpIn0.qFWIs4VU3h3I-DAojuDg5mtuv0EOUN37g10eYRzbKBU");
                var obj = new
                {
                    id = "all"
                };
                JsonContent jsonContent = JsonContent.Create(obj);

                var result = client.PostAsync(url_api, jsonContent);
                var response = JObject.Parse(result.Result.Content.ReadAsStringAsync().Result);
                dvgBookings.Rows.Clear();
                dvgBookings.Refresh();
                string[] row;
                if (response["data"].ToString().Equals("[]"))
                {
                    labelNotify.Visible = true;
                    return;
                }
                else
                {
                    labelNotify.Visible = false;
                }
                string statusString;
                foreach (var t in response["data"])
                {
                    statusString = t["TRANGTHAI"].ToString();

                    row = new String[] {
                        t["MAPD"].ToString(),
                        t["HOTEN"].ToString(),
                        t["SDT"].ToString(),
                        t["SONGUOI"].ToString(),
                        convertTime(t["NGAYDAT"].ToString()),
                        statusString,
                    };
                    dvgBookings.Rows.Add(row);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getDataBooking("all");
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void dvgBookings_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dvgBookings.Rows[e.RowIndex];

            //DataGridViewRow row = dvgBookings.Rows[e.RowIndex];
            Program.ID_BOOKING = row.Cells[0].Value.ToString();

            Form frm = this.CheckExists(typeof(BookingDetail));
            BookingDetail f = new BookingDetail();
            //f.MdiParent = this;
            f.ShowDialog();
        }

        private void cbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (cbxStatus.SelectedIndex == 0)
            {
                getDataBooking("all");
            }
            else if (cbxStatus.SelectedIndex == 1)
            {
                getDataBooking(Constants.STATUS_CONFIRMED);
            }
            else if (cbxStatus.SelectedIndex == 2)
            {
                getDataBooking(Constants.STATUS_RECEPTION);
            }
        }

        private void buttonAddBooking_Click_1(object sender, EventArgs e)
        {
            new AddBooking().ShowDialog();
        }
    }
}
