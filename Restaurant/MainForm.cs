using Restaurant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantAdmin
{
    public partial class MainForm : Form
    {
        BookingForm bookingForm = new BookingForm();
        FoodForm foodForm = new FoodForm();
        TableForm tableForm = new TableForm();
        DashBoardForm dashBoardForm = new DashBoardForm();
        StatisticalForm statisticalForm = new StatisticalForm();
        public MainForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void roundImage(PictureBox pb)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pb.Width - 3, pb.Height - 3);
            Region rg = new Region(gp);
            pb.Region = rg;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            roundImage(pbAvatar);
            roundImage(pictureUser);

            setFormChild();

            panelDashBoard.BackColor = Color.Navy;
            labelDashboard.ForeColor = Color.White;
            dashBoardForm.Show();
        }


        private void setFormChild()
        {
            bookingForm.TopLevel = false;
            panelControl.Controls.Add(bookingForm);
            bookingForm.BringToFront();

            foodForm.TopLevel = false;
            panelControl.Controls.Add(foodForm);
            foodForm.BringToFront();

            tableForm.TopLevel = false;
            panelControl.Controls.Add(tableForm);
            tableForm.BringToFront();

            dashBoardForm.TopLevel = false;
            panelControl.Controls.Add(dashBoardForm);
            dashBoardForm.BringToFront();

            statisticalForm.TopLevel = false;
            panelControl.Controls.Add(statisticalForm);
            statisticalForm.BringToFront();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            panelBooking.BackColor = Color.Navy;
            labelBooking.ForeColor= Color.White;

            panelFood.BackColor = Color.FromArgb(239, 243, 244);
            labelFood.ForeColor = Color.Black;
            panelSaleOff.BackColor = Color.FromArgb(239, 243, 244);
            labelSaleOff.ForeColor = Color.Black;
            panelTable.BackColor = Color.FromArgb(239, 243, 244);
            labelTable.ForeColor = Color.Black;
            panelDashBoard.BackColor = Color.FromArgb(239, 243, 244);
            labelDashboard.ForeColor = Color.Black;
            panelStatistical.BackColor = Color.FromArgb(239, 243, 244);
            labelStatistical.ForeColor = Color.Black;

            bookingForm.Show();
            foodForm.Hide();
            tableForm.Hide();
            statisticalForm.Hide();
            dashBoardForm.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            panelFood.BackColor = Color.Navy;
            labelFood.ForeColor = Color.White;

            panelBooking.BackColor = Color.FromArgb(239, 243, 244);
            labelBooking.ForeColor = Color.Black;
            panelSaleOff.BackColor = Color.FromArgb(239, 243, 244);
            labelSaleOff.ForeColor = Color.Black;
            panelTable.BackColor = Color.FromArgb(239, 243, 244);
            labelTable.ForeColor = Color.Black;
            panelDashBoard.BackColor = Color.FromArgb(239, 243, 244);
            labelDashboard.ForeColor = Color.Black;
            panelStatistical.BackColor = Color.FromArgb(239, 243, 244);
            labelStatistical.ForeColor = Color.Black;

            bookingForm.Hide();
            foodForm.Show();
            dashBoardForm.Hide();
            tableForm.Hide();
            statisticalForm.Hide();
        }

        private void labelTable_Click(object sender, EventArgs e)
        {
            panelTable.BackColor = Color.Navy;
            labelTable.ForeColor = Color.White;

            panelBooking.BackColor = Color.FromArgb(239, 243, 244);
            labelBooking.ForeColor = Color.Black;
            panelSaleOff.BackColor = Color.FromArgb(239, 243, 244);
            labelSaleOff.ForeColor = Color.Black;
            panelFood.BackColor = Color.FromArgb(239, 243, 244);
            labelFood.ForeColor = Color.Black;
            panelDashBoard.BackColor = Color.FromArgb(239, 243, 244);
            labelDashboard.ForeColor = Color.Black;
            panelStatistical.BackColor = Color.FromArgb(239, 243, 244);
            labelStatistical.ForeColor = Color.Black;

            bookingForm.Hide();
            dashBoardForm.Hide();
            tableForm.Hide();
            tableForm.Show();
            statisticalForm.Hide();
        }

        private void labelDashboard_Click(object sender, EventArgs e)
        {
            panelDashBoard.BackColor = Color.Navy;
            labelDashboard.ForeColor = Color.White;

            panelFood.BackColor = Color.FromArgb(239, 243, 244);
            labelFood.ForeColor = Color.Black;
            panelSaleOff.BackColor = Color.FromArgb(239, 243, 244);
            labelSaleOff.ForeColor = Color.Black;
            panelTable.BackColor = Color.FromArgb(239, 243, 244);
            labelTable.ForeColor = Color.Black;
            panelBooking.BackColor = Color.FromArgb(239, 243, 244);
            labelBooking.ForeColor = Color.Black;
            panelStatistical.BackColor = Color.FromArgb(239, 243, 244);
            labelStatistical.ForeColor = Color.Black;

            dashBoardForm.Show();
            foodForm.Hide();
            tableForm.Hide();
            bookingForm.Hide();
            statisticalForm.Hide();
        }

        private void labelStatistical_Click(object sender, EventArgs e)
        {
            panelStatistical.BackColor = Color.Navy;
            labelStatistical.ForeColor = Color.White;

            panelFood.BackColor = Color.FromArgb(239, 243, 244);
            labelFood.ForeColor = Color.Black;
            panelSaleOff.BackColor = Color.FromArgb(239, 243, 244);
            labelSaleOff.ForeColor = Color.Black;
            panelTable.BackColor = Color.FromArgb(239, 243, 244);
            labelTable.ForeColor = Color.Black;
            panelBooking.BackColor = Color.FromArgb(239, 243, 244);
            labelBooking.ForeColor = Color.Black;
            panelDashBoard.BackColor = Color.FromArgb(239, 243, 244);
            labelDashboard.ForeColor = Color.Black;

            dashBoardForm.Hide();
            foodForm.Hide();
            tableForm.Hide();
            bookingForm.Hide();
            statisticalForm.Show();

        }

        private void panelControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = this.CheckExists(typeof(LoginForm));
            if (frm != null) frm.Show();
            else
            {
                LoginForm f = new LoginForm();
                f.Show();
            }
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
    }
}
