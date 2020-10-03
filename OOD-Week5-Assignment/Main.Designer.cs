namespace OOD_Week5_Assignment
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.buttonNewAnimal = new System.Windows.Forms.Button();
            this.buttonNewCustomer = new System.Windows.Forms.Button();
            this.buttonNewAdoption = new System.Windows.Forms.Button();
            this.buttonSaveData = new System.Windows.Forms.Button();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.listBoxAdoptions = new System.Windows.Forms.ListBox();
            this.listBoxAnimals = new System.Windows.Forms.ListBox();
            this.buttonAdoptionInfo = new System.Windows.Forms.Button();
            this.buttonAnimalInfo = new System.Windows.Forms.Button();
            this.listBoxCustomers = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxShowAdopted = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonNewAnimal
            // 
            this.buttonNewAnimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNewAnimal.Location = new System.Drawing.Point(257, 366);
            this.buttonNewAnimal.Name = "buttonNewAnimal";
            this.buttonNewAnimal.Size = new System.Drawing.Size(144, 23);
            this.buttonNewAnimal.TabIndex = 0;
            this.buttonNewAnimal.Text = "New animal";
            this.buttonNewAnimal.UseVisualStyleBackColor = true;
            this.buttonNewAnimal.Click += new System.EventHandler(this.buttonNewAnimal_Click);
            // 
            // buttonNewCustomer
            // 
            this.buttonNewCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNewCustomer.Location = new System.Drawing.Point(503, 366);
            this.buttonNewCustomer.Name = "buttonNewCustomer";
            this.buttonNewCustomer.Size = new System.Drawing.Size(144, 23);
            this.buttonNewCustomer.TabIndex = 1;
            this.buttonNewCustomer.Text = "New customer";
            this.buttonNewCustomer.UseVisualStyleBackColor = true;
            this.buttonNewCustomer.Click += new System.EventHandler(this.buttonNewCustomer_Click);
            // 
            // buttonNewAdoption
            // 
            this.buttonNewAdoption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNewAdoption.Location = new System.Drawing.Point(11, 366);
            this.buttonNewAdoption.Name = "buttonNewAdoption";
            this.buttonNewAdoption.Size = new System.Drawing.Size(144, 23);
            this.buttonNewAdoption.TabIndex = 2;
            this.buttonNewAdoption.Text = "New Adoption";
            this.buttonNewAdoption.UseVisualStyleBackColor = true;
            this.buttonNewAdoption.Click += new System.EventHandler(this.buttonNewAdoption_Click);
            // 
            // buttonSaveData
            // 
            this.buttonSaveData.Location = new System.Drawing.Point(93, 12);
            this.buttonSaveData.Name = "buttonSaveData";
            this.buttonSaveData.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveData.TabIndex = 7;
            this.buttonSaveData.Text = "Save";
            this.buttonSaveData.UseVisualStyleBackColor = true;
            this.buttonSaveData.Click += new System.EventHandler(this.buttonSaveData_Click);
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Location = new System.Drawing.Point(12, 12);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadData.TabIndex = 8;
            this.buttonLoadData.Text = "Load";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_Click);
            // 
            // listBoxAdoptions
            // 
            this.listBoxAdoptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxAdoptions.FormattingEnabled = true;
            this.listBoxAdoptions.Location = new System.Drawing.Point(11, 57);
            this.listBoxAdoptions.Name = "listBoxAdoptions";
            this.listBoxAdoptions.Size = new System.Drawing.Size(240, 303);
            this.listBoxAdoptions.TabIndex = 3;
            // 
            // listBoxAnimals
            // 
            this.listBoxAnimals.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxAnimals.FormattingEnabled = true;
            this.listBoxAnimals.Location = new System.Drawing.Point(257, 57);
            this.listBoxAnimals.Name = "listBoxAnimals";
            this.listBoxAnimals.Size = new System.Drawing.Size(240, 303);
            this.listBoxAnimals.TabIndex = 5;
            // 
            // buttonAdoptionInfo
            // 
            this.buttonAdoptionInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdoptionInfo.Location = new System.Drawing.Point(161, 366);
            this.buttonAdoptionInfo.Name = "buttonAdoptionInfo";
            this.buttonAdoptionInfo.Size = new System.Drawing.Size(90, 23);
            this.buttonAdoptionInfo.TabIndex = 4;
            this.buttonAdoptionInfo.Text = "View info";
            this.buttonAdoptionInfo.UseVisualStyleBackColor = true;
            this.buttonAdoptionInfo.Click += new System.EventHandler(this.buttonAdoptionInfo_Click);
            // 
            // buttonAnimalInfo
            // 
            this.buttonAnimalInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAnimalInfo.Location = new System.Drawing.Point(407, 366);
            this.buttonAnimalInfo.Name = "buttonAnimalInfo";
            this.buttonAnimalInfo.Size = new System.Drawing.Size(90, 23);
            this.buttonAnimalInfo.TabIndex = 6;
            this.buttonAnimalInfo.Text = "View info";
            this.buttonAnimalInfo.UseVisualStyleBackColor = true;
            this.buttonAnimalInfo.Click += new System.EventHandler(this.buttonAnimalInfo_Click);
            // 
            // listBoxCustomers
            // 
            this.listBoxCustomers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxCustomers.FormattingEnabled = true;
            this.listBoxCustomers.Location = new System.Drawing.Point(503, 57);
            this.listBoxCustomers.Name = "listBoxCustomers";
            this.listBoxCustomers.Size = new System.Drawing.Size(240, 303);
            this.listBoxCustomers.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(653, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "View info";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Adoptions";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Animals";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Customers";
            // 
            // checkBoxShowAdopted
            // 
            this.checkBoxShowAdopted.AutoSize = true;
            this.checkBoxShowAdopted.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxShowAdopted.Location = new System.Drawing.Point(361, 40);
            this.checkBoxShowAdopted.Name = "checkBoxShowAdopted";
            this.checkBoxShowAdopted.Size = new System.Drawing.Size(133, 17);
            this.checkBoxShowAdopted.TabIndex = 14;
            this.checkBoxShowAdopted.Text = "Show adopted animals";
            this.checkBoxShowAdopted.UseVisualStyleBackColor = false;
            this.checkBoxShowAdopted.CheckedChanged += new System.EventHandler(this.checkBoxShowAdopted_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 400);
            this.Controls.Add(this.checkBoxShowAdopted);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxCustomers);
            this.Controls.Add(this.buttonAnimalInfo);
            this.Controls.Add(this.buttonAdoptionInfo);
            this.Controls.Add(this.listBoxAnimals);
            this.Controls.Add(this.listBoxAdoptions);
            this.Controls.Add(this.buttonLoadData);
            this.Controls.Add(this.buttonSaveData);
            this.Controls.Add(this.buttonNewAdoption);
            this.Controls.Add(this.buttonNewCustomer);
            this.Controls.Add(this.buttonNewAnimal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(771, 439);
            this.MinimumSize = new System.Drawing.Size(771, 439);
            this.Name = "Main";
            this.Text = "Shelter Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewAnimal;
        private System.Windows.Forms.Button buttonNewCustomer;
        private System.Windows.Forms.Button buttonNewAdoption;
        private System.Windows.Forms.Button buttonSaveData;
        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.ListBox listBoxAdoptions;
        private System.Windows.Forms.ListBox listBoxAnimals;
        private System.Windows.Forms.Button buttonAdoptionInfo;
        private System.Windows.Forms.Button buttonAnimalInfo;
        private System.Windows.Forms.ListBox listBoxCustomers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxShowAdopted;
    }
}

