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
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using Restaurant;

namespace RestaurantAdmin
{
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            cbxStatus.SelectedIndex = 0;

            setDataGridViewBooking();

            getDataBooking();
        }

        private void setDataGridViewBooking()
        {
            dvgBookings.ColumnCount = 6;

            dvgBookings.Columns[0].Name = "Mã phiếu đặt";
            dvgBookings.Columns[1].Name = "Khách hàng";
            dvgBookings.Columns[2].Name = "Sdt";
            dvgBookings.Columns[3].Name = "Số người";
            dvgBookings.Columns[4].Name = "Ngày tạo";
            dvgBookings.Columns[5].Name = "Trạng thái";
        }

        private void getDataBooking()
        {
            String url_api = Constants.URL_API + "/booking/get-all-bookings";
            var client = new HttpClient();

            try
            {
                //client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwOi8vYXBpLnRhbmNhLmlvL2FwaS92NC9hdXRoL3NpZ25pbi9waG9uZSIsImlhdCI6MTY3Mjg0NzIwNiwibmJmIjoxNjcyODQ3MjA2LCJqdGkiOiJRR3V5b2puTTNsWFZNNzgwIiwic3ViIjoiTml0SnBlSnV2QXgzWmNhd0oiLCJwcnYiOiIxYzU1MjBmNzBiYWE2NTVkZGM1NzQ2YTY3NjRmMzcyYTFiNjU1YWE2Iiwic2hvcF9pZCI6IjVjMjBhMTljMGIwODg4MGY1OTRmYzQ2OCIsInNob3BfdXNlcm5hbWUiOiJ0YW5jYXhheWR1bmciLCJzaG9wX3ByZWZpeCI6InQiLCJ0eXBlIjoiYXBpIn0.qFWIs4VU3h3I-DAojuDg5mtuv0EOUN37g10eYRzbKBU");
                var result = client.GetAsync(url_api);
                var response = JObject.Parse(result.Result.Content.ReadAsStringAsync().Result);
                dvgBookings.Rows.Clear();
                dvgBookings.Refresh();
                string[] row;
                foreach (var t in response["data"])
                {
                    row = new String[] {
                        t["MAPD"].ToString(),
                        t["HOTEN"].ToString(),
                        t["SDT"].ToString(),
                        t["SONGUOI"].ToString(),
                        t["NGAYTAO"].ToString(),
                        t["TRANGTHAI"].ToString()
                    };
                    dvgBookings.Rows.Add(row);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi mạng! Xin hãy kiểm tra lại kết nối");
            }
        }

        private void getDataBookingByStatus()
        {
            if (cbxStatus.SelectedIndex == 0) return;

            String status = cbxStatus.Text;
            String url_api = Constants.URL_API + "/booking/get-bookings-by-status/" + status;
            var client = new HttpClient();

            try
            {
                //client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwOi8vYXBpLnRhbmNhLmlvL2FwaS92NC9hdXRoL3NpZ25pbi9waG9uZSIsImlhdCI6MTY3Mjg0NzIwNiwibmJmIjoxNjcyODQ3MjA2LCJqdGkiOiJRR3V5b2puTTNsWFZNNzgwIiwic3ViIjoiTml0SnBlSnV2QXgzWmNhd0oiLCJwcnYiOiIxYzU1MjBmNzBiYWE2NTVkZGM1NzQ2YTY3NjRmMzcyYTFiNjU1YWE2Iiwic2hvcF9pZCI6IjVjMjBhMTljMGIwODg4MGY1OTRmYzQ2OCIsInNob3BfdXNlcm5hbWUiOiJ0YW5jYXhheWR1bmciLCJzaG9wX3ByZWZpeCI6InQiLCJ0eXBlIjoiYXBpIn0.qFWIs4VU3h3I-DAojuDg5mtuv0EOUN37g10eYRzbKBU");
                var result = client.GetAsync(url_api);
                var response = JObject.Parse(result.Result.Content.ReadAsStringAsync().Result);
                dvgBookings.Rows.Clear();
                dvgBookings.Refresh();
                string[] row;
                foreach (var t in response["data"])
                {
                    row = new String[] {
                        t["MAPD"].ToString(),
                        t["HOTEN"].ToString(),
                        t["SDT"].ToString(),
                        t["SONGUOI"].ToString(),
                        t["NGAYTAO"].ToString(),
                        t["TRANGTHAI"].ToString()                    
                    };
                    dvgBookings.Rows.Add(row);
                }
                // 
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi mạng! Xin hãy kiểm tra lại kết nối");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getDataBooking();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void dvgBookings_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //DataGridViewRow row = dvgBookings.Rows[e.RowIndex];
            Program.ID_BOOKING = dvgBookings.Rows[e.RowIndex].Cells[0].Value.ToString();

            Form frm = this.CheckExists(typeof(BookingDetail));
            if (frm != null) frm.Activate();
            else
            {
                BookingDetail f = new BookingDetail();
                //f.MdiParent = this;
                f.ShowDialog();
            }
        }

        private void cbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDataBookingByStatus();
        }
    }
}
