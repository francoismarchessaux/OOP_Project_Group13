﻿namespace OOP_Project_Group13
{
    partial class AddGrade2
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
            this.classNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.SubjectList = new System.Windows.Forms.ComboBox();
            this.labelExam = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oopprojectDataSet = new OOP_Project_Group13.oopprojectDataSet();
            this.gradeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradeTableAdapter = new OOP_Project_Group13.oopprojectDataSetTableAdapters.gradeTableAdapter();
            this.buttonAddGrade = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oopprojectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // classNameLabel
            // 
            this.classNameLabel.AutoSize = true;
            this.classNameLabel.Location = new System.Drawing.Point(40, 55);
            this.classNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.classNameLabel.Name = "classNameLabel";
            this.classNameLabel.Size = new System.Drawing.Size(94, 20);
            this.classNameLabel.TabIndex = 2;
            this.classNameLabel.Text = "Class Name";
            this.classNameLabel.Click += new System.EventHandler(this.classNameLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Location = new System.Drawing.Point(40, 120);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(63, 20);
            this.SubjectLabel.TabIndex = 4;
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
            this.SubjectList.Location = new System.Drawing.Point(170, 111);
            this.SubjectList.Margin = new System.Windows.Forms.Padding(2);
            this.SubjectList.Name = "SubjectList";
            this.SubjectList.Size = new System.Drawing.Size(239, 28);
            this.SubjectList.TabIndex = 16;
            this.SubjectList.SelectedIndexChanged += new System.EventHandler(this.SubjectList_SelectedIndexChanged);
            // 
            // labelExam
            // 
            this.labelExam.AutoSize = true;
            this.labelExam.Location = new System.Drawing.Point(44, 190);
            this.labelExam.Name = "labelExam";
            this.labelExam.Size = new System.Drawing.Size(49, 20);
            this.labelExam.TabIndex = 17;
            this.labelExam.Text = "Exam";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(170, 179);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 28);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Surname,
            this.NumberID,
            this.Grades});
            this.dataGridView1.Location = new System.Drawing.Point(154, 253);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(515, 236);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // oopprojectDataSet
            // 
            this.oopprojectDataSet.DataSetName = "oopprojectDataSet";
            this.oopprojectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gradeBindingSource
            // 
            this.gradeBindingSource.DataMember = "grade";
            this.gradeBindingSource.DataSource = this.oopprojectDataSet;
            // 
            // gradeTableAdapter
            // 
            this.gradeTableAdapter.ClearBeforeFill = true;
            // 
            // buttonAddGrade
            // 
            this.buttonAddGrade.Location = new System.Drawing.Point(691, 389);
            this.buttonAddGrade.Name = "buttonAddGrade";
            this.buttonAddGrade.Size = new System.Drawing.Size(117, 30);
            this.buttonAddGrade.TabIndex = 20;
            this.buttonAddGrade.Text = "Add grade";
            this.buttonAddGrade.UseVisualStyleBackColor = true;
            this.buttonAddGrade.Click += new System.EventHandler(this.buttonAddGrade_Click);
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Name.Width = 125;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.MinimumWidth = 6;
            this.Surname.Name = "Surname";
            this.Surname.Width = 125;
            // 
            // NumberID
            // 
            this.NumberID.HeaderText = "NumberID";
            this.NumberID.MinimumWidth = 8;
            this.NumberID.Name = "NumberID";
            this.NumberID.Width = 150;
            // 
            // Grades
            // 
            this.Grades.HeaderText = "Grade";
            this.Grades.MinimumWidth = 6;
            this.Grades.Name = "Grades";
            this.Grades.Width = 125;
            // 
            // AddGrade2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.buttonAddGrade);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelExam);
            this.Controls.Add(this.SubjectList);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.classNameLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
           
            this.Text = "AddGrade";
            this.Load += new System.EventHandler(this.AddGrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oopprojectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label classNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.ComboBox SubjectList;
        private System.Windows.Forms.Label labelExam;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private oopprojectDataSet oopprojectDataSet;
        private System.Windows.Forms.BindingSource gradeBindingSource;
        private oopprojectDataSetTableAdapters.gradeTableAdapter gradeTableAdapter;
        private System.Windows.Forms.Button buttonAddGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grades;
    }
}