namespace OOD_Week5_Assignment
{
    partial class NewCustomer
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxZipCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAddressInvalid = new System.Windows.Forms.Label();
            this.labelZipCodeInvalid = new System.Windows.Forms.Label();
            this.labelCityInvalid = new System.Windows.Forms.Label();
            this.labelNameInvalid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(15, 26);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(184, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(297, 465);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 5;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(15, 465);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(15, 80);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(184, 20);
            this.textBoxAddress.TabIndex = 2;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBoxAddress_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Address:";
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.Location = new System.Drawing.Point(15, 134);
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.Size = new System.Drawing.Size(184, 20);
            this.textBoxZipCode.TabIndex = 3;
            this.textBoxZipCode.TextChanged += new System.EventHandler(this.textBoxZipCode_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Zip code:";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(15, 187);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(184, 20);
            this.textBoxCity.TabIndex = 4;
            this.textBoxCity.TextChanged += new System.EventHandler(this.textBoxCity_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "City:";
            // 
            // labelAddressInvalid
            // 
            this.labelAddressInvalid.AutoSize = true;
            this.labelAddressInvalid.ForeColor = System.Drawing.Color.Red;
            this.labelAddressInvalid.Location = new System.Drawing.Point(205, 83);
            this.labelAddressInvalid.Name = "labelAddressInvalid";
            this.labelAddressInvalid.Size = new System.Drawing.Size(136, 13);
            this.labelAddressInvalid.TabIndex = 17;
            this.labelAddressInvalid.Text = "Please fill in a valid address";
            // 
            // labelZipCodeInvalid
            // 
            this.labelZipCodeInvalid.AutoSize = true;
            this.labelZipCodeInvalid.ForeColor = System.Drawing.Color.Red;
            this.labelZipCodeInvalid.Location = new System.Drawing.Point(205, 137);
            this.labelZipCodeInvalid.Name = "labelZipCodeInvalid";
            this.labelZipCodeInvalid.Size = new System.Drawing.Size(139, 13);
            this.labelZipCodeInvalid.TabIndex = 18;
            this.labelZipCodeInvalid.Text = "Please fill in a valid zip code";
            // 
            // labelCityInvalid
            // 
            this.labelCityInvalid.AutoSize = true;
            this.labelCityInvalid.ForeColor = System.Drawing.Color.Red;
            this.labelCityInvalid.Location = new System.Drawing.Point(205, 194);
            this.labelCityInvalid.Name = "labelCityInvalid";
            this.labelCityInvalid.Size = new System.Drawing.Size(115, 13);
            this.labelCityInvalid.TabIndex = 19;
            this.labelCityInvalid.Text = "Please fill in a valid city";
            // 
            // labelNameInvalid
            // 
            this.labelNameInvalid.AutoSize = true;
            this.labelNameInvalid.ForeColor = System.Drawing.Color.Red;
            this.labelNameInvalid.Location = new System.Drawing.Point(205, 29);
            this.labelNameInvalid.Name = "labelNameInvalid";
            this.labelNameInvalid.Size = new System.Drawing.Size(125, 13);
            this.labelNameInvalid.TabIndex = 20;
            this.labelNameInvalid.Text = "Please fill in a valid name";
            // 
            // NewCustomer
            // 
            this.AcceptButton = this.buttonConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(384, 500);
            this.Controls.Add(this.labelNameInvalid);
            this.Controls.Add(this.labelCityInvalid);
            this.Controls.Add(this.labelZipCodeInvalid);
            this.Controls.Add(this.labelAddressInvalid);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxZipCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(400, 539);
            this.MinimumSize = new System.Drawing.Size(400, 539);
            this.Name = "NewCustomer";
            this.Text = "New Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxZipCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAddressInvalid;
        private System.Windows.Forms.Label labelZipCodeInvalid;
        private System.Windows.Forms.Label labelCityInvalid;
        private System.Windows.Forms.Label labelNameInvalid;
    }
}