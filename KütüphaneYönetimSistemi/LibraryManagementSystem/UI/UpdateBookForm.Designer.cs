namespace Odev12.UI
{
    partial class UpdateBookForm
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
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtStock = new TextBox();
            txtShelf = new TextBox();
            txtSummary = new TextBox();
            txtCategory = new TextBox();
            txtYear = new TextBox();
            txtAuthor = new TextBox();
            txtTitle = new TextBox();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(54, 228);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 27;
            label7.Text = "Stock";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 199);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 26;
            label6.Text = "Shelf";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 170);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 25;
            label5.Text = "Summary";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 141);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 24;
            label4.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 112);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 23;
            label3.Text = "Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 83);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 22;
            label2.Text = "Author";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 54);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 21;
            label1.Text = "Title";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(139, 225);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(173, 23);
            txtStock.TabIndex = 20;
            // 
            // txtShelf
            // 
            txtShelf.Location = new Point(139, 196);
            txtShelf.Name = "txtShelf";
            txtShelf.Size = new Size(173, 23);
            txtShelf.TabIndex = 19;
            // 
            // txtSummary
            // 
            txtSummary.Location = new Point(139, 167);
            txtSummary.Name = "txtSummary";
            txtSummary.Size = new Size(173, 23);
            txtSummary.TabIndex = 18;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(139, 138);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(173, 23);
            txtCategory.TabIndex = 17;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(139, 109);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(173, 23);
            txtYear.TabIndex = 16;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(139, 80);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(173, 23);
            txtAuthor.TabIndex = 15;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(139, 51);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(173, 23);
            txtTitle.TabIndex = 14;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(260, 305);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 28;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // UpdateBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 340);
            Controls.Add(btnUpdate);
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
            Name = "UpdateBookForm";
            Text = "UpdateBookForm";
            Load += UpdateBookForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtStock;
        private TextBox txtShelf;
        private TextBox txtSummary;
        private TextBox txtCategory;
        private TextBox txtYear;
        private TextBox txtAuthor;
        private TextBox txtTitle;
        private Button btnUpdate;
    }
}