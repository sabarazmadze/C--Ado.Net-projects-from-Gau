namespace UniversityProject
{
    partial class StudentPortal
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
            this.logoutButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StudentName = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.AvgGrade = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(12, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 12;
            this.logoutButton.Text = "LOGOUT";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(612, 325);
            this.dataGridView1.TabIndex = 13;
            // 
            // StudentName
            // 
            this.StudentName.AutoSize = true;
            this.StudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StudentName.Location = new System.Drawing.Point(149, 15);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(94, 17);
            this.StudentName.TabIndex = 14;
            this.StudentName.Text = "StudentName";
            this.StudentName.Click += new System.EventHandler(this.StudentName_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Email.Location = new System.Drawing.Point(337, 15);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(42, 17);
            this.Email.TabIndex = 14;
            this.Email.Text = "Email";
            // 
            // AvgGrade
            // 
            this.AvgGrade.AutoSize = true;
            this.AvgGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AvgGrade.Location = new System.Drawing.Point(470, 15);
            this.AvgGrade.Name = "AvgGrade";
            this.AvgGrade.Size = new System.Drawing.Size(104, 17);
            this.AvgGrade.TabIndex = 14;
            this.AvgGrade.Text = "average Grade";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // StudentPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AvgGrade);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.logoutButton);
            this.Name = "StudentPortal";
            this.Text = "StudentPortal";
            this.Load += new System.EventHandler(this.StudentPortal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label StudentName;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label AvgGrade;
        private System.Windows.Forms.Button button1;
    }
}