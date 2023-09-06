namespace Restaurant
{
    partial class ListDepositForm
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
            this.dvgDeposits = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDeposits)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgDeposits
            // 
            this.dvgDeposits.AllowUserToAddRows = false;
            this.dvgDeposits.AllowUserToDeleteRows = false;
            this.dvgDeposits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgDeposits.BackgroundColor = System.Drawing.Color.White;
            this.dvgDeposits.ColumnHeadersHeight = 30;
            this.dvgDeposits.Location = new System.Drawing.Point(24, 63);
            this.dvgDeposits.Name = "dvgDeposits";
            this.dvgDeposits.RowTemplate.Height = 30;
            this.dvgDeposits.Size = new System.Drawing.Size(570, 224);
            this.dvgDeposits.TabIndex = 0;
            this.dvgDeposits.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgDeposits_CellClick);
            this.dvgDeposits.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgDeposits_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách phiếu cọc ";
            // 
            // ListDepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 323);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvgDeposits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ListDepositForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListDepositForm";
            this.Load += new System.EventHandler(this.ListDepositForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDeposits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgDeposits;
        private System.Windows.Forms.Label label1;
    }
}