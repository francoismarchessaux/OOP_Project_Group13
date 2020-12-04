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
            this.CreateClassButton = new System.Windows.Forms.Button();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.TeacherList = new System.Windows.Forms.ComboBox();
            this.CreateTeacherBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ClassesList = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AdminPP_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminName_Label
            // 
            this.AdminName_Label.AutoSize = true;
            this.AdminName_Label.Location = new System.Drawing.Point(242, 38);
            this.AdminName_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdminName_Label.Name = "AdminName_Label";
            this.AdminName_Label.Size = new System.Drawing.Size(200, 25);
            this.AdminName_Label.TabIndex = 0;
            this.AdminName_Label.Text = "Administrator Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hi ";
            // 
            // AdminPP_PictureBox
            // 
            this.AdminPP_PictureBox.ImageLocation = "";
            this.AdminPP_PictureBox.Location = new System.Drawing.Point(24, 38);
            this.AdminPP_PictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.AdminPP_PictureBox.Name = "AdminPP_PictureBox";
            this.AdminPP_PictureBox.Size = new System.Drawing.Size(176, 160);
            this.AdminPP_PictureBox.TabIndex = 3;
            this.AdminPP_PictureBox.TabStop = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(210, 81);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(50, 25);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "ID : ";
            // 
            // AdminID_Label
            // 
            this.AdminID_Label.AutoSize = true;
            this.AdminID_Label.Location = new System.Drawing.Point(258, 81);
            this.AdminID_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdminID_Label.Name = "AdminID_Label";
            this.AdminID_Label.Size = new System.Drawing.Size(98, 25);
            this.AdminID_Label.TabIndex = 5;
            this.AdminID_Label.Text = "Admin ID";
            // 
            // CreateStudentButton
            // 
            this.CreateStudentButton.Location = new System.Drawing.Point(24, 269);
            this.CreateStudentButton.Margin = new System.Windows.Forms.Padding(4);
            this.CreateStudentButton.Name = "CreateStudentButton";
            this.CreateStudentButton.Size = new System.Drawing.Size(176, 48);
            this.CreateStudentButton.TabIndex = 6;
            this.CreateStudentButton.Text = "Create Student";
            this.CreateStudentButton.UseVisualStyleBackColor = true;
            this.CreateStudentButton.Click += new System.EventHandler(this.CreateStudentButton_Click);
            // 
            // StudentList
            // 
            this.StudentList.FormattingEnabled = true;
            this.StudentList.Location = new System.Drawing.Point(24, 387);
            this.StudentList.Margin = new System.Windows.Forms.Padding(4);
            this.StudentList.Name = "StudentList";
            this.StudentList.Size = new System.Drawing.Size(312, 33);
            this.StudentList.TabIndex = 7;
            this.StudentList.Text = "Select Student ...";
            this.StudentList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 358);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Manage Student";
            // 
            // CreateClassButton
            // 
            this.CreateClassButton.Location = new System.Drawing.Point(816, 269);
            this.CreateClassButton.Margin = new System.Windows.Forms.Padding(4);
            this.CreateClassButton.Name = "CreateClassButton";
            this.CreateClassButton.Size = new System.Drawing.Size(176, 48);
            this.CreateClassButton.TabIndex = 11;
            this.CreateClassButton.Text = "Create Class";
            this.CreateClassButton.UseVisualStyleBackColor = true;
            this.CreateClassButton.Click += new System.EventHandler(this.CreateClassButton_Click);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 358);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Manage Teacher";
            // 
            // TeacherList
            // 
            this.TeacherList.FormattingEnabled = true;
            this.TeacherList.Location = new System.Drawing.Point(408, 387);
            this.TeacherList.Margin = new System.Windows.Forms.Padding(4);
            this.TeacherList.Name = "TeacherList";
            this.TeacherList.Size = new System.Drawing.Size(312, 33);
            this.TeacherList.TabIndex = 14;
            this.TeacherList.Text = "Select Teacher ...";
            this.TeacherList.SelectedIndexChanged += new System.EventHandler(this.TeacherList_SelectedIndexChanged_1);
            // 
            // CreateTeacherBtn
            // 
            this.CreateTeacherBtn.Location = new System.Drawing.Point(408, 269);
            this.CreateTeacherBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CreateTeacherBtn.Name = "CreateTeacherBtn";
            this.CreateTeacherBtn.Size = new System.Drawing.Size(204, 48);
            this.CreateTeacherBtn.TabIndex = 13;
            this.CreateTeacherBtn.Text = "Create Teacher";
            this.CreateTeacherBtn.UseVisualStyleBackColor = true;
            this.CreateTeacherBtn.Click += new System.EventHandler(this.CreateTeacherBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(812, 358);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Manage Classes";
            // 
            // ClassesList
            // 
            this.ClassesList.FormattingEnabled = true;
            this.ClassesList.Location = new System.Drawing.Point(816, 387);
            this.ClassesList.Margin = new System.Windows.Forms.Padding(4);
            this.ClassesList.Name = "ClassesList";
            this.ClassesList.Size = new System.Drawing.Size(312, 33);
            this.ClassesList.TabIndex = 16;
            this.ClassesList.Text = "Select Class ...";
            this.ClassesList.SelectedIndexChanged += new System.EventHandler(this.ClassesList_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 461);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 42);
            this.button1.TabIndex = 18;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 461);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 42);
            this.button2.TabIndex = 19;
            this.button2.Text = "Log Out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(208, 156);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 42);
            this.button3.TabIndex = 20;
            this.button3.Text = "Modify profile";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AdministratorMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 516);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ClassesList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TeacherList);
            this.Controls.Add(this.CreateTeacherBtn);
            this.Controls.Add(this.CreateClassButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StudentList);
            this.Controls.Add(this.CreateStudentButton);
            this.Controls.Add(this.AdminID_Label);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.AdminPP_PictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminName_Label);
            this.Location = new System.Drawing.Point(200, 100);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button CreateClassButton;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TeacherList;
        private System.Windows.Forms.Button CreateTeacherBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ClassesList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}