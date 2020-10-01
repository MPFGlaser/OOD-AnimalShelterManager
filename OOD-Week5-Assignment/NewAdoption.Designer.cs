﻿namespace OOD_Week5_Assignment
{
    partial class NewAdoption
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
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCustomerName = new System.Windows.Forms.ComboBox();
            this.comboBoxAnimal1 = new System.Windows.Forms.ComboBox();
            this.comboBoxAnimal2 = new System.Windows.Forms.ComboBox();
            this.comboBoxAnimal3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTotalAdoptionFee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(297, 465);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 10;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(15, 465);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Customer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Date and time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Animal";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm:ss dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 89);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // comboBoxCustomerName
            // 
            this.comboBoxCustomerName.FormattingEnabled = true;
            this.comboBoxCustomerName.Location = new System.Drawing.Point(12, 29);
            this.comboBoxCustomerName.Name = "comboBoxCustomerName";
            this.comboBoxCustomerName.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCustomerName.TabIndex = 16;
            // 
            // comboBoxAnimal1
            // 
            this.comboBoxAnimal1.FormattingEnabled = true;
            this.comboBoxAnimal1.Location = new System.Drawing.Point(12, 141);
            this.comboBoxAnimal1.Name = "comboBoxAnimal1";
            this.comboBoxAnimal1.Size = new System.Drawing.Size(200, 21);
            this.comboBoxAnimal1.TabIndex = 17;
            // 
            // comboBoxAnimal2
            // 
            this.comboBoxAnimal2.FormattingEnabled = true;
            this.comboBoxAnimal2.Location = new System.Drawing.Point(12, 168);
            this.comboBoxAnimal2.Name = "comboBoxAnimal2";
            this.comboBoxAnimal2.Size = new System.Drawing.Size(200, 21);
            this.comboBoxAnimal2.TabIndex = 18;
            // 
            // comboBoxAnimal3
            // 
            this.comboBoxAnimal3.FormattingEnabled = true;
            this.comboBoxAnimal3.Location = new System.Drawing.Point(12, 195);
            this.comboBoxAnimal3.Name = "comboBoxAnimal3";
            this.comboBoxAnimal3.Size = new System.Drawing.Size(200, 21);
            this.comboBoxAnimal3.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Total adoption fee:";
            // 
            // labelTotalAdoptionFee
            // 
            this.labelTotalAdoptionFee.AutoSize = true;
            this.labelTotalAdoptionFee.Location = new System.Drawing.Point(111, 235);
            this.labelTotalAdoptionFee.Name = "labelTotalAdoptionFee";
            this.labelTotalAdoptionFee.Size = new System.Drawing.Size(25, 13);
            this.labelTotalAdoptionFee.TabIndex = 21;
            this.labelTotalAdoptionFee.Text = "€12";
            // 
            // NewAdoption
            // 
            this.AcceptButton = this.buttonConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(384, 500);
            this.Controls.Add(this.labelTotalAdoptionFee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxAnimal3);
            this.Controls.Add(this.comboBoxAnimal2);
            this.Controls.Add(this.comboBoxAnimal1);
            this.Controls.Add(this.comboBoxCustomerName);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.MaximumSize = new System.Drawing.Size(400, 539);
            this.MinimumSize = new System.Drawing.Size(400, 539);
            this.Name = "NewAdoption";
            this.Text = "NewAdoption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxCustomerName;
        private System.Windows.Forms.ComboBox comboBoxAnimal1;
        private System.Windows.Forms.ComboBox comboBoxAnimal2;
        private System.Windows.Forms.ComboBox comboBoxAnimal3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTotalAdoptionFee;
    }
}