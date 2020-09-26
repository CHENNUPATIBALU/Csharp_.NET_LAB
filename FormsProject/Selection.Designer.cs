namespace FormsDemo
{
    partial class Selection
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
            this.bTech_RadioButton = new System.Windows.Forms.RadioButton();
            this.law_RadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bca_RadioButton = new System.Windows.Forms.RadioButton();
            this.mba_RadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.bTech_comboBox = new System.Windows.Forms.ComboBox();
            this.lawComboBox = new System.Windows.Forms.ComboBox();
            this.mba_comboBox = new System.Windows.Forms.ComboBox();
            this.bca_comboBox = new System.Windows.Forms.ComboBox();
            this.Btech_label = new System.Windows.Forms.Label();
            this.LawLabel = new System.Windows.Forms.Label();
            this.MBALabel = new System.Windows.Forms.Label();
            this.BCAlabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bTech_RadioButton
            // 
            this.bTech_RadioButton.AutoSize = true;
            this.bTech_RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTech_RadioButton.Location = new System.Drawing.Point(35, 62);
            this.bTech_RadioButton.Name = "bTech_RadioButton";
            this.bTech_RadioButton.Size = new System.Drawing.Size(66, 19);
            this.bTech_RadioButton.TabIndex = 0;
            this.bTech_RadioButton.TabStop = true;
            this.bTech_RadioButton.Text = "B.Tech";
            this.bTech_RadioButton.UseVisualStyleBackColor = true;
            this.bTech_RadioButton.CheckedChanged += new System.EventHandler(this.bTech_RadioButton_CheckedChanged);
            // 
            // law_RadioButton
            // 
            this.law_RadioButton.AutoSize = true;
            this.law_RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.law_RadioButton.Location = new System.Drawing.Point(267, 66);
            this.law_RadioButton.Name = "law_RadioButton";
            this.law_RadioButton.Size = new System.Drawing.Size(51, 19);
            this.law_RadioButton.TabIndex = 1;
            this.law_RadioButton.TabStop = true;
            this.law_RadioButton.Text = "Law";
            this.law_RadioButton.UseVisualStyleBackColor = true;
            this.law_RadioButton.CheckedChanged += new System.EventHandler(this.law_RadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bca_RadioButton);
            this.groupBox1.Controls.Add(this.mba_RadioButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bTech_RadioButton);
            this.groupBox1.Controls.Add(this.law_RadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 85);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Appropriate Data";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bca_RadioButton
            // 
            this.bca_RadioButton.AutoSize = true;
            this.bca_RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bca_RadioButton.Location = new System.Drawing.Point(688, 60);
            this.bca_RadioButton.Name = "bca_RadioButton";
            this.bca_RadioButton.Size = new System.Drawing.Size(51, 19);
            this.bca_RadioButton.TabIndex = 4;
            this.bca_RadioButton.TabStop = true;
            this.bca_RadioButton.Text = "BCA";
            this.bca_RadioButton.UseVisualStyleBackColor = true;
            this.bca_RadioButton.CheckedChanged += new System.EventHandler(this.bca_RadioButton_CheckedChanged);
            // 
            // mba_RadioButton
            // 
            this.mba_RadioButton.AutoSize = true;
            this.mba_RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mba_RadioButton.Location = new System.Drawing.Point(479, 62);
            this.mba_RadioButton.Name = "mba_RadioButton";
            this.mba_RadioButton.Size = new System.Drawing.Size(54, 19);
            this.mba_RadioButton.TabIndex = 3;
            this.mba_RadioButton.TabStop = true;
            this.mba_RadioButton.Text = "MBA";
            this.mba_RadioButton.UseVisualStyleBackColor = true;
            this.mba_RadioButton.CheckedChanged += new System.EventHandler(this.mba_RadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Stream";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BCAlabel);
            this.groupBox2.Controls.Add(this.MBALabel);
            this.groupBox2.Controls.Add(this.LawLabel);
            this.groupBox2.Controls.Add(this.Btech_label);
            this.groupBox2.Controls.Add(this.bca_comboBox);
            this.groupBox2.Controls.Add(this.mba_comboBox);
            this.groupBox2.Controls.Add(this.lawComboBox);
            this.groupBox2.Controls.Add(this.bTech_comboBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(797, 116);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose a Branch";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(345, 225);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(75, 23);
            this.submit_button.TabIndex = 4;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // bTech_comboBox
            // 
            this.bTech_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTech_comboBox.FormattingEnabled = true;
            this.bTech_comboBox.Items.AddRange(new object[] {
            "Computer Science and Engineering",
            "Information Science and Engineering",
            "Mechanical Engineering",
            "Electrical Engineering",
            "Electronics Engineering",
            "Petroleum Engineering",
            "Civil Engineering"});
            this.bTech_comboBox.Location = new System.Drawing.Point(6, 58);
            this.bTech_comboBox.Name = "bTech_comboBox";
            this.bTech_comboBox.Size = new System.Drawing.Size(201, 23);
            this.bTech_comboBox.TabIndex = 8;
            this.bTech_comboBox.Text = "Select B.Tech branch";
            this.bTech_comboBox.SelectedIndexChanged += new System.EventHandler(this.bTech_comboBox_SelectedIndexChanged);
            // 
            // lawComboBox
            // 
            this.lawComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lawComboBox.FormattingEnabled = true;
            this.lawComboBox.Items.AddRange(new object[] {
            "Civil Law",
            "Tax Law",
            "Criminal Law",
            "Corporate Law",
            "International Law",
            "Labour Law",
            "Real Estate Law",
            "Patent Law",
            "Media Law",
            "Competition Law",
            "Intellectual Property Law",
            "Mergers and Acquisition Law"});
            this.lawComboBox.Location = new System.Drawing.Point(213, 58);
            this.lawComboBox.Name = "lawComboBox";
            this.lawComboBox.Size = new System.Drawing.Size(207, 23);
            this.lawComboBox.TabIndex = 9;
            this.lawComboBox.Text = "Select Law branch";
            // 
            // mba_comboBox
            // 
            this.mba_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mba_comboBox.FormattingEnabled = true;
            this.mba_comboBox.Items.AddRange(new object[] {
            "MBA in Finance",
            "MBA in Human Resource Management",
            "MBA in Information Technology (IT)",
            "MBA in Logistics Management",
            "MBA in Marketing Management",
            "MBA in Business Management",
            "MBA in Rural Management",
            "MBA in Health Care Management",
            "MBA in Operations Management",
            "MBA in Event Management",
            "MBA in Business Analytics"});
            this.mba_comboBox.Location = new System.Drawing.Point(426, 58);
            this.mba_comboBox.Name = "mba_comboBox";
            this.mba_comboBox.Size = new System.Drawing.Size(207, 23);
            this.mba_comboBox.TabIndex = 10;
            this.mba_comboBox.Text = "Select MBA branch";
            // 
            // bca_comboBox
            // 
            this.bca_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bca_comboBox.FormattingEnabled = true;
            this.bca_comboBox.Location = new System.Drawing.Point(639, 58);
            this.bca_comboBox.Name = "bca_comboBox";
            this.bca_comboBox.Size = new System.Drawing.Size(152, 23);
            this.bca_comboBox.TabIndex = 11;
            this.bca_comboBox.Text = "Select BCA branch";
            // 
            // Btech_label
            // 
            this.Btech_label.AutoSize = true;
            this.Btech_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btech_label.Location = new System.Drawing.Point(7, 35);
            this.Btech_label.Name = "Btech_label";
            this.Btech_label.Size = new System.Drawing.Size(55, 18);
            this.Btech_label.TabIndex = 12;
            this.Btech_label.Text = "B.Tech";
            // 
            // LawLabel
            // 
            this.LawLabel.AutoSize = true;
            this.LawLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LawLabel.Location = new System.Drawing.Point(210, 35);
            this.LawLabel.Name = "LawLabel";
            this.LawLabel.Size = new System.Drawing.Size(35, 18);
            this.LawLabel.TabIndex = 13;
            this.LawLabel.Text = "Law";
            // 
            // MBALabel
            // 
            this.MBALabel.AutoSize = true;
            this.MBALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MBALabel.Location = new System.Drawing.Point(423, 35);
            this.MBALabel.Name = "MBALabel";
            this.MBALabel.Size = new System.Drawing.Size(40, 18);
            this.MBALabel.TabIndex = 14;
            this.MBALabel.Text = "MBA";
            // 
            // BCAlabel
            // 
            this.BCAlabel.AutoSize = true;
            this.BCAlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCAlabel.Location = new System.Drawing.Point(636, 35);
            this.BCAlabel.Name = "BCAlabel";
            this.BCAlabel.Size = new System.Drawing.Size(38, 18);
            this.BCAlabel.TabIndex = 15;
            this.BCAlabel.Text = "BCA";
            // 
            // Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Selection";
            this.Text = "Selection";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton bTech_RadioButton;
        private System.Windows.Forms.RadioButton law_RadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton bca_RadioButton;
        private System.Windows.Forms.RadioButton mba_RadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.ComboBox bTech_comboBox;
        private System.Windows.Forms.ComboBox bca_comboBox;
        private System.Windows.Forms.ComboBox mba_comboBox;
        private System.Windows.Forms.ComboBox lawComboBox;
        private System.Windows.Forms.Label BCAlabel;
        private System.Windows.Forms.Label MBALabel;
        private System.Windows.Forms.Label LawLabel;
        private System.Windows.Forms.Label Btech_label;
    }
}