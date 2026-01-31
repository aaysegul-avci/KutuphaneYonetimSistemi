namespace Odev12.UI
{
    partial class StaffDeliverForm
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
            btnDeliver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBorrows).BeginInit();
            SuspendLayout();
            // 
            // dgvBorrows
            // 
            dgvBorrows.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrows.Location = new Point(12, 12);
            dgvBorrows.Name = "dgvBorrows";
            dgvBorrows.Size = new Size(776, 391);
            dgvBorrows.TabIndex = 0;
            // 
            // btnDeliver
            // 
            btnDeliver.Location = new Point(713, 415);
            btnDeliver.Name = "btnDeliver";
            btnDeliver.Size = new Size(75, 23);
            btnDeliver.TabIndex = 1;
            btnDeliver.Text = "Deliver";
            btnDeliver.UseVisualStyleBackColor = true;
            btnDeliver.Click += btnDeliver_Click;
            // 
            // StaffDeliverForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeliver);
            Controls.Add(dgvBorrows);
            Name = "StaffDeliverForm";
            Text = "StaffDeliverForm";
            Load += StaffDeliverForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBorrows).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBorrows;
        private Button btnDeliver;
    }
}