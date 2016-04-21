namespace AnimalShelter
{
    partial class AdministrationForm
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
            this.cbAnimalType = new System.Windows.Forms.ComboBox();
            this.createAnimalButton = new System.Windows.Forms.Button();
            this.showInfoButton = new System.Windows.Forms.Button();
            this.tbchipRegistrationNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBadHabits = new System.Windows.Forms.TextBox();
            this.lbBadHabitWalkDate = new System.Windows.Forms.Label();
            this.cbLastwalkYear = new System.Windows.Forms.ComboBox();
            this.cbLastwalkMonth = new System.Windows.Forms.ComboBox();
            this.cbLastwalkDay = new System.Windows.Forms.ComboBox();
            this.lbUnReserved = new System.Windows.Forms.ListBox();
            this.lbReserved = new System.Windows.Forms.ListBox();
            this.btnReserved = new System.Windows.Forms.Button();
            this.btnUnReserved = new System.Windows.Forms.Button();
            this.cbDeleteShowAnimal = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnImportExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbAnimalType
            // 
            this.cbAnimalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnimalType.FormattingEnabled = true;
            this.cbAnimalType.Items.AddRange(new object[] {
            "Cat",
            "Dog"});
            this.cbAnimalType.Location = new System.Drawing.Point(12, 12);
            this.cbAnimalType.Name = "cbAnimalType";
            this.cbAnimalType.Size = new System.Drawing.Size(131, 21);
            this.cbAnimalType.TabIndex = 0;
            this.cbAnimalType.SelectedIndexChanged += new System.EventHandler(this.cbAnimalType_SelectedIndexChanged);
            // 
            // createAnimalButton
            // 
            this.createAnimalButton.Location = new System.Drawing.Point(14, 211);
            this.createAnimalButton.Name = "createAnimalButton";
            this.createAnimalButton.Size = new System.Drawing.Size(130, 23);
            this.createAnimalButton.TabIndex = 1;
            this.createAnimalButton.Text = "Create";
            this.createAnimalButton.UseVisualStyleBackColor = true;
            this.createAnimalButton.Click += new System.EventHandler(this.createAnimalButton_Click);
            // 
            // showInfoButton
            // 
            this.showInfoButton.Location = new System.Drawing.Point(174, 285);
            this.showInfoButton.Name = "showInfoButton";
            this.showInfoButton.Size = new System.Drawing.Size(133, 23);
            this.showInfoButton.TabIndex = 2;
            this.showInfoButton.Text = "Show";
            this.showInfoButton.UseVisualStyleBackColor = true;
            this.showInfoButton.Click += new System.EventHandler(this.showInfoButton_Click);
            // 
            // tbchipRegistrationNumber
            // 
            this.tbchipRegistrationNumber.Location = new System.Drawing.Point(13, 51);
            this.tbchipRegistrationNumber.Name = "tbchipRegistrationNumber";
            this.tbchipRegistrationNumber.Size = new System.Drawing.Size(130, 20);
            this.tbchipRegistrationNumber.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chip RegistrationNumber";
            // 
            // cbDay
            // 
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Location = new System.Drawing.Point(12, 86);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(37, 21);
            this.cbDay.TabIndex = 5;
            // 
            // cbMonth
            // 
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(55, 86);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(37, 21);
            this.cbMonth.TabIndex = 6;
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(98, 86);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(45, 21);
            this.cbYear.TabIndex = 7;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "animal Type";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 122);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(131, 20);
            this.tbName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date Of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name";
            // 
            // tbBadHabits
            // 
            this.tbBadHabits.Location = new System.Drawing.Point(13, 158);
            this.tbBadHabits.Name = "tbBadHabits";
            this.tbBadHabits.Size = new System.Drawing.Size(130, 20);
            this.tbBadHabits.TabIndex = 12;
            // 
            // lbBadHabitWalkDate
            // 
            this.lbBadHabitWalkDate.AutoSize = true;
            this.lbBadHabitWalkDate.Location = new System.Drawing.Point(171, 165);
            this.lbBadHabitWalkDate.Name = "lbBadHabitWalkDate";
            this.lbBadHabitWalkDate.Size = new System.Drawing.Size(136, 13);
            this.lbBadHabitWalkDate.TabIndex = 13;
            this.lbBadHabitWalkDate.Text = "Bad Habit/ Last Walk Date";
            // 
            // cbLastwalkYear
            // 
            this.cbLastwalkYear.FormattingEnabled = true;
            this.cbLastwalkYear.Location = new System.Drawing.Point(99, 158);
            this.cbLastwalkYear.Name = "cbLastwalkYear";
            this.cbLastwalkYear.Size = new System.Drawing.Size(45, 21);
            this.cbLastwalkYear.TabIndex = 16;
            this.cbLastwalkYear.SelectedIndexChanged += new System.EventHandler(this.cbLastwalkYear_SelectedIndexChanged);
            // 
            // cbLastwalkMonth
            // 
            this.cbLastwalkMonth.FormattingEnabled = true;
            this.cbLastwalkMonth.Location = new System.Drawing.Point(56, 158);
            this.cbLastwalkMonth.Name = "cbLastwalkMonth";
            this.cbLastwalkMonth.Size = new System.Drawing.Size(37, 21);
            this.cbLastwalkMonth.TabIndex = 15;
            // 
            // cbLastwalkDay
            // 
            this.cbLastwalkDay.FormattingEnabled = true;
            this.cbLastwalkDay.Location = new System.Drawing.Point(13, 158);
            this.cbLastwalkDay.Name = "cbLastwalkDay";
            this.cbLastwalkDay.Size = new System.Drawing.Size(37, 21);
            this.cbLastwalkDay.TabIndex = 14;
            // 
            // lbUnReserved
            // 
            this.lbUnReserved.FormattingEnabled = true;
            this.lbUnReserved.Location = new System.Drawing.Point(323, 12);
            this.lbUnReserved.Name = "lbUnReserved";
            this.lbUnReserved.Size = new System.Drawing.Size(321, 121);
            this.lbUnReserved.TabIndex = 17;
            // 
            // lbReserved
            // 
            this.lbReserved.FormattingEnabled = true;
            this.lbReserved.Location = new System.Drawing.Point(323, 187);
            this.lbReserved.Name = "lbReserved";
            this.lbReserved.Size = new System.Drawing.Size(321, 121);
            this.lbReserved.TabIndex = 18;
            this.lbReserved.SelectedIndexChanged += new System.EventHandler(this.lbReserved_SelectedIndexChanged);
            // 
            // btnReserved
            // 
            this.btnReserved.Location = new System.Drawing.Point(369, 151);
            this.btnReserved.Name = "btnReserved";
            this.btnReserved.Size = new System.Drawing.Size(89, 23);
            this.btnReserved.TabIndex = 19;
            this.btnReserved.Text = "Reserved";
            this.btnReserved.UseVisualStyleBackColor = true;
            this.btnReserved.Click += new System.EventHandler(this.btnReserved_Click);
            // 
            // btnUnReserved
            // 
            this.btnUnReserved.Location = new System.Drawing.Point(502, 151);
            this.btnUnReserved.Name = "btnUnReserved";
            this.btnUnReserved.Size = new System.Drawing.Size(89, 23);
            this.btnUnReserved.TabIndex = 20;
            this.btnUnReserved.Text = "UnReserved";
            this.btnUnReserved.UseVisualStyleBackColor = true;
            this.btnUnReserved.Click += new System.EventHandler(this.btnUnReserved_Click);
            // 
            // cbDeleteShowAnimal
            // 
            this.cbDeleteShowAnimal.DisplayMember = "Name";
            this.cbDeleteShowAnimal.FormattingEnabled = true;
            this.cbDeleteShowAnimal.Location = new System.Drawing.Point(14, 256);
            this.cbDeleteShowAnimal.Name = "cbDeleteShowAnimal";
            this.cbDeleteShowAnimal.Size = new System.Drawing.Size(129, 21);
            this.cbDeleteShowAnimal.TabIndex = 21;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(174, 256);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(174, 314);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(133, 23);
            this.btnBuy.TabIndex = 23;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnImportExport
            // 
            this.btnImportExport.Location = new System.Drawing.Point(14, 306);
            this.btnImportExport.Name = "btnImportExport";
            this.btnImportExport.Size = new System.Drawing.Size(108, 23);
            this.btnImportExport.TabIndex = 24;
            this.btnImportExport.Text = "Import/Export";
            this.btnImportExport.UseVisualStyleBackColor = true;
            this.btnImportExport.Click += new System.EventHandler(this.btnImportExport_Click);
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 341);
            this.Controls.Add(this.btnImportExport);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbDeleteShowAnimal);
            this.Controls.Add(this.btnUnReserved);
            this.Controls.Add(this.btnReserved);
            this.Controls.Add(this.lbReserved);
            this.Controls.Add(this.lbUnReserved);
            this.Controls.Add(this.cbLastwalkYear);
            this.Controls.Add(this.cbLastwalkMonth);
            this.Controls.Add(this.cbLastwalkDay);
            this.Controls.Add(this.lbBadHabitWalkDate);
            this.Controls.Add(this.tbBadHabits);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.cbDay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbchipRegistrationNumber);
            this.Controls.Add(this.showInfoButton);
            this.Controls.Add(this.createAnimalButton);
            this.Controls.Add(this.cbAnimalType);
            this.Name = "AdministrationForm";
            this.Text = "l";
            this.Load += new System.EventHandler(this.AdministrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAnimalType;
        private System.Windows.Forms.Button createAnimalButton;
        private System.Windows.Forms.Button showInfoButton;
        private System.Windows.Forms.TextBox tbchipRegistrationNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBadHabits;
        private System.Windows.Forms.Label lbBadHabitWalkDate;
        private System.Windows.Forms.ComboBox cbLastwalkYear;
        private System.Windows.Forms.ComboBox cbLastwalkMonth;
        private System.Windows.Forms.ComboBox cbLastwalkDay;
        private System.Windows.Forms.Button btnReserved;
        private System.Windows.Forms.Button btnUnReserved;
        private System.Windows.Forms.ComboBox cbDeleteShowAnimal;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnImportExport;
        public System.Windows.Forms.ListBox lbUnReserved;
        public System.Windows.Forms.ListBox lbReserved;
    }
}

