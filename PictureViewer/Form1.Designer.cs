namespace PictureViewer
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ShowPicture_Button = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.SetBg_button = new System.Windows.Forms.Button();
            this.Close_button = new System.Windows.Forms.Button();
            this.next_button = new System.Windows.Forms.Button();
            this.previous_button = new System.Windows.Forms.Button();
            this.Zoom_trackBar = new System.Windows.Forms.TrackBar();
            this.Zoom_label = new System.Windows.Forms.Label();
            this.Stretch_checkBox = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zoom_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Stretch_checkBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1377, 578);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1371, 514);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ShowPicture_Button);
            this.flowLayoutPanel1.Controls.Add(this.Clear_Button);
            this.flowLayoutPanel1.Controls.Add(this.SetBg_button);
            this.flowLayoutPanel1.Controls.Add(this.Close_button);
            this.flowLayoutPanel1.Controls.Add(this.next_button);
            this.flowLayoutPanel1.Controls.Add(this.previous_button);
            this.flowLayoutPanel1.Controls.Add(this.Zoom_trackBar);
            this.flowLayoutPanel1.Controls.Add(this.Zoom_label);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(209, 523);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1165, 52);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // ShowPicture_Button
            // 
            this.ShowPicture_Button.AutoSize = true;
            this.ShowPicture_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPicture_Button.Location = new System.Drawing.Point(1028, 3);
            this.ShowPicture_Button.Name = "ShowPicture_Button";
            this.ShowPicture_Button.Size = new System.Drawing.Size(134, 40);
            this.ShowPicture_Button.TabIndex = 0;
            this.ShowPicture_Button.Text = "Show a Picture";
            this.ShowPicture_Button.UseVisualStyleBackColor = true;
            this.ShowPicture_Button.Click += new System.EventHandler(this.showPicture_Button_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.AutoSize = true;
            this.Clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_Button.Location = new System.Drawing.Point(866, 3);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(156, 40);
            this.Clear_Button.TabIndex = 1;
            this.Clear_Button.Text = "Clear the Picture";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // SetBg_button
            // 
            this.SetBg_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetBg_button.Location = new System.Drawing.Point(673, 3);
            this.SetBg_button.Name = "SetBg_button";
            this.SetBg_button.Size = new System.Drawing.Size(187, 40);
            this.SetBg_button.TabIndex = 4;
            this.SetBg_button.Text = "Set the Background";
            this.SetBg_button.UseVisualStyleBackColor = true;
            this.SetBg_button.Click += new System.EventHandler(this.setBg_button_Click);
            // 
            // Close_button
            // 
            this.Close_button.AutoSize = true;
            this.Close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_button.Location = new System.Drawing.Point(561, 3);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(106, 40);
            this.Close_button.TabIndex = 3;
            this.Close_button.Text = "Close";
            this.Close_button.UseVisualStyleBackColor = true;
            this.Close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // next_button
            // 
            this.next_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_button.Location = new System.Drawing.Point(399, 3);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(156, 40);
            this.next_button.TabIndex = 5;
            this.next_button.Text = "Next >>";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // previous_button
            // 
            this.previous_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previous_button.Location = new System.Drawing.Point(216, 3);
            this.previous_button.Name = "previous_button";
            this.previous_button.Size = new System.Drawing.Size(177, 40);
            this.previous_button.TabIndex = 6;
            this.previous_button.Text = "<< Previous";
            this.previous_button.UseVisualStyleBackColor = true;
            this.previous_button.Click += new System.EventHandler(this.previous_button_Click);
            // 
            // Zoom_trackBar
            // 
            this.Zoom_trackBar.BackColor = System.Drawing.Color.Tan;
            this.Zoom_trackBar.Location = new System.Drawing.Point(60, 3);
            this.Zoom_trackBar.Name = "Zoom_trackBar";
            this.Zoom_trackBar.Size = new System.Drawing.Size(150, 56);
            this.Zoom_trackBar.TabIndex = 7;
            this.Zoom_trackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Zoom_trackBar.Scroll += new System.EventHandler(this.Zoom_trackBar_Scroll);
            // 
            // Zoom_label
            // 
            this.Zoom_label.AutoSize = true;
            this.Zoom_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zoom_label.Location = new System.Drawing.Point(4, 0);
            this.Zoom_label.Name = "Zoom_label";
            this.Zoom_label.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.Zoom_label.Size = new System.Drawing.Size(50, 50);
            this.Zoom_label.TabIndex = 9;
            this.Zoom_label.Text = "Zoom";
            // 
            // Stretch_checkBox
            // 
            this.Stretch_checkBox.AutoSize = true;
            this.Stretch_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stretch_checkBox.Location = new System.Drawing.Point(3, 523);
            this.Stretch_checkBox.Name = "Stretch_checkBox";
            this.Stretch_checkBox.Padding = new System.Windows.Forms.Padding(0, 0, 70, 20);
            this.Stretch_checkBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Stretch_checkBox.Size = new System.Drawing.Size(185, 52);
            this.Stretch_checkBox.TabIndex = 1;
            this.Stretch_checkBox.Text = "Stretch";
            this.Stretch_checkBox.UseVisualStyleBackColor = true;
            this.Stretch_checkBox.CheckedChanged += new System.EventHandler(this.stretch_checkBox_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Title = "Select a Picture";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 578);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "                                                                                 " +
    "                                                          Picture Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zoom_trackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ShowPicture_Button;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.CheckBox Stretch_checkBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button SetBg_button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Button previous_button;
        private System.Windows.Forms.TrackBar Zoom_trackBar;
        private System.Windows.Forms.Label Zoom_label;
    }
}

