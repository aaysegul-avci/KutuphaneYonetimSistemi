namespace Odev12.UI
{
    partial class StaffDailyReportForm
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
            label1 = new Label();
            dgvTodayBorrows = new DataGridView();
            dgvReturns = new DataGridView();
            dgvLate = new DataGridView();
            lblTodayBorrowCount = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTodayBorrows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReturns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLate).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 0;
            label1.Text = "Today Borrow Count: ";
            label1.Click += label1_Click;
            // 
            // dgvTodayBorrows
            // 
            dgvTodayBorrows.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTodayBorrows.Location = new Point(12, 53);
            dgvTodayBorrows.Name = "dgvTodayBorrows";
            dgvTodayBorrows.Size = new Size(607, 565);
            dgvTodayBorrows.TabIndex = 1;
            // 
            // dgvReturns
            // 
            dgvReturns.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReturns.Location = new Point(640, 53);
            dgvReturns.Name = "dgvReturns";
            dgvReturns.Size = new Size(682, 285);
            dgvReturns.TabIndex = 2;
            // 
            // dgvLate
            // 
            dgvLate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLate.Location = new Point(640, 381);
            dgvLate.Name = "dgvLate";
            dgvLate.Size = new Size(682, 237);
            dgvLate.TabIndex = 3;
            // 
            // lblTodayBorrowCount
            // 
            lblTodayBorrowCount.AutoSize = true;
            lblTodayBorrowCount.Location = new Point(139, 20);
            lblTodayBorrowCount.Name = "lblTodayBorrowCount";
            lblTodayBorrowCount.Size = new Size(0, 15);
            lblTodayBorrowCount.TabIndex = 4;
            lblTodayBorrowCount.Click += lblTodayBorrowCount_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(640, 20);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 5;
            label2.Text = "Returns:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(640, 351);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 6;
            label3.Text = "Late:";
            label3.Click += label3_Click;
            // 
            // StaffDailyReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 630);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblTodayBorrowCount);
            Controls.Add(dgvLate);
            Controls.Add(dgvReturns);
            Controls.Add(dgvTodayBorrows);
            Controls.Add(label1);
            Name = "StaffDailyReportForm";
            Text = "StaffDailyReportForm";
            Load += StaffDailyReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTodayBorrows).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReturns).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvTodayBorrows;
        private DataGridView dgvReturns;
        private DataGridView dgvLate;
        private Label lblTodayBorrowCount;
        private Label label2;
        private Label label3;
    }
}