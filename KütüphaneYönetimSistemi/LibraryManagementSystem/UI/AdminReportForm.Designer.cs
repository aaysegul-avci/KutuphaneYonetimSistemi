namespace Odev12.UI
{
    partial class AdminReportForm
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
            dgvMostBorrowed = new DataGridView();
            dgvAllBorrows = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblDaily = new Label();
            label5 = new Label();
            lblWeekly = new Label();
            lblMonthly = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMostBorrowed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAllBorrows).BeginInit();
            SuspendLayout();
            // 
            // dgvMostBorrowed
            // 
            dgvMostBorrowed.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMostBorrowed.Location = new Point(12, 176);
            dgvMostBorrowed.Name = "dgvMostBorrowed";
            dgvMostBorrowed.Size = new Size(301, 363);
            dgvMostBorrowed.TabIndex = 0;
            // 
            // dgvAllBorrows
            // 
            dgvAllBorrows.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllBorrows.Location = new Point(319, 176);
            dgvAllBorrows.Name = "dgvAllBorrows";
            dgvAllBorrows.Size = new Size(614, 363);
            dgvAllBorrows.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 146);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 2;
            label1.Text = "Most Borrowed:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(319, 146);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 3;
            label2.Text = "All Borrows:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 18);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 4;
            label3.Text = "Daily Borrows";
            // 
            // lblDaily
            // 
            lblDaily.AutoSize = true;
            lblDaily.Location = new Point(130, 18);
            lblDaily.Name = "lblDaily";
            lblDaily.Size = new Size(0, 15);
            lblDaily.TabIndex = 5;
            lblDaily.Click += lblDaily_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 44);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 6;
            label5.Text = "Weekly Borrows";
            // 
            // lblWeekly
            // 
            lblWeekly.AutoSize = true;
            lblWeekly.Location = new Point(130, 44);
            lblWeekly.Name = "lblWeekly";
            lblWeekly.Size = new Size(0, 15);
            lblWeekly.TabIndex = 7;
            // 
            // lblMonthly
            // 
            lblMonthly.AutoSize = true;
            lblMonthly.Location = new Point(130, 71);
            lblMonthly.Name = "lblMonthly";
            lblMonthly.Size = new Size(0, 15);
            lblMonthly.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 71);
            label8.Name = "label8";
            label8.Size = new Size(98, 15);
            label8.TabIndex = 8;
            label8.Text = "Monthly Borrows";
            // 
            // AdminReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 551);
            Controls.Add(lblMonthly);
            Controls.Add(label8);
            Controls.Add(lblWeekly);
            Controls.Add(label5);
            Controls.Add(lblDaily);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvAllBorrows);
            Controls.Add(dgvMostBorrowed);
            Name = "AdminReportForm";
            Text = "AdminReportForm";
            Load += AdminReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMostBorrowed).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAllBorrows).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMostBorrowed;
        private DataGridView dgvAllBorrows;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblDaily;
        private Label label5;
        private Label lblWeekly;
        private Label lblMonthly;
        private Label label8;
    }
}