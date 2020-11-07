namespace OOP_Project_Group13
{
    partial class StudentInformationsWindow
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
            this.StudentPicture = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.StudentIDLabel = new System.Windows.Forms.Label();
            this.BirthDate = new System.Windows.Forms.Label();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.MailLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.buttonGrade = new System.Windows.Forms.Button();
            this.buttonTimeTable = new System.Windows.Forms.Button();
            this.generalPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.StudentPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentPicture
            // 
            this.StudentPicture.Location = new System.Drawing.Point(17, 17);
            this.StudentPicture.Margin = new System.Windows.Forms.Padding(2);
            this.StudentPicture.Name = "StudentPicture";
            this.StudentPicture.Size = new System.Drawing.Size(129, 147);
            this.StudentPicture.TabIndex = 0;
            this.StudentPicture.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(150, 17);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(98, 17);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Student Name";
            // 
            // StudentIDLabel
            // 
            this.StudentIDLabel.AutoSize = true;
            this.StudentIDLabel.Location = new System.Drawing.Point(150, 44);
            this.StudentIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StudentIDLabel.Name = "StudentIDLabel";
            this.StudentIDLabel.Size = new System.Drawing.Size(29, 17);
            this.StudentIDLabel.TabIndex = 3;
            this.StudentIDLabel.Text = "ID :";
            // 
            // BirthDate
            // 
            this.BirthDate.AutoSize = true;
            this.BirthDate.Location = new System.Drawing.Point(150, 68);
            this.BirthDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(79, 17);
            this.BirthDate.TabIndex = 4;
            this.BirthDate.Text = "Birth Date :";
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Location = new System.Drawing.Point(150, 95);
            this.AdressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(64, 17);
            this.AdressLabel.TabIndex = 5;
            this.AdressLabel.Text = "Adress : ";
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.Location = new System.Drawing.Point(150, 123);
            this.MailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(41, 17);
            this.MailLabel.TabIndex = 6;
            this.MailLabel.Text = "Mail :";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(150, 148);
            this.PhoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(61, 17);
            this.PhoneLabel.TabIndex = 7;
            this.PhoneLabel.Text = "Phone : ";
            // 
            // buttonGrade
            // 
            this.buttonGrade.Location = new System.Drawing.Point(17, 215);
            this.buttonGrade.Name = "buttonGrade";
            this.buttonGrade.Size = new System.Drawing.Size(75, 23);
            this.buttonGrade.TabIndex = 9;
            this.buttonGrade.Text = "Grades";
            this.buttonGrade.UseVisualStyleBackColor = true;
            this.buttonGrade.Click += new System.EventHandler(this.buttonGrade_Click);
            // 
            // buttonTimeTable
            // 
            this.buttonTimeTable.Location = new System.Drawing.Point(90, 215);
            this.buttonTimeTable.Name = "buttonTimeTable";
            this.buttonTimeTable.Size = new System.Drawing.Size(89, 23);
            this.buttonTimeTable.TabIndex = 10;
            this.buttonTimeTable.Text = "TimeTable";
            this.buttonTimeTable.UseVisualStyleBackColor = true;
            this.buttonTimeTable.Click += new System.EventHandler(this.buttonTimeTable_Click);
            // 
            // generalPanel
            // 
            this.generalPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generalPanel.AutoScroll = true;
            this.generalPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.generalPanel.Location = new System.Drawing.Point(19, 237);
            this.generalPanel.Name = "generalPanel";
            this.generalPanel.Size = new System.Drawing.Size(1241, 426);
            this.generalPanel.TabIndex = 27;
            // 
            // StudentInformationsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1270, 690);
            this.Controls.Add(this.generalPanel);
            this.Controls.Add(this.buttonTimeTable);
            this.Controls.Add(this.buttonGrade);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.MailLabel);
            this.Controls.Add(this.AdressLabel);
            this.Controls.Add(this.BirthDate);
            this.Controls.Add(this.StudentIDLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.StudentPicture);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "StudentInformationsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Informations";
            this.Load += new System.EventHandler(this.StudentInformationsWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox StudentPicture;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label StudentIDLabel;
        private System.Windows.Forms.Label BirthDate;
        private System.Windows.Forms.Label AdressLabel;
        private System.Windows.Forms.Label MailLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Button buttonGrade;
        private System.Windows.Forms.Button buttonTimeTable;
        private System.Windows.Forms.Panel generalPanel;
    }
}