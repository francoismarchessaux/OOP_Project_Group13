namespace OOP_Project_Group13.Forms
{
    partial class CreateClass
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
            this.Student = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.CreateClassButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Clear = new System.Windows.Forms.Button();
            this.AddStudent = new System.Windows.Forms.Button();
            this.ComboStudent = new System.Windows.Forms.ComboBox();
            this.NameOfTheClass = new System.Windows.Forms.Label();
            this.NameClass = new System.Windows.Forms.TextBox();
            this.RemoveStudent = new System.Windows.Forms.Button();
            this.oopprojectDataSet = new OOP_Project_Group13.oopprojectDataSet();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classTableAdapter = new OOP_Project_Group13.oopprojectDataSetTableAdapters.classTableAdapter();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameofStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameofStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oopprojectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Student
            // 
            this.Student.AutoSize = true;
            this.Student.Location = new System.Drawing.Point(72, 104);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(50, 13);
            this.Student.TabIndex = 1;
            this.Student.Text = "Student :";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(66, 495);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 2;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // CreateClassButton
            // 
            this.CreateClassButton.Location = new System.Drawing.Point(423, 495);
            this.CreateClassButton.Name = "CreateClassButton";
            this.CreateClassButton.Size = new System.Drawing.Size(75, 23);
            this.CreateClassButton.TabIndex = 3;
            this.CreateClassButton.Text = "Create Class";
            this.CreateClassButton.UseVisualStyleBackColor = true;
            this.CreateClassButton.Click += new System.EventHandler(this.CreateClassButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassName,
            this.ID,
            this.NameofStudent,
            this.SurnameofStudent});
            this.dataGridView1.Location = new System.Drawing.Point(66, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(777, 249);
            this.dataGridView1.TabIndex = 4;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(768, 408);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // AddStudent
            // 
            this.AddStudent.Location = new System.Drawing.Point(405, 94);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(75, 23);
            this.AddStudent.TabIndex = 8;
            this.AddStudent.Text = "Add";
            this.AddStudent.UseVisualStyleBackColor = true;
            this.AddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // ComboStudent
            // 
            this.ComboStudent.FormattingEnabled = true;
            this.ComboStudent.Location = new System.Drawing.Point(202, 96);
            this.ComboStudent.Name = "ComboStudent";
            this.ComboStudent.Size = new System.Drawing.Size(183, 21);
            this.ComboStudent.TabIndex = 9;
            this.ComboStudent.SelectedIndexChanged += new System.EventHandler(this.ComboStudent_SelectedIndexChanged);
            // 
            // NameOfTheClass
            // 
            this.NameOfTheClass.AutoSize = true;
            this.NameOfTheClass.Location = new System.Drawing.Point(72, 58);
            this.NameOfTheClass.Name = "NameOfTheClass";
            this.NameOfTheClass.Size = new System.Drawing.Size(98, 13);
            this.NameOfTheClass.TabIndex = 10;
            this.NameOfTheClass.Text = "Name of the class :";
            // 
            // NameClass
            // 
            this.NameClass.Location = new System.Drawing.Point(202, 55);
            this.NameClass.Name = "NameClass";
            this.NameClass.Size = new System.Drawing.Size(183, 20);
            this.NameClass.TabIndex = 11;
            this.NameClass.TextChanged += new System.EventHandler(this.NameClass_TextChanged);
            // 
            // RemoveStudent
            // 
            this.RemoveStudent.Location = new System.Drawing.Point(66, 408);
            this.RemoveStudent.Name = "RemoveStudent";
            this.RemoveStudent.Size = new System.Drawing.Size(75, 23);
            this.RemoveStudent.TabIndex = 12;
            this.RemoveStudent.Text = "Remove";
            this.RemoveStudent.UseVisualStyleBackColor = true;
            this.RemoveStudent.Click += new System.EventHandler(this.RemoveStudent_Click);
            // 
            // oopprojectDataSet
            // 
            this.oopprojectDataSet.DataSetName = "oopprojectDataSet";
            this.oopprojectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "class";
            this.classBindingSource.DataSource = this.oopprojectDataSet;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // ClassName
            // 
            this.ClassName.HeaderText = "Class";
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NameofStudent
            // 
            this.NameofStudent.HeaderText = "Name";
            this.NameofStudent.Name = "NameofStudent";
            this.NameofStudent.ReadOnly = true;
            // 
            // SurnameofStudent
            // 
            this.SurnameofStudent.HeaderText = "Surname";
            this.SurnameofStudent.Name = "SurnameofStudent";
            this.SurnameofStudent.ReadOnly = true;
            // 
            // CreateClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 532);
            this.Controls.Add(this.RemoveStudent);
            this.Controls.Add(this.NameClass);
            this.Controls.Add(this.NameOfTheClass);
            this.Controls.Add(this.ComboStudent);
            this.Controls.Add(this.AddStudent);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CreateClassButton);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Student);
            this.Name = "CreateClass";
            this.Text = "CreateClass";
            this.Load += new System.EventHandler(this.CreateClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oopprojectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Student;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button CreateClassButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button AddStudent;
        private System.Windows.Forms.ComboBox ComboStudent;
        private System.Windows.Forms.Label NameOfTheClass;
        private System.Windows.Forms.TextBox NameClass;
        private System.Windows.Forms.Button RemoveStudent;
        private oopprojectDataSet oopprojectDataSet;
        private System.Windows.Forms.BindingSource classBindingSource;
        private oopprojectDataSetTableAdapters.classTableAdapter classTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameofStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameofStudent;
    }
}