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
            this.StudentsBtn = new System.Windows.Forms.Button();
            this.TimetableBtn = new System.Windows.Forms.Button();
            this.TimeTablePnl = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.CreateCourseBtn.Location = new System.Drawing.Point(44, 102);
            this.CreateCourseBtn.Name = "CreateCourseBtn";
            this.CreateCourseBtn.Size = new System.Drawing.Size(165, 42);
            this.CreateCourseBtn.TabIndex = 1;
            this.CreateCourseBtn.Text = "Create Course";
            this.CreateCourseBtn.UseVisualStyleBackColor = true;
            this.CreateCourseBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentsBtn
            // 
            this.StudentsBtn.Location = new System.Drawing.Point(44, 197);
            this.StudentsBtn.Name = "StudentsBtn";
            this.StudentsBtn.Size = new System.Drawing.Size(165, 42);
            this.StudentsBtn.TabIndex = 4;
            this.StudentsBtn.Text = "Students";
            this.StudentsBtn.UseVisualStyleBackColor = true;
            this.StudentsBtn.Click += new System.EventHandler(this.StudentsBtn_Click);
            // 
            // TimetableBtn
            // 
            this.TimetableBtn.Location = new System.Drawing.Point(206, 197);
            this.TimetableBtn.Name = "TimetableBtn";
            this.TimetableBtn.Size = new System.Drawing.Size(165, 42);
            this.TimetableBtn.TabIndex = 5;
            this.TimetableBtn.Text = "Timetable";
            this.TimetableBtn.UseVisualStyleBackColor = true;
            this.TimetableBtn.Click += new System.EventHandler(this.TimetableBtn_Click);
            // 
            // TimeTablePnl
            // 
            this.TimeTablePnl.AutoSize = true;
            this.TimeTablePnl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TimeTablePnl.Location = new System.Drawing.Point(44, 245);
            this.TimeTablePnl.Name = "TimeTablePnl";
            this.TimeTablePnl.Size = new System.Drawing.Size(1646, 730);
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
            this.dataGridView1.Location = new System.Drawing.Point(46, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1642, 653);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.button1.Location = new System.Drawing.Point(216, 102);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Create Exam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonCreateExam_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(434, 102);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 42);
            this.button2.TabIndex = 9;
            this.button2.Text = "Submit grade";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(46, 996);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(165, 42);
            this.deleteBtn.TabIndex = 10;
            this.deleteBtn.Text = "Delete Class";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(228, 996);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(165, 42);
            this.BackBtn.TabIndex = 11;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1523, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 42);
            this.button3.TabIndex = 12;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ManageClassWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1701, 1050);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TimeTablePnl);
            this.Controls.Add(this.TimetableBtn);
            this.Controls.Add(this.StudentsBtn);
            this.Controls.Add(this.CreateCourseBtn);
            this.Controls.Add(this.classNameLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageClassWindow";
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
        private System.Windows.Forms.Button StudentsBtn;
        private System.Windows.Forms.Button TimetableBtn;
        private System.Windows.Forms.Panel TimeTablePnl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button button3;
    }
}