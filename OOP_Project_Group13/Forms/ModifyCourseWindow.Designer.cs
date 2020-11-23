namespace OOP_Project_Group13.Forms
{
    partial class ModifyCourseWindow
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
            this.subjectLbl = new System.Windows.Forms.Label();
            this.teacherLbl = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.TeacherList = new System.Windows.Forms.ComboBox();
            this.TimeList = new System.Windows.Forms.ComboBox();
            this.ApplyBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.DayList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // subjectLbl
            // 
            this.subjectLbl.AutoSize = true;
            this.subjectLbl.Location = new System.Drawing.Point(41, 50);
            this.subjectLbl.Name = "subjectLbl";
            this.subjectLbl.Size = new System.Drawing.Size(102, 25);
            this.subjectLbl.TabIndex = 0;
            this.subjectLbl.Text = "Subject : ";
            // 
            // teacherLbl
            // 
            this.teacherLbl.AutoSize = true;
            this.teacherLbl.Location = new System.Drawing.Point(41, 110);
            this.teacherLbl.Name = "teacherLbl";
            this.teacherLbl.Size = new System.Drawing.Size(109, 25);
            this.teacherLbl.TabIndex = 1;
            this.teacherLbl.Text = "Teacher : ";
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Location = new System.Drawing.Point(41, 250);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(77, 25);
            this.timeLbl.TabIndex = 2;
            this.timeLbl.Text = "Time : ";
            // 
            // TeacherList
            // 
            this.TeacherList.FormattingEnabled = true;
            this.TeacherList.Location = new System.Drawing.Point(156, 102);
            this.TeacherList.Name = "TeacherList";
            this.TeacherList.Size = new System.Drawing.Size(338, 33);
            this.TeacherList.TabIndex = 4;
            // 
            // TimeList
            // 
            this.TimeList.FormattingEnabled = true;
            this.TimeList.Items.AddRange(new object[] {
            "8 : 00 am - 11 : 00 am",
            "1 : 00 pm - 3 : 55 pm",
            "4 : 00 pm - 7 : 00 pm"});
            this.TimeList.Location = new System.Drawing.Point(156, 250);
            this.TimeList.Name = "TimeList";
            this.TimeList.Size = new System.Drawing.Size(338, 33);
            this.TimeList.TabIndex = 5;
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.Location = new System.Drawing.Point(46, 377);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(122, 42);
            this.ApplyBtn.TabIndex = 7;
            this.ApplyBtn.Text = "Apply";
            this.ApplyBtn.UseVisualStyleBackColor = true;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(372, 377);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(122, 42);
            this.BackBtn.TabIndex = 8;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(46, 310);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(180, 42);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Delete Course";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // DayList
            // 
            this.DayList.FormattingEnabled = true;
            this.DayList.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.DayList.Location = new System.Drawing.Point(156, 177);
            this.DayList.Name = "DayList";
            this.DayList.Size = new System.Drawing.Size(338, 33);
            this.DayList.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Day :";
            // 
            // ModifyCourseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 431);
            this.Controls.Add(this.DayList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ApplyBtn);
            this.Controls.Add(this.TimeList);
            this.Controls.Add(this.TeacherList);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.teacherLbl);
            this.Controls.Add(this.subjectLbl);
            this.Name = "ModifyCourseWindow";
            this.Text = "Modify Course";
            this.Load += new System.EventHandler(this.ModifyCourseWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label subjectLbl;
        public System.Windows.Forms.Label teacherLbl;
        public System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.ComboBox TeacherList;
        private System.Windows.Forms.ComboBox TimeList;
        private System.Windows.Forms.Button ApplyBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ComboBox DayList;
        public System.Windows.Forms.Label label1;
    }
}