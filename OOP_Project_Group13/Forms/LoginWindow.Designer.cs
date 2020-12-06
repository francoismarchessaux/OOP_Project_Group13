namespace OOP_Project_Group13
{
    partial class LoginWindow
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
            this.userID_TextBox = new System.Windows.Forms.TextBox();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.userID_Label = new System.Windows.Forms.Label();
            this.password_Label = new System.Windows.Forms.Label();
            this.logIn_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userID_TextBox
            // 
            this.userID_TextBox.Location = new System.Drawing.Point(191, 41);
            this.userID_TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userID_TextBox.Name = "userID_TextBox";
            this.userID_TextBox.Size = new System.Drawing.Size(113, 26);
            this.userID_TextBox.TabIndex = 0;
            // 
            // password_TextBox
            // 
            this.password_TextBox.Location = new System.Drawing.Point(191, 92);
            this.password_TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.PasswordChar = '*';
            this.password_TextBox.Size = new System.Drawing.Size(113, 26);
            this.password_TextBox.TabIndex = 1;
            this.password_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_TextBox_KeyPress);
            // 
            // userID_Label
            // 
            this.userID_Label.AutoSize = true;
            this.userID_Label.Location = new System.Drawing.Point(72, 41);
            this.userID_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userID_Label.Name = "userID_Label";
            this.userID_Label.Size = new System.Drawing.Size(69, 20);
            this.userID_Label.TabIndex = 2;
            this.userID_Label.Text = "user ID :";
            // 
            // password_Label
            // 
            this.password_Label.AutoSize = true;
            this.password_Label.Location = new System.Drawing.Point(52, 92);
            this.password_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password_Label.Name = "password_Label";
            this.password_Label.Size = new System.Drawing.Size(86, 20);
            this.password_Label.TabIndex = 3;
            this.password_Label.Text = "Password :";
            // 
            // logIn_Button
            // 
            this.logIn_Button.Location = new System.Drawing.Point(218, 138);
            this.logIn_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logIn_Button.Name = "logIn_Button";
            this.logIn_Button.Size = new System.Drawing.Size(85, 33);
            this.logIn_Button.TabIndex = 4;
            this.logIn_Button.Text = "Log In";
            this.logIn_Button.UseVisualStyleBackColor = true;
            this.logIn_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 181);
            this.Controls.Add(this.logIn_Button);
            this.Controls.Add(this.password_Label);
            this.Controls.Add(this.userID_Label);
            this.Controls.Add(this.password_TextBox);
            this.Controls.Add(this.userID_TextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.LoginWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userID_TextBox;
        private System.Windows.Forms.TextBox password_TextBox;
        private System.Windows.Forms.Label userID_Label;
        private System.Windows.Forms.Label password_Label;
        private System.Windows.Forms.Button logIn_Button;
    }
}