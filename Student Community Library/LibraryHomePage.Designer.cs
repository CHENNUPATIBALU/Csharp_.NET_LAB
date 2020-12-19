
namespace Student_Community_Library
{
    partial class LibraryHomePage
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.studentDetailsListBox = new System.Windows.Forms.ListBox();
            this.bookDetailsListBox = new System.Windows.Forms.ListBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(296, 20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 29);
            this.nameLabel.TabIndex = 0;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(260, 88);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(299, 22);
            this.searchTextBox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(565, 87);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(78, 25);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter the Book to borrow";
            // 
            // studentDetailsListBox
            // 
            this.studentDetailsListBox.FormattingEnabled = true;
            this.studentDetailsListBox.ItemHeight = 16;
            this.studentDetailsListBox.Location = new System.Drawing.Point(12, 129);
            this.studentDetailsListBox.Name = "studentDetailsListBox";
            this.studentDetailsListBox.Size = new System.Drawing.Size(360, 228);
            this.studentDetailsListBox.TabIndex = 7;
            // 
            // bookDetailsListBox
            // 
            this.bookDetailsListBox.FormattingEnabled = true;
            this.bookDetailsListBox.ItemHeight = 16;
            this.bookDetailsListBox.Location = new System.Drawing.Point(404, 129);
            this.bookDetailsListBox.Name = "bookDetailsListBox";
            this.bookDetailsListBox.Size = new System.Drawing.Size(360, 228);
            this.bookDetailsListBox.TabIndex = 8;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Gold;
            this.logoutButton.Location = new System.Drawing.Point(642, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(135, 42);
            this.logoutButton.TabIndex = 9;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // LibraryHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 391);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.bookDetailsListBox);
            this.Controls.Add(this.studentDetailsListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "LibraryHomePage";
            this.Text = "LibraryHomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox studentDetailsListBox;
        private System.Windows.Forms.ListBox bookDetailsListBox;
        private System.Windows.Forms.Button logoutButton;
    }
}