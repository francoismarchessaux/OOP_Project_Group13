namespace OOP_Project_Group13
{
    partial class StudentInformationsWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.StudentPicture = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.StudentIDLabel = new System.Windows.Forms.Label();
            this.BirthDate = new System.Windows.Forms.Label();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.MailLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.gradeTab = new System.Windows.Forms.DataGridView();
            this.assessmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coefficientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassAverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new OOP_Project_Group13.Database1DataSet();
            this.gradesTableAdapter = new OOP_Project_Group13.Database1DataSetTableAdapters.GradesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StudentPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentPicture
            // 
            this.StudentPicture.Location = new System.Drawing.Point(26, 26);
            this.StudentPicture.Name = "StudentPicture";
            this.StudentPicture.Size = new System.Drawing.Size(193, 230);
            this.StudentPicture.TabIndex = 0;
            this.StudentPicture.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(225, 26);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(150, 25);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Student NAme";
            // 
            // StudentIDLabel
            // 
            this.StudentIDLabel.AutoSize = true;
            this.StudentIDLabel.Location = new System.Drawing.Point(225, 68);
            this.StudentIDLabel.Name = "StudentIDLabel";
            this.StudentIDLabel.Size = new System.Drawing.Size(44, 25);
            this.StudentIDLabel.TabIndex = 3;
            this.StudentIDLabel.Text = "ID :";
            // 
            // BirthDate
            // 
            this.BirthDate.AutoSize = true;
            this.BirthDate.Location = new System.Drawing.Point(225, 107);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(119, 25);
            this.BirthDate.TabIndex = 4;
            this.BirthDate.Text = "Birth Date :";
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Location = new System.Drawing.Point(225, 148);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(97, 25);
            this.AdressLabel.TabIndex = 5;
            this.AdressLabel.Text = "Adress : ";
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.Location = new System.Drawing.Point(225, 192);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(64, 25);
            this.MailLabel.TabIndex = 6;
            this.MailLabel.Text = "Mail :";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(225, 231);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(92, 25);
            this.PhoneLabel.TabIndex = 7;
            this.PhoneLabel.Text = "Phone : ";
            // 
            // gradeTab
            // 
            this.gradeTab.AllowUserToAddRows = false;
            this.gradeTab.AllowUserToDeleteRows = false;
            this.gradeTab.AutoGenerateColumns = false;
            this.gradeTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradeTab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assessmentNameDataGridViewTextBoxColumn,
            this.studentGradeDataGridViewTextBoxColumn,
            this.coefficientDataGridViewTextBoxColumn,
            this.ClassAverage});
            this.gradeTab.DataSource = this.gradesBindingSource;
            this.gradeTab.Location = new System.Drawing.Point(26, 332);
            this.gradeTab.Name = "gradeTab";
            this.gradeTab.ReadOnly = true;
            this.gradeTab.RowHeadersWidth = 82;
            this.gradeTab.RowTemplate.Height = 33;
            this.gradeTab.Size = new System.Drawing.Size(887, 486);
            this.gradeTab.TabIndex = 8;
            // 
            // assessmentNameDataGridViewTextBoxColumn
            // 
            this.assessmentNameDataGridViewTextBoxColumn.DataPropertyName = "AssessmentName";
            this.assessmentNameDataGridViewTextBoxColumn.HeaderText = "AssessmentName";
            this.assessmentNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.assessmentNameDataGridViewTextBoxColumn.Name = "assessmentNameDataGridViewTextBoxColumn";
            this.assessmentNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // studentGradeDataGridViewTextBoxColumn
            // 
            this.studentGradeDataGridViewTextBoxColumn.DataPropertyName = "studentGrade";
            dataGridViewCellStyle5.NullValue = "Not Yet Graded";
            this.studentGradeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.studentGradeDataGridViewTextBoxColumn.HeaderText = "studentGrade";
            this.studentGradeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.studentGradeDataGridViewTextBoxColumn.Name = "studentGradeDataGridViewTextBoxColumn";
            this.studentGradeDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentGradeDataGridViewTextBoxColumn.Width = 200;
            // 
            // coefficientDataGridViewTextBoxColumn
            // 
            this.coefficientDataGridViewTextBoxColumn.DataPropertyName = "coefficient";
            this.coefficientDataGridViewTextBoxColumn.HeaderText = "coefficient";
            this.coefficientDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.coefficientDataGridViewTextBoxColumn.Name = "coefficientDataGridViewTextBoxColumn";
            this.coefficientDataGridViewTextBoxColumn.Width = 200;
            // 
            // ClassAverage
            // 
            this.ClassAverage.HeaderText = "Class Average";
            this.ClassAverage.MinimumWidth = 10;
            this.ClassAverage.Name = "ClassAverage";
            this.ClassAverage.Width = 200;
            // 
            // gradesBindingSource
            // 
            this.gradesBindingSource.DataMember = "Grades";
            this.gradesBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gradesTableAdapter
            // 
            this.gradesTableAdapter.ClearBeforeFill = true;
            // 
            // StudentInformationsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 830);
            this.Controls.Add(this.gradeTab);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.MailLabel);
            this.Controls.Add(this.AdressLabel);
            this.Controls.Add(this.BirthDate);
            this.Controls.Add(this.StudentIDLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.StudentPicture);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentInformationsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Informations";
            this.Load += new System.EventHandler(this.StudentInformationsWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox StudentPicture;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label StudentIDLabel;
        private System.Windows.Forms.Label BirthDate;
        private System.Windows.Forms.Label AdressLabel;
        private System.Windows.Forms.Label MailLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.DataGridView gradeTab;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource gradesBindingSource;
        private Database1DataSetTableAdapters.GradesTableAdapter gradesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn assessmentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coefficientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassAverage;
    }
}