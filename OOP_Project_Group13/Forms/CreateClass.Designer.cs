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
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOfStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameOfStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clear = new System.Windows.Forms.Button();
            this.AddStudent = new System.Windows.Forms.Button();
            this.ComboStudent = new System.Windows.Forms.ComboBox();
            this.NameOfTheClass = new System.Windows.Forms.Label();
            this.NameClass = new System.Windows.Forms.TextBox();
            this.RemoveStudent = new System.Windows.Forms.Button();
            this.oopprojectDataSet = new OOP_Project_Group13.oopprojectDataSet();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classTableAdapter = new OOP_Project_Group13.oopprojectDataSetTableAdapters.classTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oopprojectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Student
            // 
            this.Student.AutoSize = true;
<<<<<<< HEAD
            this.Student.Location = new System.Drawing.Point(57, 101);
            this.Student.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(65, 17);
=======
            this.Student.Location = new System.Drawing.Point(86, 158);
            this.Student.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(98, 25);
>>>>>>> 482f6c242d40bf4db42d88e0b43305f263c7cc57
            this.Student.TabIndex = 1;
            this.Student.Text = "Student :";
            // 
            // Back
            // 
<<<<<<< HEAD
            this.Back.Location = new System.Drawing.Point(61, 609);
            this.Back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(100, 28);
=======
            this.Back.Location = new System.Drawing.Point(92, 952);
            this.Back.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(150, 44);
>>>>>>> 482f6c242d40bf4db42d88e0b43305f263c7cc57
            this.Back.TabIndex = 2;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // CreateClassButton
            // 
<<<<<<< HEAD
            this.CreateClassButton.Location = new System.Drawing.Point(276, 558);
            this.CreateClassButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreateClassButton.Name = "CreateClassButton";
            this.CreateClassButton.Size = new System.Drawing.Size(100, 28);
=======
            this.CreateClassButton.Location = new System.Drawing.Point(254, 785);
            this.CreateClassButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CreateClassButton.Name = "CreateClassButton";
            this.CreateClassButton.Size = new System.Drawing.Size(150, 44);
>>>>>>> 482f6c242d40bf4db42d88e0b43305f263c7cc57
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
            this.NameOfStudent,
            this.SurnameOfStudent});
<<<<<<< HEAD
            this.dataGridView1.Location = new System.Drawing.Point(61, 188);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(591, 306);
=======
            this.dataGridView1.Location = new System.Drawing.Point(92, 294);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(886, 479);
>>>>>>> 482f6c242d40bf4db42d88e0b43305f263c7cc57
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ClassName
            // 
            this.ClassName.HeaderText = "Class";
            this.ClassName.MinimumWidth = 6;
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            this.ClassName.Width = 125;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // NameOfStudent
            // 
            this.NameOfStudent.HeaderText = "Name";
            this.NameOfStudent.MinimumWidth = 6;
            this.NameOfStudent.Name = "NameOfStudent";
            this.NameOfStudent.ReadOnly = true;
            this.NameOfStudent.Width = 125;
            // 
            // SurnameOfStudent
            // 
            this.SurnameOfStudent.HeaderText = "Surname";
            this.SurnameOfStudent.MinimumWidth = 6;
            this.SurnameOfStudent.Name = "SurnameOfStudent";
            this.SurnameOfStudent.ReadOnly = true;
            this.SurnameOfStudent.Width = 125;
            // 
            // ClassName
            // 
            this.ClassName.HeaderText = "Class";
            this.ClassName.MinimumWidth = 10;
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            this.ClassName.Width = 200;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 10;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 200;
            // 
            // NameOfStudent
            // 
            this.NameOfStudent.HeaderText = "Name";
            this.NameOfStudent.MinimumWidth = 10;
            this.NameOfStudent.Name = "NameOfStudent";
            this.NameOfStudent.ReadOnly = true;
            this.NameOfStudent.Width = 200;
            // 
            // SurnameOfStudent
            // 
            this.SurnameOfStudent.HeaderText = "Surname";
            this.SurnameOfStudent.MinimumWidth = 10;
            this.SurnameOfStudent.Name = "SurnameOfStudent";
            this.SurnameOfStudent.ReadOnly = true;
            this.SurnameOfStudent.Width = 200;
            // 
            // Clear
            // 
