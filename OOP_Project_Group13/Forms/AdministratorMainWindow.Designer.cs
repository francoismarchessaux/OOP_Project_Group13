namespace OOP_Project_Group13
{
    partial class AdministratorMainWindow
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
            this.AdminName_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminPP_PictureBox = new System.Windows.Forms.PictureBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.AdminID_Label = new System.Windows.Forms.Label();
            this.CreateStudentButton = new System.Windows.Forms.Button();
            this.StudentList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateCourseButton = new System.Windows.Forms.Button();
            this.ManageCourseButton = new System.Windows.Forms.Button();
            this.CreateClassButton = new System.Windows.Forms.Button();
            this.ManageClassButton = new System.Windows.Forms.Button();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AdminPP_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminName_Label
            // 
            this.AdminName_Label.AutoSize = true;
            this.AdminName_Label.Location = new System.Drawing.Point(242, 39);
            this.AdminName_Label.Name = "AdminName_Label";
            this.AdminName_Label.Size = new System.Drawing.Size(200, 25);
            this.AdminName_Label.TabIndex = 0;
            this.AdminName_Label.Text = "Administrator Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hi ";
            // 
            // AdminPP_PictureBox
            // 
            this.AdminPP_PictureBox.ImageLocation = "";
            this.AdminPP_PictureBox.Location = new System.Drawing.Point(25, 39);
            this.AdminPP_PictureBox.Name = "AdminPP_PictureBox";
            this.AdminPP_PictureBox.Size = new System.Drawing.Size(175, 160);
            this.AdminPP_PictureBox.TabIndex = 3;
            this.AdminPP_PictureBox.TabStop = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(210, 80);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(50, 25);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "ID : ";
            // 
            // AdminID_Label
            // 
            this.AdminID_Label.AutoSize = true;
            this.AdminID_Label.Location = new System.Drawing.Point(258, 80);
            this.AdminID_Label.Name = "AdminID_Label";
            this.AdminID_Label.Size = new System.Drawing.Size(98, 25);
            this.AdminID_Label.TabIndex = 5;
            this.AdminID_Label.Text = "Admin ID";
            // 
            // CreateStudentButton
            // 
            this.CreateStudentButton.Location = new System.Drawing.Point(25, 284);
            this.CreateStudentButton.Name = "CreateStudentButton";
            this.CreateStudentButton.Size = new System.Drawing.Size(175, 48);
            this.CreateStudentButton.TabIndex = 6;
            this.CreateStudentButton.Text = "Create Student";
            this.CreateStudentButton.UseVisualStyleBackColor = true;
            this.CreateStudentButton.Click += new System.EventHandler(this.CreateStudentButton_Click);
            // 
            // StudentList
            // 
            this.StudentList.FormattingEnabled = true;
            this.StudentList.Location = new System.Drawing.Point(25, 386);
            this.StudentList.Name = "StudentList";
            this.StudentList.Size = new System.Drawing.Size(313, 33);
            this.StudentList.TabIndex = 7;
            this.StudentList.Text = "Select Student ...";
            this.StudentList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Manage Student";
            // 
            // CreateCourseButton
            // 
            this.CreateCourseButton.Location = new System.Drawing.Point(383, 284);
            this.CreateCourseButton.Name = "CreateCourseButton";
            this.CreateCourseButton.Size = new System.Drawing.Size(175, 48);
            this.CreateCourseButton.TabIndex = 9;
            this.CreateCourseButton.Text = "Create Course";
            this.CreateCourseButton.UseVisualStyleBackColor = true;
            // 
            // ManageCourseButton
            // 
            this.ManageCourseButton.Location = new System.Drawing.Point(383, 358);
            this.ManageCourseButton.Name = "ManageCourseButton";
            this.ManageCourseButton.Size = new System.Drawing.Size(175, 76);
            this.ManageCourseButton.TabIndex = 10;
            this.ManageCourseButton.Text = "Manage Courses";
            this.ManageCourseButton.UseVisualStyleBackColor = true;
            // 
            // CreateClassButton
            // 
            this.CreateClassButton.Location = new System.Drawing.Point(611, 284);
            this.CreateClassButton.Name = "CreateClassButton";
            this.CreateClassButton.Size = new System.Drawing.Size(175, 48);
            this.CreateClassButton.TabIndex = 11;
            this.CreateClassButton.Text = "Create Class";
            this.CreateClassButton.UseVisualStyleBackColor = true;
            // 
            // ManageClassButton
            // 
            this.ManageClassButton.Location = new System.Drawing.Point(611, 358);
            this.ManageClassButton.Name = "ManageClassButton";
            this.ManageClassButton.Size = new System.Drawing.Size(175, 76);
            this.ManageClassButton.TabIndex = 12;
            this.ManageClassButton.Text = "Manage Classes";
            this.ManageClassButton.UseVisualStyleBackColor = true;
            // 
            // database1DataSet
            // 
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            // 
            // usersTableAdapter
            // 
            // 
            // AdministratorMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 446);
            this.Controls.Add(this.ManageClassButton);
            this.Controls.Add(this.CreateClassButton);
            this.Controls.Add(this.ManageCourseButton);
            this.Controls.Add(this.CreateCourseButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StudentList);
            this.Controls.Add(this.CreateStudentButton);
            this.Controls.Add(this.AdminID_Label);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.AdminPP_PictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminName_Label);
            this.Location = new System.Drawing.Point(200, 100);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministratorMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.AdministratorMainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdminPP_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdminName_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox AdminPP_PictureBox;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label AdminID_Label;
        private System.Windows.Forms.Button CreateStudentButton;
        private System.Windows.Forms.ComboBox StudentList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CreateCourseButton;
        private System.Windows.Forms.Button ManageCourseButton;
        private System.Windows.Forms.Button CreateClassButton;
        private System.Windows.Forms.Button ManageClassButton;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource;
    }
}