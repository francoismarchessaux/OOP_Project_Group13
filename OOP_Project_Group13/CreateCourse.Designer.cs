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
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.textBoxTeacher = new System.Windows.Forms.TextBox();
            this.LabelSubject = new System.Windows.Forms.Label();
            this.LabelClass = new System.Windows.Forms.Label();
            this.LabelTeacher = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.checkBoxPeriodique = new System.Windows.Forms.CheckBox();
            this.checkBoxExam = new System.Windows.Forms.CheckBox();
            this.checkBoxAssignment = new System.Windows.Forms.CheckBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelTime = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(303, 44);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(145, 26);
            this.textBoxSubject.TabIndex = 0;
            this.textBoxSubject.TextChanged += new System.EventHandler(this.textBoxSubject_TextChanged);
            // 
            // textBoxClass
            // 
            this.textBoxClass.Location = new System.Drawing.Point(303, 87);
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.Size = new System.Drawing.Size(145, 26);
            this.textBoxClass.TabIndex = 1;
            this.textBoxClass.TextChanged += new System.EventHandler(this.textBoxClass_TextChanged);
            // 
            // textBoxTeacher
            // 
            this.textBoxTeacher.Location = new System.Drawing.Point(303, 133);
            this.textBoxTeacher.Name = "textBoxTeacher";
            this.textBoxTeacher.Size = new System.Drawing.Size(145, 26);
            this.textBoxTeacher.TabIndex = 3;
            this.textBoxTeacher.TextChanged += new System.EventHandler(this.textBoxTeacher_TextChanged);
            // 
            // LabelSubject
            // 
            this.LabelSubject.AccessibleName = "";
            this.LabelSubject.AutoSize = true;
            this.LabelSubject.Location = new System.Drawing.Point(141, 44);
            this.LabelSubject.Name = "LabelSubject";
            this.LabelSubject.Size = new System.Drawing.Size(63, 20);
            this.LabelSubject.TabIndex = 4;
            this.LabelSubject.Text = "Subject";
            this.LabelSubject.Click += new System.EventHandler(this.labelSubject_Click);
            // 
            // LabelClass
            // 
            this.LabelClass.AutoSize = true;
            this.LabelClass.Location = new System.Drawing.Point(141, 87);
            this.LabelClass.Name = "LabelClass";
            this.LabelClass.Size = new System.Drawing.Size(48, 20);
            this.LabelClass.TabIndex = 5;
            this.LabelClass.Text = "Class";
            // 
            // LabelTeacher
            // 
            this.LabelTeacher.AutoSize = true;
            this.LabelTeacher.Location = new System.Drawing.Point(141, 133);
            this.LabelTeacher.Name = "LabelTeacher";
            this.LabelTeacher.Size = new System.Drawing.Size(67, 20);
            this.LabelTeacher.TabIndex = 6;
            this.LabelTeacher.Text = "Teacher";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Location = new System.Drawing.Point(141, 181);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(44, 20);
            this.LabelDate.TabIndex = 7;
            this.LabelDate.Text = "Date";
            // 
            // checkBoxPeriodique
            // 
            this.checkBoxPeriodique.AutoSize = true;
            this.checkBoxPeriodique.Location = new System.Drawing.Point(98, 319);
            this.checkBoxPeriodique.Name = "checkBoxPeriodique";
            this.checkBoxPeriodique.Size = new System.Drawing.Size(110, 24);
            this.checkBoxPeriodique.TabIndex = 8;
            this.checkBoxPeriodique.Text = "Periodique";
            this.checkBoxPeriodique.UseVisualStyleBackColor = true;
            // 
            // checkBoxExam
            // 
            this.checkBoxExam.AutoSize = true;
            this.checkBoxExam.Location = new System.Drawing.Point(303, 319);
            this.checkBoxExam.Name = "checkBoxExam";
            this.checkBoxExam.Size = new System.Drawing.Size(75, 24);
            this.checkBoxExam.TabIndex = 9;
            this.checkBoxExam.Text = "Exam";
            this.checkBoxExam.UseVisualStyleBackColor = true;
            // 
            // checkBoxAssignment
            // 
            this.checkBoxAssignment.AutoSize = true;
            this.checkBoxAssignment.Location = new System.Drawing.Point(460, 319);
            this.checkBoxAssignment.Name = "checkBoxAssignment";
            this.checkBoxAssignment.Size = new System.Drawing.Size(119, 24);
            this.checkBoxAssignment.TabIndex = 10;
            this.checkBoxAssignment.Text = "Assignment";
            this.checkBoxAssignment.UseVisualStyleBackColor = true;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(98, 378);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(104, 48);
            this.buttonCreate.TabIndex = 11;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(303, 181);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerDate.TabIndex = 12;
            this.dateTimePickerDate.ValueChanged += new System.EventHandler(this.dateTimePickerDate_ValueChanged);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(145, 244);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(43, 20);
            this.labelTime.TabIndex = 13;
            this.labelTime.Text = "Time";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(303, 237);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(100, 26);
            this.textBoxTime.TabIndex = 14;
            this.textBoxTime.TextChanged += new System.EventHandler(this.textBoxTime_TextChanged);
            // 
            // CreateCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.checkBoxAssignment);
            this.Controls.Add(this.checkBoxExam);
            this.Controls.Add(this.checkBoxPeriodique);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.LabelTeacher);
            this.Controls.Add(this.LabelClass);
            this.Controls.Add(this.LabelSubject);
            this.Controls.Add(this.textBoxTeacher);
            this.Controls.Add(this.textBoxClass);
            this.Controls.Add(this.textBoxSubject);
            this.Name = "CreateCourse";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.TextBox textBoxClass;
        private System.Windows.Forms.TextBox textBoxTeacher;
        private System.Windows.Forms.Label LabelSubject;
        private System.Windows.Forms.Label LabelClass;
        private System.Windows.Forms.Label LabelTeacher;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.CheckBox checkBoxPeriodique;
        private System.Windows.Forms.CheckBox checkBoxExam;
        private System.Windows.Forms.CheckBox checkBoxAssignment;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TextBox textBoxTime;
    }
}