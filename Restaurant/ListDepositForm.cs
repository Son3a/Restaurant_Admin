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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Restaurant
{
    public partial class ListDepositForm : Form
    {
        public static String idDeposit;
        public static String moneyDeposit;
        public ListDepositForm()
        {
            InitializeComponent();
        }

        private void ListDepositForm_Load(object sender, EventArgs e)
        {
            setDataGridViewDeposit();
            getDataDeposit();
        }

        private void setDataGridViewDeposit()
        {
            dvgDeposits.ColumnCount = 3;

            dvgDeposits.Columns[0].Name = "Mã phiếu cọc";
            dvgDeposits.Columns[1].Name = "Ngày cọc";
            dvgDeposits.Columns[2].Name = "Số tiền cọc";
        }

        private void getDataDeposit()
        {
            String idBooking = Program.ID_BOOKING;
            String url_api = Constants.URL_API + "/deposit/get-deposit-by-booking/" + idBooking;
            var client = new HttpClient();

            try
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Program.TOKEN); 
                var result = client.GetAsync(url_api);
                var response = JObject.Parse(result.Result.Content.ReadAsStringAsync().Result);
                dvgDeposits.Rows.Clear();
                dvgDeposits.Refresh();
                string[] row;
                foreach (var t in response["data"])
                {
                    row = new String[] {
                        t["MAPC"].ToString(),
                        t["NGAYCOC"].ToString(),
                        Constants.formatMoney(t["GIACOC"].ToString()),
                    };
                    dvgDeposits.Rows.Add(row);
                }
                // 
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void dvgDeposits_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dvgDeposits_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dvgDeposits.Rows[e.RowIndex];
            idDeposit = row.Cells[0].Value.ToString();
            moneyDeposit = row.Cells[2].Value.ToString();
            new DepositForm().ShowDialog();
        }
    }
}
