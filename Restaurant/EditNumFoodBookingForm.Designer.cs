namespace Restaurant
{
    partial class EditNumFoodBookingForm
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
            this.labelFoodName = new System.Windows.Forms.Label();
            this.labelNumOfFood = new System.Windows.Forms.Label();
            this.pbFood = new System.Windows.Forms.PictureBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.pbMinus = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFoodName
            // 
            this.labelFoodName.AutoSize = true;
            this.labelFoodName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFoodName.Location = new System.Drawing.Point(102, 172);
            this.labelFoodName.Name = "labelFoodName";
            this.labelFoodName.Size = new System.Drawing.Size(76, 21);
            this.labelFoodName.TabIndex = 1;
            this.labelFoodName.Text = "Tên món";
            this.labelFoodName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNumOfFood
            // 
            this.labelNumOfFood.AutoSize = true;
            this.labelNumOfFood.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumOfFood.Location = new System.Drawing.Point(130, 208);
            this.labelNumOfFood.Name = "labelNumOfFood";
            this.labelNumOfFood.Size = new System.Drawing.Size(0, 21);
            this.labelNumOfFood.TabIndex = 2;
            this.labelNumOfFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbFood
            // 
            this.pbFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFood.Location = new System.Drawing.Point(72, 51);
            this.pbFood.Name = "pbFood";
            this.pbFood.Size = new System.Drawing.Size(138, 111);
            this.pbFood.TabIndex = 0;
            this.pbFood.TabStop = false;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.Green;
            this.buttonConfirm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.ForeColor = System.Drawing.Color.White;
            this.buttonConfirm.Location = new System.Drawing.Point(88, 256);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(100, 38);
            this.buttonConfirm.TabIndex = 5;
            this.buttonConfirm.Text = "Xác nhận";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // pbMinus
            // 
            this.pbMinus.BackgroundImage = global::Restaurant.Properties.Resources.ic_minus;
            this.pbMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMinus.Location = new System.Drawing.Point(174, 208);
            this.pbMinus.Name = "pbMinus";
            this.pbMinus.Size = new System.Drawing.Size(20, 20);
            this.pbMinus.TabIndex = 6;
            this.pbMinus.TabStop = false;
            this.pbMinus.Click += new System.EventHandler(this.pbMinus_Click);
            // 
            // pbAdd
            // 
            this.pbAdd.BackgroundImage = global::Restaurant.Properties.Resources.ic_plus;
            this.pbAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAdd.Location = new System.Drawing.Point(80, 208);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(20, 20);
            this.pbAdd.TabIndex = 7;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // EditFoodBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 334);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.pbMinus);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.labelNumOfFood);
            this.Controls.Add(this.labelFoodName);
            this.Controls.Add(this.pbFood);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditFoodBookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditFoodBookingForm";
            this.Load += new System.EventHandler(this.EditFoodBookingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFood;
        private System.Windows.Forms.Label labelFoodName;
        private System.Windows.Forms.Label labelNumOfFood;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.PictureBox pbMinus;
        private System.Windows.Forms.PictureBox pbAdd;
    }
}