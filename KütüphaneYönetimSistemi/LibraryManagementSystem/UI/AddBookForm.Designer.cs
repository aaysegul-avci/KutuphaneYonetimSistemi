namespace Odev12.UI
{
    partial class AddBookForm
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
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtYear = new TextBox();
            txtCategory = new TextBox();
            txtSummary = new TextBox();
            txtShelf = new TextBox();
            txtStock = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(128, 45);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(177, 23);
            txtTitle.TabIndex = 0;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(128, 74);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(177, 23);
            txtAuthor.TabIndex = 1;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(128, 103);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(177, 23);
            txtYear.TabIndex = 2;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(128, 132);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(177, 23);
            txtCategory.TabIndex = 3;
            // 
            // txtSummary
            // 
            txtSummary.Location = new Point(128, 161);
            txtSummary.Name = "txtSummary";
            txtSummary.Size = new Size(177, 23);
            txtSummary.TabIndex = 4;
            // 
            // txtShelf
            // 
            txtShelf.Location = new Point(128, 190);
            txtShelf.Name = "txtShelf";
            txtShelf.Size = new Size(177, 23);
            txtShelf.TabIndex = 5;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(128, 219);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(177, 23);
            txtStock.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 48);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 7;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 77);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 8;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 106);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 9;
            label3.Text = "Year";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 135);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 10;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 164);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 11;
            label5.Text = "Summary";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 193);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 12;
            label6.Text = "Shelf";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 222);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 13;
            label7.Text = "Stock";
            label7.Click += label7_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(259, 304);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnSave_Click;
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 339);
            Controls.Add(btnAdd);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtStock);
            Controls.Add(txtShelf);
            Controls.Add(txtSummary);
            Controls.Add(txtCategory);
            Controls.Add(txtYear);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Name = "AddBookForm";
            Text = "AddBookForm";
            Load += AddBookForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtYear;
        private TextBox txtCategory;
        private TextBox txtSummary;
        private TextBox txtShelf;
        private TextBox txtStock;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnAdd;
    }
}