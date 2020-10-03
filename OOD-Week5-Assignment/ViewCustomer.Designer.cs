namespace OOD_Week5_Assignment
{
    partial class ViewCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCustomer));
            this.groupBoxCustomerDetails = new System.Windows.Forms.GroupBox();
            this.labelCustomerCity = new System.Windows.Forms.Label();
            this.labelCustomerZipcode = new System.Windows.Forms.Label();
            this.labelCustomerAddress = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxCustomerDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCustomerDetails
            // 
            this.groupBoxCustomerDetails.Controls.Add(this.labelCustomerCity);
            this.groupBoxCustomerDetails.Controls.Add(this.labelCustomerZipcode);
            this.groupBoxCustomerDetails.Controls.Add(this.labelCustomerAddress);
            this.groupBoxCustomerDetails.Controls.Add(this.labelCustomerName);
            this.groupBoxCustomerDetails.Controls.Add(this.label4);
            this.groupBoxCustomerDetails.Controls.Add(this.label3);
            this.groupBoxCustomerDetails.Controls.Add(this.label2);
            this.groupBoxCustomerDetails.Controls.Add(this.label1);
            this.groupBoxCustomerDetails.Location = new System.Drawing.Point(15, 13);
            this.groupBoxCustomerDetails.Name = "groupBoxCustomerDetails";
            this.groupBoxCustomerDetails.Size = new System.Drawing.Size(357, 236);
            this.groupBoxCustomerDetails.TabIndex = 13;
            this.groupBoxCustomerDetails.TabStop = false;
            this.groupBoxCustomerDetails.Text = "Customer Details";
            // 
            // labelCustomerCity
            // 
            this.labelCustomerCity.AutoSize = true;
            this.labelCustomerCity.Location = new System.Drawing.Point(71, 103);
            this.labelCustomerCity.Name = "labelCustomerCity";
            this.labelCustomerCity.Size = new System.Drawing.Size(71, 13);
            this.labelCustomerCity.TabIndex = 7;
            this.labelCustomerCity.Text = "Customer City";
            // 
            // labelCustomerZipcode
            // 
            this.labelCustomerZipcode.AutoSize = true;
            this.labelCustomerZipcode.Location = new System.Drawing.Point(71, 74);
            this.labelCustomerZipcode.Name = "labelCustomerZipcode";
            this.labelCustomerZipcode.Size = new System.Drawing.Size(93, 13);
            this.labelCustomerZipcode.TabIndex = 6;
            this.labelCustomerZipcode.Text = "Customer Zipcode";
            // 
            // labelCustomerAddress
            // 
            this.labelCustomerAddress.AutoSize = true;
            this.labelCustomerAddress.Location = new System.Drawing.Point(71, 44);
            this.labelCustomerAddress.Name = "labelCustomerAddress";
            this.labelCustomerAddress.Size = new System.Drawing.Size(92, 13);
            this.labelCustomerAddress.TabIndex = 5;
            this.labelCustomerAddress.Text = "Customer Address";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(71, 16);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(82, 13);
            this.labelCustomerName.TabIndex = 4;
            this.labelCustomerName.Text = "Customer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "City:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zipcode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // ViewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.groupBoxCustomerDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "ViewCustomer";
            this.Text = "View Customer";
            this.groupBoxCustomerDetails.ResumeLayout(false);
            this.groupBoxCustomerDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxCustomerDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCustomerCity;
        private System.Windows.Forms.Label labelCustomerZipcode;
        private System.Windows.Forms.Label labelCustomerAddress;
        private System.Windows.Forms.Label labelCustomerName;
    }
}