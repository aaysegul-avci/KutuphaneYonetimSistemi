
namespace Odev12.UI
{
    partial class StaffForms
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
            btnApproval = new Button();
            btnDeliver = new Button();
            button1 = new Button();
            Admin = new Label();
            SuspendLayout();
            // 
            // btnApproval
            // 
            btnApproval.Location = new Point(106, 273);
            btnApproval.Name = "btnApproval";
            btnApproval.Size = new Size(85, 46);
            btnApproval.TabIndex = 0;
            btnApproval.Text = "Approve";
            btnApproval.UseVisualStyleBackColor = true;
            btnApproval.Click += btnApproval_Click;
            // 
            // btnDeliver
            // 
            btnDeliver.Location = new Point(197, 273);
            btnDeliver.Name = "btnDeliver";
            btnDeliver.Size = new Size(85, 46);
            btnDeliver.TabIndex = 1;
            btnDeliver.Text = "Deliver";
            btnDeliver.UseVisualStyleBackColor = true;
            btnDeliver.Click += btnDeliver_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 273);
            button1.Name = "button1";
            button1.Size = new Size(85, 46);
            button1.TabIndex = 2;
            button1.Text = "Report";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnReport_Click;
            // 
            // Admin
            // 
            Admin.AutoSize = true;
            Admin.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Admin.Location = new Point(106, 61);
            Admin.Name = "Admin";
            Admin.Size = new Size(62, 32);
            Admin.TabIndex = 4;
            Admin.Text = "Staff";
            Admin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StaffForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 361);
            Controls.Add(Admin);
            Controls.Add(button1);
            Controls.Add(btnDeliver);
            Controls.Add(btnApproval);
            Name = "StaffForms";
            Text = "StaffForms";
            Load += StaffForms_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button btnApproval;
        private Button btnDeliver;
        private Button button1;
        private Label Admin;
    }
}