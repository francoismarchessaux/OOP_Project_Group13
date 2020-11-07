namespace OOP_Project_Group13
{
    partial class CreateCourse
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
            this.components = new System.ComponentModel.Container();
            this.LabelSubject = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.SubjectList = new System.Windows.Forms.ComboBox();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oopprojectDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oopprojectDataSet = new OOP_Project_Group13.oopprojectDataSet();
            this.classTableAdapter = new OOP_Project_Group13.oopprojectDataSetTableAdapters.classTableAdapter();
            this.TeacherList = new System.Windows.Forms.ComboBox();
            this.DayList = new System.Windows.Forms.ComboBox();
            this.TimeList = new System.Windows.Forms.ComboBox();
            this.BackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oopprojectDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oopprojectDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelSubject
            // 
            this.LabelSubject.AutoSize = true;
            this.LabelSubject.Location = new System.Drawing.Point(82, 71);
            this.LabelSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSubject.Name = "LabelSubject";
            this.LabelSubject.Size = new System.Drawing.Size(96, 25);
            this.LabelSubject.TabIndex = 0;
            this.LabelSubject.Text = "Subject :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Teacher :";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(82, 203);
            this.labelDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(62, 25);
            this.labelDay.TabIndex = 6;
            this.labelDay.Text = "Day :";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(82, 267);
            this.labelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(71, 25);
            this.labelTime.TabIndex = 8;
            this.labelTime.Text = "Time :";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(87, 392);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(117, 46);
            this.buttonCreate.TabIndex = 13;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // SubjectList
            // 
            this.SubjectList.FormattingEnabled = true;
            this.SubjectList.Items.AddRange(new object[] {
            "Numerical Analysis",
            "Data Structure & Algorithms",
            "Object Oriented Programming",
            "Statistical Inference",
            "Fluid Mechanics"});
            this.SubjectList.Location = new System.Drawing.Point(241, 71);
            this.SubjectList.Name = "SubjectList";
            this.SubjectList.Size = new System.Drawing.Size(317, 33);
            this.SubjectList.TabIndex = 14;
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "class";
            this.classBindingSource.DataSource = this.oopprojectDataSetBindingSource;
            // 
            // oopprojectDataSetBindingSource
            // 
            this.oopprojectDataSetBindingSource.DataSource = this.oopprojectDataSet;
            this.oopprojectDataSetBindingSource.Position = 0;
            // 
            // oopprojectDataSet
            // 
            this.oopprojectDataSet.DataSetName = "oopprojectDataSet";
            this.oopprojectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // TeacherList
            // 
            this.TeacherList.FormattingEnabled = true;
            this.TeacherList.Location = new System.Drawing.Point(241, 133);
            this.TeacherList.Name = "TeacherList";
            this.TeacherList.Size = new System.Drawing.Size(317, 33);
            this.TeacherList.TabIndex = 15;
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
            this.DayList.Location = new System.Drawing.Point(241, 200);
            this.DayList.Name = "DayList";
            this.DayList.Size = new System.Drawing.Size(317, 33);
            this.DayList.TabIndex = 16;
            // 
            // TimeList
            // 
            this.TimeList.FormattingEnabled = true;
            this.TimeList.Items.AddRange(new object[] {
            "8 : 00 am - 11 : 00 am",
            "1 : 00 pm - 3 : 55 pm",
            "4 : 00 pm - 7 : 00 pm"});
            this.TimeList.Location = new System.Drawing.Point(241, 267);
            this.TimeList.Name = "TimeList";
            this.TimeList.Size = new System.Drawing.Size(317, 33);
            this.TimeList.TabIndex = 17;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(441, 392);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(117, 46);
            this.BackBtn.TabIndex = 18;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // CreateCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 496);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.TimeList);
            this.Controls.Add(this.DayList);
            this.Controls.Add(this.TeacherList);
            this.Controls.Add(this.SubjectList);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelSubject);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Course";
            this.Load += new System.EventHandler(this.CreateCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oopprojectDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oopprojectDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.ComboBox SubjectList;
        private System.Windows.Forms.BindingSource oopprojectDataSetBindingSource;
        private oopprojectDataSet oopprojectDataSet;
        private System.Windows.Forms.BindingSource classBindingSource;
        private oopprojectDataSetTableAdapters.classTableAdapter classTableAdapter;
        private System.Windows.Forms.ComboBox TeacherList;
        private System.Windows.Forms.ComboBox DayList;
        private System.Windows.Forms.ComboBox TimeList;
        private System.Windows.Forms.Button BackBtn;
    }
}