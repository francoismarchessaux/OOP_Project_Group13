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
            this.LabelSubject.Location = new System.Drawing.Point(116, 79);
            this.LabelSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSubject.Name = "LabelSubject";
            this.LabelSubject.Size = new System.Drawing.Size(84, 25);
            this.LabelSubject.TabIndex = 0;
            this.LabelSubject.Text = "Subject";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(365, 71);
            this.textBoxSubject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(132, 31);
            this.textBoxSubject.TabIndex = 1;
            this.textBoxSubject.TextChanged += new System.EventHandler(this.textBoxSubject_TextChanged);
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(116, 134);
            this.labelClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(66, 25);
            this.labelClass.TabIndex = 2;
            this.labelClass.Text = "Class";
            // 
            // textBoxClass
            // 
            this.textBoxClass.Location = new System.Drawing.Point(365, 126);
            this.textBoxClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.Size = new System.Drawing.Size(132, 31);
            this.textBoxClass.TabIndex = 3;
            this.textBoxClass.TextChanged += new System.EventHandler(this.textBoxClass_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Teacher";
            // 
            // textBoxTeacher
            // 
            this.textBoxTeacher.Location = new System.Drawing.Point(365, 184);
            this.textBoxTeacher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTeacher.Name = "textBoxTeacher";
            this.textBoxTeacher.Size = new System.Drawing.Size(132, 31);
            this.textBoxTeacher.TabIndex = 5;
            this.textBoxTeacher.TextChanged += new System.EventHandler(this.textBoxTeacher_TextChanged);
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(116, 241);
            this.labelDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(50, 25);
            this.labelDay.TabIndex = 6;
            this.labelDay.Text = "Day";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(365, 241);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(265, 31);
            this.dateTimePickerDate.TabIndex = 7;
            this.dateTimePickerDate.ValueChanged += new System.EventHandler(this.dateTimePickerDate_ValueChanged);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(116, 294);
            this.labelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(59, 25);
            this.labelTime.TabIndex = 8;
            this.labelTime.Text = "Time";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(365, 294);
            this.textBoxTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(132, 31);
            this.textBoxTime.TabIndex = 9;
            this.textBoxTime.TextChanged += new System.EventHandler(this.textBoxTime_TextChanged);
            // 
            // checkBoxPeriodique
            // 
            this.checkBoxPeriodique.AutoSize = true;
            this.checkBoxPeriodique.Location = new System.Drawing.Point(121, 400);
            this.checkBoxPeriodique.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxPeriodique.Name = "checkBoxPeriodique";
            this.checkBoxPeriodique.Size = new System.Drawing.Size(122, 29);
            this.checkBoxPeriodique.TabIndex = 10;
            this.checkBoxPeriodique.Text = "Periodic";
            this.checkBoxPeriodique.UseVisualStyleBackColor = true;
            this.checkBoxPeriodique.CheckedChanged += new System.EventHandler(this.checkBoxPeriodique_CheckedChanged);
            // 
            // checkBoxExam
            // 
            this.checkBoxExam.AutoSize = true;
            this.checkBoxExam.Location = new System.Drawing.Point(365, 400);
            this.checkBoxExam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxExam.Name = "checkBoxExam";
            this.checkBoxExam.Size = new System.Drawing.Size(98, 29);
            this.checkBoxExam.TabIndex = 11;
            this.checkBoxExam.Text = "Exam";
            this.checkBoxExam.UseVisualStyleBackColor = true;
            // 
            // checkBoxAssignment
            // 
            this.checkBoxAssignment.AutoSize = true;
            this.checkBoxAssignment.Location = new System.Drawing.Point(531, 400);
            this.checkBoxAssignment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxAssignment.Name = "checkBoxAssignment";
            this.checkBoxAssignment.Size = new System.Drawing.Size(156, 29);
            this.checkBoxAssignment.TabIndex = 12;
            this.checkBoxAssignment.Text = "Assignment";
            this.checkBoxAssignment.UseVisualStyleBackColor = true;
            this.checkBoxAssignment.CheckedChanged += new System.EventHandler(this.checkBoxAssignment_CheckedChanged);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(127, 491);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(100, 39);
            this.buttonCreate.TabIndex = 13;
            this.buttonCreate.Text = "CreateCourse";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // CreateCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 562);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "CreateCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCreateCourse";
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