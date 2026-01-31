namespace Odev12.UI
{
    partial class UserListForm
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
            components = new System.ComponentModel.Container();
            databaseBindingSource = new BindingSource(components);
            dgvUsers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)databaseBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // databaseBindingSource
            // 
            databaseBindingSource.DataSource = typeof(Repository.Database);
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(12, 12);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.Size = new Size(865, 425);
            dgvUsers.TabIndex = 0;
            dgvUsers.CellClick += dgvUsers_CellClick;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
            // 
            // UserListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 448);
            Controls.Add(dgvUsers);
            Name = "UserListForm";
            Text = "UserListForm";
            Load += UserListForm_Load;
            ((System.ComponentModel.ISupportInitialize)databaseBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource databaseBindingSource;
        private DataGridView dgvUsers;
    }
}