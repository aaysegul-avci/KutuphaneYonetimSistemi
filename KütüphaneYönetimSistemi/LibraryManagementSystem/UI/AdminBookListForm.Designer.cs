namespace Odev12.UI
{
    partial class AdminBookListForm
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
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(12, 12);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.Size = new Size(1056, 431);
            dgvBooks.TabIndex = 0;
            dgvBooks.CellClick += dgvBooks_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(993, 449);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Book";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAddBook_Click;
            // 
            // AdminBookListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 484);
            Controls.Add(btnAdd);
            Controls.Add(dgvBooks);
            Name = "AdminBookListForm";
            Text = "AdminBookListForm";
            Load += AdminBookListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBooks;
        private Button btnAdd;
    }
}