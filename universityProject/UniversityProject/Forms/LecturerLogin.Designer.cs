namespace UniversityProject.Forms
{
    partial class LecturerLogin
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
            this.lecturerLoginButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lecturerPasswordInput = new System.Windows.Forms.TextBox();
            this.lecturerEmailInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lecturerLoginButton
            // 
            this.lecturerLoginButton.Location = new System.Drawing.Point(178, 83);
            this.lecturerLoginButton.Name = "lecturerLoginButton";
            this.lecturerLoginButton.Size = new System.Drawing.Size(75, 23);
            this.lecturerLoginButton.TabIndex = 11;
            this.lecturerLoginButton.Text = "LOG IN";
            this.lecturerLoginButton.UseVisualStyleBackColor = true;
            this.lecturerLoginButton.Click += new System.EventHandler(this.lecturerLoginButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(29, 83);
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
            this.label2.Location = new System.Drawing.Point(29, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Email:";
            // 
            // lecturerPasswordInput
            // 
            this.lecturerPasswordInput.Location = new System.Drawing.Point(121, 48);
            this.lecturerPasswordInput.Name = "lecturerPasswordInput";
            this.lecturerPasswordInput.PasswordChar = '*';
            this.lecturerPasswordInput.Size = new System.Drawing.Size(133, 20);
            this.lecturerPasswordInput.TabIndex = 7;
            // 
            // lecturerEmailInput
            // 
            this.lecturerEmailInput.Location = new System.Drawing.Point(121, 17);
            this.lecturerEmailInput.Name = "lecturerEmailInput";
            this.lecturerEmailInput.Size = new System.Drawing.Size(133, 20);
            this.lecturerEmailInput.TabIndex = 6;
            // 
            // LecturerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 118);
            this.Controls.Add(this.lecturerLoginButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lecturerPasswordInput);
            this.Controls.Add(this.lecturerEmailInput);
            this.Name = "LecturerLogin";
            this.Text = "LecturerLogin";
            this.Load += new System.EventHandler(this.LecturerLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lecturerLoginButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lecturerPasswordInput;
        private System.Windows.Forms.TextBox lecturerEmailInput;
    }
}