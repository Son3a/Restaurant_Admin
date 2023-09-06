using Microsoft.Reporting.WinForms;
using Restaurant.model;
using RestaurantAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class StatisticalForm : Form
    {
       
        StatisticalByDateForm statisticalByDate = new StatisticalByDateForm();
        StatisticalByMonth statisticalByMonth = new StatisticalByMonth();
       
        public StatisticalForm()
        {
            InitializeComponent();
        }

        private void StatisticalForm_Load(object sender, EventArgs e)
        {
            cbxStatistical.SelectedIndex = 0;
            setFormChild();

            statisticalByDate.Show();
            statisticalByMonth.Hide();
        }

        private void setFormChild()
        {
            statisticalByDate.TopLevel = false;
            panelStatistical.Controls.Add(statisticalByDate);
            statisticalByDate.BringToFront();
            statisticalByDate.Dock= DockStyle.Fill;

            statisticalByMonth.TopLevel = false;
            panelStatistical.Controls.Add(statisticalByMonth);
            statisticalByMonth.BringToFront();
            statisticalByMonth.Dock = DockStyle.Fill;
        }

        private void cbxStatistical_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxStatistical.SelectedIndex == 0)
            {
                statisticalByDate.Show();
                statisticalByMonth.Hide();
            } else
            {
                statisticalByDate.Hide();
                statisticalByMonth.Show();
            }
        }
    }
}
