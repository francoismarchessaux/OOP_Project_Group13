namespace OOP_Project_Group13.Forms
{
    partial class ManageClassWindow
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
            this.classNameLabel = new System.Windows.Forms.Label();
            this.CreateCourseBtn = new System.Windows.Forms.Button();
            this.ModifyCourseBtn = new System.Windows.Forms.Button();
            this.DeleteCourseBtn = new System.Windows.Forms.Button();
            this.StudentsBtn = new System.Windows.Forms.Button();
            this.TimetableBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // classNameLabel
            // 
            this.classNameLabel.AutoSize = true;
            this.classNameLabel.Location = new System.Drawing.Point(39, 45);
            this.classNameLabel.Name = "classNameLabel";
            this.classNameLabel.Size = new System.Drawing.Size(128, 25);
            this.classNameLabel.TabIndex = 0;
            this.classNameLabel.Text = "Class Name";
            // 
            // CreateCourseBtn
            // 
            this.CreateCourseBtn.Location = new System.Drawing.Point(44, 101);
            this.CreateCourseBtn.Name = "CreateCourseBtn";
            this.CreateCourseBtn.Size = new System.Drawing.Size(165, 43);
            this.CreateCourseBtn.TabIndex = 1;
            this.CreateCourseBtn.Text = "Create Course";
            this.CreateCourseBtn.UseVisualStyleBackColor = true;
            this.CreateCourseBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModifyCourseBtn
            // 
            this.ModifyCourseBtn.Location = new System.Drawing.Point(242, 101);
            this.ModifyCourseBtn.Name = "ModifyCourseBtn";
            this.ModifyCourseBtn.Size = new System.Drawing.Size(165, 43);
            this.ModifyCourseBtn.TabIndex = 2;
            this.ModifyCourseBtn.Text = "Modify Course";
            this.ModifyCourseBtn.UseVisualStyleBackColor = true;
            this.ModifyCourseBtn.Click += new System.EventHandler(this.ModifyCourseBtn_Click);
            // 
            // DeleteCourseBtn
            // 
            this.DeleteCourseBtn.Location = new System.Drawing.Point(442, 101);
            this.DeleteCourseBtn.Name = "DeleteCourseBtn";
            this.DeleteCourseBtn.Size = new System.Drawing.Size(165, 43);
            this.DeleteCourseBtn.TabIndex = 3;
            this.DeleteCourseBtn.Text = "Delete Course";
            this.DeleteCourseBtn.UseVisualStyleBackColor = true;
            // 
            // StudentsBtn
            // 
            this.StudentsBtn.Location = new System.Drawing.Point(44, 196);
            this.StudentsBtn.Name = "StudentsBtn";
            this.StudentsBtn.Size = new System.Drawing.Size(165, 43);
            this.StudentsBtn.TabIndex = 4;
            this.StudentsBtn.Text = "Students";
            this.StudentsBtn.UseVisualStyleBackColor = true;
            // 
            // TimetableBtn
            // 
            this.TimetableBtn.Location = new System.Drawing.Point(206, 196);
            this.TimetableBtn.Name = "TimetableBtn";
            this.TimetableBtn.Size = new System.Drawing.Size(165, 43);
            this.TimetableBtn.TabIndex = 5;
            this.TimetableBtn.Text = "Timetable";
            this.TimetableBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(44, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1243, 630);
            this.panel1.TabIndex = 6;
            // 
            // ManageClassWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 887);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TimetableBtn);
            this.Controls.Add(this.StudentsBtn);
            this.Controls.Add(this.DeleteCourseBtn);
            this.Controls.Add(this.ModifyCourseBtn);
            this.Controls.Add(this.CreateCourseBtn);
            this.Controls.Add(this.classNameLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageClassWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Class";
            this.Load += new System.EventHandler(this.ManageClassWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label classNameLabel;
        private System.Windows.Forms.Button CreateCourseBtn;
        private System.Windows.Forms.Button ModifyCourseBtn;
        private System.Windows.Forms.Button DeleteCourseBtn;
        private System.Windows.Forms.Button StudentsBtn;
        private System.Windows.Forms.Button TimetableBtn;
        private System.Windows.Forms.Panel panel1;
    }
}