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
            this.profileBtn = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentPicture
            // 
            this.StudentPicture.Location = new System.Drawing.Point(17, 17);
            this.StudentPicture.Name = "StudentPicture";
            this.StudentPicture.Size = new System.Drawing.Size(129, 147);
            this.StudentPicture.TabIndex = 0;
            this.StudentPicture.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(149, 17);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(98, 17);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Student Name";
            // 
            // StudentIDLabel
            // 
            this.StudentIDLabel.AutoSize = true;
            this.StudentIDLabel.Location = new System.Drawing.Point(149, 44);
            this.StudentIDLabel.Name = "StudentIDLabel";
            this.StudentIDLabel.Size = new System.Drawing.Size(29, 17);
            this.StudentIDLabel.TabIndex = 3;
            this.StudentIDLabel.Text = "ID :";
            // 
            // BirthDate
            // 
            this.BirthDate.AutoSize = true;
            this.BirthDate.Location = new System.Drawing.Point(149, 68);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(79, 17);
            this.BirthDate.TabIndex = 4;
            this.BirthDate.Text = "Birth Date :";
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Location = new System.Drawing.Point(149, 95);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(64, 17);
            this.AdressLabel.TabIndex = 5;
            this.AdressLabel.Text = "Adress : ";
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.Location = new System.Drawing.Point(149, 123);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(41, 17);
            this.MailLabel.TabIndex = 6;
            this.MailLabel.Text = "Mail :";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(149, 148);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(61, 17);
            this.PhoneLabel.TabIndex = 7;
            this.PhoneLabel.Text = "Phone : ";
            // 
            // buttonGrade
            // 
            this.buttonGrade.Location = new System.Drawing.Point(17, 213);
            this.buttonGrade.Name = "buttonGrade";
            this.buttonGrade.Size = new System.Drawing.Size(75, 24);
            this.buttonGrade.TabIndex = 9;
            this.buttonGrade.Text = "Grades";
            this.buttonGrade.UseVisualStyleBackColor = true;
            this.buttonGrade.Click += new System.EventHandler(this.buttonGrade_Click);
            // 
            // buttonTimeTable
            // 
            this.buttonTimeTable.Location = new System.Drawing.Point(89, 213);
            this.buttonTimeTable.Name = "buttonTimeTable";
            this.buttonTimeTable.Size = new System.Drawing.Size(89, 24);
            this.buttonTimeTable.TabIndex = 10;
            this.buttonTimeTable.Text = "TimeTable";
            this.buttonTimeTable.UseVisualStyleBackColor = true;
            this.buttonTimeTable.Click += new System.EventHandler(this.buttonTimeTable_Click);
            // 
            // generalPanel
            // 
            this.generalPanel.AllowDrop = true;
            this.generalPanel.AutoScroll = true;
            this.generalPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.generalPanel.Location = new System.Drawing.Point(17, 236);
            this.generalPanel.Name = "generalPanel";
            this.generalPanel.Size = new System.Drawing.Size(1241, 424);
            this.generalPanel.TabIndex = 27;
            this.generalPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.generalPanel_Paint);
            // 
            // buttonAttendance
            // 
            this.buttonAttendance.Location = new System.Drawing.Point(177, 213);
            this.buttonAttendance.Name = "buttonAttendance";
            this.buttonAttendance.Size = new System.Drawing.Size(99, 24);
            this.buttonAttendance.TabIndex = 28;
            this.buttonAttendance.Text = "Attendance";
            this.buttonAttendance.UseVisualStyleBackColor = true;
            this.buttonAttendance.Click += new System.EventHandler(this.buttonAttendance_Click);
            // 
            // Fees
            // 
            this.Fees.Location = new System.Drawing.Point(271, 213);
            this.Fees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Fees.Name = "Fees";
            this.Fees.Size = new System.Drawing.Size(89, 24);
            this.Fees.TabIndex = 29;
            this.Fees.Text = "Fees";
            this.Fees.UseVisualStyleBackColor = true;
            this.Fees.Click += new System.EventHandler(this.Fees_Click);
            // 
            // PaymentButton
            // 
            this.PaymentButton.AutoSize = true;
            this.PaymentButton.Location = new System.Drawing.Point(469, 664);
            this.PaymentButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PaymentButton.Name = "PaymentButton";
            this.PaymentButton.Size = new System.Drawing.Size(296, 33);
            this.PaymentButton.TabIndex = 0;
            this.PaymentButton.Text = "Click here to proceed payment";
            this.PaymentButton.UseVisualStyleBackColor = true;
            this.PaymentButton.Click += new System.EventHandler(this.PaymentButton_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.Location = new System.Drawing.Point(19, 170);
            this.profileBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(107, 28);
            this.profileBtn.TabIndex = 30;
            this.profileBtn.Text = "Modify profile";
            this.profileBtn.UseVisualStyleBackColor = true;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(19, 664);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 28);
            this.backButton.TabIndex = 31;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(100, 664);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(75, 28);
            this.RefreshBtn.TabIndex = 32;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(100, 664);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(92, 28);
            this.DeleteBtn.TabIndex = 33;
            this.DeleteBtn.Text = "Delete user";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // StudentInformationsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1269, 675);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.profileBtn);
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
        private System.Windows.Forms.Button profileBtn;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button DeleteBtn;
    }
}