namespace PlantsShop.forms
{
    partial class LogInAsManager
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
            this.ManagerLoginButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ManagerPasswordInput = new System.Windows.Forms.TextBox();
            this.ManagerEmailInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ManagerLoginButton
            // 
            this.ManagerLoginButton.Location = new System.Drawing.Point(156, 78);
            this.ManagerLoginButton.Name = "ManagerLoginButton";
            this.ManagerLoginButton.Size = new System.Drawing.Size(75, 23);
            this.ManagerLoginButton.TabIndex = 17;
            this.ManagerLoginButton.Text = "LOG IN";
            this.ManagerLoginButton.UseVisualStyleBackColor = true;
            this.ManagerLoginButton.Click += new System.EventHandler(this.ManagerLoginButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(7, 78);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 16;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Email:";
            // 
            // ManagerPasswordInput
            // 
            this.ManagerPasswordInput.Location = new System.Drawing.Point(98, 43);
            this.ManagerPasswordInput.Name = "ManagerPasswordInput";
            this.ManagerPasswordInput.PasswordChar = '*';
            this.ManagerPasswordInput.Size = new System.Drawing.Size(133, 20);
            this.ManagerPasswordInput.TabIndex = 13;
            // 
            // ManagerEmailInput
            // 
            this.ManagerEmailInput.Location = new System.Drawing.Point(98, 12);
            this.ManagerEmailInput.Name = "ManagerEmailInput";
            this.ManagerEmailInput.Size = new System.Drawing.Size(133, 20);
            this.ManagerEmailInput.TabIndex = 12;
            // 
            // LogInAsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 136);
            this.Controls.Add(this.ManagerLoginButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ManagerPasswordInput);
            this.Controls.Add(this.ManagerEmailInput);
            this.Name = "LogInAsManager";
            this.Text = "LogInAsManager";
            this.Load += new System.EventHandler(this.LogInAsManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ManagerLoginButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ManagerPasswordInput;
        private System.Windows.Forms.TextBox ManagerEmailInput;
    }
}