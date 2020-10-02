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
            this.buttonNewAnimal = new System.Windows.Forms.Button();
            this.buttonNewCustomer = new System.Windows.Forms.Button();
            this.buttonNewAdoption = new System.Windows.Forms.Button();
            this.buttonSaveData = new System.Windows.Forms.Button();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.listBoxAdoptions = new System.Windows.Forms.ListBox();
            this.listBoxAnimals = new System.Windows.Forms.ListBox();
            this.buttonAdoptionInfo = new System.Windows.Forms.Button();
            this.buttonAnimalInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNewAnimal
            // 
            this.buttonNewAnimal.Location = new System.Drawing.Point(644, 12);
            this.buttonNewAnimal.Name = "buttonNewAnimal";
            this.buttonNewAnimal.Size = new System.Drawing.Size(144, 23);
            this.buttonNewAnimal.TabIndex = 0;
            this.buttonNewAnimal.Text = "New animal";
            this.buttonNewAnimal.UseVisualStyleBackColor = true;
            this.buttonNewAnimal.Click += new System.EventHandler(this.buttonNewAnimal_Click);
            // 
            // buttonNewCustomer
            // 
            this.buttonNewCustomer.Location = new System.Drawing.Point(644, 41);
            this.buttonNewCustomer.Name = "buttonNewCustomer";
            this.buttonNewCustomer.Size = new System.Drawing.Size(144, 23);
            this.buttonNewCustomer.TabIndex = 1;
            this.buttonNewCustomer.Text = "New customer";
            this.buttonNewCustomer.UseVisualStyleBackColor = true;
            this.buttonNewCustomer.Click += new System.EventHandler(this.buttonNewCustomer_Click);
            // 
            // buttonNewAdoption
            // 
            this.buttonNewAdoption.Location = new System.Drawing.Point(644, 70);
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
            this.listBoxAdoptions.FormattingEnabled = true;
            this.listBoxAdoptions.Location = new System.Drawing.Point(12, 41);
            this.listBoxAdoptions.Name = "listBoxAdoptions";
            this.listBoxAdoptions.Size = new System.Drawing.Size(263, 342);
            this.listBoxAdoptions.TabIndex = 3;
            this.listBoxAdoptions.SelectedIndexChanged += new System.EventHandler(this.listBoxAdoptions_SelectedIndexChanged);
            // 
            // listBoxAnimals
            // 
            this.listBoxAnimals.FormattingEnabled = true;
            this.listBoxAnimals.Location = new System.Drawing.Point(281, 41);
            this.listBoxAnimals.Name = "listBoxAnimals";
            this.listBoxAnimals.Size = new System.Drawing.Size(263, 342);
            this.listBoxAnimals.TabIndex = 5;
            this.listBoxAnimals.SelectedIndexChanged += new System.EventHandler(this.listBoxAnimals_SelectedIndexChanged);
            // 
            // buttonAdoptionInfo
            // 
            this.buttonAdoptionInfo.Location = new System.Drawing.Point(200, 389);
            this.buttonAdoptionInfo.Name = "buttonAdoptionInfo";
            this.buttonAdoptionInfo.Size = new System.Drawing.Size(75, 23);
            this.buttonAdoptionInfo.TabIndex = 4;
            this.buttonAdoptionInfo.Text = "View info";
            this.buttonAdoptionInfo.UseVisualStyleBackColor = true;
            this.buttonAdoptionInfo.Click += new System.EventHandler(this.buttonAdoptionInfo_Click);
            // 
            // buttonAnimalInfo
            // 
            this.buttonAnimalInfo.Location = new System.Drawing.Point(469, 389);
            this.buttonAnimalInfo.Name = "buttonAnimalInfo";
            this.buttonAnimalInfo.Size = new System.Drawing.Size(75, 23);
            this.buttonAnimalInfo.TabIndex = 6;
            this.buttonAnimalInfo.Text = "View info";
            this.buttonAnimalInfo.UseVisualStyleBackColor = true;
            this.buttonAnimalInfo.Click += new System.EventHandler(this.buttonAnimalInfo_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAnimalInfo);
            this.Controls.Add(this.buttonAdoptionInfo);
            this.Controls.Add(this.listBoxAnimals);
            this.Controls.Add(this.listBoxAdoptions);
            this.Controls.Add(this.buttonLoadData);
            this.Controls.Add(this.buttonSaveData);
            this.Controls.Add(this.buttonNewAdoption);
            this.Controls.Add(this.buttonNewCustomer);
            this.Controls.Add(this.buttonNewAnimal);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

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
    }
}