<<<<<<< HEAD
            this.Clear.Location = new System.Drawing.Point(552, 502);
            this.Clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(100, 28);
=======
            this.Clear.Location = new System.Drawing.Point(828, 785);
            this.Clear.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(150, 44);
>>>>>>> 482f6c242d40bf4db42d88e0b43305f263c7cc57
            this.Clear.TabIndex = 7;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // AddStudent
            // 
<<<<<<< HEAD
            this.AddStudent.Location = new System.Drawing.Point(516, 97);
            this.AddStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(100, 28);
=======
            this.AddStudent.Location = new System.Drawing.Point(774, 152);
            this.AddStudent.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(150, 44);
>>>>>>> 482f6c242d40bf4db42d88e0b43305f263c7cc57
            this.AddStudent.TabIndex = 8;
            this.AddStudent.Text = "Add";
            this.AddStudent.UseVisualStyleBackColor = true;
            this.AddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // ComboStudent
            // 
            this.ComboStudent.FormattingEnabled = true;
<<<<<<< HEAD
            this.ComboStudent.Location = new System.Drawing.Point(228, 97);
            this.ComboStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboStudent.Name = "ComboStudent";
            this.ComboStudent.Size = new System.Drawing.Size(243, 24);
=======
            this.ComboStudent.Location = new System.Drawing.Point(342, 152);
            this.ComboStudent.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ComboStudent.Name = "ComboStudent";
            this.ComboStudent.Size = new System.Drawing.Size(362, 33);
>>>>>>> 482f6c242d40bf4db42d88e0b43305f263c7cc57
            this.ComboStudent.TabIndex = 9;
            this.ComboStudent.SelectedIndexChanged += new System.EventHandler(this.ComboStudent_SelectedIndexChanged);
            // 
            // NameOfTheClass
            // 
            this.NameOfTheClass.AutoSize = true;
<<<<<<< HEAD
            this.NameOfTheClass.Location = new System.Drawing.Point(57, 39);
            this.NameOfTheClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameOfTheClass.Name = "NameOfTheClass";
            this.NameOfTheClass.Size = new System.Drawing.Size(129, 17);
=======
            this.NameOfTheClass.Location = new System.Drawing.Point(86, 62);
            this.NameOfTheClass.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NameOfTheClass.Name = "NameOfTheClass";
            this.NameOfTheClass.Size = new System.Drawing.Size(196, 25);
>>>>>>> 482f6c242d40bf4db42d88e0b43305f263c7cc57
            this.NameOfTheClass.TabIndex = 10;
            this.NameOfTheClass.Text = "Name of the class :";
            // 
            // NameClass
            // 
<<<<<<< HEAD
            this.NameClass.Location = new System.Drawing.Point(228, 36);
            this.NameClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameClass.Name = "NameClass";
            this.NameClass.Size = new System.Drawing.Size(243, 22);
=======
            this.NameClass.Location = new System.Drawing.Point(342, 56);
            this.NameClass.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NameClass.Name = "NameClass";
            this.NameClass.Size = new System.Drawing.Size(362, 31);
>>>>>>> 482f6c242d40bf4db42d88e0b43305f263c7cc57
            this.NameClass.TabIndex = 11;
            this.NameClass.TextChanged += new System.EventHandler(this.NameClass_TextChanged);
            // 
            // RemoveStudent
            // 
<<<<<<< HEAD
            this.RemoveStudent.Location = new System.Drawing.Point(61, 502);
            this.RemoveStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RemoveStudent.Name = "RemoveStudent";
            this.RemoveStudent.Size = new System.Drawing.Size(100, 28);
=======
            this.RemoveStudent.Location = new System.Drawing.Point(92, 785);
            this.RemoveStudent.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RemoveStudent.Name = "RemoveStudent";
            this.RemoveStudent.Size = new System.Drawing.Size(150, 44);
>>>>>>> 482f6c242d40bf4db42d88e0b43305f263c7cc57
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
            // CreateClass
            // 
<<<<<<< HEAD
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 655);
=======
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1088, 1023);
>>>>>>> 482f6c242d40bf4db42d88e0b43305f263c7cc57
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
<<<<<<< HEAD
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
>>>>>>> 482f6c242d40bf4db42d88e0b43305f263c7cc57
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
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameOfStudent;
    }
}