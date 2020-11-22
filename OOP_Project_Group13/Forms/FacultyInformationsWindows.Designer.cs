namespace OOP_Project_Group13.Forms
{
    partial class FacultyInformationsWindows
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
            this.teacherPicture = new System.Windows.Forms.PictureBox();
            this.TeacherName = new System.Windows.Forms.Label();
            this.teacherID = new System.Windows.Forms.Label();
            this.TeacherMail = new System.Windows.Forms.Label();
            this.TeacherPhone = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.panelTT = new System.Windows.Forms.Panel();
            this.ClassesBtn = new System.Windows.Forms.Button();
            this.AttendanceBtn = new System.Windows.Forms.Button();
            this.classesPanel = new System.Windows.Forms.Panel();
            this.ttBtn = new System.Windows.Forms.Button();
            this.ModifyBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teacherPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // teacherPicture
            // 
            this.teacherPicture.Location = new System.Drawing.Point(26, 26);
            this.teacherPicture.Name = "teacherPicture";
            this.teacherPicture.Size = new System.Drawing.Size(200, 265);
            this.teacherPicture.TabIndex = 0;
            this.teacherPicture.TabStop = false;
            // 
            // TeacherName
            // 
            this.TeacherName.AutoSize = true;
            this.TeacherName.Location = new System.Drawing.Point(246, 26);
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.Size = new System.Drawing.Size(153, 25);
            this.TeacherName.TabIndex = 1;
            this.TeacherName.Text = "Teacher Name";
            // 
            // teacherID
            // 
            this.teacherID.AutoSize = true;
            this.teacherID.Location = new System.Drawing.Point(246, 70);
            this.teacherID.Name = "teacherID";
            this.teacherID.Size = new System.Drawing.Size(117, 25);
            this.teacherID.TabIndex = 2;
            this.teacherID.Text = "Teacher ID";
            // 
            // TeacherMail
            // 
            this.TeacherMail.AutoSize = true;
            this.TeacherMail.Location = new System.Drawing.Point(246, 118);
            this.TeacherMail.Name = "TeacherMail";
            this.TeacherMail.Size = new System.Drawing.Size(136, 25);
            this.TeacherMail.TabIndex = 3;
            this.TeacherMail.Text = "Teacher mail";
            // 
            // TeacherPhone
            // 
            this.TeacherPhone.AutoSize = true;
            this.TeacherPhone.Location = new System.Drawing.Point(246, 168);
            this.TeacherPhone.Name = "TeacherPhone";
            this.TeacherPhone.Size = new System.Drawing.Size(157, 25);
            this.TeacherPhone.TabIndex = 4;
            this.TeacherPhone.Text = "Teacher phone";
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(200, 1014);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(119, 39);
            this.BackBtn.TabIndex = 5;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(26, 1014);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(157, 39);
            this.DeleteBtn.TabIndex = 6;
            this.DeleteBtn.Text = "Delete User";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // panelTT
            // 
            this.panelTT.AutoSize = true;
            this.panelTT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelTT.Location = new System.Drawing.Point(26, 360);
            this.panelTT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTT.Name = "panelTT";
            this.panelTT.Size = new System.Drawing.Size(1668, 646);
            this.panelTT.TabIndex = 7;
            // 
            // ClassesBtn
            // 
            this.ClassesBtn.Location = new System.Drawing.Point(189, 322);
            this.ClassesBtn.Name = "ClassesBtn";
            this.ClassesBtn.Size = new System.Drawing.Size(157, 39);
            this.ClassesBtn.TabIndex = 9;
            this.ClassesBtn.Text = "Classes";
            this.ClassesBtn.UseVisualStyleBackColor = true;
            this.ClassesBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // AttendanceBtn
            // 
            this.AttendanceBtn.Location = new System.Drawing.Point(352, 322);
            this.AttendanceBtn.Name = "AttendanceBtn";
            this.AttendanceBtn.Size = new System.Drawing.Size(157, 39);
            this.AttendanceBtn.TabIndex = 10;
            this.AttendanceBtn.Text = "Attendance";
            this.AttendanceBtn.UseVisualStyleBackColor = true;
            this.AttendanceBtn.Click += new System.EventHandler(this.AttendanceBtn_Click);
            // 
            // classesPanel
            // 
            this.classesPanel.AutoSize = true;
            this.classesPanel.Enabled = false;
            this.classesPanel.Location = new System.Drawing.Point(26, 360);
            this.classesPanel.Name = "classesPanel";
            this.classesPanel.Size = new System.Drawing.Size(1665, 617);
            this.classesPanel.TabIndex = 11;
            // 
            // ttBtn
            // 
            this.ttBtn.Location = new System.Drawing.Point(26, 322);
            this.ttBtn.Name = "ttBtn";
            this.ttBtn.Size = new System.Drawing.Size(157, 39);
            this.ttBtn.TabIndex = 12;
            this.ttBtn.Text = "Timetable";
            this.ttBtn.UseVisualStyleBackColor = true;
            this.ttBtn.Click += new System.EventHandler(this.ttBtn_Click);
            // 
            // ModifyBtn
            // 
            this.ModifyBtn.Location = new System.Drawing.Point(246, 217);
            this.ModifyBtn.Name = "ModifyBtn";
            this.ModifyBtn.Size = new System.Drawing.Size(157, 39);
            this.ModifyBtn.TabIndex = 13;
            this.ModifyBtn.Text = "Modify profile";
            this.ModifyBtn.UseVisualStyleBackColor = true;
            this.ModifyBtn.Click += new System.EventHandler(this.ModifyBtn_Click);
            // 
            // FacultyInformationsWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1707, 1065);
            this.Controls.Add(this.ModifyBtn);
            this.Controls.Add(this.ttBtn);
            this.Controls.Add(this.classesPanel);
            this.Controls.Add(this.AttendanceBtn);
            this.Controls.Add(this.ClassesBtn);
            this.Controls.Add(this.panelTT);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.TeacherPhone);
            this.Controls.Add(this.TeacherMail);
            this.Controls.Add(this.teacherID);
            this.Controls.Add(this.TeacherName);
            this.Controls.Add(this.teacherPicture);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FacultyInformationsWindows";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faculty Informations";
            this.Load += new System.EventHandler(this.FacultyInformationsWindows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teacherPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox teacherPicture;
        private System.Windows.Forms.Label TeacherName;
        private System.Windows.Forms.Label teacherID;
        private System.Windows.Forms.Label TeacherMail;
        private System.Windows.Forms.Label TeacherPhone;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Panel panelTT;
        private System.Windows.Forms.Button ClassesBtn;
        private System.Windows.Forms.Button AttendanceBtn;
        private System.Windows.Forms.Panel classesPanel;
        private System.Windows.Forms.Button ttBtn;
        private System.Windows.Forms.Button ModifyBtn;
    }
}