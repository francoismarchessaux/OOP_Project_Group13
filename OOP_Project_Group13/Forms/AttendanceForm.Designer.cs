namespace OOP_Project_Group13.Forms
{
    partial class AttendanceForm
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
            this.panelAttendance = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.Modify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelAttendance
            // 
            this.panelAttendance.AutoScroll = true;
            this.panelAttendance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelAttendance.Location = new System.Drawing.Point(59, 85);
            this.panelAttendance.Name = "panelAttendance";
            this.panelAttendance.Size = new System.Drawing.Size(699, 317);
            this.panelAttendance.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(59, 49);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(88, 17);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "courseName";
            // 
            // buttonValidate
            // 
            this.buttonValidate.Location = new System.Drawing.Point(59, 408);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(104, 35);
            this.buttonValidate.TabIndex = 2;
            this.buttonValidate.Text = "Validate";
            this.buttonValidate.UseVisualStyleBackColor = true;
            //this.buttonValidate.Click += new System.EventHandler(this.buttonValidate_Click);
            // 
            // Modify
            // 
            this.Modify.Location = new System.Drawing.Point(654, 408);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(104, 35);
            this.Modify.TabIndex = 3;
            this.Modify.Text = "Modify";
            this.Modify.UseVisualStyleBackColor = true;
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 518);
            this.Controls.Add(this.Modify);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.panelAttendance);
            this.Name = "AttendanceForm";
            this.Text = "AttendanceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAttendance;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.Button Modify;
    }
}