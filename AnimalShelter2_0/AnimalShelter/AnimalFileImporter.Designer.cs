namespace AnimalShelter
{
    partial class AnimalFileImporter
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
            this.lbCats = new System.Windows.Forms.ListBox();
            this.lbDogs = new System.Windows.Forms.ListBox();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCats
            // 
            this.lbCats.FormattingEnabled = true;
            this.lbCats.Location = new System.Drawing.Point(12, 12);
            this.lbCats.Name = "lbCats";
            this.lbCats.Size = new System.Drawing.Size(223, 173);
            this.lbCats.TabIndex = 0;
            // 
            // lbDogs
            // 
            this.lbDogs.FormattingEnabled = true;
            this.lbDogs.Location = new System.Drawing.Point(265, 12);
            this.lbDogs.Name = "lbDogs";
            this.lbDogs.Size = new System.Drawing.Size(223, 173);
            this.lbDogs.TabIndex = 1;
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(12, 216);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(100, 20);
            this.tbPath.TabIndex = 2;
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(118, 216);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(129, 23);
            this.btnPath.TabIndex = 3;
            this.btnPath.Text = "Select Directory";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 260);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(94, 260);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(175, 260);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click_1);
            // 
            // AnimalFileImporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 294);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.lbDogs);
            this.Controls.Add(this.lbCats);
            this.Name = "AnimalFileImporter";
            this.Text = "AnimalFileImporter";
            this.Load += new System.EventHandler(this.AnimalFileImporter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbDogs;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        public System.Windows.Forms.ListBox lbCats;
        private System.Windows.Forms.Button btnExport;
    }
}