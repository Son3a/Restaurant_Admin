using Newtonsoft.Json.Linq;
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
using Microsoft.Reporting.WinForms;
using Restaurant.model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Restaurant
{
    public partial class BillForm : Form
    {
        List<FoodBill> foodBills = new List<FoodBill>();
        public BillForm()
        {
            InitializeComponent();
        }

        private void BillForm_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            this.reportViewer1.LocalReport.ReportPath = "../../Report/BillReport.rdlc";
            getData();
        }

        private void getData()
        {
            String url_api = Constants.URL_API + "/bill/get-food-to-pay";
            var client = new HttpClient();

            try
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Program.TOKEN);
                var obj = new
                {
                    idBooking = Program.ID_BOOKING,
                };
                JsonContent jsonContent = JsonContent.Create(obj);
                var result = client.PostAsync(url_api, jsonContent);
                var response = JObject.Parse(result.Result.Content.ReadAsStringAsync().Result);
                var foodsObj = response["data"][0];
                var depositObj = response["data"][1];
                var tablesObj = response["data"][2];
                var billObj = response["data"][3];

                string idBill = billObj[0]["MAHD"].ToString().Trim();
                string nameTable = "";
                
                foreach (var t in tablesObj)
                {
                    nameTable += t["TENBAN"].ToString().Trim();
                }

                string timeCreated = DateTime.Parse(billObj[0]["NGAYTAO"].ToString().Trim()).ToString("HH:mm dddd/MM/yyyy");

                int total = 0;
                int index = 1;

                foreach (var t in foodsObj)
                {
                    string totalString = t["GIA"].ToString().Trim();
                    total += Int32.Parse(totalString);
                    string num = t["SO_LUONG"].ToString().Trim();
                    foodBills.Add(new FoodBill(
                        index.ToString(),
                        t["TEN"].ToString().Trim(),
                        Constants.formatMoney(totalString),
                        num,
                        Constants.formatMoney((Int32.Parse(num) * Int32.Parse(totalString)).ToString())
                    ));
                    index++;
                }

                int deposit = 0;

                foreach (var t in depositObj)
                {
                    deposit += Int32.Parse(t["GIACOC"].ToString().Trim());
                }

                string nameclient = billObj[0]["HOTEN"].ToString().Trim();

                double tax = 0.1;

                int amount = (int)((total * tax) - deposit);

                setReportParameter(idBill,nameTable,timeCreated,Constants.formatMoney(total.ToString()), 
                                    Constants.formatMoney(deposit.ToString()),tax.ToString(), Constants.formatMoney(amount.ToString()), nameclient);
                setReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void setReportParameter(string idBill, string nameTable, string timeCreated, string total, string deposit, string tax, string amount, string nameClient )
        {
            ReportParameter pidBooking = new ReportParameter("idBill", idBill);
            ReportParameter ptime = new ReportParameter("timeBill", timeCreated);
            ReportParameter ptable = new ReportParameter("nameTable", nameTable);
            ReportParameter pttotal = new ReportParameter("total", total);
            ReportParameter pdeposit = new ReportParameter("deposit", deposit);
            ReportParameter ptax = new ReportParameter("tax", tax);
            ReportParameter pamount = new ReportParameter("amount", amount);
            ReportParameter pnameEmployer = new ReportParameter("nameEmloyer", Program.NAME_USER);

            this.reportViewer1.LocalReport.SetParameters(pidBooking);
            this.reportViewer1.LocalReport.SetParameters(ptime);
            this.reportViewer1.LocalReport.SetParameters(ptable);
            this.reportViewer1.LocalReport.SetParameters(pttotal);
            this.reportViewer1.LocalReport.SetParameters(pdeposit);
            this.reportViewer1.LocalReport.SetParameters(ptax);
            this.reportViewer1.LocalReport.SetParameters(pamount);
            this.reportViewer1.LocalReport.SetParameters(pnameEmployer);

        }

        private void setReport()
        {
            this.reportViewer1.LocalReport.ReportPath = "../../Report/BillReport.rdlc";
            ReportDataSource reportData = new ReportDataSource("DataSetBill", foodBills);

            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(reportData);

            this.reportViewer1.RefreshReport();
        }
    }
}
