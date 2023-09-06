using Microsoft.Reporting.WinForms;
using Newtonsoft.Json.Linq;
using Restaurant.model;
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
    public partial class StatisticalByDateForm : Form
    {
        List<StatisticalModel> statisticalModels = new List<StatisticalModel>();
        int totaMoney = 0;
        public StatisticalByDateForm()
        {
            InitializeComponent();
        }

        private void StatisticalByDateForm_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "../../Report/Report2.rdlc";
        }

        private void getData()
        {
            setReportParameter();
            String url_api = Constants.URL_API + "/statistical/statistical-by-date";
            var client = new HttpClient();

            try
            {
                //client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwOi8vYXBpLnRhbmNhLmlvL2FwaS92NC9hdXRoL3NpZ25pbi9waG9uZSIsImlhdCI6MTY3Mjg0NzIwNiwibmJmIjoxNjcyODQ3MjA2LCJqdGkiOiJRR3V5b2puTTNsWFZNNzgwIiwic3ViIjoiTml0SnBlSnV2QXgzWmNhd0oiLCJwcnYiOiIxYzU1MjBmNzBiYWE2NTVkZGM1NzQ2YTY3NjRmMzcyYTFiNjU1YWE2Iiwic2hvcF9pZCI6IjVjMjBhMTljMGIwODg4MGY1OTRmYzQ2OCIsInNob3BfdXNlcm5hbWUiOiJ0YW5jYXhheWR1bmciLCJzaG9wX3ByZWZpeCI6InQiLCJ0eXBlIjoiYXBpIn0.qFWIs4VU3h3I-DAojuDg5mtuv0EOUN37g10eYRzbKBU");
                var obj = new
                {
                    fromDate= fromDate.Value.ToString("yyyy/MM/dd"),
                    toDate= toDate.Value.ToString("yyyy/MM/dd")

                };
                JsonContent jsonContent = JsonContent.Create(obj);
                var result = client.PostAsync(url_api, jsonContent);
                var response = JObject.Parse(result.Result.Content.ReadAsStringAsync().Result);

                int index = 1;
                foreach (var t in response["data"])
                {
                    totaMoney += Int32.Parse(t["TONG_TIEN"].ToString());
                    statisticalModels.Add(new StatisticalModel(index.ToString(), t["NGAY"].ToString(), t["TONG_TIEN"].ToString()));
                    index++;
                }

                setReport();
                setReportParameter();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void setReportParameter()
        {
            ReportParameter title = new ReportParameter("title", "THỐNG KÊ DOANH THU");
            this.reportViewer1.LocalReport.SetParameters(title);
            ReportParameter time = new ReportParameter("time", "Từ ngày " + fromDate.Value.ToString("dd/MM/yyyy") + " đến ngày " + toDate.Value.ToString("dd/MM/yyyy"));
            this.reportViewer1.LocalReport.SetParameters(time);
            ReportParameter total = new ReportParameter("total", totaMoney.ToString());
            this.reportViewer1.LocalReport.SetParameters(total);
            ReportParameter timeCreated = new ReportParameter("timeCreated", DateTime.Now.ToString("dd/MM/yyyy") + ", Hồ Chí Minh");
            this.reportViewer1.LocalReport.SetParameters(timeCreated);
            ReportParameter nameEmplyer = new ReportParameter("nameEmployer", "Nguyễn Văn A");
            this.reportViewer1.LocalReport.SetParameters(nameEmplyer);
        }

        private void setReport()
        {
            ReportDataSource reportData = new ReportDataSource("DataSet1", statisticalModels);

            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(reportData);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(DateTime.Compare(fromDate.Value, toDate.Value) > 0)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc!");
                return;
            }
            getData();
        }
    }
}
