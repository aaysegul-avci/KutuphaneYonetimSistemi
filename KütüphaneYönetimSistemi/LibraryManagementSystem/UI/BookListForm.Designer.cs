namespace Odev12.UI
{
    partial class BookListForm
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
            dgvBooks = new DataGridView();
            txtSearch = new TextBox();
            cmbSearchType = new ComboBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(12, 67);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.Size = new Size(776, 371);
            dgvBooks.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(222, 28);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(322, 23);
            txtSearch.TabIndex = 1;
            // 
            // cmbSearchType
            // 
            cmbSearchType.FormattingEnabled = true;
            cmbSearchType.Location = new Point(85, 28);
            cmbSearchType.Name = "cmbSearchType";
            cmbSearchType.Size = new Size(121, 23);
            cmbSearchType.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(562, 28);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // BookListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearch);
            Controls.Add(cmbSearchType);
            Controls.Add(txtSearch);
            Controls.Add(dgvBooks);
            Name = "BookListForm";
            Text = "BookListForm";
            Load += BookListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBooks;
        private TextBox txtSearch;
        private ComboBox cmbSearchType;
        private Button btnSearch;
    }
}