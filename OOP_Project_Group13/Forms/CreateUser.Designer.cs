namespace OOP_Project_Group13.Forms
{
    partial class CreateUser
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
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.LastName_TxtBox = new System.Windows.Forms.TextBox();
            this.FirstName_TxtBox = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(124, 47);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(133, 25);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Last Name : ";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(124, 104);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(134, 25);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "First Name : ";
            // 
            // LastName_TxtBox
            // 
            this.LastName_TxtBox.Location = new System.Drawing.Point(264, 47);
            this.LastName_TxtBox.Name = "LastName_TxtBox";
            this.LastName_TxtBox.Size = new System.Drawing.Size(171, 31);
            this.LastName_TxtBox.TabIndex = 3;
            // 
            // FirstName_TxtBox
            // 
            this.FirstName_TxtBox.Location = new System.Drawing.Point(265, 104);
            this.FirstName_TxtBox.Name = "FirstName_TxtBox";
            this.FirstName_TxtBox.Size = new System.Drawing.Size(170, 31);
            this.FirstName_TxtBox.TabIndex = 4;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(129, 177);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(128, 40);
            this.CreateButton.TabIndex = 6;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(307, 177);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(128, 40);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CreateStudentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 252);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.FirstName_TxtBox);
            this.Controls.Add(this.LastName_TxtBox);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateStudentWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New User";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox LastName_TxtBox;
        private System.Windows.Forms.TextBox FirstName_TxtBox;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button BackButton;
    }
}