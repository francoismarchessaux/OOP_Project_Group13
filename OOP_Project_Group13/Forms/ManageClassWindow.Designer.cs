namespace OOP_Project_Group13.Forms
{
    partial class CreateExamButton
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
            this.TimeTablePnl = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // classNameLabel
            // 
            this.classNameLabel.AutoSize = true;
            this.classNameLabel.Location = new System.Drawing.Point(26, 29);
            this.classNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.classNameLabel.Name = "classNameLabel";
            this.classNameLabel.Size = new System.Drawing.Size(83, 17);
            this.classNameLabel.TabIndex = 0;
            this.classNameLabel.Text = "Class Name";
            // 
            // CreateCourseBtn
            // 
            this.CreateCourseBtn.Location = new System.Drawing.Point(29, 65);
            this.CreateCourseBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CreateCourseBtn.Name = "CreateCourseBtn";
            this.CreateCourseBtn.Size = new System.Drawing.Size(110, 27);
            this.CreateCourseBtn.TabIndex = 1;
            this.CreateCourseBtn.Text = "Create Course";
            this.CreateCourseBtn.UseVisualStyleBackColor = true;
            this.CreateCourseBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModifyCourseBtn
            // 
            this.ModifyCourseBtn.Location = new System.Drawing.Point(162, 65);
            this.ModifyCourseBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyCourseBtn.Name = "ModifyCourseBtn";
            this.ModifyCourseBtn.Size = new System.Drawing.Size(110, 27);
            this.ModifyCourseBtn.TabIndex = 2;
            this.ModifyCourseBtn.Text = "Modify Course";
            this.ModifyCourseBtn.UseVisualStyleBackColor = true;
            this.ModifyCourseBtn.Click += new System.EventHandler(this.ModifyCourseBtn_Click);
            // 
            // DeleteCourseBtn
            // 
            this.DeleteCourseBtn.Location = new System.Drawing.Point(295, 65);
            this.DeleteCourseBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteCourseBtn.Name = "DeleteCourseBtn";
            this.DeleteCourseBtn.Size = new System.Drawing.Size(110, 27);
            this.DeleteCourseBtn.TabIndex = 3;
            this.DeleteCourseBtn.Text = "Delete Course";
            this.DeleteCourseBtn.UseVisualStyleBackColor = true;
            // 
            // StudentsBtn
            // 
            this.StudentsBtn.Location = new System.Drawing.Point(29, 126);
            this.StudentsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.StudentsBtn.Name = "StudentsBtn";
            this.StudentsBtn.Size = new System.Drawing.Size(110, 27);
            this.StudentsBtn.TabIndex = 4;
            this.StudentsBtn.Text = "Students";
            this.StudentsBtn.UseVisualStyleBackColor = true;
            this.StudentsBtn.Click += new System.EventHandler(this.StudentsBtn_Click);
            // 
            // TimetableBtn
            // 
            this.TimetableBtn.Location = new System.Drawing.Point(137, 126);
            this.TimetableBtn.Margin = new System.Windows.Forms.Padding(2);
            this.TimetableBtn.Name = "TimetableBtn";
            this.TimetableBtn.Size = new System.Drawing.Size(110, 27);
            this.TimetableBtn.TabIndex = 5;
            this.TimetableBtn.Text = "Timetable";
            this.TimetableBtn.UseVisualStyleBackColor = true;
            this.TimetableBtn.Click += new System.EventHandler(this.TimetableBtn_Click);
            // 
            // TimeTablePnl
            // 
            this.TimeTablePnl.AutoSize = true;
            this.TimeTablePnl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TimeTablePnl.Location = new System.Drawing.Point(29, 157);
            this.TimeTablePnl.Margin = new System.Windows.Forms.Padding(2);
            this.TimeTablePnl.Name = "TimeTablePnl";
            this.TimeTablePnl.Size = new System.Drawing.Size(1097, 467);
            this.TimeTablePnl.TabIndex = 6;
            this.TimeTablePnl.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.LastName,
            this.FirstName});
            this.dataGridView1.Location = new System.Drawing.Point(31, 161);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1095, 418);
            this.dataGridView1.TabIndex = 7;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 10;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 200;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 10;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 200;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 10;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 200;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(656, 65);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "Create Exam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonCreateExam_Click_1);
            // 
            // CreateExamButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1134, 672);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TimeTablePnl);
            this.Controls.Add(this.TimetableBtn);
            this.Controls.Add(this.StudentsBtn);
            this.Controls.Add(this.DeleteCourseBtn);
            this.Controls.Add(this.ModifyCourseBtn);
            this.Controls.Add(this.CreateCourseBtn);
            this.Controls.Add(this.classNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateExamButton";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Class";
            this.Load += new System.EventHandler(this.ManageClassWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Panel TimeTablePnl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.Button button1;
    }
}