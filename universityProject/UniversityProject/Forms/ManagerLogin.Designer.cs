namespace UniversityProject.Forms
{
    partial class ManagerLogin
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
            this.managerLoginButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.managerPasswordInput = new System.Windows.Forms.TextBox();
            this.managerEmailInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // managerLoginButton
            // 
            this.managerLoginButton.Location = new System.Drawing.Point(170, 88);
            this.managerLoginButton.Name = "managerLoginButton";
            this.managerLoginButton.Size = new System.Drawing.Size(75, 23);
            this.managerLoginButton.TabIndex = 11;
            this.managerLoginButton.Text = "LOG IN";
            this.managerLoginButton.UseVisualStyleBackColor = true;
            this.managerLoginButton.Click += new System.EventHandler(this.managerLoginButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(21, 88);
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
            this.label2.Location = new System.Drawing.Point(21, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Email:";
            // 
            // managerPasswordInput
            // 
            this.managerPasswordInput.Location = new System.Drawing.Point(113, 53);
            this.managerPasswordInput.Name = "managerPasswordInput";
            this.managerPasswordInput.PasswordChar = '*';
            this.managerPasswordInput.Size = new System.Drawing.Size(133, 20);
            this.managerPasswordInput.TabIndex = 7;
            // 
            // managerEmailInput
            // 
            this.managerEmailInput.Location = new System.Drawing.Point(113, 22);
            this.managerEmailInput.Name = "managerEmailInput";
            this.managerEmailInput.Size = new System.Drawing.Size(133, 20);
            this.managerEmailInput.TabIndex = 6;
            // 
            // ManagerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 125);
            this.Controls.Add(this.managerLoginButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.managerPasswordInput);
            this.Controls.Add(this.managerEmailInput);
            this.Name = "ManagerLogin";
            this.Text = "ManagerLogin";
            this.Load += new System.EventHandler(this.ManagerLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button managerLoginButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox managerPasswordInput;
        private System.Windows.Forms.TextBox managerEmailInput;
    }
}