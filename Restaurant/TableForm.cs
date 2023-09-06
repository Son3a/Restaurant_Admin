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
    public partial class TableForm : Form
    {
        private List<String> listId = new List<String>();
        public TableForm()
        {
            InitializeComponent();
        }

        private void TableForm_Load(object sender, EventArgs e)
        {
            cbxStatus.SelectedIndex = 0;
            setDataGridViewTable();
            getRooms();
            getTables("all", 1);
        }

        private void getRooms()
        {
            cbxRoom.Items.Add("Tất cả");
            listId.Add("0");
            cbxRoom.SelectedIndex = 0;
            String url_api = Constants.URL_API + "/table/get-rooms";
            var client = new HttpClient();

            try
            {
                //client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwOi8vYXBpLnRhbmNhLmlvL2FwaS92NC9hdXRoL3NpZ25pbi9waG9uZSIsImlhdCI6MTY3Mjg0NzIwNiwibmJmIjoxNjcyODQ3MjA2LCJqdGkiOiJRR3V5b2puTTNsWFZNNzgwIiwic3ViIjoiTml0SnBlSnV2QXgzWmNhd0oiLCJwcnYiOiIxYzU1MjBmNzBiYWE2NTVkZGM1NzQ2YTY3NjRmMzcyYTFiNjU1YWE2Iiwic2hvcF9pZCI6IjVjMjBhMTljMGIwODg4MGY1OTRmYzQ2OCIsInNob3BfdXNlcm5hbWUiOiJ0YW5jYXhheWR1bmciLCJzaG9wX3ByZWZpeCI6InQiLCJ0eXBlIjoiYXBpIn0.qFWIs4VU3h3I-DAojuDg5mtuv0EOUN37g10eYRzbKBU");
                var result = client.GetAsync(url_api);
                var response = JObject.Parse(result.Result.Content.ReadAsStringAsync().Result);

                foreach (var t in response["data"])
                {
                    listId.Add(t["MAPHONG"].ToString().Trim());
                    cbxRoom.Items.Add(t["TEN"].ToString().Trim());
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi mạng! Xin hãy kiểm tra lại kết nối");
            }
        }
        private void setDataGridViewTable()
        {
            dgvTables.ColumnCount = 4;
            dgvTables.Columns[0].Name = "Mã bàn";
            dgvTables.Columns[1].Name = "Tên bàn";
            dgvTables.Columns[2].Name = "Số ghế";
            dgvTables.Columns[3].Name = "Trạng thái";
        }

        private void getTables(String idRoom, int idStatus)
        {
            String url_api = Constants.URL_API + "/table/find-tables";
            var client = new HttpClient();

            try
            {
                //client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwOi8vYXBpLnRhbmNhLmlvL2FwaS92NC9hdXRoL3NpZ25pbi9waG9uZSIsImlhdCI6MTY3Mjg0NzIwNiwibmJmIjoxNjcyODQ3MjA2LCJqdGkiOiJRR3V5b2puTTNsWFZNNzgwIiwic3ViIjoiTml0SnBlSnV2QXgzWmNhd0oiLCJwcnYiOiIxYzU1MjBmNzBiYWE2NTVkZGM1NzQ2YTY3NjRmMzcyYTFiNjU1YWE2Iiwic2hvcF9pZCI6IjVjMjBhMTljMGIwODg4MGY1OTRmYzQ2OCIsInNob3BfdXNlcm5hbWUiOiJ0YW5jYXhheWR1bmciLCJzaG9wX3ByZWZpeCI6InQiLCJ0eXBlIjoiYXBpIn0.qFWIs4VU3h3I-DAojuDg5mtuv0EOUN37g10eYRzbKBU");
                var obj = new
                {
                    idRoom = idRoom,
                    status = idStatus
                };
                JsonContent jsonContent = JsonContent.Create(obj);
                var result = client.PostAsync(url_api, jsonContent);
                var response = JObject.Parse(result.Result.Content.ReadAsStringAsync().Result);

                dgvTables.Rows.Clear();
                dgvTables.Refresh();
                string[] row;
                String status = "";
                foreach (var t in response["data"])
                {
                    status = t["MAPD"].ToString().Equals("") ? "Trống" : "Có khách";
                    row = new String[] {
                        t["MABAN"].ToString(),
                        t["TENBAN"].ToString(),
                        t["SONGUOI"].ToString(),
                        status
                    };
                    dgvTables.Rows.Add(row);
                }

             /*   DataGridViewButtonColumn button1 = new DataGridViewButtonColumn();
                {
                    button1.Name = "buttonPayMent";
                    button1.HeaderText = "";
                    button1.Text = "Thanh toán";
                    button1.UseColumnTextForButtonValue = true; //dont forget this line
                    dgvTables.Columns.Add(button1);
                }*/
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi mạng! Xin hãy kiểm tra lại kết nối");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            findJob();
        }

        private void findJob()
        {
            int index = cbxRoom.SelectedIndex;

            if (index == 0 && cbxStatus.SelectedIndex == 0)
            {
                getTables("all", 1);
            }
            else if (index != 0 && cbxStatus.SelectedIndex == 0)
            {
                getTables(listId[index], 1);
            }
            if (index == 0 && cbxStatus.SelectedIndex == 1)
            {
                getTables("all", 2);
            }
            if (index != 0 && cbxStatus.SelectedIndex == 1)
            {
                getTables(listId[index], 2);
            }
            if (index == 0 && cbxStatus.SelectedIndex == 2)
            {
                getTables("all", 3);
            }
            if (index != 0 && cbxStatus.SelectedIndex == 2)
            {
                getTables(listId[index], 3);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            findJob();
        }
    }
}
