namespace Restaurant
{
    partial class BookingDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingDetail));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.dvgFoods = new System.Windows.Forms.DataGridView();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textIdBooking = new System.Windows.Forms.Label();
            this.textNameClient = new System.Windows.Forms.Label();
            this.textPhoneNum = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.Label();
            this.textNameTable = new System.Windows.Forms.Label();
            this.textNumOfPeople = new System.Windows.Forms.Label();
            this.textTimeComing = new System.Windows.Forms.Label();
            this.textStatus = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.buttonEditFood = new System.Windows.Forms.Button();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pbBill = new System.Windows.Forms.PictureBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgFoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBill)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu đặt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(301, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Trạng thái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(301, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ngày đến";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(301, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Số người";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(301, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Bàn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(576, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 21);
            this.label9.TabIndex = 19;
            this.label9.Text = "Món ăn đã đặt";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // dvgFoods
            // 
            this.dvgFoods.AllowUserToAddRows = false;
            this.dvgFoods.AllowUserToDeleteRows = false;
            this.dvgFoods.AllowUserToResizeColumns = false;
            this.dvgFoods.AllowUserToResizeRows = false;
            this.dvgFoods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgFoods.BackgroundColor = System.Drawing.Color.White;
            this.dvgFoods.ColumnHeadersHeight = 30;
            this.dvgFoods.Location = new System.Drawing.Point(523, 70);
            this.dvgFoods.Name = "dvgFoods";
            this.dvgFoods.RowHeadersVisible = false;
            this.dvgFoods.RowTemplate.Height = 30;
            this.dvgFoods.Size = new System.Drawing.Size(240, 185);
            this.dvgFoods.TabIndex = 20;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(50)))));
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(417, 308);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 44);
            this.btnConfirm.TabIndex = 21;
            this.btnConfirm.Text = "Duyệt";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(291, 308);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 44);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Hủy đơn";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textIdBooking
            // 
            this.textIdBooking.AutoSize = true;
            this.textIdBooking.BackColor = System.Drawing.Color.White;
            this.textIdBooking.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIdBooking.Location = new System.Drawing.Point(64, 70);
            this.textIdBooking.Margin = new System.Windows.Forms.Padding(0);
            this.textIdBooking.Name = "textIdBooking";
            this.textIdBooking.Padding = new System.Windows.Forms.Padding(5);
            this.textIdBooking.Size = new System.Drawing.Size(10, 27);
            this.textIdBooking.TabIndex = 23;
            // 
            // textNameClient
            // 
            this.textNameClient.AutoSize = true;
            this.textNameClient.BackColor = System.Drawing.Color.White;
            this.textNameClient.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNameClient.Location = new System.Drawing.Point(64, 129);
            this.textNameClient.Name = "textNameClient";
            this.textNameClient.Padding = new System.Windows.Forms.Padding(5);
            this.textNameClient.Size = new System.Drawing.Size(10, 27);
            this.textNameClient.TabIndex = 24;
            // 
            // textPhoneNum
            // 
            this.textPhoneNum.AutoSize = true;
            this.textPhoneNum.BackColor = System.Drawing.Color.White;
            this.textPhoneNum.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPhoneNum.Location = new System.Drawing.Point(64, 190);
            this.textPhoneNum.Name = "textPhoneNum";
            this.textPhoneNum.Padding = new System.Windows.Forms.Padding(5);
            this.textPhoneNum.Size = new System.Drawing.Size(10, 27);
            this.textPhoneNum.TabIndex = 25;
            // 
            // textEmail
            // 
            this.textEmail.AutoSize = true;
            this.textEmail.BackColor = System.Drawing.Color.White;
            this.textEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.Location = new System.Drawing.Point(64, 238);
            this.textEmail.Name = "textEmail";
            this.textEmail.Padding = new System.Windows.Forms.Padding(5);
            this.textEmail.Size = new System.Drawing.Size(10, 27);
            this.textEmail.TabIndex = 26;
            // 
            // textNameTable
            // 
            this.textNameTable.AutoSize = true;
            this.textNameTable.BackColor = System.Drawing.Color.White;
            this.textNameTable.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNameTable.Location = new System.Drawing.Point(314, 70);
            this.textNameTable.Margin = new System.Windows.Forms.Padding(0);
            this.textNameTable.Name = "textNameTable";
            this.textNameTable.Padding = new System.Windows.Forms.Padding(5);
            this.textNameTable.Size = new System.Drawing.Size(10, 27);
            this.textNameTable.TabIndex = 27;
            // 
            // textNumOfPeople
            // 
            this.textNumOfPeople.AutoSize = true;
            this.textNumOfPeople.BackColor = System.Drawing.Color.White;
            this.textNumOfPeople.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumOfPeople.Location = new System.Drawing.Point(314, 129);
            this.textNumOfPeople.Name = "textNumOfPeople";
            this.textNumOfPeople.Padding = new System.Windows.Forms.Padding(5);
            this.textNumOfPeople.Size = new System.Drawing.Size(10, 27);
            this.textNumOfPeople.TabIndex = 28;
            // 
            // textTimeComing
            // 
            this.textTimeComing.AutoSize = true;
            this.textTimeComing.BackColor = System.Drawing.Color.White;
            this.textTimeComing.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTimeComing.Location = new System.Drawing.Point(314, 190);
            this.textTimeComing.Name = "textTimeComing";
            this.textTimeComing.Padding = new System.Windows.Forms.Padding(5);
            this.textTimeComing.Size = new System.Drawing.Size(10, 27);
            this.textTimeComing.TabIndex = 29;
            // 
            // textStatus
            // 
            this.textStatus.AutoSize = true;
            this.textStatus.BackColor = System.Drawing.Color.White;
            this.textStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStatus.Location = new System.Drawing.Point(314, 238);
            this.textStatus.Name = "textStatus";
            this.textStatus.Padding = new System.Windows.Forms.Padding(5);
            this.textStatus.Size = new System.Drawing.Size(10, 27);
            this.textStatus.TabIndex = 30;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkGray;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(50, 308);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 44);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // buttonEditFood
            // 
            this.buttonEditFood.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditFood.Location = new System.Drawing.Point(547, 261);
            this.buttonEditFood.Name = "buttonEditFood";
            this.buttonEditFood.Size = new System.Drawing.Size(75, 23);
            this.buttonEditFood.TabIndex = 36;
            this.buttonEditFood.Text = "Chỉnh sửa";
            this.buttonEditFood.UseVisualStyleBackColor = true;
            this.buttonEditFood.Click += new System.EventHandler(this.buttonEditFood_Click);
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeposit.Location = new System.Drawing.Point(658, 261);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(75, 23);
            this.buttonDeposit.TabIndex = 37;
            this.buttonDeposit.Text = "Phiếu cọc";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // pbBill
            // 
            this.pbBill.BackgroundImage = global::Restaurant.Properties.Resources.ic_bill;
            this.pbBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBill.Location = new System.Drawing.Point(616, 307);
            this.pbBill.Name = "pbBill";
            this.pbBill.Size = new System.Drawing.Size(45, 45);
            this.pbBill.TabIndex = 39;
            this.pbBill.TabStop = false;
            this.pbBill.Visible = false;
            this.pbBill.Click += new System.EventHandler(this.pbBill_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.DarkGray;
            this.buttonRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.Black;
            this.buttonRefresh.Location = new System.Drawing.Point(169, 307);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(100, 44);
            this.buttonRefresh.TabIndex = 40;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // BookingDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 375);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.pbBill);
            this.Controls.Add(this.buttonDeposit);
            this.Controls.Add(this.buttonEditFood);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.textStatus);
            this.Controls.Add(this.textTimeComing);
            this.Controls.Add(this.textNumOfPeople);
            this.Controls.Add(this.textNameTable);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textPhoneNum);
            this.Controls.Add(this.textNameClient);
            this.Controls.Add(this.textIdBooking);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dvgFoods);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BookingDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingDetail";
            this.Load += new System.EventHandler(this.BookingDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgFoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.DataGridView dvgFoods;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label textStatus;
        private System.Windows.Forms.Label textTimeComing;
        private System.Windows.Forms.Label textNumOfPeople;
        private System.Windows.Forms.Label textNameTable;
        private System.Windows.Forms.Label textEmail;
        private System.Windows.Forms.Label textPhoneNum;
        private System.Windows.Forms.Label textNameClient;
        private System.Windows.Forms.Label textIdBooking;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Button buttonEditFood;
        private System.Windows.Forms.PictureBox pbBill;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button buttonRefresh;
    }
}