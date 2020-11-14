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
            this.typeLbl = new System.Windows.Forms.Label();
            this.TeacherList = new System.Windows.Forms.ComboBox();
            this.TimeList = new System.Windows.Forms.ComboBox();
            this.TypeList = new System.Windows.Forms.ComboBox();
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
            this.timeLbl.Location = new System.Drawing.Point(41, 169);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(77, 25);
            this.timeLbl.TabIndex = 2;
            this.timeLbl.Text = "Time : ";
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(41, 231);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(78, 25);
            this.typeLbl.TabIndex = 3;
            this.typeLbl.Text = "Type : ";
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
            this.TimeList.Location = new System.Drawing.Point(156, 169);
            this.TimeList.Name = "TimeList";
            this.TimeList.Size = new System.Drawing.Size(338, 33);
            this.TimeList.TabIndex = 5;
            // 
            // TypeList
            // 
            this.TypeList.FormattingEnabled = true;
            this.TypeList.Items.AddRange(new object[] {
            "Normal",
            "Assignement",
            "Exam"});
            this.TypeList.Location = new System.Drawing.Point(156, 231);
            this.TypeList.Name = "TypeList";
            this.TypeList.Size = new System.Drawing.Size(338, 33);
            this.TypeList.TabIndex = 6;
            // 
            // ModifyCourseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 416);
            this.Controls.Add(this.TypeList);
            this.Controls.Add(this.TimeList);
            this.Controls.Add(this.TeacherList);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.teacherLbl);
            this.Controls.Add(this.subjectLbl);
            this.Name = "ModifyCourseWindow";
            this.Text = "ModifyCourseWindow";
            this.Load += new System.EventHandler(this.ModifyCourseWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label subjectLbl;
        public System.Windows.Forms.Label teacherLbl;
        public System.Windows.Forms.Label timeLbl;
        public System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.ComboBox TeacherList;
        private System.Windows.Forms.ComboBox TimeList;
        private System.Windows.Forms.ComboBox TypeList;
    }
}