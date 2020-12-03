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
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.panelTT = new System.Windows.Forms.Panel();
            this.ClassesBtn = new System.Windows.Forms.Button();
            this.classesPanel = new System.Windows.Forms.Panel();
            this.ttBtn = new System.Windows.Forms.Button();
            this.ModifyBtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teacherPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // teacherPicture
            // 
            this.teacherPicture.Location = new System.Drawing.Point(20, 21);
            this.teacherPicture.Margin = new System.Windows.Forms.Padding(2);
            this.teacherPicture.Name = "teacherPicture";
            this.teacherPicture.Size = new System.Drawing.Size(150, 212);
            this.teacherPicture.TabIndex = 0;
            this.teacherPicture.TabStop = false;
            // 
            // TeacherName
            // 
            this.TeacherName.AutoSize = true;
            this.TeacherName.Location = new System.Drawing.Point(184, 21);
            this.TeacherName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.Size = new System.Drawing.Size(113, 20);
            this.TeacherName.TabIndex = 1;
            this.TeacherName.Text = "Teacher Name";
            // 
            // teacherID
            // 
            this.teacherID.AutoSize = true;
            this.teacherID.Location = new System.Drawing.Point(184, 56);
            this.teacherID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.teacherID.Name = "teacherID";
            this.teacherID.Size = new System.Drawing.Size(88, 20);
            this.teacherID.TabIndex = 2;
            this.teacherID.Text = "Teacher ID";
            // 
            // TeacherMail
            // 
            this.TeacherMail.AutoSize = true;
            this.TeacherMail.Location = new System.Drawing.Point(184, 94);
            this.TeacherMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TeacherMail.Name = "TeacherMail";
            this.TeacherMail.Size = new System.Drawing.Size(99, 20);
            this.TeacherMail.TabIndex = 3;
            this.TeacherMail.Text = "Teacher mail";
            // 
            // TeacherPhone
            // 
            this.TeacherPhone.AutoSize = true;
            this.TeacherPhone.Location = new System.Drawing.Point(184, 134);
            this.TeacherPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TeacherPhone.Name = "TeacherPhone";
            this.TeacherPhone.Size = new System.Drawing.Size(116, 20);
            this.TeacherPhone.TabIndex = 4;
            this.TeacherPhone.Text = "Teacher phone";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(20, 811);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(118, 31);
            this.DeleteBtn.TabIndex = 6;
            this.DeleteBtn.Text = "Delete User";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // panelTT
            // 
            this.panelTT.AutoSize = true;
            this.panelTT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelTT.Location = new System.Drawing.Point(20, 288);
            this.panelTT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTT.Name = "panelTT";
            this.panelTT.Size = new System.Drawing.Size(1251, 517);
            this.panelTT.TabIndex = 7;
            // 
            // ClassesBtn
            // 
            this.ClassesBtn.Location = new System.Drawing.Point(142, 258);
            this.ClassesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ClassesBtn.Name = "ClassesBtn";
            this.ClassesBtn.Size = new System.Drawing.Size(118, 31);
            this.ClassesBtn.TabIndex = 9;
            this.ClassesBtn.Text = "Classes";
            this.ClassesBtn.UseVisualStyleBackColor = true;
            this.ClassesBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // classesPanel
            // 
            this.classesPanel.AutoSize = true;
            this.classesPanel.Enabled = false;
            this.classesPanel.Location = new System.Drawing.Point(20, 288);
            this.classesPanel.Margin = new System.Windows.Forms.Padding(2);
            this.classesPanel.Name = "classesPanel";
            this.classesPanel.Size = new System.Drawing.Size(1249, 494);
            this.classesPanel.TabIndex = 11;
            // 
            // ttBtn
            // 
            this.ttBtn.Location = new System.Drawing.Point(20, 258);
            this.ttBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ttBtn.Name = "ttBtn";
            this.ttBtn.Size = new System.Drawing.Size(118, 31);
            this.ttBtn.TabIndex = 12;
            this.ttBtn.Text = "Timetable";
            this.ttBtn.UseVisualStyleBackColor = true;
            this.ttBtn.Click += new System.EventHandler(this.ttBtn_Click);
            // 
            // ModifyBtn
            // 
            this.ModifyBtn.Location = new System.Drawing.Point(182, 202);
            this.ModifyBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyBtn.Name = "ModifyBtn";
            this.ModifyBtn.Size = new System.Drawing.Size(118, 31);
            this.ModifyBtn.TabIndex = 13;
            this.ModifyBtn.Text = "Modify profile";
            this.ModifyBtn.UseVisualStyleBackColor = true;
            this.ModifyBtn.Click += new System.EventHandler(this.ModifyBtn_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(20, 811);
            this.LogOutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(118, 31);
            this.LogOutBtn.TabIndex = 14;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(752, 94);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(144, 28);
            this.comboBoxStudent.TabIndex = 15;
            this.comboBoxStudent.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudent_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(748, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Information student";
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(184, 169);
            this.labelAdress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(119, 20);
            this.labelAdress.TabIndex = 18;
            this.labelAdress.Text = "Teacher adress";
            // 
            // FacultyInformationsWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1280, 840);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxStudent);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.ModifyBtn);
            this.Controls.Add(this.ttBtn);
            this.Controls.Add(this.classesPanel);
            this.Controls.Add(this.ClassesBtn);
            this.Controls.Add(this.panelTT);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.TeacherPhone);
            this.Controls.Add(this.TeacherMail);
            this.Controls.Add(this.teacherID);
            this.Controls.Add(this.TeacherName);
            this.Controls.Add(this.teacherPicture);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Panel panelTT;
        private System.Windows.Forms.Button ClassesBtn;
        private System.Windows.Forms.Panel classesPanel;
        private System.Windows.Forms.Button ttBtn;
        private System.Windows.Forms.Button ModifyBtn;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.ComboBox comboBoxStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAdress;
    }
}