namespace OOP_Project_Group13.Forms
{
    partial class FirstConWin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pswrd1 = new System.Windows.Forms.TextBox();
            this.pswrd2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "This is your first connection on your account.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please choose a new password.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(401, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "The password must match the following :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter new password : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Confirm new password : ";
            // 
            // pswrd1
            // 
            this.pswrd1.Location = new System.Drawing.Point(280, 262);
            this.pswrd1.Name = "pswrd1";
            this.pswrd1.PasswordChar = '*';
            this.pswrd1.Size = new System.Drawing.Size(338, 31);
            this.pswrd1.TabIndex = 5;
            // 
            // pswrd2
            // 
            this.pswrd2.Location = new System.Drawing.Point(280, 317);
            this.pswrd2.Name = "pswrd2";
            this.pswrd2.PasswordChar = '*';
            this.pswrd2.Size = new System.Drawing.Size(338, 31);
            this.pswrd2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(512, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "- Must contain at least 1 uppercase and 1 lowercase";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(518, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "- Must contain at least 1 digit and 1 special character";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(350, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "- Must be at least 8 characters long";
            // 
            // FirstConWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 442);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pswrd2);
            this.Controls.Add(this.pswrd1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FirstConWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirstConWin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pswrd1;
        private System.Windows.Forms.TextBox pswrd2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}