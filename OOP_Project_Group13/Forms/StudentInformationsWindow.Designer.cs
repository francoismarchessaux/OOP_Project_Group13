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
            this.buttonAttendance = new System.Windows.Forms.Button();
            this.Fees = new System.Windows.Forms.Button();
            this.PaymentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentPicture
            // 
            this.StudentPicture.Location = new System.Drawing.Point(13, 14);
            this.StudentPicture.Margin = new System.Windows.Forms.Padding(2);
            this.StudentPicture.Name = "StudentPicture";
            this.StudentPicture.Size = new System.Drawing.Size(97, 119);
            this.StudentPicture.TabIndex = 0;
            this.StudentPicture.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(112, 14);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(75, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Student Name";
            // 
            // StudentIDLabel
            // 
            this.StudentIDLabel.AutoSize = true;
            this.StudentIDLabel.Location = new System.Drawing.Point(112, 36);
            this.StudentIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StudentIDLabel.Name = "StudentIDLabel";
            this.StudentIDLabel.Size = new System.Drawing.Size(24, 13);
            this.StudentIDLabel.TabIndex = 3;
            this.StudentIDLabel.Text = "ID :";
            // 
            // BirthDate
            // 
            this.BirthDate.AutoSize = true;
            this.BirthDate.Location = new System.Drawing.Point(112, 55);
            this.BirthDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(60, 13);
            this.BirthDate.TabIndex = 4;
            this.BirthDate.Text = "Birth Date :";
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Location = new System.Drawing.Point(112, 77);
            this.AdressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(48, 13);
            this.AdressLabel.TabIndex = 5;
            this.AdressLabel.Text = "Adress : ";
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.Location = new System.Drawing.Point(112, 100);
            this.MailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(32, 13);
            this.MailLabel.TabIndex = 6;
            this.MailLabel.Text = "Mail :";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(112, 120);
            this.PhoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(47, 13);
            this.PhoneLabel.TabIndex = 7;
            this.PhoneLabel.Text = "Phone : ";
            // 
            // buttonGrade
            // 
            this.buttonGrade.Location = new System.Drawing.Point(13, 175);
            this.buttonGrade.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGrade.Name = "buttonGrade";
            this.buttonGrade.Size = new System.Drawing.Size(56, 19);
            this.buttonGrade.TabIndex = 9;
            this.buttonGrade.Text = "Grades";
            this.buttonGrade.UseVisualStyleBackColor = true;
            this.buttonGrade.Click += new System.EventHandler(this.buttonGrade_Click);
            // 
            // buttonTimeTable
            // 
            this.buttonTimeTable.Location = new System.Drawing.Point(68, 175);
            this.buttonTimeTable.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTimeTable.Name = "buttonTimeTable";
            this.buttonTimeTable.Size = new System.Drawing.Size(67, 19);
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
            this.generalPanel.Location = new System.Drawing.Point(14, 193);
            this.generalPanel.Margin = new System.Windows.Forms.Padding(2);
            this.generalPanel.Name = "generalPanel";
            this.generalPanel.Size = new System.Drawing.Size(931, 344);
            this.generalPanel.TabIndex = 27;
            this.generalPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.generalPanel_Paint);
            // 
            // buttonAttendance
            // 
            this.buttonAttendance.Location = new System.Drawing.Point(133, 175);
            this.buttonAttendance.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAttendance.Name = "buttonAttendance";
            this.buttonAttendance.Size = new System.Drawing.Size(74, 19);
            this.buttonAttendance.TabIndex = 28;
            this.buttonAttendance.Text = "Attendance";
            this.buttonAttendance.UseVisualStyleBackColor = true;
            this.buttonAttendance.Click += new System.EventHandler(this.buttonAttendance_Click);
            // 
            // Fees
            // 
            this.Fees.Location = new System.Drawing.Point(203, 175);
            this.Fees.Name = "Fees";
            this.Fees.Size = new System.Drawing.Size(67, 19);
            this.Fees.TabIndex = 29;
            this.Fees.Text = "Fees";
            this.Fees.UseVisualStyleBackColor = true;
            this.Fees.Click += new System.EventHandler(this.Fees_Click);
            // 
            // PaymentButton
            // 
            this.PaymentButton.Location = new System.Drawing.Point(357, 542);
            this.PaymentButton.Name = "PaymentButton";
            this.PaymentButton.Size = new System.Drawing.Size(222, 27);
            this.PaymentButton.TabIndex = 0;
            this.PaymentButton.Text = "Click here to proceed payment";
            this.PaymentButton.UseVisualStyleBackColor = true;
            this.PaymentButton.Click += new System.EventHandler(this.PaymentButton_Click);
            // 
            // StudentInformationsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(952, 569);
            this.Controls.Add(this.PaymentButton);
            this.Controls.Add(this.Fees);
            this.Controls.Add(this.buttonAttendance);
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
        private System.Windows.Forms.Button buttonAttendance;
        private System.Windows.Forms.Button Fees;
        private System.Windows.Forms.Button PaymentButton;
    }
}