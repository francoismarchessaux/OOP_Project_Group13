namespace OOP_Project_Group13
{
    partial class FacultyHomePage
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
            this.labelNom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonClasses = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(56, 42);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(90, 17);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom Prenom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time Table :";
            // 
            // buttonClasses
            // 
            this.buttonClasses.Location = new System.Drawing.Point(59, 370);
            this.buttonClasses.Name = "buttonClasses";
            this.buttonClasses.Size = new System.Drawing.Size(149, 39);
            this.buttonClasses.TabIndex = 3;
            this.buttonClasses.Text = "Show classes";
            this.buttonClasses.UseVisualStyleBackColor = true;
            this.buttonClasses.Click += new System.EventHandler(this.buttonClasses_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(59, 154);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(596, 195);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FacultyHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonClasses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNom);
            this.Name = "FacultyHomePage";
            this.Text = "FacultyHomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonClasses;
        private System.Windows.Forms.ListView listView1;
    }
} 