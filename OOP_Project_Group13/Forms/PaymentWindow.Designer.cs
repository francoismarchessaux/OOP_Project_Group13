
namespace OOP_Project_Group13.Forms
{
    partial class PaymentWindow
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
            this.BackButton = new System.Windows.Forms.Button();
            this.Payment = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Balance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPayment = new System.Windows.Forms.Panel();
            this.deptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(9, 240);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(52, 26);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Payment
            // 
            this.Payment.Location = new System.Drawing.Point(131, 174);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(84, 38);
            this.Payment.TabIndex = 1;
            this.Payment.Text = "Proceed Payment";
            this.Payment.UseVisualStyleBackColor = true;
            this.Payment.Click += new System.EventHandler(this.Payment_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.Location = new System.Drawing.Point(12, 61);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(98, 13);
            this.Balance.TabIndex = 4;
            this.Balance.Text = "You currently owe :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please, fill the following box with the amount you\'d like to pay :";
            // 
            // panelPayment
            // 
            this.panelPayment.Location = new System.Drawing.Point(0, 0);
            this.panelPayment.Name = "panelPayment";
            this.panelPayment.Size = new System.Drawing.Size(357, 47);
            this.panelPayment.TabIndex = 7;
            // 
            // deptLabel
            // 
            this.deptLabel.AutoSize = true;
            this.deptLabel.Location = new System.Drawing.Point(116, 61);
            this.deptLabel.Name = "deptLabel";
            this.deptLabel.Size = new System.Drawing.Size(28, 13);
            this.deptLabel.TabIndex = 8;
            this.deptLabel.Text = "dept";
            // 
            // PaymentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(358, 275);
            this.Controls.Add(this.deptLabel);
            this.Controls.Add(this.panelPayment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.BackButton);
            this.Name = "PaymentWindow";
            this.Text = "PaymentWindow";
            this.Load += new System.EventHandler(this.PaymentWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button Payment;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelPayment;
        private System.Windows.Forms.Label deptLabel;
    }
}