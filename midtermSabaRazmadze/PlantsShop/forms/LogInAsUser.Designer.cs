namespace PlantsShop.forms
{
    partial class LogInAsUser
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
            this.backButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserPasswordInput = new System.Windows.Forms.TextBox();
            this.userEmailInput = new System.Windows.Forms.TextBox();
            this.Register = new System.Windows.Forms.Button();
            this.userLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 84);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 22;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Email:";
            // 
            // UserPasswordInput
            // 
            this.UserPasswordInput.Location = new System.Drawing.Point(103, 49);
            this.UserPasswordInput.Name = "UserPasswordInput";
            this.UserPasswordInput.PasswordChar = '*';
            this.UserPasswordInput.Size = new System.Drawing.Size(167, 20);
            this.UserPasswordInput.TabIndex = 19;
            // 
            // userEmailInput
            // 
            this.userEmailInput.Location = new System.Drawing.Point(103, 18);
            this.userEmailInput.Name = "userEmailInput";
            this.userEmailInput.Size = new System.Drawing.Size(167, 20);
            this.userEmailInput.TabIndex = 18;
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(195, 84);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(75, 23);
            this.Register.TabIndex = 22;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // userLoginButton
            // 
            this.userLoginButton.Location = new System.Drawing.Point(103, 84);
            this.userLoginButton.Name = "userLoginButton";
            this.userLoginButton.Size = new System.Drawing.Size(75, 23);
            this.userLoginButton.TabIndex = 24;
            this.userLoginButton.Text = "LOG IN";
            this.userLoginButton.UseVisualStyleBackColor = true;
            this.userLoginButton.Click += new System.EventHandler(this.userLoginButton_Click);
            // 
            // LogInAsUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 139);
            this.Controls.Add(this.userLoginButton);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserPasswordInput);
            this.Controls.Add(this.userEmailInput);
            this.Name = "LogInAsUser";
            this.Text = "LogInAsUser";
            this.Load += new System.EventHandler(this.LogInAsUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserPasswordInput;
        private System.Windows.Forms.TextBox userEmailInput;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Button userLoginButton;
    }
}