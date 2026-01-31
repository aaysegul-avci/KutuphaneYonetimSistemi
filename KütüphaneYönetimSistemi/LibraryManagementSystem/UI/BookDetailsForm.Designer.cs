namespace Odev12.UI
{
    partial class BookDetailsForm
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
            lblTitle = new Label();
            lblAuthor = new Label();
            lblYear = new Label();
            lblStock = new Label();
            lblShelf = new Label();
            txtSummary = new Label();
            lblCategory = new Label();
            btnBorrow = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(58, 58);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "label1";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(58, 82);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(38, 15);
            lblAuthor.TabIndex = 1;
            lblAuthor.Text = "label2";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(58, 107);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(38, 15);
            lblYear.TabIndex = 2;
            lblYear.Text = "label3";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(58, 158);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(38, 15);
            lblStock.TabIndex = 3;
            lblStock.Text = "label4";
            // 
            // lblShelf
            // 
            lblShelf.AutoSize = true;
            lblShelf.Location = new Point(58, 185);
            lblShelf.Name = "lblShelf";
            lblShelf.Size = new Size(38, 15);
            lblShelf.TabIndex = 4;
            lblShelf.Text = "label5";
            // 
            // txtSummary
            // 
            txtSummary.AutoSize = true;
            txtSummary.Location = new Point(58, 214);
            txtSummary.Name = "txtSummary";
            txtSummary.Size = new Size(38, 15);
            txtSummary.TabIndex = 5;
            txtSummary.Text = "label6";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(58, 133);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(38, 15);
            lblCategory.TabIndex = 6;
            lblCategory.Text = "label1";
            // 
            // btnBorrow
            // 
            btnBorrow.Location = new Point(178, 299);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(75, 23);
            btnBorrow.TabIndex = 7;
            btnBorrow.Text = "Borrow";
            btnBorrow.UseVisualStyleBackColor = true;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // BookDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 450);
            Controls.Add(btnBorrow);
            Controls.Add(lblCategory);
            Controls.Add(txtSummary);
            Controls.Add(lblShelf);
            Controls.Add(lblStock);
            Controls.Add(lblYear);
            Controls.Add(lblAuthor);
            Controls.Add(lblTitle);
            Name = "BookDetailsForm";
            Text = "BookDetailsForm";
            Load += BookDetailsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblAuthor;
        private Label lblYear;
        private Label lblStock;
        private Label lblShelf;
        private Label txtSummary;
        private Label lblCategory;
        private Button btnBorrow;
    }
}