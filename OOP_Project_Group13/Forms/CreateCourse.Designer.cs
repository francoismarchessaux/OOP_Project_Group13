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
            this.LabelSubject = new System.Windows.Forms.Label();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.labelClass = new System.Windows.Forms.Label();
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTeacher = new System.Windows.Forms.TextBox();
            this.labelDay = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelTime = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.checkBoxPeriodique = new System.Windows.Forms.CheckBox();
            this.checkBoxExam = new System.Windows.Forms.CheckBox();
            this.checkBoxAssignment = new System.Windows.Forms.CheckBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelSubject
            // 
            this.LabelSubject.AutoSize = true;
            this.LabelSubject.Location = new System.Drawing.Point(58, 41);
            this.LabelSubject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelSubject.Name = "LabelSubject";
            this.LabelSubject.Size = new System.Drawing.Size(43, 13);
            this.LabelSubject.TabIndex = 0;
            this.LabelSubject.Text = "Subject";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(183, 37);
            this.textBoxSubject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(68, 20);
            this.textBoxSubject.TabIndex = 1;
            this.textBoxSubject.TextChanged += new System.EventHandler(this.textBoxSubject_TextChanged);
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(58, 70);
            this.labelClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(32, 13);
            this.labelClass.TabIndex = 2;
            this.labelClass.Text = "Class";
            // 
            // textBoxClass
            // 
            this.textBoxClass.Location = new System.Drawing.Point(183, 66);
            this.textBoxClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.Size = new System.Drawing.Size(68, 20);
            this.textBoxClass.TabIndex = 3;
            this.textBoxClass.TextChanged += new System.EventHandler(this.textBoxClass_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Teacher";
            // 
            // textBoxTeacher
            // 
            this.textBoxTeacher.Location = new System.Drawing.Point(183, 96);
            this.textBoxTeacher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTeacher.Name = "textBoxTeacher";
            this.textBoxTeacher.Size = new System.Drawing.Size(68, 20);
            this.textBoxTeacher.TabIndex = 5;
            this.textBoxTeacher.TextChanged += new System.EventHandler(this.textBoxTeacher_TextChanged);
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(58, 125);
            this.labelDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(26, 13);
            this.labelDay.TabIndex = 6;
            this.labelDay.Text = "Day";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(183, 125);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(135, 20);
            this.dateTimePickerDate.TabIndex = 7;
            this.dateTimePickerDate.ValueChanged += new System.EventHandler(this.dateTimePickerDate_ValueChanged);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(58, 153);
            this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(30, 13);
            this.labelTime.TabIndex = 8;
            this.labelTime.Text = "Time";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(183, 153);
            this.textBoxTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(68, 20);
            this.textBoxTime.TabIndex = 9;
            this.textBoxTime.TextChanged += new System.EventHandler(this.textBoxTime_TextChanged);
            // 
            // checkBoxPeriodique
            // 
            this.checkBoxPeriodique.AutoSize = true;
            this.checkBoxPeriodique.Location = new System.Drawing.Point(61, 208);
            this.checkBoxPeriodique.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxPeriodique.Name = "checkBoxPeriodique";
            this.checkBoxPeriodique.Size = new System.Drawing.Size(76, 17);
            this.checkBoxPeriodique.TabIndex = 10;
            this.checkBoxPeriodique.Text = "Periodique";
            this.checkBoxPeriodique.UseVisualStyleBackColor = true;
            this.checkBoxPeriodique.CheckedChanged += new System.EventHandler(this.checkBoxPeriodique_CheckedChanged);
            // 
            // checkBoxExam
            // 
            this.checkBoxExam.AutoSize = true;
            this.checkBoxExam.Location = new System.Drawing.Point(183, 208);
            this.checkBoxExam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxExam.Name = "checkBoxExam";
            this.checkBoxExam.Size = new System.Drawing.Size(52, 17);
            this.checkBoxExam.TabIndex = 11;
            this.checkBoxExam.Text = "Exam";
            this.checkBoxExam.UseVisualStyleBackColor = true;
            // 
            // checkBoxAssignment
            // 
            this.checkBoxAssignment.AutoSize = true;
            this.checkBoxAssignment.Location = new System.Drawing.Point(265, 208);
            this.checkBoxAssignment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxAssignment.Name = "checkBoxAssignment";
            this.checkBoxAssignment.Size = new System.Drawing.Size(80, 17);
            this.checkBoxAssignment.TabIndex = 12;
            this.checkBoxAssignment.Text = "Assignment";
            this.checkBoxAssignment.UseVisualStyleBackColor = true;
            this.checkBoxAssignment.CheckedChanged += new System.EventHandler(this.checkBoxAssignment_CheckedChanged);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(63, 255);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(50, 20);
            this.buttonCreate.TabIndex = 13;
            this.buttonCreate.Text = "CreateCourse";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // CreateCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.checkBoxAssignment);
            this.Controls.Add(this.checkBoxExam);
            this.Controls.Add(this.checkBoxPeriodique);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.textBoxTeacher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxClass);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.LabelSubject);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CreateCourse";
            this.Text = "FormCreateCourse";
            this.Load += new System.EventHandler(this.CreateCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelSubject;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.TextBox textBoxClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTeacher;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.CheckBox checkBoxPeriodique;
        private System.Windows.Forms.CheckBox checkBoxExam;
        private System.Windows.Forms.CheckBox checkBoxAssignment;
        private System.Windows.Forms.Button buttonCreate;
    }
}