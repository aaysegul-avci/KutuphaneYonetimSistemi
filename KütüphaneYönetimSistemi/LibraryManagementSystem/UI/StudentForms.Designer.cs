namespace Odev12.UI
{
    partial class StudentForms
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
            btnBooks = new Button();
            btnReturn = new Button();
            Admin = new Label();
            SuspendLayout();
            // 
            // btnBooks
            // 
            btnBooks.Location = new Point(12, 254);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(127, 58);
            btnBooks.TabIndex = 0;
            btnBooks.Text = "Books";
            btnBooks.UseVisualStyleBackColor = true;
            btnBooks.Click += btnBooks_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(155, 254);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(127, 58);
            btnReturn.TabIndex = 2;
            btnReturn.Text = "Return Books";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturns_Click;
            // 
            // Admin
            // 
            Admin.AutoSize = true;
            Admin.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Admin.Location = new Point(98, 73);
            Admin.Name = "Admin";
            Admin.Size = new Size(97, 32);
            Admin.TabIndex = 4;
            Admin.Text = "Student";
            Admin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StudentForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 361);
            Controls.Add(Admin);
            Controls.Add(btnReturn);
            Controls.Add(btnBooks);
            Name = "StudentForms";
            Text = "StudentForms";
            Load += StudentForms_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBooks;
        private Button btnReturn;
        private Label Admin;
    }
}