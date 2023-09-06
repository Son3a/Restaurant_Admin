namespace RestaurantAdmin
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelStatistical = new System.Windows.Forms.Panel();
            this.labelStatistical = new System.Windows.Forms.Label();
            this.panelTable = new System.Windows.Forms.Panel();
            this.labelTable = new System.Windows.Forms.Label();
            this.panelSaleOff = new System.Windows.Forms.Panel();
            this.labelSaleOff = new System.Windows.Forms.Label();
            this.panelFood = new System.Windows.Forms.Panel();
            this.labelFood = new System.Windows.Forms.Label();
            this.panelBooking = new System.Windows.Forms.Panel();
            this.labelBooking = new System.Windows.Forms.Label();
            this.panelDashBoard = new System.Windows.Forms.Panel();
            this.labelDashboard = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelStatistical.SuspendLayout();
            this.panelTable.SuspendLayout();
            this.panelSaleOff.SuspendLayout();
            this.panelFood.SuspendLayout();
            this.panelBooking.SuspendLayout();
            this.panelDashBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.White;
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl.Location = new System.Drawing.Point(246, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(938, 661);
            this.panelControl.TabIndex = 0;
            this.panelControl.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "BaLi Restaurant";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.panelStatistical);
            this.panel1.Controls.Add(this.panelTable);
            this.panel1.Controls.Add(this.panelSaleOff);
            this.panel1.Controls.Add(this.panelFood);
            this.panel1.Controls.Add(this.panelBooking);
            this.panel1.Controls.Add(this.panelDashBoard);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureUser);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbAvatar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 661);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelStatistical
            // 
            this.panelStatistical.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelStatistical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelStatistical.Controls.Add(this.labelStatistical);
            this.panelStatistical.Location = new System.Drawing.Point(20, 422);
            this.panelStatistical.Name = "panelStatistical";
            this.panelStatistical.Size = new System.Drawing.Size(200, 37);
            this.panelStatistical.TabIndex = 12;
            // 
            // labelStatistical
            // 
            this.labelStatistical.AutoSize = true;
            this.labelStatistical.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatistical.Location = new System.Drawing.Point(43, 6);
            this.labelStatistical.Name = "labelStatistical";
            this.labelStatistical.Size = new System.Drawing.Size(78, 21);
            this.labelStatistical.TabIndex = 6;
            this.labelStatistical.Text = "Thống kê";
            this.labelStatistical.Click += new System.EventHandler(this.labelStatistical_Click);
            // 
            // panelTable
            // 
            this.panelTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelTable.Controls.Add(this.labelTable);
            this.panelTable.Location = new System.Drawing.Point(20, 182);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(200, 37);
            this.panelTable.TabIndex = 11;
            // 
            // labelTable
            // 
            this.labelTable.AutoSize = true;
            this.labelTable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTable.Location = new System.Drawing.Point(43, 8);
            this.labelTable.Name = "labelTable";
            this.labelTable.Size = new System.Drawing.Size(95, 21);
            this.labelTable.TabIndex = 4;
            this.labelTable.Text = "Quản lý bàn";
            this.labelTable.Click += new System.EventHandler(this.labelTable_Click);
            // 
            // panelSaleOff
            // 
            this.panelSaleOff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSaleOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelSaleOff.Controls.Add(this.labelSaleOff);
            this.panelSaleOff.Location = new System.Drawing.Point(20, 362);
            this.panelSaleOff.Name = "panelSaleOff";
            this.panelSaleOff.Size = new System.Drawing.Size(200, 37);
            this.panelSaleOff.TabIndex = 11;
            // 
            // labelSaleOff
            // 
            this.labelSaleOff.AutoSize = true;
            this.labelSaleOff.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaleOff.Location = new System.Drawing.Point(43, 6);
            this.labelSaleOff.Name = "labelSaleOff";
            this.labelSaleOff.Size = new System.Drawing.Size(123, 21);
            this.labelSaleOff.TabIndex = 6;
            this.labelSaleOff.Text = "Đợt khuyến mãi";
            // 
            // panelFood
            // 
            this.panelFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelFood.Controls.Add(this.labelFood);
            this.panelFood.Location = new System.Drawing.Point(20, 302);
            this.panelFood.Name = "panelFood";
            this.panelFood.Size = new System.Drawing.Size(200, 37);
            this.panelFood.TabIndex = 11;
            // 
            // labelFood
            // 
            this.labelFood.AutoSize = true;
            this.labelFood.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFood.Location = new System.Drawing.Point(43, 8);
            this.labelFood.Name = "labelFood";
            this.labelFood.Size = new System.Drawing.Size(65, 21);
            this.labelFood.TabIndex = 5;
            this.labelFood.Text = "Món ăn";
            this.labelFood.Click += new System.EventHandler(this.label5_Click);
            // 
            // panelBooking
            // 
            this.panelBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBooking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelBooking.Controls.Add(this.labelBooking);
            this.panelBooking.Location = new System.Drawing.Point(20, 242);
            this.panelBooking.Name = "panelBooking";
            this.panelBooking.Size = new System.Drawing.Size(200, 37);
            this.panelBooking.TabIndex = 10;
            // 
            // labelBooking
            // 
            this.labelBooking.AutoSize = true;
            this.labelBooking.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBooking.Location = new System.Drawing.Point(43, 8);
            this.labelBooking.Name = "labelBooking";
            this.labelBooking.Size = new System.Drawing.Size(78, 21);
            this.labelBooking.TabIndex = 4;
            this.labelBooking.Text = "Phiếu đặt";
            this.labelBooking.Click += new System.EventHandler(this.label4_Click);
            // 
            // panelDashBoard
            // 
            this.panelDashBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDashBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelDashBoard.Controls.Add(this.labelDashboard);
            this.panelDashBoard.Location = new System.Drawing.Point(20, 122);
            this.panelDashBoard.Name = "panelDashBoard";
            this.panelDashBoard.Size = new System.Drawing.Size(200, 37);
            this.panelDashBoard.TabIndex = 9;
            // 
            // labelDashboard
            // 
            this.labelDashboard.AutoSize = true;
            this.labelDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboard.Location = new System.Drawing.Point(43, 7);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(89, 21);
            this.labelDashboard.TabIndex = 3;
            this.labelDashboard.Text = "Dashboard";
            this.labelDashboard.Click += new System.EventHandler(this.labelDashboard_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(76, 584);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Đăng xuất";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // pictureUser
            // 
            this.pictureUser.BackgroundImage = global::Restaurant.Properties.Resources.avatarUser;
            this.pictureUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureUser.Location = new System.Drawing.Point(63, 504);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(100, 68);
            this.pictureUser.TabIndex = 7;
            this.pictureUser.TabStop = false;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(20, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 2);
            this.label2.TabIndex = 2;
            // 
            // pbAvatar
            // 
            this.pbAvatar.Image = global::Restaurant.Properties.Resources.avatar;
            this.pbAvatar.Location = new System.Drawing.Point(28, 27);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(40, 40);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatar.TabIndex = 0;
            this.pbAvatar.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelControl);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelStatistical.ResumeLayout(false);
            this.panelStatistical.PerformLayout();
            this.panelTable.ResumeLayout(false);
            this.panelTable.PerformLayout();
            this.panelSaleOff.ResumeLayout(false);
            this.panelSaleOff.PerformLayout();
            this.panelFood.ResumeLayout(false);
            this.panelFood.PerformLayout();
            this.panelBooking.ResumeLayout(false);
            this.panelBooking.PerformLayout();
            this.panelDashBoard.ResumeLayout(false);
            this.panelDashBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelBooking;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.Label labelSaleOff;
        private System.Windows.Forms.Label labelFood;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelSaleOff;
        private System.Windows.Forms.Panel panelFood;
        private System.Windows.Forms.Panel panelBooking;
        private System.Windows.Forms.Panel panelDashBoard;
        private System.Windows.Forms.Panel panelTable;
        private System.Windows.Forms.Label labelTable;
        private System.Windows.Forms.Panel panelStatistical;
        private System.Windows.Forms.Label labelStatistical;
    }
}