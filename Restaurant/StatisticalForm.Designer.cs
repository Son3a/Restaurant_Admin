namespace Restaurant
{
    partial class StatisticalForm
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
            this.cbxStatistical = new System.Windows.Forms.ComboBox();
            this.panelStatistical = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cbxStatistical
            // 
            this.cbxStatistical.FormattingEnabled = true;
            this.cbxStatistical.Items.AddRange(new object[] {
            "Thống kê theo ngày",
            "Thống kê theo tháng"});
            this.cbxStatistical.Location = new System.Drawing.Point(720, 27);
            this.cbxStatistical.Name = "cbxStatistical";
            this.cbxStatistical.Size = new System.Drawing.Size(118, 21);
            this.cbxStatistical.TabIndex = 24;
            this.cbxStatistical.SelectedIndexChanged += new System.EventHandler(this.cbxStatistical_SelectedIndexChanged);
            // 
            // panelStatistical
            // 
            this.panelStatistical.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatistical.Location = new System.Drawing.Point(0, 69);
            this.panelStatistical.Name = "panelStatistical";
            this.panelStatistical.Size = new System.Drawing.Size(938, 592);
            this.panelStatistical.TabIndex = 25;
            // 
            // StatisticalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(938, 661);
            this.Controls.Add(this.panelStatistical);
            this.Controls.Add(this.cbxStatistical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatisticalForm";
            this.Text = "StatisticalForm";
            this.Load += new System.EventHandler(this.StatisticalForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxStatistical;
        private System.Windows.Forms.Panel panelStatistical;
    }
}