namespace Odev12.UI
{
    partial class RegisterForm
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
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtSchoolNumber = new TextBox();
            txtPhone = new TextBox();
            btnRegister = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(338, 81);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(136, 23);
            txtFullName.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(338, 120);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(136, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(338, 158);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(136, 23);
            txtPassword.TabIndex = 2;
            // 
            // txtSchoolNumber
            // 
            txtSchoolNumber.Location = new Point(338, 203);
            txtSchoolNumber.Name = "txtSchoolNumber";
            txtSchoolNumber.Size = new Size(136, 23);
            txtSchoolNumber.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(338, 244);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(136, 23);
            txtPhone.TabIndex = 4;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(303, 298);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(103, 23);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 84);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 6;
            label1.Text = "Fullname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 123);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 7;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(235, 161);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(235, 203);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 9;
            label4.Text = "School Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(235, 247);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 10;
            label5.Text = "Phone Number";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(txtPhone);
            Controls.Add(txtSchoolNumber);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtSchoolNumber;
        private TextBox txtPhone;
        private Button btnRegister;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}