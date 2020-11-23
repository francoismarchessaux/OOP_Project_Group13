namespace OOP_Project_Group13
{
    partial class CreateExam
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
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.SubjectList = new System.Windows.Forms.ComboBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonCreateExam = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCoeff = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // classNameLabel
            // 
            this.classNameLabel.AutoSize = true;
            this.classNameLabel.Location = new System.Drawing.Point(31, 26);
            this.classNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.classNameLabel.Name = "classNameLabel";
            this.classNameLabel.Size = new System.Drawing.Size(83, 17);
            this.classNameLabel.TabIndex = 1;
            this.classNameLabel.Text = "Class Name";
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Location = new System.Drawing.Point(35, 78);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(55, 17);
            this.SubjectLabel.TabIndex = 2;
            this.SubjectLabel.Text = "Subject";
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
            this.SubjectList.Location = new System.Drawing.Point(184, 72);
            this.SubjectList.Margin = new System.Windows.Forms.Padding(2);
            this.SubjectList.Name = "SubjectList";
            this.SubjectList.Size = new System.Drawing.Size(213, 24);
            this.SubjectList.TabIndex = 15;
            this.SubjectList.SelectedIndexChanged += new System.EventHandler(this.SubjectList_SelectedIndexChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(38, 126);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(35, 17);
            this.labelTitle.TabIndex = 16;
            this.labelTitle.Text = "Title";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(184, 121);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(89, 22);
            this.textBoxTitle.TabIndex = 17;
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(184, 167);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 22);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // buttonCreateExam
            // 
            this.buttonCreateExam.Location = new System.Drawing.Point(201, 294);
            this.buttonCreateExam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCreateExam.Name = "buttonCreateExam";
            this.buttonCreateExam.Size = new System.Drawing.Size(142, 27);
            this.buttonCreateExam.TabIndex = 20;
            this.buttonCreateExam.Text = "Create Exam";
            this.buttonCreateExam.UseVisualStyleBackColor = true;
            this.buttonCreateExam.Click += new System.EventHandler(this.buttonCreateExam_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Coeff";
            // 
            // textBoxCoeff
            // 
            this.textBoxCoeff.Location = new System.Drawing.Point(184, 214);
            this.textBoxCoeff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCoeff.Name = "textBoxCoeff";
            this.textBoxCoeff.Size = new System.Drawing.Size(89, 22);
            this.textBoxCoeff.TabIndex = 22;
            this.textBoxCoeff.TextChanged += new System.EventHandler(this.textBoxCoeff_TextChanged);
            // 
            // CreateExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.textBoxCoeff);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCreateExam);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.SubjectList);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.classNameLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateExam";
            this.Text = "CreateExam";
            this.Load += new System.EventHandler(this.CreateExam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label classNameLabel;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.ComboBox SubjectList;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonCreateExam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCoeff;
    }
}