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
            this.generalPanel = new System.Windows.Forms.Panel();
            this.BackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentPicture
            // 
            this.StudentPicture.Location = new System.Drawing.Point(26, 27);
            this.StudentPicture.Name = "StudentPicture";
            this.StudentPicture.Size = new System.Drawing.Size(194, 230);
            this.StudentPicture.TabIndex = 0;
            this.StudentPicture.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(225, 27);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(150, 25);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Student NAme";
            // 
            // StudentIDLabel
            // 
            this.StudentIDLabel.AutoSize = true;
            this.StudentIDLabel.Location = new System.Drawing.Point(225, 69);
            this.StudentIDLabel.Name = "StudentIDLabel";
            this.StudentIDLabel.Size = new System.Drawing.Size(44, 25);
            this.StudentIDLabel.TabIndex = 3;
            this.StudentIDLabel.Text = "ID :";
            // 
            // BirthDate
            // 
            this.BirthDate.AutoSize = true;
            this.BirthDate.Location = new System.Drawing.Point(225, 106);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(119, 25);
            this.BirthDate.TabIndex = 4;
            this.BirthDate.Text = "Birth Date :";
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Location = new System.Drawing.Point(225, 148);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(97, 25);
            this.AdressLabel.TabIndex = 5;
            this.AdressLabel.Text = "Adress : ";
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.Location = new System.Drawing.Point(225, 192);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(64, 25);
            this.MailLabel.TabIndex = 6;
            this.MailLabel.Text = "Mail :";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(225, 231);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(92, 25);
            this.PhoneLabel.TabIndex = 7;
            this.PhoneLabel.Text = "Phone : ";
            // 
            // generalPanel
            // 
            this.generalPanel.AutoScroll = true;
            this.generalPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.generalPanel.Location = new System.Drawing.Point(50, 394);
            this.generalPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.generalPanel.Name = "generalPanel";
            this.generalPanel.Size = new System.Drawing.Size(1506, 491);
            this.generalPanel.TabIndex = 8;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(1449, 916);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(107, 47);
            this.BackBtn.TabIndex = 9;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // StudentInformationsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1605, 1092);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.generalPanel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.MailLabel);
            this.Controls.Add(this.AdressLabel);
            this.Controls.Add(this.BirthDate);
            this.Controls.Add(this.StudentIDLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.StudentPicture);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Panel generalPanel;
        private System.Windows.Forms.Button BackBtn;
    }
}