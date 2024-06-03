namespace UniversityProject.Forms
{
    partial class StudentLogin
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
            this.studentLoginButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.studentPasswordInput = new System.Windows.Forms.TextBox();
            this.studentEmailInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // studentLoginButton
            // 
            this.studentLoginButton.Location = new System.Drawing.Point(175, 84);
            this.studentLoginButton.Name = "studentLoginButton";
            this.studentLoginButton.Size = new System.Drawing.Size(75, 23);
            this.studentLoginButton.TabIndex = 11;
            this.studentLoginButton.Text = "LOG IN";
            this.studentLoginButton.UseVisualStyleBackColor = true;
            this.studentLoginButton.Click += new System.EventHandler(this.studentLoginButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(26, 84);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Email:";
            // 
            // studentPasswordInput
            // 
            this.studentPasswordInput.Location = new System.Drawing.Point(118, 49);
            this.studentPasswordInput.Name = "studentPasswordInput";
            this.studentPasswordInput.PasswordChar = '*';
            this.studentPasswordInput.Size = new System.Drawing.Size(133, 20);
            this.studentPasswordInput.TabIndex = 7;
            // 
            // studentEmailInput
            // 
            this.studentEmailInput.Location = new System.Drawing.Point(118, 18);
            this.studentEmailInput.Name = "studentEmailInput";
            this.studentEmailInput.Size = new System.Drawing.Size(133, 20);
            this.studentEmailInput.TabIndex = 6;
            // 
            // StudentLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 122);
            this.Controls.Add(this.studentLoginButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentPasswordInput);
            this.Controls.Add(this.studentEmailInput);
            this.Name = "StudentLogin";
            this.Text = "StudentLogin";
            this.Load += new System.EventHandler(this.StudentLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button studentLoginButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentPasswordInput;
        private System.Windows.Forms.TextBox studentEmailInput;
    }
}