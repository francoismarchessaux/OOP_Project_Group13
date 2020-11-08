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
            this.panelTT = new System.Windows.Forms.Panel();
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
            this.buttonClasses.Location = new System.Drawing.Point(59, 579);
            this.buttonClasses.Name = "buttonClasses";
            this.buttonClasses.Size = new System.Drawing.Size(149, 39);
            this.buttonClasses.TabIndex = 3;
            this.buttonClasses.Text = "Show classes";
            this.buttonClasses.UseVisualStyleBackColor = true;
            this.buttonClasses.Click += new System.EventHandler(this.buttonClasses_Click);
            // 
            // panelTT
            // 
            this.panelTT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelTT.Location = new System.Drawing.Point(59, 147);
            this.panelTT.Name = "panelTT";
            this.panelTT.Size = new System.Drawing.Size(1241, 426);
            this.panelTT.TabIndex = 4;
            // 
            // FacultyHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 638);
            this.Controls.Add(this.panelTT);
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
        private System.Windows.Forms.Panel panelTT;
    }
} 