namespace UniversityProject
{
    partial class HomePage
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
            this.managerButton = new System.Windows.Forms.Button();
            this.lecturerButton = new System.Windows.Forms.Button();
            this.studentButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // managerButton
            // 
            this.managerButton.Location = new System.Drawing.Point(51, 117);
            this.managerButton.Name = "managerButton";
            this.managerButton.Size = new System.Drawing.Size(75, 23);
            this.managerButton.TabIndex = 0;
            this.managerButton.Text = "Manager";
            this.managerButton.UseVisualStyleBackColor = true;
            this.managerButton.Click += new System.EventHandler(this.managerButton_Click);
            // 
            // lecturerButton
            // 
            this.lecturerButton.Location = new System.Drawing.Point(289, 117);
            this.lecturerButton.Name = "lecturerButton";
            this.lecturerButton.Size = new System.Drawing.Size(75, 23);
            this.lecturerButton.TabIndex = 1;
            this.lecturerButton.Text = "Lecturer";
            this.lecturerButton.UseVisualStyleBackColor = true;
            this.lecturerButton.Click += new System.EventHandler(this.lecturerButton_Click);
            // 
            // studentButton
            // 
            this.studentButton.Location = new System.Drawing.Point(170, 117);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(75, 23);
            this.studentButton.TabIndex = 2;
            this.studentButton.Text = "Student";
            this.studentButton.UseVisualStyleBackColor = true;
            this.studentButton.Click += new System.EventHandler(this.studentButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(47, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "WELCOME TO THE UNIVERSITY PORTAL";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 169);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentButton);
            this.Controls.Add(this.lecturerButton);
            this.Controls.Add(this.managerButton);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button managerButton;
        private System.Windows.Forms.Button lecturerButton;
        private System.Windows.Forms.Button studentButton;
        private System.Windows.Forms.Label label1;
    }
}