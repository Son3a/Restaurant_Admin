namespace Restaurant
{
    partial class DepositForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.lbDeposited = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbDeposit = new System.Windows.Forms.Label();
            this.lbRest = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTypePay = new System.Windows.Forms.Label();
            this.labelDatePay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelIdDeposit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đã thanh toán";
            // 
            // lbDeposited
            // 
            this.lbDeposited.AutoSize = true;
            this.lbDeposited.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeposited.Location = new System.Drawing.Point(159, 29);
            this.lbDeposited.Name = "lbDeposited";
            this.lbDeposited.Size = new System.Drawing.Size(99, 30);
            this.lbDeposited.TabIndex = 5;
            this.lbDeposited.Text = "100.000đ";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(95, 206);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(110, 40);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Duyệt";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(631, 107);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbTotal.Size = new System.Drawing.Size(0, 17);
            this.lbTotal.TabIndex = 7;
            // 
            // lbDeposit
            // 
            this.lbDeposit.AutoSize = true;
            this.lbDeposit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeposit.Location = new System.Drawing.Point(631, 151);
            this.lbDeposit.Name = "lbDeposit";
            this.lbDeposit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbDeposit.Size = new System.Drawing.Size(0, 17);
            this.lbDeposit.TabIndex = 8;
            // 
            // lbRest
            // 
            this.lbRest.AutoSize = true;
            this.lbRest.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRest.Location = new System.Drawing.Point(631, 196);
            this.lbRest.Name = "lbRest";
            this.lbRest.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbRest.Size = new System.Drawing.Size(0, 17);
            this.lbRest.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hình thức thanh toán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày thanh toán";
            // 
            // labelTypePay
            // 
            this.labelTypePay.AutoSize = true;
            this.labelTypePay.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypePay.Location = new System.Drawing.Point(184, 127);
            this.labelTypePay.Name = "labelTypePay";
            this.labelTypePay.Size = new System.Drawing.Size(0, 17);
            this.labelTypePay.TabIndex = 10;
            // 
            // labelDatePay
            // 
            this.labelDatePay.AutoSize = true;
            this.labelDatePay.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatePay.Location = new System.Drawing.Point(184, 153);
            this.labelDatePay.Name = "labelDatePay";
            this.labelDatePay.Size = new System.Drawing.Size(0, 17);
            this.labelDatePay.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã phiếu cọc";
            // 
            // labelIdDeposit
            // 
            this.labelIdDeposit.AutoSize = true;
            this.labelIdDeposit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdDeposit.Location = new System.Drawing.Point(184, 97);
            this.labelIdDeposit.Name = "labelIdDeposit";
            this.labelIdDeposit.Size = new System.Drawing.Size(0, 17);
            this.labelIdDeposit.TabIndex = 13;
            // 
            // DepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 317);
            this.Controls.Add(this.labelIdDeposit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelDatePay);
            this.Controls.Add(this.labelTypePay);
            this.Controls.Add(this.lbRest);
            this.Controls.Add(this.lbDeposit);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lbDeposited);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DepositForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepositForm";
            this.Load += new System.EventHandler(this.DepositForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbDeposited;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbDeposit;
        private System.Windows.Forms.Label lbRest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTypePay;
        private System.Windows.Forms.Label labelDatePay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelIdDeposit;
    }
}