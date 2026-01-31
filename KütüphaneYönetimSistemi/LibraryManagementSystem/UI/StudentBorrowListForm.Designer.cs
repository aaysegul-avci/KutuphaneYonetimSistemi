namespace Odev12.UI
{
    partial class StudentBorrowListForm
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
            dgvBorrows = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBorrows).BeginInit();
            SuspendLayout();
            // 
            // dgvBorrows
            // 
            dgvBorrows.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrows.Location = new Point(12, 12);
            dgvBorrows.Name = "dgvBorrows";
            dgvBorrows.Size = new Size(776, 426);
            dgvBorrows.TabIndex = 0;
            // 
            // StudentBorrowListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvBorrows);
            Name = "StudentBorrowListForm";
            Text = "StudentBorrowListForm";
            Load += StudentBorrowListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBorrows).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBorrows;
    }
}