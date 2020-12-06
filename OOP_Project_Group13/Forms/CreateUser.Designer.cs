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
            this.Label1.Location = new System.Drawing.Point(93, 38);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(98, 20);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Last Name : ";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(93, 83);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(98, 20);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "First Name : ";
            // 
            // LastName_TxtBox
            // 
            this.LastName_TxtBox.Location = new System.Drawing.Point(198, 38);
            this.LastName_TxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LastName_TxtBox.Name = "LastName_TxtBox";
            this.LastName_TxtBox.Size = new System.Drawing.Size(129, 26);
            this.LastName_TxtBox.TabIndex = 3;
            // 
            // FirstName_TxtBox
            // 
            this.FirstName_TxtBox.Location = new System.Drawing.Point(199, 83);
            this.FirstName_TxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FirstName_TxtBox.Name = "FirstName_TxtBox";
            this.FirstName_TxtBox.Size = new System.Drawing.Size(128, 26);
            this.FirstName_TxtBox.TabIndex = 4;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(97, 142);
            this.CreateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(96, 32);
            this.CreateButton.TabIndex = 6;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(230, 142);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(96, 32);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 202);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.FirstName_TxtBox);
            this.Controls.Add(this.LastName_TxtBox);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New User";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CreateUser_Load);
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