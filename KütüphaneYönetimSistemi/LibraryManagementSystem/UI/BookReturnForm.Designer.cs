namespace Odev12.UI
{
    partial class BookReturnForm
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
            btnReturn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBorrows).BeginInit();
            SuspendLayout();
            // 
            // dgvBorrows
            // 
            dgvBorrows.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrows.Location = new Point(12, 12);
            dgvBorrows.Name = "dgvBorrows";
            dgvBorrows.Size = new Size(776, 397);
            dgvBorrows.TabIndex = 0;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(705, 415);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(83, 23);
            btnReturn.TabIndex = 1;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // BookReturnForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReturn);
            Controls.Add(dgvBorrows);
            Name = "BookReturnForm";
            Text = "BookReturnForm";
            Load += BookReturnForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBorrows).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBorrows;
        private Button btnReturn;
    }
}