namespace OOP_Project_Group13.Forms
{
    partial class FacultyInformationsWindows
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
            this.teacherPicture = new System.Windows.Forms.PictureBox();
            this.TeacherName = new System.Windows.Forms.Label();
            this.teacherID = new System.Windows.Forms.Label();
            this.TeacherMail = new System.Windows.Forms.Label();
            this.TeacherPhone = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teacherPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // teacherPicture
            // 
            this.teacherPicture.Location = new System.Drawing.Point(26, 26);
            this.teacherPicture.Name = "teacherPicture";
            this.teacherPicture.Size = new System.Drawing.Size(200, 265);
            this.teacherPicture.TabIndex = 0;
            this.teacherPicture.TabStop = false;
            // 
            // TeacherName
            // 
            this.TeacherName.AutoSize = true;
            this.TeacherName.Location = new System.Drawing.Point(246, 26);
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.Size = new System.Drawing.Size(153, 25);
            this.TeacherName.TabIndex = 1;
            this.TeacherName.Text = "Teacher Name";
            // 
            // teacherID
            // 
            this.teacherID.AutoSize = true;
            this.teacherID.Location = new System.Drawing.Point(246, 70);
            this.teacherID.Name = "teacherID";
            this.teacherID.Size = new System.Drawing.Size(117, 25);
            this.teacherID.TabIndex = 2;
            this.teacherID.Text = "Teacher ID";
            // 
            // TeacherMail
            // 
            this.TeacherMail.AutoSize = true;
            this.TeacherMail.Location = new System.Drawing.Point(246, 118);
            this.TeacherMail.Name = "TeacherMail";
            this.TeacherMail.Size = new System.Drawing.Size(136, 25);
            this.TeacherMail.TabIndex = 3;
            this.TeacherMail.Text = "Teacher mail";
            // 
            // TeacherPhone
            // 
            this.TeacherPhone.AutoSize = true;
            this.TeacherPhone.Location = new System.Drawing.Point(246, 168);
            this.TeacherPhone.Name = "TeacherPhone";
            this.TeacherPhone.Size = new System.Drawing.Size(157, 25);
            this.TeacherPhone.TabIndex = 4;
            this.TeacherPhone.Text = "Teacher phone";
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(845, 669);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(119, 39);
            this.BackBtn.TabIndex = 5;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // FacultyInformationsWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 730);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.TeacherPhone);
            this.Controls.Add(this.TeacherMail);
            this.Controls.Add(this.teacherID);
            this.Controls.Add(this.TeacherName);
            this.Controls.Add(this.teacherPicture);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FacultyInformationsWindows";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faculty Informations";
            this.Load += new System.EventHandler(this.FacultyInformationsWindows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teacherPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox teacherPicture;
        private System.Windows.Forms.Label TeacherName;
        private System.Windows.Forms.Label teacherID;
        private System.Windows.Forms.Label TeacherMail;
        private System.Windows.Forms.Label TeacherPhone;
        private System.Windows.Forms.Button BackBtn;
    }
}