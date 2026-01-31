namespace Odev12.UI
{
    partial class AdminForms
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
            Users = new Button();
            btnReport = new Button();
            button1 = new Button();
            Admin = new Label();
            SuspendLayout();
            // 
            // Users
            // 
            Users.Location = new Point(105, 272);
            Users.Name = "Users";
            Users.Size = new Size(87, 43);
            Users.TabIndex = 0;
            Users.Text = "Users";
            Users.UseVisualStyleBackColor = true;
            Users.Click += btnUsers_Click;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(12, 272);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(87, 43);
            btnReport.TabIndex = 1;
            btnReport.Text = "Report";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // button1
            // 
            button1.Location = new Point(198, 272);
            button1.Name = "button1";
            button1.Size = new Size(87, 43);
            button1.TabIndex = 2;
            button1.Text = "Books";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnBooks_Click;
            // 
            // Admin
            // 
            Admin.AutoSize = true;
            Admin.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Admin.Location = new Point(105, 59);
            Admin.Name = "Admin";
            Admin.Size = new Size(84, 32);
            Admin.TabIndex = 3;
            Admin.Text = "Admin";
            Admin.TextAlign = ContentAlignment.MiddleCenter;
            Admin.Click += label1_Click;
            // 
            // AdminForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 361);
            Controls.Add(Admin);
            Controls.Add(button1);
            Controls.Add(btnReport);
            Controls.Add(Users);
            Name = "AdminForms";
            Text = "AdminForms";
            Load += AdminForms_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Users;
        private Button btnReport;
        private Button button1;
        private Label Admin;
    }
}