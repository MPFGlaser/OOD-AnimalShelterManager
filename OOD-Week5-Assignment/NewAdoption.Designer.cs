namespace OOD_Week5_Assignment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAdoption));
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAnimal = new System.Windows.Forms.Label();
            this.dateTimePickerAdoptionMoment = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCustomerName = new System.Windows.Forms.ComboBox();
            this.comboBoxAnimal1 = new System.Windows.Forms.ComboBox();
            this.comboBoxAnimal2 = new System.Windows.Forms.ComboBox();
            this.comboBoxAnimal3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTotalAdoptionFee = new System.Windows.Forms.Label();
            this.buttonRemoveAnimal2 = new System.Windows.Forms.Button();
            this.buttonRemoveAnimal3 = new System.Windows.Forms.Button();
            this.buttonNewAnimalComboBox = new System.Windows.Forms.Button();
            this.labelAnimal2AlreadyChosen = new System.Windows.Forms.Label();
            this.labelAnimal3AlreadyChosen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(297, 465);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 9;
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
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
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
            // labelAnimal
            // 
            this.labelAnimal.AutoSize = true;
            this.labelAnimal.Location = new System.Drawing.Point(15, 125);
            this.labelAnimal.Name = "labelAnimal";
            this.labelAnimal.Size = new System.Drawing.Size(41, 13);
            this.labelAnimal.TabIndex = 14;
            this.labelAnimal.Text = "Animal:";
            // 
            // dateTimePickerAdoptionMoment
            // 
            this.dateTimePickerAdoptionMoment.CustomFormat = "HH:mm:ss dd/MM/yyyy";
            this.dateTimePickerAdoptionMoment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAdoptionMoment.Location = new System.Drawing.Point(12, 89);
            this.dateTimePickerAdoptionMoment.Name = "dateTimePickerAdoptionMoment";
            this.dateTimePickerAdoptionMoment.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAdoptionMoment.TabIndex = 2;
            // 
            // comboBoxCustomerName
            // 
            this.comboBoxCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomerName.FormattingEnabled = true;
            this.comboBoxCustomerName.Location = new System.Drawing.Point(12, 29);
            this.comboBoxCustomerName.Name = "comboBoxCustomerName";
            this.comboBoxCustomerName.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCustomerName.TabIndex = 1;
            this.comboBoxCustomerName.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomerName_SelectedIndexChanged);
            // 
            // comboBoxAnimal1
            // 
            this.comboBoxAnimal1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAnimal1.FormattingEnabled = true;
            this.comboBoxAnimal1.Location = new System.Drawing.Point(12, 141);
            this.comboBoxAnimal1.Name = "comboBoxAnimal1";
            this.comboBoxAnimal1.Size = new System.Drawing.Size(200, 21);
            this.comboBoxAnimal1.TabIndex = 3;
            this.comboBoxAnimal1.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnimal1_SelectedIndexChanged);
            // 
            // comboBoxAnimal2
            // 
            this.comboBoxAnimal2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAnimal2.FormattingEnabled = true;
            this.comboBoxAnimal2.Location = new System.Drawing.Point(12, 168);
            this.comboBoxAnimal2.Name = "comboBoxAnimal2";
            this.comboBoxAnimal2.Size = new System.Drawing.Size(200, 21);
            this.comboBoxAnimal2.TabIndex = 5;
            this.comboBoxAnimal2.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnimal2_SelectedIndexChanged);
            // 
            // comboBoxAnimal3
            // 
            this.comboBoxAnimal3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAnimal3.FormattingEnabled = true;
            this.comboBoxAnimal3.Location = new System.Drawing.Point(12, 195);
            this.comboBoxAnimal3.Name = "comboBoxAnimal3";
            this.comboBoxAnimal3.Size = new System.Drawing.Size(200, 21);
            this.comboBoxAnimal3.TabIndex = 7;
            this.comboBoxAnimal3.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnimal3_SelectedIndexChanged);
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
            this.labelTotalAdoptionFee.Size = new System.Drawing.Size(34, 13);
            this.labelTotalAdoptionFee.TabIndex = 21;
            this.labelTotalAdoptionFee.Text = "€0.00";
            // 
            // buttonRemoveAnimal2
            // 
            this.buttonRemoveAnimal2.Location = new System.Drawing.Point(218, 168);
            this.buttonRemoveAnimal2.Name = "buttonRemoveAnimal2";
            this.buttonRemoveAnimal2.Size = new System.Drawing.Size(21, 21);
            this.buttonRemoveAnimal2.TabIndex = 6;
            this.buttonRemoveAnimal2.Text = "🗑️";
            this.buttonRemoveAnimal2.UseVisualStyleBackColor = true;
            this.buttonRemoveAnimal2.Click += new System.EventHandler(this.buttonRemoveAnimal2_Click);
            // 
            // buttonRemoveAnimal3
            // 
            this.buttonRemoveAnimal3.Location = new System.Drawing.Point(218, 195);
            this.buttonRemoveAnimal3.Name = "buttonRemoveAnimal3";
            this.buttonRemoveAnimal3.Size = new System.Drawing.Size(21, 21);
            this.buttonRemoveAnimal3.TabIndex = 8;
            this.buttonRemoveAnimal3.Text = "🗑️";
            this.buttonRemoveAnimal3.UseVisualStyleBackColor = true;
            this.buttonRemoveAnimal3.Click += new System.EventHandler(this.buttonRemoveAnimal3_Click);
            // 
            // buttonNewAnimalComboBox
            // 
            this.buttonNewAnimalComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonNewAnimalComboBox.Location = new System.Drawing.Point(218, 141);
            this.buttonNewAnimalComboBox.Name = "buttonNewAnimalComboBox";
            this.buttonNewAnimalComboBox.Size = new System.Drawing.Size(21, 21);
            this.buttonNewAnimalComboBox.TabIndex = 4;
            this.buttonNewAnimalComboBox.Text = "➕";
            this.buttonNewAnimalComboBox.UseVisualStyleBackColor = true;
            this.buttonNewAnimalComboBox.Click += new System.EventHandler(this.buttonNewAnimalComboBox_Click);
            // 
            // labelAnimal2AlreadyChosen
            // 
            this.labelAnimal2AlreadyChosen.AutoSize = true;
            this.labelAnimal2AlreadyChosen.ForeColor = System.Drawing.Color.Red;
            this.labelAnimal2AlreadyChosen.Location = new System.Drawing.Point(245, 172);
            this.labelAnimal2AlreadyChosen.Name = "labelAnimal2AlreadyChosen";
            this.labelAnimal2AlreadyChosen.Size = new System.Drawing.Size(113, 13);
            this.labelAnimal2AlreadyChosen.TabIndex = 22;
            this.labelAnimal2AlreadyChosen.Text = "Animal already chosen";
            this.labelAnimal2AlreadyChosen.Visible = false;
            // 
            // labelAnimal3AlreadyChosen
            // 
            this.labelAnimal3AlreadyChosen.AutoSize = true;
            this.labelAnimal3AlreadyChosen.ForeColor = System.Drawing.Color.Red;
            this.labelAnimal3AlreadyChosen.Location = new System.Drawing.Point(245, 199);
            this.labelAnimal3AlreadyChosen.Name = "labelAnimal3AlreadyChosen";
            this.labelAnimal3AlreadyChosen.Size = new System.Drawing.Size(113, 13);
            this.labelAnimal3AlreadyChosen.TabIndex = 23;
            this.labelAnimal3AlreadyChosen.Text = "Animal already chosen";
            this.labelAnimal3AlreadyChosen.Visible = false;
            // 
            // NewAdoption
            // 
            this.AcceptButton = this.buttonConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(384, 500);
            this.Controls.Add(this.labelAnimal3AlreadyChosen);
            this.Controls.Add(this.labelAnimal2AlreadyChosen);
            this.Controls.Add(this.buttonNewAnimalComboBox);
            this.Controls.Add(this.buttonRemoveAnimal3);
            this.Controls.Add(this.buttonRemoveAnimal2);
            this.Controls.Add(this.labelTotalAdoptionFee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxAnimal3);
            this.Controls.Add(this.comboBoxAnimal2);
            this.Controls.Add(this.comboBoxAnimal1);
            this.Controls.Add(this.comboBoxCustomerName);
            this.Controls.Add(this.dateTimePickerAdoptionMoment);
            this.Controls.Add(this.labelAnimal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 539);
            this.MinimumSize = new System.Drawing.Size(400, 539);
            this.Name = "NewAdoption";
            this.Text = "New Adoption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAnimal;
        private System.Windows.Forms.DateTimePicker dateTimePickerAdoptionMoment;
        private System.Windows.Forms.ComboBox comboBoxCustomerName;
        private System.Windows.Forms.ComboBox comboBoxAnimal1;
        private System.Windows.Forms.ComboBox comboBoxAnimal2;
        private System.Windows.Forms.ComboBox comboBoxAnimal3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTotalAdoptionFee;
        private System.Windows.Forms.Button buttonRemoveAnimal2;
        private System.Windows.Forms.Button buttonRemoveAnimal3;
        private System.Windows.Forms.Button buttonNewAnimalComboBox;
        private System.Windows.Forms.Label labelAnimal2AlreadyChosen;
        private System.Windows.Forms.Label labelAnimal3AlreadyChosen;
    }
}